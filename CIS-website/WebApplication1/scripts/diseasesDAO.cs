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
            string connectionString =@"Data Source=cdb.c1lbyzt9l8fn.us-west-2.rds.amazonaws.com,1433;" + "Initial Catalog=cis;" + "User id=sonaaaa;" + "Password=mo7senzzzz;";
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandText = "insert into diseases (id,anemia,asthma,epilipsy,depression,diabetes,diarrhea,heartAttack,hepatitis,rheumatism,scarletFever,std) Values ('" + disease.getId().ToString() + "','" + disease.getAnemia() + "','" + disease.getAsthma() + "','" + disease.getEpilipsy() + "','" + disease.getDepression() + "','" + disease.getDiabetes() + "','" + disease.getDiarrhea() + "','" + disease.getHeartAttack() + "','" + disease.getHepatitis() + "','" + disease.getRheumatism() + "','" + disease.getScarletFever() + "','" + disease.getSTD() + "')  ;  ";
            myCommand.Connection = myConnection;
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }

        public diseases getDisease(int id)
        {
            string connectionString =@"Data Source=cdb.c1lbyzt9l8fn.us-west-2.rds.amazonaws.com,1433;" + "Initial Catalog=cis;" + "User id=sonaaaa;" + "Password=mo7senzzzz;";
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            diseases dis = new diseases();
            SqlCommand myCommand = new SqlCommand();

            myCommand.CommandText = "Select * from diseases where id = '" + id + "';";
            myCommand.Connection = myConnection;
            SqlDataReader reader = myCommand.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dis.setId(reader.GetInt32(0));
                    dis.setAnemia(Convert.ToBoolean(reader[1]));
                    dis.setAsthma(Convert.ToBoolean(reader[2]));
                    dis.setEpilipsy(Convert.ToBoolean(reader[3]));
                    dis.setDepression(Convert.ToBoolean(reader[4]));
                    dis.setDiabetes(Convert.ToBoolean(reader[5]));
                    dis.setDiarrhea(Convert.ToBoolean(reader[6]));
                    dis.setHeartAttack(Convert.ToBoolean(reader[7]));
                    dis.setHepatitis(Convert.ToBoolean(reader[8]));
                    dis.setRheumatism(Convert.ToBoolean(reader[9]));
                    dis.SetScarletFever(Convert.ToBoolean(reader[10]));
                    dis.setStd(Convert.ToBoolean(reader[11]));

                }
                

            }

            reader.Close();
            myConnection.Close();   
            return dis;

        }

        public void updateDiseases(diseases disease)
        {
            string connectionString =@"Data Source=cdb.c1lbyzt9l8fn.us-west-2.rds.amazonaws.com,1433;" + "Initial Catalog=cis;" + "User id=sonaaaa;" + "Password=mo7senzzzz;";
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandText = "UPDATE diseases SET id =" + disease.getId().ToString() + ",anemia ='" + disease.getAnemia() + "',asthma ='" + disease.getAsthma() + "', epilipsy ='" + disease.getEpilipsy() + "', depression = '" + disease.getDepression() + "',diabetes = '"+ disease.getDiabetes() + "', diarrhea = '" + disease.getDiarrhea() + "', heartAttack = '" + disease.getHeartAttack() + "',hepatitis = '" + disease.getHepatitis() + "', rheumatism = '" + disease.getRheumatism() + "', scarletFever = '" + disease.getScarletFever() + "',std = '" + disease.getSTD() + "' WHERE id = " + disease.getId().ToString() + ";";
            myCommand.Connection = myConnection;
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }
    }
}