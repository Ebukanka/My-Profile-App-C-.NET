using System.Windows;
using System.Windows.Controls;

namespace My_Profile
{
    public partial class SignInPage : Page
    {
        public SignInPage()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            // Retrieve input values
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            // Implement sign-in logic here
            MessageBox.Show($"Username: {username}\nPassword: {password}", "Sign In");
        }

        private void ForgotPassword_Click(object sender, RoutedEventArgs e)
        {
            // Implement forgot password logic
            MessageBox.Show("Forgot Password Clicked");
            // You can navigate to a ForgotPasswordPage here
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to SignUpPage
            NavigationService.Navigate(new SignUpPage());
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to SignUpPage
            NavigationService.Navigate(new SignUpPage());
        }
    }
}
