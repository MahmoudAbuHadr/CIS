using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] == null || Session["dId"]==null)
            {
                Session["id"] = 0;
                Session["dId"] = 0;
            }
            else if(((int)Session["id"])==0 && ((int)Session["dId"])!=0) { //doctor
                Response.Redirect(Page.ResolveClientUrl("/doctor/doctorIndex.aspx"));

            }

            
        }
    }
}