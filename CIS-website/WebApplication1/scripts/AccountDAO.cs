using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.scripts
{
    public class AccountDAO : AccountDAOinterface
    {
        public AccountCredentials getAccountById(int id)
        {
            AccountCredentials acc = new AccountCredentials();
            string connectionString =@"Data Source=cdb.c1lbyzt9l8fn.us-west-2.rds.amazonaws.com,1433;" + "Initial Catalog=cis;" + "User id=sonaaaa;" + "Password=mo7senzzzz;";
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand();

            myCommand.CommandText = "Select * from Accounts where id = '" + id + "';";
            myCommand.Connection = myConnection;
            SqlDataReader reader = myCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    acc.setID(reader.GetInt32(reader.GetOrdinal("id")));
                    acc.setPhoneNumber(Convert.ToString(reader[1]));
                    acc.setEmail(Convert.ToString(reader[2]));
                    acc.setPassword(Convert.ToString(reader[3]));
                    acc.setFName(Convert.ToString(reader[4]));
                    acc.setLName(Convert.ToString(reader[5]));
                }

            }

            reader.Close();
            myConnection.Close();

            return acc;
        }

        public int getIdByPhoneNumber(string phoneNumber)
        {
            int id=-1; 
            string connectionString =@"Data Source=cdb.c1lbyzt9l8fn.us-west-2.rds.amazonaws.com,1433;" + "Initial Catalog=cis;" + "User id=sonaaaa;" + "Password=mo7senzzzz;";
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand();

            myCommand.CommandText = "Select ID from Accounts where PNumber = '" + phoneNumber + "';";
            myCommand.Connection = myConnection;
            SqlDataReader reader = myCommand.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                id = reader.GetInt32(0);
            }
            
            reader.Close();
            myConnection.Close();
           
            return id; // if id returned is -1 then this phonenumber isn't regestered 
        }

        public void insertAccount(AccountCredentials acc)
        {
            string connectionString =@"Data Source=cdb.c1lbyzt9l8fn.us-west-2.rds.amazonaws.com,1433;" + "Initial Catalog=cis;" + "User id=sonaaaa;" + "Password=mo7senzzzz;";
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandText = "insert into Accounts (Pnumber,Email,Password,Fname,Lname) Values ('" + acc.getPhoneNumber() + "','" + acc.getEmail() + "','" + acc.getPassword() + "','" + acc.getFName() + "','" + acc.getLName() + "')  ;  ";
            myCommand.Connection = myConnection;
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }

        public void updateAccount(AccountCredentials acc)
        {
            string connectionString =@"Data Source=cdb.c1lbyzt9l8fn.us-west-2.rds.amazonaws.com,1433;" + "Initial Catalog=cis;" + "User id=sonaaaa;" + "Password=mo7senzzzz;";
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandText = "UPDATE Accounts SET id =" + acc.getID().ToString() + ",PNumber ='" + acc.getPhoneNumber() + "',Email ='" + acc.getEmail() + "', Password ='" + acc.getPassword() + "', FName = '" + acc.getFName() + "', LName = '" + acc.getLName() + "' WHERE id = " + acc.getID() + ";";
            myCommand.Connection = myConnection;
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }
    }
}