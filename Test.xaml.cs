using System.Windows;

namespace MatrixDisplayWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Example matrix data
            double[,] matrixData = new double[,]
            {
                {11, 12, 47, 58, 58},
                {15, 58, 45, 48, 58},
                {13, 78, 95, 61, 58},
                {34, 64, 45, 66, 58},
                {58, 58, 58, 58, 58}
            };

            // Bind the matrix data to the DataGrid
            matrixDataGrid.ItemsSource = ConvertToDataTable(matrixData).DefaultView;
        }

        private System.Data.DataTable ConvertToDataTable(double[,] array)
        {
            System.Data.DataTable dataTable = new System.Data.DataTable();

            // Create columns
            for (int i = 0; i < array.GetLength(1); i++)
            {
                dataTable.Columns.Add($"Column{i + 1}");
            }

            // Populate rows
            for (int i = 0; i < array.GetLength(0); i++)
            {
                var row = dataTable.NewRow();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    row[j] = array[i, j];
                }
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }
    }
}
