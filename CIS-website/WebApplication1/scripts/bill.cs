using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.scripts
{
    public class bill
    {
        int id;
        int billNumber;
        string bDate;
        int value;
        bool paid;

        public void setID(int ID) { id = ID; }
        public int getID() { return id; }

        public void setBillNumber(int billNo) { billNumber = billNo; }
        public int getBillNumber() { return billNumber; }

        public void setBDate(string date2) { bDate = date2; }
        public string getBDate() { return bDate; }

        public void setValue(int value2) { value = value2; }
        public int getValue() { return value; }

        public void setPaid(bool paid2) { paid = paid2; }
        public bool getPaid() { return paid; }



    }
}