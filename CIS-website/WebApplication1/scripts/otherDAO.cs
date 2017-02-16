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
            string connectionString = @"Data Source=NABSTER\SQLEXPRESS; Initial Catalog=CIS; Integrated Security=SSPI";
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
                    int ID = reader.GetInt32(0);
                    string disease = Convert.ToString(reader[1]);
                    other dis = new other();
                    dis.setDis_id(ID); dis.setOther_dis(disease);
                    myList.Add(Convert.ToString(dis));
                }
            }
            reader.Close();
            myConnection.Close();
            return myList;
        }

        public List<string> getDrugByID(int id)
        {

            string connectionString = @"Data Source=NABSTER\SQLEXPRESS; Initial Catalog=CIS; Integrated Security=SSPI";
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            List<string> myList = new List<string>();
            SqlCommand myCommand = new SqlCommand();

            myCommand.CommandText = "Select * from otherDrugs where id = '" + id + "';";
            myCommand.Connection = myConnection;
            SqlDataReader reader = myCommand.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int ID = reader.GetInt32(0);
                    string drugs = Convert.ToString(reader[1]);
                    other drug = new other();
                    drug.setDrug_id(ID); drug.setOther_drug(drugs);
                    myList.Add(Convert.ToString(drug));
                }
            }
            reader.Close();
            myConnection.Close();
            return myList;
        }

        public List<string> getSurgByID(int id)
        {

            string connectionString = @"Data Source=NABSTER\SQLEXPRESS; Initial Catalog=CIS; Integrated Security=SSPI";
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            List<string> myList = new List<string>();
            SqlCommand myCommand = new SqlCommand();

            myCommand.CommandText = "Select * from otherSurgery where id = '" + id + "';";
            myCommand.Connection = myConnection;
            SqlDataReader reader = myCommand.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int ID = reader.GetInt32(0);
                    string surgery = Convert.ToString(reader[1]);
                    other surg = new other();
                    surg.setSurg_id(ID); surg.setOther_surg(surgery);
                    myList.Add(Convert.ToString(surg));
                }
            }
            reader.Close();
            myConnection.Close();
            return myList;
        }

        public void insertOther_dis(other dis)
        {
            string connectionString = @"Data Source=NABSTER\SQLEXPRESS; Initial Catalog=CIS; Integrated Security=SSPI";
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
            string connectionString = @"Data Source=NABSTER\SQLEXPRESS; Initial Catalog=CIS; Integrated Security=SSPI";
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
            string connectionString = @"Data Source=NABSTER\SQLEXPRESS; Initial Catalog=CIS; Integrated Security=SSPI";
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