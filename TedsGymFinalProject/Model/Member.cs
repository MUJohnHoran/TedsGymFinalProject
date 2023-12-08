using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TedsGymFinalProject.Model;
 public class Member
{
    public int ID { get; set; }
    public string Password { get; set; }
    public string Username {get; set;}
    public static int IDGenerator;
    public string MemberFirstName { get; set; }
    public string MemberLastName { get; set; }
    public string PhoneNumber { get; set; }
    public bool ActiveOrInactive { get; set; }
    public Membership Membership { get; set; }

    

    public Member()
    {
       IDGenerator ++;
       ID = IDGenerator;
    }
}
    
   
    
   




}
