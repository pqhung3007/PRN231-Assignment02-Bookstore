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
    internal class UserRepository : IUserRepository
    {
        public void DeleteUser(User user) => UserDAO.DeleteUser(user);

        public List<User> GetAllUsers() => UserDAO.GetAllUsers();

        public User GetMemberByUsernameAndPassword(string username, string password) => UserDAO.GetMemberByUsernameAndPassword(username, password);

        public User GetUserById(int id) => UserDAO.GetUserById(id);

        public void InsertUser(User user) => UserDAO.InsertUser(user);

        public void UpdateUser(User user) => UserDAO.UpdateUser(user);
    }
}
