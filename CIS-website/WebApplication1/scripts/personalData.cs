using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.scripts
{
    public class personalData
    {
        int id;
        string firstName;
        string lastName;
        string mobile;
        string gender;
        string birthday;
        float height;
        float weight;


        public void setId(int  Id) { id = Id; }
        public string getId() { return id; }


        public void setFname(string fname) { firstName = fname;      }
        public string getFname() { return firstName; }

        public void setLname(string lname) { lastName = lname; }
        public string getLname() { return lastName; }

        public void setMobile(string mobileNum) { mobile = mobileNum; }
        public string getMobile() { return mobile; }

        public void setGender(string gen) { gender = gen; }
        public string getGender() { return gender; }

        public void setBirthday(string birth) { birthday = birth; }
        public string getBirthday() { return birthday; }

        public void setHeight(float height2) { height = height2; }
        public float getHeight() { return height; }

        public void setWeight(float weight2) { weight = weight2; }
        public float getWeight() { return weight; }

    }
}