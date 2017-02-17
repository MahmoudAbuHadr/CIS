using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.doctor.reservatoins
{
    public partial class reservations : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebApplication1.scripts.AppointmentDAO appDao = new scripts.AppointmentDAO();
            List<WebApplication1.scripts.Appointment> appointments = new List<scripts.Appointment>();
            WebApplication1.scripts.AccountDAO accDao = new scripts.AccountDAO();
            DateTime now = DateTime.Now;
            string today = now.ToString("yyyy-MM-dd");
            appointments = appDao.searchByDay(today);
            for(int i = 0; i < appointments.Count; i++)
            {
                TableRow row = new TableRow();
                TableCell fNameCell = new TableCell();
                TableCell lNameCell = new TableCell();
                TableCell dayCell = new TableCell();
                TableCell timeCell = new TableCell();

                WebApplication1.scripts.AccountCredentials patient = new scripts.AccountCredentials();
                patient = accDao.getAccountById(appointments[i].getId());
                fNameCell.Text=patient.getFName();
                lNameCell.Text=patient.getLName();
                dayCell.Text=appointments[i].getDay();
                timeCell.Text=appointments[i].getTime();
                row.Cells.Add(fNameCell);
                row.Cells.Add(lNameCell);
                row.Cells.Add(dayCell);
                row.Cells.Add(timeCell);
                tableReservation.Rows.Add(row);


            }





        }
    }
}