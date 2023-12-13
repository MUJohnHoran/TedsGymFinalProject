using System.ComponentModel.Design;
using System.Net;
using System.Numerics;
using System.Security.Cryptography;
using TedsGymFinalProject.Model;

namespace TedsGymFinalProject.Model;

public class Program
{
    private static Members members; // Declare Members class and variable to be used in main program
    private static Member member; // Declare Member class and variable to be used in main program
    private static Member authenticatedMember; // Declare authenticatedMember variable to be used in main program 
    private static List<Appointment> appointment; // Declare new list from the Appointment class
    private static List<MemberAppointment> memberAppointment; // Declare new list from the MemberAppointement class
    private static Membership membership; // Declare Membership class and variable to be used in main program
    static void Main(string[] args)
    {

        Console.WriteLine("Loading..."); // Display to user "Loading.."
        Begin(); // Run Begin method 
        Menu(); // Run Menu Method for user input and selection

    }

    static void Begin()
    {
        var a1 = new Member // new member constructor (Ted)
        {
            Password = "4321", // Ted's password
            Username = "Ted4321", // Ted's Username
            MemberFirstName = "Ted", // Ted's first name
            MemberLastName = "Lawder", // Ted's last name
            PhoneNumber = "642-245-8989", // Ted's phone number
            MembershipPlan = "Plus", // Ted's membership type 
            ActiveOrInactive = true // Ted's active membership? 
        };

        var a2 = new Member  // new member constructor (John)
        {
            Password = "2345", // John's password 
            Username = "HennyHoran", // John's username
            MemberFirstName = "John", // John's first name
            MemberLastName = "Horan", // John's last name
            PhoneNumber = "262-888-9490", // John's phone number
            MembershipPlan = "Premium", // John's curent plan
            ActiveOrInactive = true // John's active membership? 

        };

        string activityType; // Activity type variable for the appointment on the birth of Christ
        activityType = null; // Set Activity type to null

        string dayofWeek; // day of week variable for the appointment on the birth of Christ
        dayofWeek = null; // Set day of week to null

        string time; // time variable for the appointment on the birth of Christ
        time = null; // Set time to null


        var JohnApp = new Appointment(activityType, dayofWeek, time); // create new appointment from Appointment Class

        var JohnMemApp = new MemberAppointment(a2, JohnApp); // create new appointment from MemberAppointment class

        members = new Members(); // Create new Members 
        members.members.Add(a1); // member a1 (Ted)
        members.members.Add(a2); // Member a2 (john)

        appointment = new List<Appointment>(); // new list for appointments 
        appointment.Add(JohnApp); // John's appointment 

        memberAppointment = new List<MemberAppointment>(); // New list for memberAppointments 
        memberAppointment.Add(JohnMemApp); // John's member appointment 

    }


    static void Menu() // Method for the main menu of the program
    {
        bool over = false; // Sets the variable over to false to set loop condition

        while (!over) // While causes the loop to run while �over� is false
        {
            Console.WriteLine("For: To Login (1), To Create Membership (2), To clear screen (c), To Quit (q)"); // Gives the user options to enter to navigate the program
            Console.Write("Option:");
            String Option = Console.ReadLine(); // Displays �Option:� and stores input in Option
            switch (Option) // Switch evaluates the input and executes that case
            {
                case "1": // Case that takes the user to the login menu by running log in method
                    LoginMenu(); // The breaks after each case end the loop after executed
                    break; // Case that takes user to Sign up menu y running signup method
                case "2":
                    SignUpMenu();
                    break;
                case "c": // Case that clears the users screen and starts over
                    Console.Clear();
                    break;
                case "q": // Case that quits the program and ends the loop and code
                    over = true;
                    break;
                default: // If user enters an invalid option says invalid and restarts.
                    Console.WriteLine("Invalid command!");
                    break;
            }
        }
    }

    static void LoginMenu() //Method for logging into the program
    {

        if (authenticatedMember == null) //Checks if authenticated member is null, if so loop doesn�t run
        {
            Console.Write("Enter your username: ");  // Asks user to enter username
            string username = Console.ReadLine();  // Stores input as username
            Console.Write("Enter your password: ");  // Asks user to enter password
            string password = Console.ReadLine();  // Stores input as password
            authenticatedMember = members.Authenticate(username, password); // Calls method to verify if the user is authenticated
            if (authenticatedMember != null) // If a non-null value is returned, loop is run
            {
                Console.WriteLine($"Welcome {authenticatedMember.MemberFirstName}"); // displays username
                Console.WriteLine($"Current Plan: {authenticatedMember.MembershipPlan}"); // displays users current plan
                LoggedIn(); // calls the LoggedIn method
            }
            else
            {
                Console.WriteLine("Invalid username or password"); // If user is not athenticated, displays invalid
            }
        }
    }

