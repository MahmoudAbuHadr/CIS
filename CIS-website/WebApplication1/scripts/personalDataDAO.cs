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
            string connectionString = @"Data Source=cdb.c1lbyzt9l8fn.us-west-2.rds.amazonaws.com,1433;" + "Initial Catalog=cis;" + "User id=sonaaaa;" + "Password=mo7senzzzz;";
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandText = "insert into personalData (id,firstName,lastName,mobile,gender,birthday,height,weight) Values ('" + data.getId().ToString() + "','" + data.getFname() + "','" + data.getLname() + "','" + data.getMobile() + "','" + data.getGender() + "','" + data.getBirthday() + "','" + data.getHeight() + "','" + data.getWeight() + "')  ;  ";
            myCommand.Connection = myConnection;
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }

        public void updateData(personalData data)
        {
            string connectionString = @"Data Source=cdb.c1lbyzt9l8fn.us-west-2.rds.amazonaws.com,1433;" + "Initial Catalog=cis;" + "User id=sonaaaa;" + "Password=mo7senzzzz;";
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandText = "UPDATE personalData SET id =" + data.getId().ToString() + ",firstName ='" + data.getFname() + "',lastName ='" + data.getLname() + "', mobile ='" + data.getMobile() + "', gender = '" + data.getGender() + "', birthday = '" + data.getBirthday() + "', height = '" + data.getHeight().ToString() + "', weight = '" + data.getWeight().ToString() + "' WHERE ID = " + data.getId() + ";";
            myCommand.Connection = myConnection;
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }
    }
}