using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Balance
{

    public Balance()  // Empty constructor
    {
    }

    public double TotalBalance { get; set; }  // Creating objects with getter and setter

    public double LateFees { get; set; }

    public double Rewards { get; set; }

    public double Vending { get; set; }


    public Balance(double totalBalance, double lateFees, double rewards, double vending)  // Constructor for Balance
    {
        this.TotalBalance = totalBalance;  // Using “this” to reference the objects
        this.LateFees = lateFees;
        this.Rewards = rewards;
        this.Vending = vending;
    }

}
