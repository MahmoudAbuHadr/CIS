using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.scripts
{
    public class other
    {
        int dis_id;
        int drug_id;
        int surg_id;

        string other_dis;
        string other_drug;
        string other_surg;


        public void setDis_id(int dis) { dis_id = dis; }
        public int  getDis_id() { return dis_id; }

        public void setDrug_id(int drug) { drug_id = drug; }
        public int getDrug_id() { return drug_id; }

        public void setSurg_id(int surg) { surg_id = surg ; }
        public int getSurg_id() { return surg_id; }

        public void setOther_dis(string dis) { other_dis = dis; }
        public string getOther_dis() { return other_dis; }

        public void setOther_drug(string drug) { other_drug = drug; }
        public string getOther_drug() { return other_drug; }

        public void setOther_surg(string surg) { other_surg =surg; }
        public string getOther_surg() { return other_surg; }
    }
}