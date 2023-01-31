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
using System.Windows.Shapes;

namespace project4
{
    /// <summary>
    /// Interaction logic for editpizza.xaml
    /// </summary>
    public partial class editpizza : Window
    {
        public editpizza(DataRowView pizzasoort)
        {
            InitializeComponent();
            FillScreen(pizzasoort);
        }

        private void FillScreen(DataRowView pizzasoort)
        {
            tbId.Text = pizzasoort["pizzaid"].ToString();
            tbpizzasoort.Text = pizzasoort["pizzasoort"].ToString();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            prj4 prj4 = new prj4();
            if (prj4.Updatepizza(tbId.Text, tbpizzasoort.Text, tbtoppings.Text, tbprijs.Text))
            {
                MessageBox.Show($"pizzasoort {tbId.Text} aangepast");
            }
            else
            {
                MessageBox.Show($"Aanpassen van {tbId.Text} mislukt");
            }
            this.Close();
        }
    }
}
