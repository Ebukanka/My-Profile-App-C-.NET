    using System.Windows;

    namespace My_Profile
    {
        public partial class NotificationsWindow : Window
        {
            public NotificationsWindow()
            {
                InitializeComponent();
            }

            private void CloseButton_Click(object sender, RoutedEventArgs e)
            {
                this.Close();
            }
        }
    }
