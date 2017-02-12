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

        }

        protected void ButtonSignupSubmit_Click(object sender, EventArgs e)
        {
            string fName = this.TextboxSignupFirstname.Text;
            string lName = this.TextboxSignupLastname.Text;
            string email = this.TextboxSignupLastname.Text;
            string password = this.TextboxSignupPassword.Text;
            string phone = this.TextboxSignupMobile.Text;
            WebApplication1.scripts.AccountCredentials acc = new scripts.AccountCredentials();
            acc.setFName(fName);
            acc.setLName(lName);
            acc.setEmail(email);
            acc.setPassword(password);
            acc.setPhoneNumber(phone);
            WebApplication1.scripts.AccountDAO dao = new scripts.AccountDAO();
            if (dao.getIdByPhoneNumber(phone) == -1) {
                dao.insertAccount(acc);
                //should redirect to home page
            }
            else {
                ///unhandeled 
            }

        }
    }
}