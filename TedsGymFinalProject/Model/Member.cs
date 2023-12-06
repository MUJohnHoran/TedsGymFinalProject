using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TedsGymFinalProject.Model;
 public class Member
{

    public string MemberFirstName { get; set; }
    public string MemberLastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public bool ActiveOrInactive { get; set; }

    public Member (string memberFirtName, string memberLastName, string phoneNumber, string address, bool activeOrInactive)
    {
        this.MemberFirstName = memberFirtName;
        this.MemberLastName = memberLastName;
        this.PhoneNumber = phoneNumber;
        this.Address = address;
        this.ActiveOrInactive = activeOrInactive;
    }
    
   

   




}
