using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.users.bill
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((int)Session["id"] == 0) {
                Response.Redirect(Page.ResolveClientUrl("../../index.aspx"));

            }
            else
            {
                WebApplication1.scripts.billDAO dao = new scripts.billDAO();
                int id = (int)Session["id"];
                List<WebApplication1.scripts.bill> bills = new List<scripts.bill>();
                bills = dao.getBillByID(id);
                for (int i = 0; i < bills.Count; i++)
                {
                    TableRow row = new TableRow();
                    TableCell billNumerCell = new TableCell();
                    TableCell dateCell = new TableCell();
                    TableCell valueCell = new TableCell();
                    TableCell paidCell = new TableCell();
                    billNumerCell.Text = bills[i].getBillNumber().ToString();
                    dateCell.Text = bills[i].getBDate();
                    valueCell.Text = bills[i].getValue().ToString();
                    if (bills[i].getPaid()) paidCell.Text = "Paid";
                    else paidCell.Text = "Not Paid";

                    row.Cells.Add(billNumerCell);
                    row.Cells.Add(dateCell);
                    row.Cells.Add(valueCell);
                    row.Cells.Add(paidCell);
                    tableBill.Rows.Add(row);
                }

            }


        }
    }
}
