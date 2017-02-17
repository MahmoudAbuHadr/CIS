using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.scripts
{
    public class familyHistoryDAO : familyHistoryDAOinteraface
    {
        public List<familyHistory> getHistoryById(int id)
        {
            string connectionString = @"Data Source=cdb.c1lbyzt9l8fn.us-west-2.rds.amazonaws.com,1433;" + "Initial Catalog=cis;" + "User id=sonaaaa;" + "Password=mo7senzzzz;";
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            List<familyHistory> myList = new List<familyHistory>();
            SqlCommand myCommand = new SqlCommand();

            myCommand.CommandText = "Select * from familyHistory where id = '" + id + "';";
            myCommand.Connection = myConnection;
            SqlDataReader reader = myCommand.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                    string relative = Convert.ToString(reader[1]);
                    string disease = (Convert.ToString(reader[2]));
                    familyHistory hist = new familyHistory();
                    hist.setID(id); hist.setRelative(relative); hist.setDisease(disease);
                    myList.Add(hist);
                }
            }
            reader.Close();
            myConnection.Close();
            return myList;
        }

        public void insertHistory(familyHistory history)
        {
            string connectionString = @"Data Source=cdb.c1lbyzt9l8fn.us-west-2.rds.amazonaws.com,1433;" + "Initial Catalog=cis;" + "User id=sonaaaa;" + "Password=mo7senzzzz;";
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandText = "insert into familyHistory (relative,disease) Values ('" + history.getRelative() + "','" + history.getDisease() + "')  ;  ";
            myCommand.Connection = myConnection;
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }

        public void updateHistory(familyHistory history)
        {
            string connectionString = @"Data Source=cdb.c1lbyzt9l8fn.us-west-2.rds.amazonaws.com,1433;" + "Initial Catalog=cis;" + "User id=sonaaaa;" + "Password=mo7senzzzz;";
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandText = "UPDATE familyHistory SET relative ='" + history.getRelative() + "',disease ='" + history.getDisease() +"'  WHERE id = " + history.getID() + ";";
            myCommand.Connection = myConnection;
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }
    }
}