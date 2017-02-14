using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WebApplication1.scripts
{
    public class personalDataDAO : personalDataDAOinterface
    {
        public void insertData(personalData data)
        {
            string connectionString = @"Data Source= NABSTER\SQLEXPRESS; Initial Catalog=CIS; Integrated Security=SSPI";
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandText = "insert into personalData (firstName,lastName,mobile,gender,birthday,height,weight) Values ('" + + "','" + acc.getEmail() + "','" + acc.getPassword() + "','" + acc.getFName() + "','" + acc.getLName() + "')  ;  ";
            myCommand.Connection = myConnection;
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }
    }

        public void updateData(personalData data)
        {
            throw new NotImplementedException();
        }
    }
}