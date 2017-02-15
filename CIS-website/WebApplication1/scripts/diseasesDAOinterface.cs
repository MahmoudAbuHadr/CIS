using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.scripts
{
    interface diseasesDAOinterface
    {
        void insertDiseases(diseases disease);
        void updateDiseases(diseases disease);
        diseases getDisease(int id);
                      
    }
}
