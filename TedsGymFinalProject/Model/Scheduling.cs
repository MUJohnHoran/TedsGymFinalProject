using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Scheduling
{
	public Scheduling()
	{

        public string ActivityType { get; set; }
    public string DayOfWeek { get; set; }
    public string Time { get; set; }

    public Scheduling(string activityType, string dayOfWeek, string time)
    {
        ActivityType = activityType;
        DayOfWeek = dayOfWeek;
        Time = time;

    }
}
