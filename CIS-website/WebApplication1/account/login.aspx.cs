using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonLoginSubmit_Click(object sender, EventArgs e)
        {
            string phone = this.TextboxLoginMobile.Text;
            string password = this.TextboxLoginPassword.Text;
            WebApplication1.scripts.AccountDAO dao = new scripts.AccountDAO();
            WebApplication1.scripts.AccountCredentials acc = new scripts.AccountCredentials();
            int id = dao.getIdByPhoneNumber(phone);
            if (id == -1)
            {
                //not regestierd
                Response.Redirect(Page.ResolveClientUrl("www.google.com"));
            }
            else
            {
                acc = dao.getAccountById(id);
                if (acc.getPassword() != password)
                {
                    //wrong password
                    Response.Redirect(Page.ResolveClientUrl("www.facebook.com"));
                }
                else
                {
                    //access granted
                    string day="11/02/2016"; string time="08:30";
                    WebApplication1.scripts.Appointment app = new scripts.Appointment();
                    app.setId(id);
                    app.setTime(time);
                    app.setDay(day);
                    WebApplication1.scripts.AppointmentDAO D = new scripts.AppointmentDAO();
                    D.setAppointment(app);
                     day = "11/02/2016";
                     time = "09:30";
                      id = 2;
                    app.setId(id);
                    app.setTime(time);
                    app.setDay(day);
                    D.setAppointment(app);


                    List<WebApplication1.scripts.Appointment> list = new List<scripts.Appointment>();
                    list = D.searchByDay(day);
                    if (list.Count == 2) {
                        Response.Redirect(Page.ResolveClientUrl("yesBitch"));

                    }






                }

            }
        }
    }
}