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
            myCommand.CommandText = "insert into personalData (id,firstName,lastName,mobile,gender,birthday,height,weight) Values ('" + data.getId().ToString() + "','" + data.getFname() + "','" + data.getLname() + "','" + data.getMobile() + "','" + data.getGender() + "','" + data.getBirthday() + "','" + data.getHeight() + "','" + data.getWeight() + "')  ;  ";
            myCommand.Connection = myConnection;
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }

        public void updateData(personalData data)
        {
            string connectionString = @"Data Source= NABSTER\SQLEXPRESS; Initial Catalog=CIS; Integrated Security=SSPI";
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