using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.scripts
{
    public class otherSurgery
    {
        int id;
        string surgery;
        public void setId(int Id) { id = Id; }
        public int getId() { return id; }

        public void setSurgery(string surg) { surgery = surg; }
        public string getSurgery() { return surgery; }
    }
}