using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.scripts
{
    public class billDAO : billDAOinterface
    {
        public List<bill> getBillByID(int id)
        {
            bill bill = new bill();
            List<bill> bills = new List<bill>();
            string connectionString = @"Data Source=NABSTER\SQLEXPRESS; Initial Catalog=CIS; Integrated Security=SSPI";
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand();

            myCommand.CommandText = "Select * from bill where id = '" + id + "';";
            myCommand.Connection = myConnection;
            SqlDataReader reader = myCommand.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                bill.setID(reader.GetInt32(0));
                bill.setBillNumber(reader.GetInt32(1));
                bill.setBDate(Convert.ToString(reader[2]));
                bill.setValue((reader.GetInt32(3)));
                bill.setPaid(Convert.ToBoolean(reader[4]));
                bills.Add(bill);              
            }

            reader.Close();
            myConnection.Close();

            return bills;
        }

        public void insertBill(bill bill)
        {
            string connectionString = @"Data Source=NABSTER\SQLEXPRESS; Initial Catalog=CIS; Integrated Security=SSPI";
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandText = "insert into bill (id,billNumber,bDate,value,paid) Values ('" + bill.getID().ToString() + "','" + bill.getBillNumber() + "','" + bill.getBDate() + "','" + bill.getValue() + "','" + bill.getPaid() + "')  ;  ";
            myCommand.Connection = myConnection;
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }

        public void updateBillByID(int id)
        {
            throw new NotImplementedException();
        }
        
    }
}