using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TimeTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var vm = new TimeTrackerViewModel();
            DataContext = vm;
        }

        private void Months_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var month = new Month();

            Enum.TryParse(Months.SelectedValue.ToString(), out MonthName monthName);
            month.MonthName = monthName;

            List<int> test;
            test = month.Days;

            var vm = new TimeTrackerViewModel();
            DataContext = vm;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var x = Months.SelectedValue;
            var y = Days.SelectedValue;
            var z = InputHours.SelectedText;



        }
    }
}
