using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace TedsGymFinalProject.Model;

public class Members//Creates class for members
{

    public List<Member> members { get; set; }//Creates list that will hold members

    public Members()//Constructor to create a new member and add them to the list
    {
        members = new List<Member>();//connects members created to list
    }
    public Member Authenticate(string username, string password)//Constructor used for login
    {
        var c = members.Where(o => (o.Username == username) && (o.Password == password));//validates whether there is a username associated with input username and a password associated with the password that relates to the username

        if (c.Count() > 0)//checks if c the variable for count of matches above is above 0
        {
            return c.First();//if it is above 0 return the first element of the sequence
        }
        else
        {
            return null;//otherwise it returns null
        }
    }


}