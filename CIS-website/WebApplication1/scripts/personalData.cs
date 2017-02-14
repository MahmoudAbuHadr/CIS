using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.scripts
{
    public class personalData
    {
        string firstName;
        string lastName;
        string mobile;
        string gender;
        string birthday;
        float height;
        float weight;

        void setFname(string fname) { firstName = fname;      }
        string getFname() { return firstName; }

        void setLname(string lname) { lastName = lname; }
        string getLname() { return lastName; }

        void setMobile(string mobileNum) { mobile = mobileNum; }
        string getMobile() { return mobile; }

        void setGender(string gen) { gender = gen; }
        string getGender() { return gender; }

        void setBirthday(string birth) { birthday = birth; }
        string get() { return firstName; }
    }
}