using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfCustomerApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MetadataHelper _metadataHelper;

        public MainWindow()
        {
            InitializeComponent();
            var dbContext = new ApplicationDbContext();
            _metadataHelper = new MetadataHelper(dbContext);
            LoadColumnNames();
        }

        private void LoadColumnNames()
        {
            var columnNames = _metadataHelper.GetColumnNames();
            searchDbColumn.ItemsSource = columnNames;
            searchDbColumn.SelectedItem = "Name";
        }

       

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedDbColumn = searchDbColumn.SelectedItem as string; 
            var searchText = searchWord.Text;

            // Navigate to ResultsPage
            MainFrame.Navigate(new ResultsPage(selectedDbColumn, searchText));

            // Hide the entire content container
            MainContentContainer.Visibility = Visibility.Collapsed;
        }

        public void ShowMainContent()
        {
            MainContentContainer.Visibility = Visibility.Visible;
            MainFrame.Content = null; // Clear the frame content
        }
    }
}
