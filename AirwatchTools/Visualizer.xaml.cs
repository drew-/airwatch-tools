using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows;

namespace AirwatchTools {
    /// <summary>
    /// Interaction logic for Visualizer.xaml
    /// </summary>
    public partial class Visualizer : Window {
        public Visualizer(ObservableCollection<AirWatchEntry> entries) {
            InitializeComponent();

            dgCsvData.IsReadOnly = true;
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
