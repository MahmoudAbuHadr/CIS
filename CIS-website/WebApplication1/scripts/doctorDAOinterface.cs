using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.scripts
{
    interface doctorDAOinterface
    {
        void insertData(doctor doc);
        void updateData(doctor doc);
        doctor getDataByID(int id);
        doctor getAccountByPhone(string phone);
    }
}
