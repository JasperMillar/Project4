using System;
using System.Collections.Generic;
using System.Data;
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

namespace project4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        prj3 prj3 = new prj3();
        public MainWindow()
        {
            InitializeComponent();
            FillDataGrid();
        }
        private void FillDataGrid()
        {
            DataTable verkiezingsoort = prj3.Selectverkiezingsoort();
            if (verkiezingsoort != null)
            {
                dgverkiezingsoort.ItemsSource = verkiezingsoort.DefaultView;
            }
        }
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            DataRowView selectedRow = dgpizzasoort.SelectedItem as DataRowView;

            editpizza edit = new editpizza(selectedRow);
            edit.ShowDialog();
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            DataRowView selectedRow = dgpizzasoort.SelectedItem as DataRowView;

            if (prj3.DeletePizza(selectedRow["verkiezingsoort_id"].ToString()))
            {
                MessageBox.Show($"verkiezingsoort {selectedRow["verkiezingsoort_id"]} verwijderd");
            }
            else
            {
                MessageBox.Show($"Verwijderen van {selectedRow["verkiezingsoort_id"]} mislukt");
            }

            FillDataGrid();
        }
        private void Create_Click(object sender, RoutedEventArgs e)
        {
            createverkiezingsoort create = new createverkiezingsoort();
            create.ShowDialog();
            FillDataGrid();
        }
        private void Standpunten_Click(object sender, RoutedEventArgs e)
        {
            standpunten standpunten = new standpunten();
            standpunten.ShowDialog();
            FillDataGrid();
        }
    }
}
