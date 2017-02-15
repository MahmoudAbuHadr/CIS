using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.scripts
{
    public class AppointmentDAO : AppointmentDAOinterface
    {
        public List<Appointment> searchByDay(string day)
        {
            string connectionString =@"Data Source=NABSTER\SQLEXPRESS; Initial Catalog=CIS; Integrated Security=SSPI";
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            List<Appointment> myList = new List<Appointment>();
            SqlCommand myCommand = new SqlCommand();

            myCommand.CommandText = "Select * from appointment where appointmentDay = '" + day + "';";
            myCommand.Connection = myConnection;
            SqlDataReader reader = myCommand.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string Day = Convert.ToString(reader[1]);
                    string time = (Convert.ToString(reader[2]));
                    Appointment app = new Appointment();
                    app.setId(id); app.setDay(Day); app.setTime(time);
                    myList.Add(app);


                }
            }
            
            reader.Close();
            myConnection.Close();
            return myList;
        }

        public void setAppointment(Appointment appoint)
        {
            string connectionString =@"Data Source=NABSTER\SQLEXPRESS; Initial Catalog=CIS; Integrated Security=SSPI";
            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandText = "insert into appointment (pID,appointmentDay,appointmentTime) Values ('" + appoint.getId() + "','" + appoint.getDay() + "','" + appoint.getTime() + "')  ;  ";
            myCommand.Connection = myConnection;
            myCommand.ExecuteNonQuery();
            myConnection.Close();

        }
    }
}