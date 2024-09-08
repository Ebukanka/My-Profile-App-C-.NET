using System.Windows;
using System.Windows.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Configuration;

namespace My_Profile
{
    public partial class SignUpPage : Page
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            // Retrieve input values
            string username = UsernameTextBox.Text;
            string email = EmailTextBox.Text;
            string password = PasswordBox.Password;
            string gender = ((ComboBoxItem)GenderComboBox.SelectedItem)?.Content.ToString();
            string dob = DobDatePicker.SelectedDate?.ToString("d");
            string country = ((ComboBoxItem)CountryComboBox.SelectedItem)?.Content.ToString();
            string address = AddressTextBox.Text;
            string location = LocationTextBox.Text;

            // Implement sign-up logic here
            MessageBox.Show($"Username: {username}\nEmail: {email}\nPassword: {password}\nGender: {gender}\nDate of Birth: {dob}\nCountry: {country}\nAddress: {address}\nLocation: {location}", "Sign Up");
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            // Navigate back to SignInPage
            NavigationService.Navigate(new SignInPage());
        }
    }
}
