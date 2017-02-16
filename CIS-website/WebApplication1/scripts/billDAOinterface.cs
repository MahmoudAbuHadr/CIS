using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.scripts
{
    interface billDAOinterface
    {
        void insertBill(bill bill);
        List <bill> getBillByID(int id);
        void updateBillByID(int id);
    }
}
