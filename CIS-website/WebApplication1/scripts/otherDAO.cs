using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.scripts
{
    public class otherDAO : otherDAOinterface
    {
        public List<string> getDisByID(int id)
        {
            string connectionString = @"Data Source=cdb.c1lbyzt9l8fn.us-west-2.rds.amazonaws.com,1433;" + "Initial Catalog=cis;" + "User id=sonaaaa;" + "Password=mo7senzzzz;";
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            List<string> myList = new List<string>();
            SqlCommand myCommand = new SqlCommand();

            myCommand.CommandText = "Select * from otherDisease where id = '" + id + "';";
            myCommand.Connection = myConnection;
            SqlDataReader reader = myCommand.ExecuteReader();
            
            
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    other dis = new other();
                    string disease = Convert.ToString(reader[1]);   
                    dis.setDis_id(id);
                    dis.setOther_dis(disease);
                    myList.Add(disease);
                }
            }
            reader.Close();
            myConnection.Close();
            return myList;
        }

        public List<string> getDrugByID(int id)
        {

            string connectionString = @"Data Source=cdb.c1lbyzt9l8fn.us-west-2.rds.amazonaws.com,1433;" + "Initial Catalog=cis;" + "User id=sonaaaa;" + "Password=mo7senzzzz;";
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            List<string> myList = new List<string>();
            SqlCommand myCommand = new SqlCommand();

            myCommand.CommandText = "Select * from otherDrugs where id = '" + id + "';";
            myCommand.Connection = myConnection;
            SqlDataReader reader = myCommand.ExecuteReader();

            other drug = new other();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string drugs = Convert.ToString(reader[1]);
                    drug.setDrug_id(id); drug.setOther_drug(drugs);
                    myList.Add(drugs);
                }
            }
            reader.Close();
            myConnection.Close();
            return myList;
        }

        public List<string> getSurgByID(int id)
        {

            string connectionString = @"Data Source=cdb.c1lbyzt9l8fn.us-west-2.rds.amazonaws.com,1433;" + "Initial Catalog=cis;" + "User id=sonaaaa;" + "Password=mo7senzzzz;";
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            List<string> myList = new List<string>();
            SqlCommand myCommand = new SqlCommand();

            myCommand.CommandText = "Select * from otherSurgery where id = '" + id + "';";
            myCommand.Connection = myConnection;
            SqlDataReader reader = myCommand.ExecuteReader();
            other surg = new other();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string surgery = Convert.ToString(reader[1]);
                    surg.setSurg_id(id); surg.setOther_surg(surgery);
                    myList.Add(Convert.ToString(surgery));
                }
            }
            reader.Close();
            myConnection.Close();
            return myList;
        }

        public void insertOther_dis(other dis)
        {
            string connectionString = @"Data Source=cdb.c1lbyzt9l8fn.us-west-2.rds.amazonaws.com,1433;" + "Initial Catalog=cis;" + "User id=sonaaaa;" + "Password=mo7senzzzz;";
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandText = "insert into otherDisease (id,disease) Values ('" + dis.getDis_id().ToString() + "','" + dis.getOther_dis() + "')  ;  ";
            myCommand.Connection = myConnection;
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }

        public void insertOther_drug(other drug)
        {
            string connectionString = @"Data Source=cdb.c1lbyzt9l8fn.us-west-2.rds.amazonaws.com,1433;" + "Initial Catalog=cis;" + "User id=sonaaaa;" + "Password=mo7senzzzz;";
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandText = "insert into otherDrugs (id,drugs) Values ('" + drug.getDrug_id().ToString() + "','" + drug.getOther_drug() + "')  ;  ";
            myCommand.Connection = myConnection;
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }

        public void insertOther_surg(other surg)
        {
            string connectionString = @"Data Source=cdb.c1lbyzt9l8fn.us-west-2.rds.amazonaws.com,1433;" + "Initial Catalog=cis;" + "User id=sonaaaa;" + "Password=mo7senzzzz;";
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandText = "insert into otherSurgery (id,surgery) Values ('" + surg.getSurg_id().ToString() + "','" + surg.getOther_surg() + "')  ;  ";
            myCommand.Connection = myConnection;
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }
    }
}