using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.scripts
{
    public class otherSurgeryDao
    {
        public List<otherSurgery> getSurgeryByid(int id)
        {
            string connectionString = @"Data Source=cdb.c1lbyzt9l8fn.us-west-2.rds.amazonaws.com,1433;" + "Initial Catalog=cis;" + "User id=sonaaaa;" + "Password=mo7senzzzz;";
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            List<otherSurgery> myList = new List<otherSurgery>();
            SqlCommand myCommand = new SqlCommand();

            myCommand.CommandText = "Select * from otherSurgery where id = '" + id + "';";
            myCommand.Connection = myConnection;
            SqlDataReader reader = myCommand.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                    string surgery = Convert.ToString(reader[1]);
                    otherSurgery dis = new otherSurgery();
                    dis.setId(id);
                    dis.setSurgery(surgery);
                    myList.Add(dis);


                }
            }

            reader.Close();
            myConnection.Close();
            return myList;


        }
        public void insertSurgery(otherSurgery dis)
        {
            string connectionString = @"Data Source=cdb.c1lbyzt9l8fn.us-west-2.rds.amazonaws.com,1433;" + "Initial Catalog=cis;" + "User id=sonaaaa;" + "Password=mo7senzzzz;";
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandText = "insert into otherSurgery (id,surgery) Values ('" + dis.getId().ToString() + "','" + dis.getSurgery() + "')  ;  ";
            myCommand.Connection = myConnection;
            myCommand.ExecuteNonQuery();
            myConnection.Close();

        }
    }
}