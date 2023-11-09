using BusinessLayer.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AccountRepository : IAccountRepository
    {
        public Account checkLogin(string username, string password)=> AccountDAO.Instance.checkLogin(username, password);   
    }
}
