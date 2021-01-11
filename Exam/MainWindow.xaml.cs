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
            CurrentAccount ca1 = new CurrentAccount("Jane", "Jones", 45748275, 1500);
            CurrentAccount ca2 = new CurrentAccount("John", "Smith", 679569, 30000);

            // Full time employees (First name, last name, status, salary)
            SavingsAccount sa1 = new SavingsAccount("Joe", "Murphy", 95684, 4000);
            SavingsAccount sa2 = new SavingsAccount("Jess", "Walsh", 7535737, 9999);

            // Added Full time and Part time employees to observable list
            Accounts.Add(ca1);
            Accounts.Add(ca2);
            Accounts.Add(sa1);
            Accounts.Add(sa2);
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
