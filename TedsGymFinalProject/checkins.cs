using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TedsGymFinalProject.Model
{
    public class check_ins
    {
        
        public string Date { get; set; }
        public string TimeIn { get; set; }
        public string TimeOut { get; set; }
        public double NumofCheckIns { get; set; }   
        public double NumPerMonth {  get; set; }
        public double NumPerYear { get; set;}


        public check_ins(string date, string timeIn, string timeOut, double numofCheckIns, double numPerMonth, double numPerYear)
        {
            this.Date = date;
            this.TimeIn = timeIn;
            this.TimeOut = timeOut;
            this.NumofCheckIns = numofCheckIns;
            this.NumPerMonth = numPerMonth;
            this.NumPerYear = numPerYear;

        }
        
          
        

    }
}
