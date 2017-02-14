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

        }

        protected void ButtonBookSubmit_Click(object sender, EventArgs e)
        {
            string day = this.TextboxBookDate.Text;
            string time = this.TextboxBookTime.Text;
            int id =Convert.ToInt32(Request.QueryString["id"]);
            //needed : check if this is booked 
            WebApplication1.scripts.AppointmentDAO dao = new scripts.AppointmentDAO();
            WebApplication1.scripts.Appointment app = new scripts.Appointment();
            app.setDay(day);
            app.setTime(time);
            app.setId(id);
            dao.setAppointment(app);




        }
    }
}