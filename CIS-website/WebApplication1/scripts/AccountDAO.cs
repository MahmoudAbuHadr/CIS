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
            throw new NotImplementedException();
        }

        public int getIdByPhoneNumber(string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public void insertAccount(AccountCredentials acc)
        {
            string connectionString = @"Data Source= NABSTER\SQLEXPRESS; Initial Catalog=CIS; Integrated Security=SSPI";
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
            string connectionString = @"Data Source= NABSTER\SQLEXPRESS; Initial Catalog=CIS; Integrated Security=SSPI";
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandText = "UPDATE Accounts SET ID =" + acc.getID().ToString() + ",PNumber ='" + acc.getPhoneNumber() + "',Email ='" + acc.getEmail() + "', Password ='" + acc.getPassword() + "', FName = '" + acc.getFName() + "', LName = '" + acc.getLName() + "' WHERE ID = " + acc.getID() + ";";
            myCommand.Connection = myConnection;
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }
    }
}