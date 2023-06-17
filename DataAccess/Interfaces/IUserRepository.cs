using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IUserRepository
    {
        User GetUserById(int id);
        User GetMemberByUsernameAndPassword(string username, string password);
        List<User> GetAllUsers();
        void InsertUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
    }
}
