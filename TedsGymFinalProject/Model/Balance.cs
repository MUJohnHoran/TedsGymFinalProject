using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Balance
{ 
	public Balance()
	{
	}	
		
	public double TotalBalance {  get; set; }
		
	public double LateFees {  get; set; }

	public double Rewards { get; set; }
		
	public double Vending {  get; set; }


	public Balance (double totalBalance, double lateFees, double rewards, double vending)
	{
		this.TotalBalance = totalBalance;
		this.LateFees = lateFees;
		this.Rewards = rewards;
		this.Vending = vending;
	}

		


	
}
