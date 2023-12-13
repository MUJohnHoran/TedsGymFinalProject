using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TedsGymFinalProject.Model;

public class MemberAppointment//makes class for MemberAppointment (used to attatch member and appointment)
{

    public Member member { get; set; } //sets variable of member within the class
    public Appointment appointment { get; set; } //sets variable of appointment within the class

    public MemberAppointment(Member c, Appointment a)//makes constructors to attach member and appointment
    {
        member = c;//attaches input c to member 
        appointment = a;//attatches input a to appointment
    }
}
