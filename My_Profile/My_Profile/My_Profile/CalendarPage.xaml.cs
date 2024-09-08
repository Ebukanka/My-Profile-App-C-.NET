using System.Windows;
using System.Windows.Controls;

namespace My_Profile
{
    public partial class CalendarPage : Page
    {
        public CalendarPage()
        {
            InitializeComponent();
        }

        private void SeeAllEvents_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // Implement the logic to show all events or navigate to a detailed events page
            MessageBox.Show("Showing all events...");
        }
    }
}
