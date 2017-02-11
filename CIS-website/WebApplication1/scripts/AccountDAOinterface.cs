using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.scripts
{
    interface AccountDAOinterface
    {
        void insertAccount(AccountCredentials acc);
        AccountCredentials getAccountById(int id);
        void updateAccount( AccountCredentials acc);
        int getIdByPhoneNumber(string phoneNumber);





    }
}
