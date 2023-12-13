using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TedsGymFinalProject.Model;

public class Membership//Creates membership class
{

    public List<Membership> membership { get; set; }//creates list to enter membership in

    public Membership()//membership constructor to create new membership
    {
        membership = new List<Membership>();//links membership created to list
    }
    public int MembershipLvl { get; set; }//creates membership level variable

    public string MembershipName { get; set; }//creates membership name variable
    public double Cost { get; set; }//creates cost variable


    public Membership(int membershipLvl, string membershipName, double cost)//creates constructor that you can input membershiplvl, membershipnamem and cost into
    {
        this.MembershipLvl = membershipLvl;//connects input to variable of membership
        this.MembershipName = membershipName; //connects input to variable of membership

        this.Cost = cost; //connects input to variable of membership

    }


}
