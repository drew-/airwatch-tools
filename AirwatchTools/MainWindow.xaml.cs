using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media;
using Microsoft.Win32;

namespace AirwatchTools {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        ObservableCollection<AirWatchEntry> airwatchEntries = new ObservableCollection<AirWatchEntry>();
        ConsoleContent dc = new ConsoleContent();

        //PUBLIC METHODS
        public MainWindow() {
            InitializeComponent();

            DataContext = dc;

            this.Title = "AirWolf Configuration";
            this.Background = Brushes.DarkGray;
            this.ResizeMode = ResizeMode.NoResize;

            tbInput.TextWrapping = TextWrapping.Wrap;
            tbInput.AcceptsReturn = true;
            tbInput.Background = SystemColors.ControlBrush;

            tbAdd.KeyDown += TbInput_KeyDown;
            tbAdd.Background = SystemColors.ControlBrush; ;
        }

        //PRIVATE METHODS
        void Scroll() {
            dc.RunCommand();
            Scroller.ScrollToBottom();
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

        private void ImportNamesFromExcel_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if(dialog.ShowDialog() == true) {

            }
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e) {
            About about = new About();
            about.Show();
        }

        //MAIN PAGE BUTTON EVENT HANDLERS
        private void btnAdd_Click(object sender, RoutedEventArgs e) {
            if (tbAdd.Text.Length > 0) {
                if (tbInput.Text.Length == 0)
                    tbInput.Text += tbAdd.Text;
                else
                    tbInput.Text += ", " + tbAdd.Text;

                tbAdd.Text = "";
            }
        }

        private void btnGenerateList_Click(object sender, RoutedEventArgs e) {
            ValidateInput val = new ValidateInput(tbInput.Text);
            bool result = val.IsValid();

            if (result) {
                List<string> userNames = val.GetUserList();

                dc.ConsoleInput = ">> " + userNames.Count.ToString() + " Users in list...";
                Scroll();

                AdGrabber grabber = new AdGrabber(userNames);
                airwatchEntries = grabber.GetUserInfo();

                dc.ConsoleInput = ">> List generated..";
                Scroll();
            }
        }
        private void btnCreateCsv_Click(object sender, RoutedEventArgs e) {
            CsvBuilder buidler = new CsvBuilder("andy.csv", airwatchEntries);
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
