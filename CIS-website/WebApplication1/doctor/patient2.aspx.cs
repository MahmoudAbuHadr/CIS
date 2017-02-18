using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.doctor
{
    public partial class patient2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int reload2 =0;
            if (reload2 == 0)
            {
                int id = (int)Session["id"];
                WebApplication1.scripts.personalData data = new scripts.personalData();
                WebApplication1.scripts.personalDataDAO dataDAO = new scripts.personalDataDAO();
                WebApplication1.scripts.otherDiseaseDao otherDisDao = new scripts.otherDiseaseDao();
                WebApplication1.scripts.diseases dis = new scripts.diseases();
                WebApplication1.scripts.diseasesDAO disDAO = new scripts.diseasesDAO();
                WebApplication1.scripts.otherDrugDao drugDao = new scripts.otherDrugDao();
                WebApplication1.scripts.otherSurgeryDao surgDao = new scripts.otherSurgeryDao();

                List<WebApplication1.scripts.otherDisease> tempDis = new List<scripts.otherDisease>();
                List<WebApplication1.scripts.otherDrugs> tempDrug = new List<scripts.otherDrugs>();
                List<WebApplication1.scripts.otherSurgery> tempSurg = new List<scripts.otherSurgery>();
                tempDis = otherDisDao.getDiseaseById(id);
                tempDrug = drugDao.getDrugsById(id);
                tempSurg = surgDao.getSurgeryByid(id);

                WebApplication1.scripts.personalData temp = new scripts.personalData();
                temp = dataDAO.getDataByID(id);

                TextboxPatientHistoryFirstname.Text = temp.getFname();
                TextboxPatientHistoryLastname.Text = temp.getLname();
                TextboxPatientHistoryMobile.Text = temp.getMobile();
                TextboxPatientHistoryBirthday.Text = temp.getBirthday();
                TextboxPatientHistoryHeight.Text = Convert.ToString(temp.getHeight());
                TextboxPatientHistoryWeight.Text = Convert.ToString(temp.getWeight());
                string gender = temp.getGender();

                if (gender == "Male") { RadioButtonListPatientHistoryGenderMale.Selected = true; }
                else { RadioButtonListPatientHistoryGenderFemale.Selected = true; }


                bool[] diseases = new bool[11];


                dis = disDAO.getDisease(id);

                diseases[0] = dis.getAnemia();
                diseases[1] = dis.getAsthma();
                diseases[2] = dis.getEpilipsy();
                diseases[3] = dis.getDepression();
                diseases[4] = dis.getDiabetes();
                diseases[5] = dis.getDiarrhea();
                diseases[6] = dis.getHeartAttack();
                diseases[7] = dis.getHepatitis();
                diseases[8] = dis.getRheumatism();
                diseases[9] = dis.getScarletFever();
                diseases[10] = dis.getSTD();

                int index = 0;
                foreach (ListItem i in CheckBoxListDisease.Items)
                {
                    if (diseases[index] == true)
                    {
                        i.Selected = true;
                    }
                    else
                    {
                        i.Selected = false;
                    }
                    index++;
                }



                for (int i = 0; i < tempDis.Count; i++)
                {
                    BulletedListDisease.Items.Add(new ListItem(tempDis[i].getDisease()));
                }

                for (int i = 0; i < tempDrug.Count; i++)
                {
                    BulletedListDrug.Items.Add(new ListItem(tempDrug[i].getDrug()));
                }

                for (int i = 0; i < tempSurg.Count; i++)
                {
                    BulletedListSurgery.Items.Add(new ListItem(tempSurg[i].getSurgery()));
                }


            }
        }
    }
}