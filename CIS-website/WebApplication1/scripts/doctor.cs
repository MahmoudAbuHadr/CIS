using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.scripts
{
    public class doctor
    {
        int id;
        string PNumber;
        string Email;
        string Password;
        string FName;
        string LName;
        int fees;


        public void setID(int ID) { id = ID; }
        public int getID() { return id; }

        public void setPNumber(string PNo) { PNumber = PNo; }
        public string getPNumber() { return PNumber; }

        public void setEmail(string email) { Email = email; }
        public string getEmail() { return Email; }

        public void setPassword(string pass) { Password = pass; }
        public string getPassword() { return Password; }

        public void setFname(string firstName) { FName = firstName; }
        public string getFname() { return FName; }

        public void setLname(string lastName) { LName = lastName; }
        public string getLname() { return LName; }

        public void setFees(int fee) { fees = fee; }
        public int getFees() { return fees; }


    }
}