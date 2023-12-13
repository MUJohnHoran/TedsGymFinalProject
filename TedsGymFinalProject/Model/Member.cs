using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TedsGymFinalProject.Model;
public class Member//creates member class to create members
{
    public int ID { get; set; }  //creates variable for ID
    public string Password { get; set; } //creates variable for Password
    public string Username { get; set; } //creates variable for Username
    public static int IDGenerator; //creates variable for IDGenerator
    public string MemberFirstName { get; set; } //creates variable for MemberFirstName
    public string MemberLastName { get; set; } //creates variable for MemberLastName
    public string PhoneNumber { get; set; } //creates variable for PhoneNumber
    public bool ActiveOrInactive { get; set; } //creates variable for ActiveOrInactive
    public Membership membership { get; set; } //creates variable for membership that is a object in the Membership class with its own attributes

    public string MembershipPlan { get; set; } //creates variable for MembershipPlan





    public Member()//constructor to construct number
    {
        IDGenerator++;//increases this variable by 1 every time it is used
        ID = IDGenerator;//associates this increased variable to the ID
    }


}









