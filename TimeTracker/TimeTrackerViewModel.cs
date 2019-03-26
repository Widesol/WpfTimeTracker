using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker
{
    public class TimeTrackerViewModel
    {
        public ObservableCollection<string> Months { get; set; }
        public ObservableCollection<string> Days { get; set; }
        //fylla 


        public TimeTrackerViewModel()
        {
            Months = Month.GetMonthNames();



            Days = Month.GetDaysInCertainMonth();
        }
    }
}
