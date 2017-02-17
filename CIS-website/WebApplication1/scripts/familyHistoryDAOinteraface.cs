using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.scripts
{
    interface familyHistoryDAOinteraface
    {
        void insertHistory(familyHistory history);
        List<familyHistory> getHistoryById(int id);
        void updateHistory(familyHistory history);
    }
}
