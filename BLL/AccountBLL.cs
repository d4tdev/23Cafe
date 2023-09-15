using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AccountBLL
    {
        private static AccountBLL instance;
        public static AccountBLL Instance
        {
            get { if (instance == null) instance = new AccountBLL(); return AccountBLL.instance; }
            private set { AccountBLL.instance = value; }
        }
        public AccountBLL() { }

        public bool Login(string userName, string passWord)
        {
            return AccountDAL.Instance.Login(userName, passWord);
        }
        public bool UpdateAccountWithPassword(string userName, string displayName, string pass, string newPass)
        {
            return AccountDAL.Instance.UpdateAccountPassword(userName, displayName, pass, newPass);
        }

        public DataTable GetListAccountsTable()
        {
            return AccountDAL.Instance.GetListAccountsTable();
        }

        public List<Account> GetAccounts()
        {
            return AccountDAL.Instance.GetListAccounts();
        }

        public Account GetAccountByUsername(string username)
        {
            return AccountDAL.Instance.GetAccountByUserName(username);
        }

        public bool InsertAccount(string username, string displayName, int type, string password)
        {
            return AccountDAL.Instance.InsertAccount(username, displayName, type, password);
        }

        public bool UpdateAccount(string username, string displayName, int role)
        {
            return AccountDAL.Instance.UpdateAccount(username, displayName, role);
        }

        public bool DeleteAccount(string username)
        {
            return AccountDAL.Instance.DeleteAccount(username);
        }

        public bool ResetPassword(string newPass, string username)
        {
            return AccountDAL.Instance.ResetPassword(newPass, username);
        }
    }
}
