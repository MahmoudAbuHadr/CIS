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
            string connectionString = @"Data Source=cdb.c1lbyzt9l8fn.us-west-2.rds.amazonaws.com,1433;" + "Initial Catalog=cis;" + "User id=sonaaaa;" + "Password=mo7senzzzz;";
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand();

            myCommand.CommandText = "Select * from bill where id = '" + id + "';";
            myCommand.Connection = myConnection;
            SqlDataReader reader = myCommand.ExecuteReader();


            if (reader.HasRows) {
                while (reader.Read())
                {
                    bill.setID(reader.GetInt32(0));
                    bill.setBillNumber(reader.GetInt32(1));
                    bill.setBDate(Convert.ToString(reader[2]));
                    bill.setValue((reader.GetInt32(3)));
                    bill.setPaid(Convert.ToBoolean(reader[4]));
                    bills.Add(bill);
                }
            }
                    
                
            reader.Close();
            myConnection.Close();

            return bills;
        }

        public void insertBill(bill bill)
        {
            string connectionString = @"Data Source=cdb.c1lbyzt9l8fn.us-west-2.rds.amazonaws.com,1433;" + "Initial Catalog=cis;" + "User id=sonaaaa;" + "Password=mo7senzzzz;";
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandText = "insert into bill (id,date,value,paid) Values ('" + bill.getID().ToString() + "','" + bill.getBDate() + "','" + bill.getValue() + "','" + bill.getPaid() + "')  ;  ";
            myCommand.Connection = myConnection;
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }

        public void updateBillByID(int id)
        {
            string connectionString = @"Data Source=cdb.c1lbyzt9l8fn.us-west-2.rds.amazonaws.com,1433;" + "Initial Catalog=cis;" + "User id=sonaaaa;" + "Password=mo7senzzzz;";
            SqlConnection myConnection = new SqlConnection(connectionString);
            bill bill = new bill();
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandText = "UPDATE bill SET id =" + id + ",billNumber ='" + bill.getBillNumber().ToString() + "',date ='" + bill.getBDate() + "', value ='" + bill.getValue().ToString() + "', paid = '" +bill.getPaid().ToString() + "' WHERE ID = " + id + ";";
            myCommand.Connection = myConnection;
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }
        
    }
}