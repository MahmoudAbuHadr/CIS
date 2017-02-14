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
        string getBirthday() { return birthday; }

        void setHeight(float height2) { height = height2; }
        float getHeight() { return height; }

        void setWeight(float weight2) { weight = weight2; }
        float getWeight() { return weight; }

    }
}