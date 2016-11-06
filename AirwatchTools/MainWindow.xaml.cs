using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media;

namespace AirwatchTools {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        ObservableCollection<AirWatchEntry> airwatchEntries = new ObservableCollection<AirWatchEntry>();


        public MainWindow() {
            InitializeComponent();

            this.Title = "AirWolf Configuration";
            this.Background = Brushes.DarkGray;
            this.ResizeMode = ResizeMode.NoResize;

            tbInput.TextWrapping = TextWrapping.Wrap;
            tbInput.AcceptsReturn = true;
            tbInput.Background = SystemColors.ControlBrush;

            tbAdd.KeyDown += TbInput_KeyDown;
            tbAdd.Background = SystemColors.ControlBrush; ;

            //airwatchEntries.Add(new AirWatchEntry { FirstName = "Andy", LastName = "Myers", Active = "1", EmailAddress="me@here.com" });
        }

        //TOOLBAR MENU EVENT HANDLERS
        private void btnExit_Click(object sender, RoutedEventArgs e) {
            MessageBoxResult result = MessageBox.Show("Do you want to exit?", "Exiting", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
                Application.Current.Shutdown();
        }

        private void Visualize_Click(object sender, RoutedEventArgs e) {
            Visualizer v = new Visualizer(airwatchEntries);
            v.Show();
        }
        private void btnAbout_Click(object sender, RoutedEventArgs e) {
            About about = new About();
            about.Show();
        }

        //MAIN PAGE BUTTON EVENT HANDLERS
        private void btnAdd_Click(object sender, RoutedEventArgs e) {

        }

        private void btnCreateCsv_Click(object sender, RoutedEventArgs e) {

        }

        private void btnAppend_Click(object sender, RoutedEventArgs e) {

        }

        //EVENT HANDLER TO ACCEPT ENTER FROM INPUT BOX
        private void TbInput_KeyDown(object sender, System.Windows.Input.KeyEventArgs e) {
            if (e.Key == System.Windows.Input.Key.Return) {
                if (tbAdd.Text.Length > 0) {
                    if (tbInput.Text.Length == 0)
                        tbInput.Text += tbAdd.Text;
                    else
                        tbInput.Text += ", " + tbAdd.Text;

                    tbAdd.Text = "";
                }
            }
        }
    }
}
