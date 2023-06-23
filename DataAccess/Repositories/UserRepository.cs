using BusinessObject;
using DataAccess.DAO;
using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IUserDAO _userDao;

        public UserRepository(IUserDAO userDAO)
        {
            _userDao = userDAO;
        }

        public async Task<string?> Login(string email, string password)
        {
            return await _userDao.Login(email, password);
        }
    }
}
