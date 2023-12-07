using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TedsGymFinalProject.Model;

public class Membership
{

    public int MembershipLvl { get; set; }

    public string MembershipName { get; set; }
    public double Cost { get; set; }

    
    public Membership (int membershipLvl, string membershipName, double cost)
    {
        this.MembershipLvl = membershipLvl;
        this.MembershipName = membershipName;
        this.Cost = cost;
    }


}
