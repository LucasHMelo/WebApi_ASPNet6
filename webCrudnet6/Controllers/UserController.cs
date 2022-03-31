using Microsoft.AspNetCore.Mvc;
using webCrudnet6.Models;

namespace webCrudnet6.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private static List<User> Users()
        {
            return new List<User> { new User { Nome = "Lucas", Id = 123456, DataNascimento = new DateTime(2000,01,01)}
            };
        }

        [HttpGet]
        public IActionResult Get() { return Ok(Users()); }

        [HttpPost]
        public IActionResult Post(User user) { 
            
            var users = Users();
            users.Add(user);

            return Ok(users); 
        }
    }
}
