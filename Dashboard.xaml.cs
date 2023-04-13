using System.Windows;

namespace GarageManagementSystem
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void BtnMechanic_Click(object sender, RoutedEventArgs e)
        {
            // Create a new instance of the Mechanic window
            Mechanics mechanicWindow = new Mechanics();
            // Hide the Dashboard window
            Hide();
            // Show the Mechanic window
            mechanicWindow.ShowDialog();
            // After the Mechanic window is closed, show the Dashboard window again
            Show();
        }
    }
}