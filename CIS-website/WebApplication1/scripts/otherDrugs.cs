using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.scripts
{
    public class otherDrugs
    {
        int id;
        string drug;
        public void setId(int Id) { id = Id; }
        public int getId() { return id; }

        public void setDrug(string dru) { drug = dru; }
        public string getDrug() { return drug; }
    }
}