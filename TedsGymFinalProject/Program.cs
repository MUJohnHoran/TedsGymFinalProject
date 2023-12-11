using System.ComponentModel.Design;
using System.Net;
using System.Numerics;
using System.Security.Cryptography;
using TedsGymFinalProject.Model;

namespace TedsGymFinalProject.Model;

public class Program
{
    private static Members members;
    private static Member member;
    private static Member authenticatedMember;

    static void Main(string[] args)
    {
        Console.WriteLine("Loading...");
        Begin();
        Menu();

    }

    static void Begin()
    {
        var a1 = new Member
        {
            Password = "4321",
            Username = "Ted4321",
            MemberFirstName = "Ted",
            MemberLastName = "Lawder",
            PhoneNumber = "642-245-8989",
            ActiveOrInactive = true
        };

        members = new Members();
        members.members.Add(a1);


        Membership Premium = new Membership(3, "Premium", 100.00);
        Membership Plus = new Membership(2, "Plus", 75.00);
        Membership Basic = new Membership(1, "Basic", 50.00);


    }


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

                if (authenticatedMember == null)
                {
                    Console.Write("Enter your username: ");
                    string username = Console.ReadLine();
                    Console.Write("Enter your password");
                    string password = Console.ReadLine();
                    authenticatedMember = members.Authenticate(username, password);
                    if (authenticatedMember != null)
                    {
                        Console.WriteLine($"Welcome {authenticatedMember.MemberFirstName}");
                        LoggedIn();
                    }
                    else
                    {
                        Console.WriteLine("Invalid username or password");
                    }
                }
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
    }
    static void LoggedIn()
    {
        bool over = false;

        while (!over)
        {
            Console.WriteLine("For: Appointment Sign Up (1), To Check Balance (2), View Current Appointments (3), To Quit (Q)");
            Console.Write("Option:");
            String Option = Console.ReadLine();
            switch (Option)
            {
                case "1":
                    AppointmentSignUp();
                    break;
                case "2":
                    CheckBalance();
                    break;
                case "3":
                    ViewAppointments();
                    break;

                case "q":
                    over = true;
                    Console.WriteLine("Thank you for your time!");
                    break;

            }
            static void AppointmentSignUp()
            {

            }
            static void CheckBalance()
            {

            }
            static void ViewAppointments()
            {

            }
            

        }
    }
}