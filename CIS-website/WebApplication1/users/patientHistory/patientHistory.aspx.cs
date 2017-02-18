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

           /* int id = (int)Session["id"];
            WebApplication1.scripts.personalData data = new scripts.personalData();
            WebApplication1.scripts.personalDataDAO dataDAO = new scripts.personalDataDAO();
            WebApplication1.scripts.otherDiseaseDao otherDisDao = new scripts.otherDiseaseDao();
            WebApplication1.scripts.diseases dis = new scripts.diseases();
            WebApplication1.scripts.diseasesDAO disDAO = new scripts.diseasesDAO();

            List<WebApplication1.scripts.otherDisease> tempDis = new List<scripts.otherDisease>();
            //List<string> tempDrug = new List<string>();
            //List<string> tempSurg = new List<string>();

            tempDis = otherDisDao.getDiseaseById(id);
            // tempDrug = otherDAO.getDrugByID(id);
            // tempSurg = otherDAO.getSurgByID(id);

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

            /*  for (int i = 0; i < tempDrug.Count; i++)
              {
                  BulletedListDrug.Items.Add(new ListItem(tempDrug[i]));
              }
              for (int i = 0; i < tempSurg.Count; i++)
              {
                  BulletedListSurgery.Items.Add(new ListItem(tempSurg[i]));
              }*/
        }







        protected void ButtonPatientHistorySubmit_Click(object sender, EventArgs e)
        {

            int id = (int)Session["id"];
            bool isExist = true;



            string fname = this.TextboxPatientHistoryFirstname.Text;
            string lname = this.TextboxPatientHistoryLastname.Text;
            string mobile = this.TextboxPatientHistoryMobile.Text;
            string gender = this.RadioButtonListPatientHistoryGender.Text;
            string birthday = this.TextboxPatientHistoryBirthday.Text;
            float height = float.Parse(this.TextboxPatientHistoryHeight.Text);
            float weight = float.Parse(this.TextboxPatientHistoryWeight.Text);

            WebApplication1.scripts.personalData data = new scripts.personalData();
            WebApplication1.scripts.personalDataDAO dataDao = new scripts.personalDataDAO();

            if (dataDao.getDataByID(id).getId() == 0) isExist = false;

            data.setId(id);
            data.setFname(fname);
            data.setLname(lname);
            data.setMobile(mobile);
            data.setGender(gender);
            data.setBirthday(birthday);
            data.setHeight(height);
            data.setWeight(weight);


            if (isExist)
            {
                dataDao.updateData(data);
            }
            else
            {
                dataDao.insertData(data);
            }


            isExist = true;

            bool[] diseases = new bool[11];
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

            /////////////////////////////peace 



            WebApplication1.scripts.otherDiseaseDao otherDisDao = new scripts.otherDiseaseDao();
            foreach (ListItem i in BulletedListDisease.Items)
            {
                WebApplication1.scripts.otherDisease otherDis = new scripts.otherDisease();
                otherDisease = i.Text;
                otherDis.setDisease(otherDisease);
                otherDis.setId(id);
                otherDisDao.insertDisease(otherDis);

            }

            WebApplication1.scripts.otherDrugDao otherDrDao = new scripts.otherDrugDao();
            foreach (ListItem i in BulletedListDrug.Items)
            {
                WebApplication1.scripts.otherDrugs otherDrugg = new scripts.otherDrugs();
                drug= i.Text;
                otherDrugg.setDrug(drug);
                otherDrugg.setId(id);
                otherDrDao.insertDrug(otherDrugg);

            }

            WebApplication1.scripts.otherSurgeryDao otherSurgeryDa = new scripts.otherSurgeryDao();
            foreach (ListItem i in BulletedListSurgery.Items)
            {
                WebApplication1.scripts.otherSurgery otherSurg = new scripts.otherSurgery();
                surgery = i.Text;
                otherSurg.setSurgery(drug);
                otherSurg.setId(id);
                otherSurgeryDa.insertSurgery(otherSurg);

            }



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