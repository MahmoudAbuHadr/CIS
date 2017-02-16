using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.scripts
{
    interface personalDataDAOinterface
    {
        void insertData(personalData data);
        void updateData(personalData data);
        personalData getDataByID(int id);
    }
}
