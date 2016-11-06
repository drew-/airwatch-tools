using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media;

namespace AirwatchTools {
    /// <summary>
    /// Interaction logic for Visualizer.xaml
    /// </summary>
    public partial class Visualizer : Window {
        public Visualizer(ObservableCollection<AirWatchEntry> entries) {
            InitializeComponent();

            dgCsvData.IsReadOnly = true;
            dgCsvData.AlternationCount = 2;
            dgCsvData.AlternatingRowBackground = new SolidColorBrush(Color.FromRgb(204, 153, 153));
            dgCsvData.Background = new SolidColorBrush(Color.FromRgb(102, 102, 204));

            dgCsvData.ItemsSource = entries;
        }

        //VIZUALIZER PAGE BUTTON EVENT HANDLERS
        private void Edit_Click(object sender, RoutedEventArgs e) {
            if (dgCsvData.IsReadOnly == true) {
                dgCsvData.IsReadOnly = false;
                btnEdit.Content = "Disable Editing";
            } else {
                dgCsvData.IsReadOnly = true;
                btnEdit.Content = "Enable Editing";
            }
        }

        private void btnScan_Click(object sender, RoutedEventArgs e) {

        }
    }
}
