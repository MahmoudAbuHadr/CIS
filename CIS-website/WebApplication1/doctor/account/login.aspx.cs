using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.doctor.account
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
            WebApplication1.scripts.doctorDAO dao = new scripts.doctorDAO();
            WebApplication1.scripts.doctor acc = new scripts.doctor();
            int id = dao.getAccountByPhone(phone).getID();
            if (id == -1)
            {
                //not regestierd
                ClientScriptManager cs = Page.ClientScript;
                Type cstype = this.GetType();

                String alert = "alert('this phone number is not registered');";
                cs.RegisterStartupScript(cstype, "PopupScript", alert, true);
            }
            else
            {
                //phone number exist 
                acc = dao.getAccountByPhone(phone);
                if (acc.getPassword() != password)
                {
                    //wrong password
                    ClientScriptManager cs = Page.ClientScript;
                    Type cstype = this.GetType();

                    String alert = "alert('wrong password');";
                    cs.RegisterStartupScript(cstype, "PopupScript", alert, true);
                }
                else
                {
                    //access granted
                    Session["pID"] = id;
                    Response.Redirect(Page.ResolveClientUrl("/doctor/doctorHome.aspx"));


                }

            }
        }
    }
}