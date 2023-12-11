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
    private static List<Appointment> appointment;
    private static List<MemberAppointment> memberAppointment;
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
        var c1 = new Appointment();


        var ca1 = new MemberAppointment(a1, c1);

        members = new Members();
        members.members.Add(a1);

        memberAppointment = new List<MemberAppointment>();
        memberAppointment.Add(ca1);

        appointment = new List<Appointment>();
        appointment.Add(c1);

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

            static void MembershipPlan()
            {
                Membership userMembership = new Membership()
                {
                    MembershipLvl = 2,
                    MembershipName = Plus,
                    Cost = 75.00
                }


            bool exit = false;

                while (!exit)
                {
                    Console.WriteLine("Welcome! Please select a plan.");
                    Console.WriteLine("1. Basic. Cost = $50.00");
                    Console.WriteLine("2. Plus. Cost = $75.00");
                    Console.WriteLine("3. Premium. Cost = $100.00");
                    Console.WriteLine("4. Exit");


                    Console.WriteLine("Please make a selection:");
                    string input = Console.ReadLine();


                    switch (input)
                    {
                        case "1":
                            Console.WriteLine("You have selected Basic.");
                            break;
                        case "2":
                            Console.WriteLine("You have selected Plus.");
                            break;
                        case "3"
                            Console.WriteLine("You have selected Premium.")
                            break;
                        case "4":
                            Console.WriteLine("Goodbye.");
                        default:
                            Console.WriteLine("Invalid input. Please enter a number 1-4.");
                            break;
                    }
                    Console.WriteLine();
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
                    ScheduleAppointment();
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
            static void ScheduleAppointment()
            {
                Console.WriteLine("Available activities: Yoga, Swim, Cycling, Weight Training, Basketball, and Tennis.");

                Console.Write("Please enter the type of activity:");
                string activityType = Console.ReadLine();

                Console.Write("Enter the day of the week:");
                string dayofWeek = Console.ReadLine();

                Console.WriteLine("Enter what time:");
                string time = Console.ReadLine();

                Scheduling yourSchedule = new Scheduling(activityType, dayofWeek, time);

                Console.WriteLine("/nSign-up Details:");
                Console.WriteLine("Class type: " + yourSchedule.ActivityType);
                Console.WriteLine("Day of the week: " + yourSchedule.DayOfWeek);
                Console.WriteLine("Time: " + yourSchedule.Time);

            }
            
            static void CheckBalance()
            {
            Balance userBalance = new Balance()
            {
                TotalBalance = 100.0,
                LateFees = 10.0,
                Rewards = 5.0,
                Vending = 20.0
            };

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Welcome! Please choose an option.");
                Console.WriteLine("1. Check Total Balance");

                Console.WriteLine("2. Check late fees")
                Console.WriteLine("3. Check rewards")
                Console.WriteLine("4. Check vending credits")

                Console.WriteLine("5. Exit");

                Console.WriteLine("Enter your choice:");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine($"Your total balance is: {userBalance.TotalBalance:C}");
                        break;
                    case "2":
                        Console.WriteLine($"You have {userBalance.LateFees:C} in late fees.")
                        break;
                    case "3":
                        Console.WriteLine($"You have {userBalance.Rewards:C} in rewards.");
                        break;
                    case "4":
                        Console.WriteLine($"You have {userBalance.Vending:C} in vending credits.");
                        break;
                    case "5":
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please enter either 1 or 2.");
                        break;
                }
                Console.WriteLine();
            }

        }

        static void ViewAppointments()
            {

                 var appointmentList = memberAppointment.Where(o => o.member.Username == authenticatedMember.Username);


            if (appointmentList.Count() == 0)
            {
                Console.WriteLine("No appointment found.");
            }
            else
            {
                foreach (var appointment in appointmentList)
                {
                    Console.WriteLine(appointment.appointment.date);
                }
            }
            
            

        }
    }
}
