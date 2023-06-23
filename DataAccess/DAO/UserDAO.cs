using BusinessObject;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class UserDAO : IUserDAO
    {
        private readonly IConfiguration _configuration;
        
        public UserDAO(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task<string> Login(string email, string password)
        {
            string configEmail = _configuration["Email"];
            string configPassword = _configuration["Password"];
            if (configEmail== email && configPassword == password)
            {
                var user = new User()
                {
                    EmailAddress = email,
                    Password = password,
                    FirstName = "Admin",
                    LastName = "BookStore",
                    RoleId = 2,
                    PubId = 1,
                };
                return Task.FromResult("Login successfully: " + user);
            }
            else
            {
                return Task.FromResult("Login Failed");
            }
        }
    }
}
