using System.ComponentModel.Design;
using TedsGymFinalProject.Model;

namespace TedsGymFinalProject.model;

public class Program
{
    private static Members members;
    private static Member member;

    static void Main(string[] args)
    {
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

        static void Menu()
        {
            bool over = false;

            while (!over)
            {
                Console.WriteLine("For: To Login (1), To Create Membership (2), To Quit (Q)");
                Console.Write("Option:");
                String Option = Console.ReadLine();
                switch (Option)
                {
                    case "1":
                        LoginMenu();
                        break;
                    case "2":
                        SignUpMenu();
                        break;
                    case "q":
                        over = true;
                        Console.WriteLine("Thank you for your time!"); 
                        break;

                }
                static void LoginMenu()
                {

                }

                static void SignUpMenu()
                {

                }
            }
        }
    }
}