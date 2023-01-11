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
using System.Windows.Shapes;

namespace project4
{
    /// <summary>
    /// Interaction logic for createpizza.xaml
    /// </summary>
    public partial class createpizza : Window
    {
        public createpizza()
        {
            InitializeComponent();
        }
        private void Createpizza_Click(object sender, RoutedEventArgs e)
        {
            prj4 prj4 = new prj4();
            if (prj4.Insertpizzasoort(tbpizzasoort.Text, tbtoppings.Text, tbprijs.Text))
            {
                MessageBox.Show($"pizza aangemaakt");
            }
            else
            {
                MessageBox.Show($"Aanmaken mislukt");
            }
            this.Close();
        }
    }
}
