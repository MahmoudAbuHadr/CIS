﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.doctor.patients_files
{
    public partial class patients_files : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string phone = Convert.ToString(Request.QueryString["phone"]);
            WebApplication1.scripts.AccountDAO accDao = new scripts.AccountDAO();
            int  id = accDao.getIdByPhoneNumber(phone);


        }
    }
}