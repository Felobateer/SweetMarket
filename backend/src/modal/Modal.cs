using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Database;

public class Purchase
{
    public int id {get; set;}
    public string name {get; set;}
    public double price {get; set;}
    public string img {get; set;}
    public DateTime date {get; set;}
}

public class User 
{
    public int id {get; set;}
    public string name {get; set;}
    public string email {get; set;}
    public string password {get; set;}
    public Purchase[] orders {get; set;}
}

public class Product
{
    public string id {get; set;}
    public string name {get; set;}
    public string description {get; set;}
    public string img {get; set;}
    public double price {get; set;}
}

public class MyDb: DbContext
{
    public DbSet<User> Users {get; set;}
    public DbSet<Product> Products {get; set;}
    private readonly IConfiguration _configuration;

    public MyDb(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("Default"));
        }
}