using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Services;
using Database;
using Microsoft.AspNetCore.Identity.Data;

namespace API
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly MyServices _services;

        public UsersController(MyServices services)
        {
            _services = services;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser(User user)
        {
            await _services.RegisterUser(user);
            return Ok();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            var user = await _services.Login(request.Email, request.Password);
            if (user != null)
            {
                // Return user data or token
                return Ok(user);
            }
            return NotFound(); // Or Unauthorized() depending on your authentication flow
        }

        [HttpPut("edit/{id}")]
        public async Task<IActionResult> EditUser(int id, User user)
        {
            var editedUser = await _services.EditUser(id, user);
            if (editedUser != null)
            {
                return Ok(editedUser);
            }
            return NotFound();
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var deletedUser = await _services.DeleteUser(id);
            if (deletedUser != null)
            {
                return Ok(deletedUser);
            }
            return NotFound();
        }
    }

    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly MyServices _services;

        public OrdersController(MyServices services)
        {
            _services = services;
        }

        [HttpPost("order/{id}")]
        public async Task<IActionResult> Order(int id, Purchase product)
        {
            await _services.Order(id, product);
            return Ok();
        }

        [HttpPost("remove/{id}")]
        public async Task<IActionResult> Remove(int id, Purchase product)
        {
            await _services.Remove(id, product);
            return Ok();
        }
    }
}