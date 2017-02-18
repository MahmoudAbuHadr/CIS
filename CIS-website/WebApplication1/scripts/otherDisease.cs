using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.scripts
{
    public class otherDisease

    {
        int id;
        string disease;
        public void setId(int Id) { id = Id; }
        public int getId() { return id; }

        public void setDisease(string dis) { disease = dis; }
        public string getDisease() { return disease ; }


    }
}