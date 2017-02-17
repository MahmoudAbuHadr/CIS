using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((int)Session["id"] != 0) { Response.Redirect(Page.ResolveClientUrl("../users/book/book.aspx")); }
        }

        protected void ButtonSignupSubmit_Click(object sender, EventArgs e)
        {
            if (TextboxSignupPassword.Text == TextboxSignupConfirmPassword.Text)
            {
                string fName = this.TextboxSignupFirstname.Text;
                string lName = this.TextboxSignupLastname.Text;
                string email = this.TextboxSignupEmail.Text;
                string password = this.TextboxSignupPassword.Text;
                string phone = this.TextboxSignupMobile.Text;
                WebApplication1.scripts.AccountCredentials acc = new scripts.AccountCredentials();
                acc.setFName(fName);
                acc.setLName(lName);
                acc.setEmail(email);
                acc.setPassword(password);
                acc.setPhoneNumber(phone);
                WebApplication1.scripts.AccountDAO dao = new scripts.AccountDAO();
                if (dao.getIdByPhoneNumber(phone) == -1)
                {
                    dao.insertAccount(acc);

                    ClientScriptManager cs = Page.ClientScript;
                    Type cstype = this.GetType();

                    String alert = "alert('registeration completed');";
                    cs.RegisterStartupScript(cstype, "PopupScript", alert, true);
                    Response.Redirect(Page.ResolveClientUrl("login.aspx"));

                }
                else
                {
                    ClientScriptManager cs = Page.ClientScript;
                    Type cstype = this.GetType();

                    String alert = "alert('this phone number is already registered ');";
                    cs.RegisterStartupScript(cstype, "PopupScript", alert, true);
                }

            }
            else
            {
                Response.Write("<script language=javascript>alert('password and confirm password does not match');</script>");
            }
        }
    }
}