using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.users.bill
{
    public partial class bill : System.Web.UI.Page
    {
        public void insertBillToTable(string billNumber, string date, string fees, string paid,Table table)
        {
            TableRow row = new TableRow();
            for (int i = 0; i < 4; i++)
            {
                TableCell cell = new TableCell();
                cell.Text = billNumber;
                row.Cells.Add(cell);
            }
            table.Rows.Add(row);
        }

        protected void Page_Load(object sender, EventArgs e)
        {


            insertBillToTable("hi", "hi", "hi", "hi", billTable);
        }
    }
}