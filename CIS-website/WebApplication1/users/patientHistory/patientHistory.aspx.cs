﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.users
{
    public partial class patientHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           CheckboxPatientHistoryAgree.Checked = false;
           if ((int)Session["id"] == 0)
            {
                Response.Redirect(Page.ResolveClientUrl("../../index.aspx"));
            }
        }

        protected void ButtonPatientHistorySubmit_Click(object sender, EventArgs e)
        {
            if(CheckboxPatientHistoryAgree.Checked == true)
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

                data.setFname(fname);
                data.setLname(lname);
                data.setMobile(mobile);
                data.setGender(gender);
                data.setBirthday(birthday);
                data.setHeight(height);
                data.setWeight(weight);

                dataDao.insertData(data);

            }
            else
            {
                ClientScriptManager cs = Page.ClientScript;
                Type cstype = this.GetType();

                String alert = "alert('you can't submit without agreeing ');";
                cs.RegisterStartupScript(cstype, "PopupScript", alert, true);
            }
        }

        protected void ButtonAddDrug_Click(object sender, EventArgs e)
        {
            string drug = TextboxAddDrug.Text;
            BulletedListDrug.Items.Add(drug);
        }

        protected void ButtonAddSurgery_Click(object sender, EventArgs e)
        {
            string surgery = TextboxAddSurgery.Text;
            BulletedListSurgery.Items.Add(surgery);
        }

        protected void ButtonDiseaseOther_Click(object sender, EventArgs e)
        {
            string otherDisease = TextboxDiseaseOther.Text;
            BulletedListDisease.Items.Add(otherDisease);
        }

    }
}