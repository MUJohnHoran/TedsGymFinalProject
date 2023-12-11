<<<<<<< Updated upstream
﻿namespace TedsGymFinalProject;
=======
﻿using System.ComponentModel;
using System.ComponentModel.Design;
using System.Net;
using System.Numerics;
using System.Security.Cryptography;
using TedsGymFinalProject.Model;
>>>>>>> Stashed changes

internal class Program
{
    static void Main(string[] args)
    {
<<<<<<< Updated upstream
=======
        Console.WriteLine("Loading...");
        Begin();
        Menu();

    }

    static void Begin()
    {
        var a1 = new Member()
        {
            Password = "4321",
            Username = "Ted4321",
            MemberFirstName = "Ted",
            MemberLastName = "Lawder",
            PhoneNumber = "642-245-8989",
            ActiveOrInactive = true
        };


        var a2 = new Member()
        {
            Password = "6789",
            Username = "Tom6789",
            MemberFirstName = "Tom",
            MemberLastName = "Wagner",
            PhoneNumber = "708-770-6657",
            ActiveOrInactive = true
        };


        Membership Premium = new Membership(3, "Premium", 100.00);
        Membership Plus = new Membership(2, "Plus", 75.00);
        Membership Basic = new Membership(1, "Basic", 50.00);

>>>>>>> Stashed changes
        





<<<<<<< Updated upstream
=======
                Console.WriteLine("Choose a Membership Level:");
                Console.WriteLine($"Basic (1), Plus (2), Premium (3)");

                static void MembershipPlan()
                {
                    int selectedPlan = 0

                    while ( selectedPlan < 1 || selectedPlan > 3) 
                    
                    

                }


            }
>>>>>>> Stashed changes

    }
}