using System.Windows;
using System.Windows.Controls;

namespace My_Profile
{
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void SeeAllNotifications_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // Create and show the NotificationsWindow
            NotificationsWindow notificationsWindow = new NotificationsWindow();
            notificationsWindow.ShowDialog(); // ShowDialog() makes it a modal window
        }
    }


}
