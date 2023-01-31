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
        prj4 prj4 = new prj4();
        public MainWindow()
        {
            InitializeComponent();
            FillDataGrid();
        }
        private void FillDataGrid()
        {
            DataTable pizzasoort = prj4.Selectpizzasoort();
            if (pizzasoort\ != null)
            {
                dgpizzasoort.ItemsSource = pizzasoort.DefaultView;
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

            if (prj4.Deletepizza(selectedRow["pizzaid"].ToString()))
            {
                MessageBox.Show($"pizzasoort {selectedRow["pizzaid"]} verwijderd");
            }
            else
            {
                MessageBox.Show($"Verwijderen van {selectedRow["pizzaid"]} mislukt");
            }

            FillDataGrid();
        }
        private void Create_Click(object sender, RoutedEventArgs e)
        {
            createpizza create = new createpizza();
            create.ShowDialog();
            FillDataGrid();
        }
        private void Toppings_Click(object sender, RoutedEventArgs e)
        {
            toppings toppings = new toppings();
            toppings.ShowDialog();
            FillDataGrid();
        }
    }
}
