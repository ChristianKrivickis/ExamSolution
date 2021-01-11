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
        // Observable List
        ObservableCollection<Account> Accounts = new ObservableCollection<Account>();
        ObservableCollection<Account> filteredAccounts = new ObservableCollection<Account>();

        public MainWindow()
        {
            InitializeComponent();
        }

        // Method runs when window is loaded
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Current Accounts (First Name, Last Name, Account Number, Balance, Account Type)
            CurrentAccount ca1 = new CurrentAccount("Jane", "Jones", 45748275, 1500, "Current Account");
            CurrentAccount ca2 = new CurrentAccount("John", "Smith", 679569, 30000, "Current Account");

            // Savings Accounts (First Name, Last Name, Account Number, Balance, Account Type)
            SavingsAccount sa1 = new SavingsAccount("Joe", "Murphy", 95684, 4000, "Savings Account");
            SavingsAccount sa2 = new SavingsAccount("Jess", "Walsh", 7535737, 9999, "Savings Account");

            // Adds 4 objects to ObservableCollection<Account> Accounts
            Accounts.Add(ca1);
            Accounts.Add(ca2);
            Accounts.Add(sa1);
            Accounts.Add(sa2);

            listBox.ItemsSource = Accounts;

        }

        // Method runs when buttonDeposit is clicked
        private void buttonDeposit_Click(object sender, RoutedEventArgs e)
        {

        }

        // Method runs when buttonWithdraw_Click is clicked
        private void buttonWithdraw_Click(object sender, RoutedEventArgs e)
        {

        }

        // Method runs when buttonInterest_Click is clicked
        private void buttonInterest_Click(object sender, RoutedEventArgs e)
        {

        }

        private void textBoxTransactionAmount_GotFocus(object sender, RoutedEventArgs e)
        {
            // Clears text in textbox when clicked on
            textBoxTransactionAmount.Text = "";
        }

        // Code for selecting accounts from list
        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CurrentAccount selectedCA = listBox.SelectedItem as CurrentAccount;
            SavingsAccount selectedSA = listBox.SelectedItem as SavingsAccount;
            Account accountEmployee = (Account)listBox.SelectedItem;

            // If Current Account is pressed - this if statement runs and data is displayed
            if (selectedCA != null)
            {
                textBlockFirstName.Text = selectedCA.FirstName;
                textBlockLastName.Text = selectedCA.LastName;
                textBlockBalance.Text = selectedCA.Balance.ToString();
                textBlockAccountType.Text = selectedCA.Type;
            }

            // If Savings Account is pressed - this if statement runs and data is displayed
            else if (selectedSA != null)
            {
                textBlockFirstName.Text = selectedSA.FirstName;
                textBlockLastName.Text = selectedSA.LastName;
                textBlockBalance.Text = selectedSA.Balance.ToString();
                textBlockAccountType.Text = selectedSA.Type;
            }
        }

        // Method runs when either/ neither/ both checkboxCurrent or checkboxSavings are pressed 
        private void checkBox_Click(object sender, RoutedEventArgs e)
        {
            // Run Filter() Method
            Filter();
        }

        // Method to filter which accounts are observable on the list
        // DOES NOT WORK
        private void Filter()
        {
            // Removes filtered acccounts from the list
            filteredAccounts.Clear();
            listBox.ItemsSource = null;


            // If checkboxCurrent equals true (checked) - this if statement runs
            if (checkBoxCurrent.IsChecked == true)
            {
                foreach (Account Accounts in Accounts)
                {
                    if (Accounts is CurrentAccount)
                    {
                        // If the account is a current account , they will be added to the filtered account
                        filteredAccounts.Add(Accounts);
                    }
                }
            }

            // If checkboxSavings equals true (checked) - this if statement runs
            if (checkBoxSavings.IsChecked == true)
            {
                foreach (Account Accounts in Accounts)
                {
                    if (Accounts is SavingsAccount)
                    {
                        // If the account is a savings account, they will be added to the filtered account
                        filteredAccounts.Add(Accounts);
                    }
                }
            }
        }
    }
}
