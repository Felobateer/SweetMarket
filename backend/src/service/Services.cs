using System.Text.Json;
using MySqlConnector;
using Database;
using Microsoft.EntityFrameworkCore;
using BCrypt.Net;

namespace Services
{
    public class MyServices
    {
        private readonly string _connectionString;
        private readonly MyDb _context;
        public MyServices(string connectionString, MyDb context)
        {
            _connectionString = connectionString;
            _context = context;
        }
        public async Task InsertData(string jsonData)
        {
            // Check if the Products table is empty
            if (!_context.Products.Any())
            {
                // Products table is empty, proceed with inserting data
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    await connection.OpenAsync();
                    foreach (var category in JsonSerializer.Deserialize<Dictionary<string, List<Product>>>(jsonData))
                    {
                        string categoryName = category.Key;
                        List<Product> products = category.Value;

                        foreach (var product in products)
                        {
                            string insertQuery = $"INSERT INTO {categoryName} (id, name, description, price, img) VALUES (@id, @name, @description, @price, @img)";

                            using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                            {
                                command.Parameters.AddWithValue("@id", product.id);
                                command.Parameters.AddWithValue("@name", product.name);
                                command.Parameters.AddWithValue("@description", product.description);
                                command.Parameters.AddWithValue("@price", product.price);
                                command.Parameters.AddWithValue("@img", product.img);

                                await command.ExecuteNonQueryAsync();
                            }
                        }
                    }
                }
            }
        }
        public async Task<List<Product>> getAllProducts()
        {
            return await _context.Products.ToListAsync();
        }
        public async Task<Product> getProductById(string id)
        {
            return await _context.Products.FirstOrDefaultAsync(p => p.id == id);
        }
        public async Task RegisterUser(User user)
        {
            user.password = BCrypt.Net.BCrypt.HashPassword(user.password);
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }
        public async Task<User> Login(string email, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.email == email);
            if(user != null && BCrypt.Net.BCrypt.Verify(password, user.password))
            {
                return user;
            }
            return null;
        }
        public async Task<User> EditUser(int id, User user)
        {
            var target = await _context.Users.FirstOrDefaultAsync(u => u.id == id);
            if (target == null) return null; // Handle non-existent user
            // Update relevant user properties (implement logic for specific updates)
            target.name = user.name;
            target.email = user.email; // Example updates, adjust based on your needs
            _context.Users.Update(target);
            await _context.SaveChangesAsync();
            return target;
        }
        public async Task<User> DeleteUser(int id)
        {
            var target = await _context.Users.FirstOrDefaultAsync(u => u.id == id);
            if (target == null) return null; // Handle non-existent user
            _context.Users.Remove(target);
            await _context.SaveChangesAsync();
            return target;
        }

        public async Task Order(int id, Purchase product)
        {
            product.date = DateTime.UtcNow; // Set purchase time directly on the "Purchase" object

            var target = await _context.Users.Include(u => u.orders).FirstOrDefaultAsync(u => u.id == id);
            if (target != null)
            {
                if (target.orders == null)
                    target.orders = new Purchase[] { product };
                else
                    target.orders = target.orders.Append(product).ToArray(); // Add the modified "Purchase" object to the user's orders

                await _context.SaveChangesAsync();
            }
        }

        public async Task Remove(int id, Purchase product)
        {
            var target = await _context.Users.Include(u => u.orders).FirstOrDefaultAsync(u => u.id == id);
            if (target != null && target.orders != null)
            {
                var purchaseToRemove = target.orders.FirstOrDefault(p => p.id == product.id);
                if (purchaseToRemove != null)
                {
                    target.orders = target.orders.Where(p => p.id != product.id).ToArray(); // Remove the "Purchase" object from the user's orders
                    await _context.SaveChangesAsync();
                }
            }
        }
    }
}
