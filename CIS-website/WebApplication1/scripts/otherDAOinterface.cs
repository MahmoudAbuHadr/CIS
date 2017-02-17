using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.scripts
{
    interface otherDAOinterface
    {
        void insertOther_drug(other drug);
        void insertOther_dis(other dis);
        void insertOther_surg(other surg);

        List<string> getDisByID(int id);
        List<string> getDrugByID(int id);
        List<string> getSurgByID(int id);

        void updateOther_drug(other drug);
        void updateOther_dis(other dis);
        void updateOther_surg(other surg);

    }
}
