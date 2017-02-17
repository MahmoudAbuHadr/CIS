using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WebApplication1.scripts
{
    public class personalDataDAO : personalDataDAOinterface
    {
        public personalData getDataByID(int id)
        {
            personalData data = new personalData();
            string connectionString = @"Data Source=cdb.c1lbyzt9l8fn.us-west-2.rds.amazonaws.com,1433;" + "Initial Catalog=cis;" + "User id=sonaaaa;" + "Password=mo7senzzzz;";
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand();

            myCommand.CommandText = "Select * from personalData where id = '" + id + "';";
            myCommand.Connection = myConnection;
            SqlDataReader reader = myCommand.ExecuteReader();
            data.setId(0);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    data.setId(reader.GetInt32(reader.GetOrdinal("id")));
                    data.setFname(Convert.ToString(reader[1]));
                    data.setLname(Convert.ToString(reader[2]));
                    data.setMobile(Convert.ToString(reader[3]));
                    data.setGender(Convert.ToString(reader[4]));
                    data.setBirthday(Convert.ToString(reader[5]));
                    data.setHeight(float.Parse(Convert.ToString(reader[6])));
                    data.setWeight(float.Parse(Convert.ToString(reader[7])));
                }

            }

            reader.Close();
            myConnection.Close();

            return data;
        }

        public void insertData(personalData data)
        {
            string connectionString =@"Data Source=cdb.c1lbyzt9l8fn.us-west-2.rds.amazonaws.com,1433;" + "Initial Catalog=cis;" + "User id=sonaaaa;" + "Password=mo7senzzzz;";
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandText = "insert into personalData (id,firstName,lastName,mobile,gender,birthday,height,weight) Values ('"+data.getId().ToString()+"','" + data.getFname() + "','" + data.getLname() + "','" + data.getMobile() + "','" + data.getGender() + "','" + data.getBirthday() + "','" + data.getHeight().ToString() + "','" + data.getWeight().ToString() + "')  ;  ";
            myCommand.Connection = myConnection;
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }

        public void updateData(personalData data)
        {
            string connectionString =@"Data Source=cdb.c1lbyzt9l8fn.us-west-2.rds.amazonaws.com,1433;" + "Initial Catalog=cis;" + "User id=sonaaaa;" + "Password=mo7senzzzz;";
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandText = "UPDATE personalData SET id ='" + data.getId() + "',firstName ='" + data.getFname() + "',lastName ='" + data.getLname() + "', mobile ='" + data.getMobile() + "', gender = '" + data.getGender() + "', birthday = '" + data.getBirthday() + "', height = '" + data.getHeight().ToString() + "', weight = '" + data.getWeight().ToString() + "' WHERE id = " + data.getId() + ";";
            myCommand.Connection = myConnection;
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }
    }
}