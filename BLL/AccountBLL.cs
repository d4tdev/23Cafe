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
        public bool UpdateAccountWithPassword(string userName, string pass, string newPass)
        {
            return AccountDAL.Instance.UpdateAccountPassword(userName, pass, newPass);
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

        public bool InsertAccount(string username, string displayName, int role, string password, string phone, int basic_salary)
        {
            return AccountDAL.Instance.InsertAccount(username, displayName,phone, basic_salary, role, password);
        }

        public bool UpdateAccount(string username, string displayName, int role, string phone, int basic_salary)
        {
            return AccountDAL.Instance.UpdateAccount(username, displayName, role, phone, basic_salary);
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
