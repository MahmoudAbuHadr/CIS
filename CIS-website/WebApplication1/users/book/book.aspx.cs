using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
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

                app.setDay(day);
                app.setTime(time);
                app.setId(id);
                dao.setAppointment(app);
                //after booking should redirect him to somewhere else 
            }
            else
            {
                ClientScriptManager cs = Page.ClientScript;
                Type cstype = this.GetType();

                String alert = "alert('this time is booked');";
                    cs.RegisterStartupScript(cstype, "PopupScript", alert, true);
                


            }




        }
    }
}