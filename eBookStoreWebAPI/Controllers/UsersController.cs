using BusinessObject;
using DataAccess.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eBookStoreWebAPI.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly BookStoreDbContext _context;

        public UsersController(IUserRepository userRepository, BookStoreDbContext context)
        {
            _userRepository = userRepository;
            _context = context;
        }

        [HttpPost]
        [Route("users/login")]
        public async Task<string> Login([FromBody] FormData data)
        {
            var result = await _userRepository.Login(data.Email, data.Password);
            return result;
        }

    }
}
