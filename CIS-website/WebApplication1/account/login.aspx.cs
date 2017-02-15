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
            if ((int)Session["id"] != 0) { Response.Redirect(Page.ResolveClientUrl("../users/book/book.aspx")); }
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
                ClientScriptManager cs = Page.ClientScript;
                Type cstype = this.GetType();

                String alert = "alert('this phone number is not registered');";
                cs.RegisterStartupScript(cstype, "PopupScript", alert, true);
            }
            else
            {
                //phone number exist 
                acc = dao.getAccountById(id);
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
                    Session["id"] = id;
                    Response.Redirect(Page.ResolveClientUrl("../users/book/book.aspx"));


                }






            }

            }
        }
    }
