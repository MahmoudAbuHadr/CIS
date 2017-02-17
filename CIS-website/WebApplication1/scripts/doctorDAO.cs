using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.scripts
{
    public class doctorDAO : doctorDAOinterface
    {
        public doctor getDataByID(int id)
        {
            doctor doc = new doctor();
            string connectionString = @"Data Source=cdb.c1lbyzt9l8fn.us-west-2.rds.amazonaws.com,1433;" + "Initial Catalog=cis;" + "User id=sonaaaa;" + "Password=mo7senzzzz;";
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand();

            myCommand.CommandText = "Select * from doctorAccounts where id = '" + id + "';";
            myCommand.Connection = myConnection;
            SqlDataReader reader = myCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    doc.setID(reader.GetInt32(reader.GetOrdinal("id")));
                    doc.setPNumber(Convert.ToString(reader[1]));
                    doc.setEmail(Convert.ToString(reader[2]));
                    doc.setPassword(Convert.ToString(reader[3]));
                    doc.setFname(Convert.ToString(reader[4]));
                    doc.setLname(Convert.ToString(reader[5]));
                    doc.setFees(int.Parse(Convert.ToString(reader[6])));                    
                }
            }
            reader.Close();
            myConnection.Close();
            return doc;
        }

        public void insertData(doctor doc)
        {
            string connectionString = @"Data Source=cdb.c1lbyzt9l8fn.us-west-2.rds.amazonaws.com,1433;" + "Initial Catalog=cis;" + "User id=sonaaaa;" + "Password=mo7senzzzz;";
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandText = "insert into doctorAccounts (PNumber,Email,Password,FName,LName,fees) Values ('" + doc.getPNumber() + "','" + doc.getEmail() + "','" + doc.getPassword() + "','" + doc.getFname() + "','" + doc.getLname() + "','" + doc.getFees().ToString() + "')  ;  ";
            myCommand.Connection = myConnection;
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }

        public void updateData(doctor doc)
        {
            string connectionString = @"Data Source=cdb.c1lbyzt9l8fn.us-west-2.rds.amazonaws.com,1433;" + "Initial Catalog=cis;" + "User id=sonaaaa;" + "Password=mo7senzzzz;";
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandText = "UPDATE doctorAccounts SET PNumber ='" + doc.getPNumber() + "',Email ='" + doc.getEmail() + "', Password ='" + doc.getPassword() + "', FName = '" + doc.getFname() + "', LName = '" + doc.getLname() + "', fees = '" + doc.getFees().ToString() + "'  WHERE id = " + doc.getID() + ";";
            myCommand.Connection = myConnection;
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }
        public doctor getAccountByPhone(string phone) {
            doctor doc = new doctor();
            string connectionString = @"Data Source=cdb.c1lbyzt9l8fn.us-west-2.rds.amazonaws.com,1433;" + "Initial Catalog=cis;" + "User id=sonaaaa;" + "Password=mo7senzzzz;";
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand();

            myCommand.CommandText = "Select * from doctorAccounts where PNumber = '" + phone + "';";
            myCommand.Connection = myConnection;
            SqlDataReader reader = myCommand.ExecuteReader();
            doc.setID (-1);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    doc.setID(reader.GetInt32(reader.GetOrdinal("id")));
                    doc.setPNumber(Convert.ToString(reader[1]));
                    doc.setEmail(Convert.ToString(reader[2]));
                    doc.setPassword(Convert.ToString(reader[3]));
                    doc.setFname(Convert.ToString(reader[4]));
                    doc.setLname(Convert.ToString(reader[5]));
                    doc.setFees(int.Parse(Convert.ToString(reader[6])));
                }
            }
            reader.Close();
            myConnection.Close();
            return doc;
        }
    }
}