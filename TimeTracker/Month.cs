﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker
{
    public class Month : INotifyPropertyChanged
    {

        private MonthName _monthName;
        public MonthName MonthName { get { return _monthName; } set { _monthName = value; OnPropertyChanged(); } }

        private static List<int> _days = new List<int>();
        

        public List<int> Days
        {
            get
            {
                int monthLength = 0;
                switch (MonthName)
                {
                    case MonthName.Feb:
                        monthLength = 28;
                        break;
                    case MonthName.Apr:
                        monthLength = 30;
                        break;
                    case MonthName.Jun:
                        monthLength = 30;
                        break;
                    case MonthName.Sep:
                        monthLength = 30;
                        break;
                    case MonthName.Nov:
                        monthLength = 30;
                        break;
                    default:
                        monthLength = 31;
                        break;
                }
                _days = new List<int>();
                for (int i = 1; i <= monthLength; i++)
                {
                    _days.Add(i);
                }
                return _days;
            }
            set
            {
                _days = value;
                OnPropertyChanged();
            }
        }


        public List<decimal> HoursPerDay { get; set; }

        public decimal TotalHours { get { return HoursPerDay.Sum(); } }





        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }


        public static ObservableCollection<string> GetDaysInCertainMonth()
        {
            var obcollOfDays = new ObservableCollection<string>();

            if (_days == null)
            { 
                return obcollOfDays;
            }

            foreach (var day in _days)
            {
                obcollOfDays.Add(day.ToString());
            }
            return obcollOfDays;
        }
        public static ObservableCollection<string> GetMonthNames()
        {
            string[] arrOfEnums = Enum.GetNames(typeof(MonthName));
            var obcollOfEnums = new ObservableCollection<string>();

            foreach (var month in arrOfEnums)
            {
                string nameOfMonth = month.ToString();
                obcollOfEnums.Add(nameOfMonth);
            }
            return obcollOfEnums;
        }
    }

    public enum MonthName
    {
        Jan,
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec
    }
}
