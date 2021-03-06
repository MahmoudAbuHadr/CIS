﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebApplication1.users
{
    public partial class book : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((int)Session["id"] == 0) {
                Response.Redirect(Page.ResolveClientUrl("../../index.aspx"));
            }
            TextboxBookDate.Attributes["min"] = DateTime.Now.ToString("yyyy-MM-dd");
            TextboxBookDate.Attributes["max"] = DateTime.Now.ToString("2018-01-01");
        }

        protected void ButtonBookSubmit_Click(object sender, EventArgs e)
        {
            string day = this.TextboxBookDate.Text;
            string time = this.TextboxBookTime.Text;
            int id = (int)Session["id"];
            //needed : check if this is booked 
            WebApplication1.scripts.AppointmentDAO dao = new scripts.AppointmentDAO();
            WebApplication1.scripts.Appointment app = new scripts.Appointment();
            List<WebApplication1.scripts.Appointment> list = new List<scripts.Appointment>();
            list = dao.searchByDay(day);
            bool booked = false;
            for (int i = 0; i < list.Count; i++) {
                if (list[i].getTime() == time) { booked = true; }

            }

            if (!booked) {
                int fees = 100;
                app.setDay(day);
                app.setTime(time);
                app.setId(id);
                dao.setAppointment(app);
                //after booking the bill inserted to bills table
                WebApplication1.scripts.bill Bill = new scripts.bill();
                Bill.setID(id);
                Bill.setBDate(day);
                Bill.setValue(fees);
                Bill.setPaid(false);

                WebApplication1.scripts.billDAO bDao = new scripts.billDAO();
                bDao.insertBill(Bill);

                //redirect to bills 
                Response.Redirect(Page.ResolveClientUrl("../bill/bill.aspx"));

            }
            else
            {
                ClientScriptManager cs = Page.ClientScript;
                Type cstype = this.GetType();

                String alert = "alert('this time is booked');";
                    cs.RegisterStartupScript(cstype, "PopupScript", alert, true);
                


            }




        }

        protected void TextboxBookDate_TextChanged(object sender, EventArgs e)
        {
            
            ///it didn't work
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string day = this.TextboxBookDate.Text;
            WebApplication1.scripts.AppointmentDAO dao = new scripts.AppointmentDAO();
            WebApplication1.scripts.Appointment app = new scripts.Appointment();
            List<WebApplication1.scripts.Appointment> list = new List<scripts.Appointment>();
            list = dao.searchByDay(day);
            for (int i = 0; i < list.Count; i++)
            {
                HtmlGenericControl li = new HtmlGenericControl("li");
                tabs.Controls.Add(li);
                HtmlGenericControl paragraph = new HtmlGenericControl("p");
                paragraph.InnerText = list[i].getTime();
                li.Controls.Add(paragraph);
            }
        }
    }
}