using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TedsGymFinalProject.Model
{
    public class MemberAppointment
    {
        public Member member { get; set; }
        public Appointment appointment { get; set; }

        public MemberAppointment (Member c, Appointment a)
        {
            member = c;
            appointment = a;
        }
    }
}
