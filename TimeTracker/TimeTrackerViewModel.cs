using Caliburn.Micro;
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

        private BindableCollection<string> _listOfDays = new BindableCollection<string>();
        //Caliburn.Micro nuget package tillägg
        //public BindableCollection<string> ListOfDays { get { return _listOfDays; } set { _listOfDays = value; } }
        public BindableCollection<string> ListOfDays { get; set; }




        //public TimeTrackerViewModel()
        //{
        //    Months = Month.GetMonthNames();
        //    Days = Month.GetDaysInCertainMonth();

        //    var x = new BindableCollection<string>();
        //    x.Add("cha");
        //    x.Add("sdsd");
        //    x.Add("fgd");
        //    x.Add("ewr");
        //    x.Add("hgs");
        //    _listOfDays = x;

        //}
    }
}
