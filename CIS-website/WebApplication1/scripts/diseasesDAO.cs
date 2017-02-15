using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.scripts
{
    public class diseasesDAO : diseasesDAOinterface
    {
        public void insertDiseases(diseases disease)
        {
            string connectionString = @"Data Source=cdb.c1lbyzt9l8fn.us-west-2.rds.amazonaws.com,1433;" + "Initial Catalog=cis;" + "User id=sonaaaa;" + "Password=mo7senzzzz;";
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandText = "insert into diseases (id,hepatitis,rheumatism,std,heartAttack,depression) Values ('" + disease.getId().ToString() + "','" + disease.getHepatitis() + "','" + disease.getRheumatism() + "','" + disease.getSTD() + "','" + disease.getHeartAttack() + "','" + disease.getDepression() + "')  ;  ";
            myCommand.Connection = myConnection;
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }

        public diseases getDisease(int id)
        {
            string connectionString = @"Data Source=cdb.c1lbyzt9l8fn.us-west-2.rds.amazonaws.com,1433;" + "Initial Catalog=cis;" + "User id=sonaaaa;" + "Password=mo7senzzzz;";
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            diseases dis = new diseases();
            SqlCommand myCommand = new SqlCommand();

            myCommand.CommandText = "Select * from diseases where id = '" + id + "';";
            myCommand.Connection = myConnection;
            SqlDataReader reader = myCommand.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                dis.setId (reader.GetInt32(0)); 
                dis.setHepatitis( Convert.ToBoolean(reader[1]));
                dis.setRheumatism(Convert.ToBoolean(reader[2]));
                dis.setStd( Convert.ToBoolean(reader[3]));
                dis.setHeartAttack( Convert.ToBoolean(reader[4]));
                dis.setDepression( Convert.ToBoolean(reader[5]));
                

            }

            reader.Close();
            myConnection.Close();   
            return dis;

        }

        public void updateDiseases(diseases disease)
        {
            string connectionString = @"Data Source=cdb.c1lbyzt9l8fn.us-west-2.rds.amazonaws.com,1433;" + "Initial Catalog=cis;" + "User id=sonaaaa;" + "Password=mo7senzzzz;";
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandText = "UPDATE diseases SET ID =" + disease.getId().ToString() + ",hepatitis ='" + disease.getHepatitis() + "',rheumatism ='" + disease.getRheumatism() + "', std ='" + disease.getSTD() + "', heartAttack = '" + disease.getHeartAttack() + "', depression = '" + disease.getDepression() + "' WHERE id = " + disease.getId().ToString() + ";";
            myCommand.Connection = myConnection;
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }
    }
}