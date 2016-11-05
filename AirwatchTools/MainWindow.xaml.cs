using System.Collections.ObjectModel;
using System.Windows;

namespace AirwatchTools {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        ObservableCollection<AirWatchEntry> airwatchEntries = new ObservableCollection<AirWatchEntry>();


        public MainWindow() {
            InitializeComponent();
        }

        //TOOLBAR MENU EVENT HANDLERS
        private void btnExit_Click(object sender, RoutedEventArgs e) {

        }

        private void Visualize_Click(object sender, RoutedEventArgs e) {

        }
        private void btnAbout_Click(object sender, RoutedEventArgs e) {

        }

        //MAIN PAGE BUTTON EVENT HANDLERS
        private void btnAdd_Click(object sender, RoutedEventArgs e) {

        }

        private void btnCreateCsv_Click(object sender, RoutedEventArgs e) {

        }

        private void btnAppend_Click(object sender, RoutedEventArgs e) {

        }
    }
}
