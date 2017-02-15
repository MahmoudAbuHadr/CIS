using System;
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
            CheckboxPatientHistoryAgree.Checked = true;
        }

        protected void ButtonPatientHistorySubmit_Click(object sender, EventArgs e)
        {
            if(CheckboxPatientHistoryAgree.Checked == true)
            {
                //unhandled store the information in the database
            }
            else
            {

            }
        }
    }
}