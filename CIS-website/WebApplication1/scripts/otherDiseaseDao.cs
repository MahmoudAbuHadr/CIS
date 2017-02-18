using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.scripts
{
    public class otherDiseaseDao
    {
        public List<otherDisease> getDiseaseById(int id)
        {
            string connectionString = @"Data Source=cdb.c1lbyzt9l8fn.us-west-2.rds.amazonaws.com,1433;" + "Initial Catalog=cis;" + "User id=sonaaaa;" + "Password=mo7senzzzz;";
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            List<otherDisease> myList = new List<otherDisease>();
            SqlCommand myCommand = new SqlCommand();

            myCommand.CommandText = "Select * from otherDisease where id = '" + id + "';";
            myCommand.Connection = myConnection;
            SqlDataReader reader = myCommand.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                     id = reader.GetInt32(0);
                    string disease = Convert.ToString(reader[1]);
                    otherDisease dis = new otherDisease();
                    dis.setId(id);
                    dis.setDisease(disease);
                    myList.Add(dis);


                }
            }

            reader.Close();
            myConnection.Close();
            return myList;


        }
        public void insertDisease(otherDisease dis) {
            string connectionString = @"Data Source=cdb.c1lbyzt9l8fn.us-west-2.rds.amazonaws.com,1433;" + "Initial Catalog=cis;" + "User id=sonaaaa;" + "Password=mo7senzzzz;";
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandText = "insert into otherDisease (id,disease) Values ('" + dis.getId().ToString() + "','" + dis.getDisease() + "')  ;  ";
            myCommand.Connection = myConnection;
            myCommand.ExecuteNonQuery();
            myConnection.Close();

        }
    }
}