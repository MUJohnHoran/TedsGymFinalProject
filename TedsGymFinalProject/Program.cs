using System.ComponentModel.Design;
using System.Net;
using System.Numerics;
using System.Security.Cryptography;
using TedsGymFinalProject.Model;

internal class Program
{
    static void Main(string[] args)
    {
        



        Membership Premium = new Membership(3, "Premium", 100.00);
        Membership Plus = new Membership(2, "Plus", 75.00);
        Membership Basic = new Membership(1, "Basic", 50.00);

>>>>>>> Stashed changes
        
    }



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
                Console.Write("First Name: ");
                string memberFirstName = Console.ReadLine();
                Console.Write("Last Name: ");
                string memberLastName = Console.ReadLine();
                Console.Write("Username: ");
                string username = Console.ReadLine();
                Console.Write("Password: ");
                string password = Console.ReadLine();
                Console.Write("Phone Number: ");
                string phoneNumber = Console.ReadLine();


                var newMember = new Member
                {
                    MemberFirstName = memberFirstName,
                    MemberLastName = memberLastName,
                    Username = username,
                    Password = password,
                    PhoneNumber = phoneNumber,
                };

                Console.WriteLine("Choose a Membership Level:");
                Console.WriteLine($"Basic (1), Plus (2), Premium (3)");
            }

        }
>>>>>>> Stashed changes

    }
}