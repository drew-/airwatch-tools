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

            dgCsvData.ItemsSource = entries;
        }

        //VIZUALIZER PAGE BUTTON EVENT HANDLERS
        private void Edit_Click(object sender, RoutedEventArgs e) {

        }
    }
}
