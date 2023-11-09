using BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AccountDAO
    {
        private static AccountDAO instance = null;
        private static object lockobj = new object();

        private AccountDAO() { }

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountDAO();
                }


                return instance;
            }
        }

        public Account checkLogin(string user, string password)
        {
            using var db = new zooContext();
            return db.Accounts.SingleOrDefault(m => m.UserName.Equals(user) &&
           m.Password.Equals(password));


        }
    }
}
