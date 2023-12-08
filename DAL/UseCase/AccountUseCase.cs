using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UseCase
{
    public interface AccountUseCase
    {

        bool Login(String username, String password);
        bool UpdateAccountPassword(string userName, string pass, string newPass);
        DataTable GetListAccountsTable();
        List<Account> GetListAccounts();
        List<Account> SearchListAccounts(string querySearch);
        Account GetAccountByUserName(string userName);
        bool InsertAccount(string username, string displayName, string phone, int basic_salary, int role, string password);
        bool UpdateAccount(string username, string displayName, int role, string phone, int basic_salary);
        bool DeleteAccount(string username);
        bool ResetPassword(string newPass, string username);

    }
}
