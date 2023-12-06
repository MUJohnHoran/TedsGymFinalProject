using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TedsGymFinalProject.Model;

public class Membership
{
    public int MembershipLvl { get; set; }

    public bool Renewal { get; set; }

    public bool IsActive { get; set; }

    public double Cost { get; set; }

    
    public Membership (int membershipLvl, bool isActive, bool renewal, double cost)
    {
        this.MembershipLvl = membershipLvl;
        this.IsActive = isActive;
        this.Renewal = renewal;
        this.Cost = cost;
    }





}
