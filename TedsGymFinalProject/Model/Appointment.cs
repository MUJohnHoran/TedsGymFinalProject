using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TedsGymFinalProject.Model;

public class Appointment //Creates appointment class
{

    private static int autoIncreament; //declares variable for increasing ID
    public int Id { get; set; } //declares ID
    public DateTime date { get; set; } //declares variable for time app was scheduled (not used)

    public string activitytype { get; set; } //declares activitytype of app
    public string time { get; set; }//declares variable for time of app

    public string day { get; set; }// declares variable for day of app

    public Appointment(string Time, string Activitytype, string Dayofweek)//constructor of app that inserts a time activity type and day of week
    {
        this.activitytype = Activitytype;//connects the inserted string to variable activitytype 
        this.day = Dayofweek;//connects inserted string to day
        this.time = Time;//connects inserted string to Time
        autoIncreament++;//increases the increment variable by one each time the constructors used
        Id = autoIncreament;//gives the ID the value of this increase
    }

}
