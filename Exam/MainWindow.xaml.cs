using System;
using System.Collections.Generic;
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
using System.Collections.ObjectModel;


namespace Exam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Account> Accounts = new ObservableCollection<Account>();
        ObservableCollection<Account> filteredAccounts = new ObservableCollection<Account>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Part time employees (First name, last name, status, hourly rate, hours worked)
            CurrentAccount ca1 = new CurrentAccount("Jane", "Jones", "Part Time", 10, 15);
            CurrentAccount ca2 = new CurrentAccount("John", "Smith", "Part Time", 15, 14);

            // Full time employees (First name, last name, status, salary)
            SavingsAccount sat1 = new SavingsAccount("Joe", "Murphy", "Full Time", 24000);
            SavingsAccount sa2 = new SavingsAccount("Jess", "Walsh", "Full Time", 25000);

            // Added Full time and Part time employees to observable list
            Accounts.Add(pt1);
            Accounts.Add(pt2);
            Accounts.Add(ft1);
            Accounts.Add(ft2);
        }

        private void buttonDeposit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonWithdraw_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonInterest_Click(object sender, RoutedEventArgs e)
        {

        }

        private void textBoxTransactionAmount_GotFocus(object sender, RoutedEventArgs e)
        {
            // Clears text in textbox when clicked on
            textBoxTransactionAmount.Text = "";
        }

  
    }
}
