using System.Windows.Controls;
using System.Windows;
using System.Collections.Generic;

namespace WpfCustomerApp
{
    public partial class ResultsPage : Page
    {
        private readonly MetadataHelper _metadataHelper;
        public ResultsPage(string selectedDbColumn, string searchText)
        {
            InitializeComponent();

            var dbContext = new ApplicationDbContext();
            _metadataHelper = new MetadataHelper(dbContext);

            LoadData(selectedDbColumn, searchText);
        }


        private void LoadData(string selectedDbColumn, string searchText)
        {
            var customerData = _metadataHelper.GetCustomer(selectedDbColumn,  searchText);

          
            // Bind data to DataGrid
            ResultsDataGrid.ItemsSource = customerData;
        }

        private void DownloadExcelButton_Click(object sender, RoutedEventArgs e)
        {
            var data = ResultsDataGrid.ItemsSource as List<Customer>; // Assuming data is of type List<Customer>
            if (data != null)
            {
                var workbook = new ClosedXML.Excel.XLWorkbook();
                var worksheet = workbook.Worksheets.Add("Sheet1");

                // Add column headers
                worksheet.Cell(1, 1).Value = "Name";
                worksheet.Cell(1, 2).Value = "Type";

                // Add data rows
                for (int i = 0; i < data.Count; i++)
                {
                    worksheet.Cell(i + 2, 1).Value = data[i].Name;
                    worksheet.Cell(i + 2, 2).Value = data[i].Type;
                }

                // Save to file
                var saveFileDialog = new Microsoft.Win32.SaveFileDialog
                {
                    Filter = "Excel Files (*.xlsx)|*.xlsx",
                    FileName = "Results.xlsx"
                };
                if (saveFileDialog.ShowDialog() == true)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                }
            }
        }


        private void DownloadXmlButton_Click(object sender, RoutedEventArgs e)
        {
            var data = ResultsDataGrid.ItemsSource as List<Customer>; // Assuming data is of type List<Customer>
            if (data != null)
            {
                var serializer = new System.Xml.Serialization.XmlSerializer(data.GetType());
                var saveFileDialog = new Microsoft.Win32.SaveFileDialog
                {
                    Filter = "XML Files (*.xml)|*.xml",
                    FileName = "Results.xml"
                };
                if (saveFileDialog.ShowDialog() == true)
                {
                    using (var writer = new System.IO.StreamWriter(saveFileDialog.FileName))
                    {
                        serializer.Serialize(writer, data);
                    }
                }
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the parent window of the UserControl
            var window = Window.GetWindow(this) as MainWindow;
            if (window != null)
            {
                // Show the original content
                window.ShowMainContent();
            }
        }



    }


}