using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.scripts
{
    interface AppointmentDAOinterface
    {
         void setAppointment(Appointment appoint);
         List<Appointment> searchByDay(string day);




    }
}
