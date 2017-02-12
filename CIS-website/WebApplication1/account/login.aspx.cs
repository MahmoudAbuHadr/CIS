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
                    Response.Redirect(Page.ResolveClientUrl("www.wikipedia.com"));
                }

            }
        }
    }
}