using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.scripts
{
    public class Appointment
    {
        private int id;
        private string day;
        private string time;
        
        public void setId(int Id) { id = Id; }
        public int getId() { return id; }

        public void setDay(string Day) { day = Day; }
        public string getDay() { return day; }

        public void setTime(string Time) { time = Time; }
        public string getTime() { return time; }







    }
}