using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public interface IUserDAO
    {
        Task<string> Login(string email, string password);
    }
}