    static void SignUpMenu() //Method to sign up as a new member
    {
        Console.Write("First Name: ");  // Prompts user to enter their information
        string memberFirstName = Console.ReadLine();  // Stores the user�s input as variable
        Console.Write("Last Name: ");
        string memberLastName = Console.ReadLine();
        Console.Write("Username: ");
        string username = Console.ReadLine();
        Console.Write("Password: ");
        string password = Console.ReadLine();
        Console.Write("Phone Number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Please enter the plan you would like to purchase (Premium, Plus, or Basic)  ");  // Asks user to choose a membership plan
        string membership = Console.ReadLine(); //Stores input as a variable


        var newMember = new Member // Calls the Member class constructor
        {
            MemberFirstName = memberFirstName, //Referencing objects under new variables
            MemberLastName = memberLastName,
            Username = username,
            Password = password,
            PhoneNumber = phoneNumber,
            MembershipPlan = membership,

        };

        members.members.Add(newMember); // Adds the entered information into the members list

        Console.WriteLine($"Welcome {memberFirstName}!");  // Displays the members name and plan
        Console.WriteLine($"Your current Plan: {membership}");
        Menu();  // Returns the user to the main menu

    }

    static void LoggedIn()  // Method for when user is logged in successfully
    {
        bool over = false;  // Sets the over variable to false

        while (!over)  // Loop runs while over is false
        {
            Console.WriteLine("For: Appointment Sign Up (1), To Check Balance (2), View Current Appointments (3), To Quit (q)");  // Displays options for the logged in user
            Console.Write("Option:");  // Asks user to choose an option
            String Option = Console.ReadLine();  // Stores user input in �Option�
            switch (Option)  // Switch runs case depending on what option was chosen
            {
                case "1":  // Case for Scheduling appoinment
                    ScheduleAppointment();  // Runs schedul appointment method
                    break;  // Each break ends the loop after case is performed
                case "2":
                    CheckBalance();  // Case for checking balance, runs check balance mehtod
                    break;
                case "3":
                    ViewAppointments();  // Case for viewing appointments, runs viewappointments method
                    break;

                case "q":
                    authenticatedMember = null;
                    over = true;  // Case for quitting menu, breaks loop by setting �over� to true
                    break;

            }
            static void ScheduleAppointment() // Method for scheduling appointment
            {
                Console.WriteLine("Available activities: Yoga, Swim, Cycling, Weight Training, Basketball, and Tennis."); // Displays appointment options for user

                Console.Write("Please enter the type of activity:");  // Asks user to enter option
                string activityType = Console.ReadLine();  // stores input in variable

                Console.Write("Enter the day of the week:"); // Asks user to enter option
                string dayofWeek = Console.ReadLine(); // Asks user to enter option

                Console.WriteLine("Enter what time (3:00 P.M, 5:00 P.M or 7:00 P.M):"); // Asks user to enter option
                string time = Console.ReadLine(); // Asks user to enter option

                Appointment APP1 = new Appointment(activityType, dayofWeek, time); // Constructor for new appointment

                appointment = new List<Appointment>(); // Creates new list
                appointment.Add(APP1); // Adds the users input to the list

                var CAPP1 = new MemberAppointment(authenticatedMember, APP1); // stores CAPP1 as new memberAppointment 
                memberAppointment = new List<MemberAppointment>(); // Creates new list
                memberAppointment.Add(CAPP1); // Adds the users input to the list
            }

            static void CheckBalance()  // Method for checking balance
            {
                Balance userBalance = new Balance()  // Calls constructor for new balance
                {
                    TotalBalance = 0,  // Assigns values to objects
                    LateFees = 0,
                    Rewards = 0,
                    Vending = 0,
                };

                bool exit = false;  // sets �exit� to false

                while (!exit)  // While loop runs as long as exit is false
                {
                    Console.WriteLine("Welcome! Please choose an option.");  // prompts user to choose option
                    Console.WriteLine("1. Check Total Balance");  // Displays option to user

                    Console.WriteLine("2. Check late fees");
                    Console.WriteLine("3. Check rewards");
                    Console.WriteLine("4. Check vending credits");

                    Console.WriteLine("5. Exit");  // option to exit

                    Console.WriteLine("Enter your choice:");  // Asks user for choice
                    string input = Console.ReadLine();  // stores input as �input�

                    switch (input)  // Runs case depending on input
                    {
                        case "1":
                            Console.WriteLine($"Your total balance is: {userBalance.TotalBalance:C}");  // Displays total balance
                            break;
                        case "2":
                            Console.WriteLine($"You have {userBalance.LateFees:C} in late fees.");
                            break;  // Displays late fees
                        case "3":
                            Console.WriteLine($"You have {userBalance.Rewards:C} in rewards.");
                            break;  // Displays rewards
                        case "4":
                            Console.WriteLine($"You have {userBalance.Vending:C} in vending credits.");  // Displays vending balance
                            break;
                        case "5":
                            Console.WriteLine("Exiting...");
                            exit = true;  // Exits menu and ends the loop
                            break;
                        default:  // Runs if user input is invalid; doesn�t match case options
                            Console.WriteLine("Invalid option. Please enter either 1 or 2.");
                            break;
                    }
                    Console.WriteLine();  // Leaves a space
                }
              
            }

            static void ViewAppointments()//Creates Method for option to view appointments
              }
                if (authenticatedMember == null)//if the value for authenticated member is null return the following...
                {
                    Console.WriteLine("You are not logged in.");// write this on the screen
                    return;//continue
                }

                var appointmentList = memberAppointment.Where(o => o.member.Username == authenticatedMember.Username);//checks the member list for apointment associated to the current member username

                if (appointmentList.Count() == 0)//If appointment count is equal to 0...
                {
                    Console.WriteLine("No appointment found.");//write on screen �no appointment found�
                }
                else
                {
                    Console.WriteLine($"You have an appointment at see you there!");//If it does not = 0 found write this on the screen
                }
            }
        }
    }
}