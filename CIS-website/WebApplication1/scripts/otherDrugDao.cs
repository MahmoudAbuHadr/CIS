using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.scripts
{
    public class otherDrugDao
    {
        public List<otherDrugs> getDrugsById(int id)
        {
            string connectionString = @"Data Source=cdb.c1lbyzt9l8fn.us-west-2.rds.amazonaws.com,1433;" + "Initial Catalog=cis;" + "User id=sonaaaa;" + "Password=mo7senzzzz;";
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            List<otherDrugs> myList = new List<otherDrugs>();
            SqlCommand myCommand = new SqlCommand();

            myCommand.CommandText = "Select * from otherDrugs where id = '" + id + "';";
            myCommand.Connection = myConnection;
            SqlDataReader reader = myCommand.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                    string drug = Convert.ToString(reader[1]);
                    otherDrugs Drug = new otherDrugs();
                    Drug.setId(id);
                    Drug.setDrug(drug);
                    myList.Add(Drug);


                }
            }

            reader.Close();
            myConnection.Close();
            return myList;


        }
        public void insertDrug(otherDrugs dis)
        {
            string connectionString = @"Data Source=cdb.c1lbyzt9l8fn.us-west-2.rds.amazonaws.com,1433;" + "Initial Catalog=cis;" + "User id=sonaaaa;" + "Password=mo7senzzzz;";
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandText = "insert into otherDrugs (id,drugs) Values ('" + dis.getId().ToString() + "','" + dis.getDrug() + "')  ;  ";
            myCommand.Connection = myConnection;
            myCommand.ExecuteNonQuery();
            myConnection.Close();

        }
    }
}