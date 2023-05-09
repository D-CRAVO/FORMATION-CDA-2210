using ApiUser.Db;
using ApiUser.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ApiUser.Extensions;

namespace ApiUser.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private UserDbContext _context;

        public LoginController() 
        {
            _context = new UserDbContext();
        }

        [HttpPost]
        public User? Login(User user)
        {
            return _context.Users.FirstOrDefault
                (
                    u => u.UserName == user.UserName
                    && u.Password.CheckPassword(user.Password)
                    //&& u.Password == user.Password
                );
        }
    }
}
