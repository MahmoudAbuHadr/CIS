using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.scripts
{
    public class familyHistory
    {
        private int id;
        private string relative;
        private string disease;

        public void setID(int ID) { id = ID; }
        public int getID() { return id; }

        public void setRelative(string rel) { relative = rel; }
        public string getRelative() { return relative; }

        public void setDisease(string dis) { disease = dis; }
        public string getDisease() { return disease; }

    }
}