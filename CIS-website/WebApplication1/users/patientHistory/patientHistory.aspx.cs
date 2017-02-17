using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.users
{
    public partial class patientHistory : System.Web.UI.Page
    {
        string drug;
        string surgery;
        string otherDisease;

        protected void Page_Load(object sender, EventArgs e)
        {

            if ((int)Session["id"] == 0)
            {
                Response.Redirect(Page.ResolveClientUrl("../../index.aspx"));
            }
            else
            {
                int id = (int)Session["id"];
                WebApplication1.scripts.personalData data = new scripts.personalData();
                WebApplication1.scripts.personalDataDAO dataDAO = new scripts.personalDataDAO();
                WebApplication1.scripts.otherDAO otherDAO = new scripts.otherDAO();
                List<WebApplication1.scripts.diseases> dis = new List<scripts.diseases>();
                WebApplication1.scripts.diseasesDAO disDAO = new scripts.diseasesDAO();

                List<string> tempDis =  new List<string>();
                List<string> tempDrug = new List<string>();
                List<string> tempSurg = new List<string>();

                tempDis = otherDAO.getDisByID(id);
                tempDrug = otherDAO.getDrugByID(id);
                tempSurg = otherDAO.getSurgByID(id);

                WebApplication1.scripts.personalData temp = new scripts.personalData();
                temp = dataDAO.getDataByID(id);

                TextboxPatientHistoryFirstname.Text = temp.getFname();
                TextboxPatientHistoryLastname.Text  = temp.getLname();
                TextboxPatientHistoryMobile.Text    = temp.getMobile();
                TextboxPatientHistoryBirthday.Text  = temp.getBirthday();
                TextboxPatientHistoryHeight.Text    = Convert.ToString(temp.getHeight());
                TextboxPatientHistoryWeight.Text    = Convert.ToString(temp.getWeight());
                string gender = temp.getGender();   
                            
                if (gender == "Male")   { RadioButtonListPatientHistoryGenderMale.Selected   = true; }
                else                    { RadioButtonListPatientHistoryGenderFemale.Selected = true; }


                bool[] diseases = new bool[11];
                

                diseases[0] = dis[0].getAnemia();
                diseases[1] = dis[0].getAsthma();
                diseases[2] = dis[0].getEpilipsy();
                diseases[3] = dis[0].getDepression();
                diseases[4] = dis[0].getDiabetes();
                diseases[5] = dis[0].getDiarrhea();
                diseases[6] = dis[0].getHeartAttack();
                diseases[7] = dis[0].getHepatitis();
                diseases[8] = dis[0].getRheumatism();
                diseases[9] = dis[0].getScarletFever();
                diseases[10] = dis[0].getSTD();

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
                    BulletedListDisease.Items.Add(new ListItem(tempDis[i]));
                }

                for (int i = 0; i < tempDrug.Count; i++)
                {
                    BulletedListDrug.Items.Add(new ListItem(tempDrug[i]));
                }

                for (int i = 0; i < tempSurg.Count; i++)
                {
                    BulletedListSurgery.Items.Add(new ListItem(tempSurg[i]));
                }

            }
        }

        protected void ButtonPatientHistorySubmit_Click(object sender, EventArgs e)
        {
            
                int id = (int)Session["id"];
                string fname = this.TextboxPatientHistoryFirstname.Text;
                string lname = this.TextboxPatientHistoryLastname.Text;
                string mobile = this.TextboxPatientHistoryMobile.Text;
                string gender = this.RadioButtonListPatientHistoryGender.Text;
                string birthday = this.TextboxPatientHistoryBirthday.Text;
                float height = float.Parse(this.TextboxPatientHistoryHeight.Text);
                float weight = float.Parse(this.TextboxPatientHistoryWeight.Text);

                WebApplication1.scripts.personalData data = new scripts.personalData();
                WebApplication1.scripts.personalDataDAO dataDao = new scripts.personalDataDAO();

                data.setId(id);
                data.setFname(fname);
                data.setLname(lname);
                data.setMobile(mobile);
                data.setGender(gender);
                data.setBirthday(birthday);
                data.setHeight(height);
                data.setWeight(weight);

                dataDao.insertData(data);

               bool[] diseases = new bool[12];
                int index = 0;
                foreach (ListItem i in CheckBoxListDisease.Items)
                {
                    if (i.Selected == true)
                    {
                        diseases[index] = true;
                    }
                    else
                    {
                        diseases[index] = false;
                    }
                    index++;
                }
            WebApplication1.scripts.diseases dis = new WebApplication1.scripts.diseases(id, diseases[0], diseases[1], diseases[2], diseases[3], diseases[4], diseases[5], diseases[6], diseases[7], diseases[8], diseases[9], diseases[10] );
            WebApplication1.scripts.diseasesDAO dieseasesDao = new WebApplication1.scripts.diseasesDAO();
            dieseasesDao.insertDiseases(dis);

            WebApplication1.scripts.other other = new scripts.other();
            WebApplication1.scripts.otherDAO otherDAO = new scripts.otherDAO();

            foreach(ListItem i in BulletedListDisease.Items)
            {
                otherDisease = i.Text;
                other.setOther_dis(otherDisease);
            }

            foreach (ListItem i in BulletedListDrug.Items)
            {
                drug = i.Text;
                other.setOther_drug(drug);
            }

            foreach (ListItem i in BulletedListSurgery.Items)
            {
                surgery = i.Text;
                other.setOther_surg(surgery);
            }

            other.setDis_id(id);
            other.setDrug_id(id);            
            other.setSurg_id(id);                                  

            otherDAO.insertOther_dis(other);
            otherDAO.insertOther_drug(other);
            otherDAO.insertOther_surg(other);
           
        }

        protected void ButtonAddDrug_Click(object sender, EventArgs e)
        {
            string textDrug = TextboxAddDrug.Text;
            BulletedListDrug.Items.Add(textDrug);
        }

        protected void ButtonAddSurgery_Click(object sender, EventArgs e)
        {
            string textSurgery = TextboxAddSurgery.Text;
            BulletedListSurgery.Items.Add(textSurgery);
        }

        protected void ButtonDiseaseOther_Click(object sender, EventArgs e)
        {
            string textOtherDisease = TextboxDiseaseOther.Text;
            BulletedListDisease.Items.Add(textOtherDisease);
        }

        protected void CheckboxPatientHistoryAgree_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckboxPatientHistoryAgree.Checked == true)
            {
                ButtonPatientHistorySubmit.Enabled = true;
            }
            else
            {
                ButtonPatientHistorySubmit.Enabled = false;
            }
        }

        protected void ButtonFamilyHistoryAdd_Click(object sender, EventArgs e)
        {
            TableRow row = new TableRow();
            TableCell relativeCell = new TableCell();
            TableCell diseaseCell = new TableCell();

            relativeCell.Text = TextboxFamilyHistoryRelative.Text;
            diseaseCell.Text = TextboxFamilyHistoryDisease.Text;

            row.Cells.Add(relativeCell);
            row.Cells.Add(diseaseCell);
            tableFamilyHistory.Rows.Add(row);
        }

    }
}