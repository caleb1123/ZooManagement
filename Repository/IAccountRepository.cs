using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Models;
using DataAccess;
namespace Repository
{
    public interface IAccountRepository
    {
        Account checkLogin(string username, string password);
    }
}
