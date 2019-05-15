using NipponBar.DB;
using NipponBar.Strategy;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace NipponBar
{
    /// <summary>
    /// Логика взаимодействия для SushiCart.xaml
    /// </summary>
    public partial class SushiCart : UserControl
    {
        public List<Sushi1> shoppingCart;
        public SushiCart(List<Sushi1> sushi1s)
        {
            InitializeComponent();

            shoppingCart = sushi1s;
            sushisCart.ItemsSource = shoppingCart;

           

        }

        private decimal SumDLstBox()
        {
            return sushisCart.Items.Cast<Sushi1>().Sum(f =>Convert.ToInt32( f.Price));
        }
      
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Bill bill = new Bill();
            // bill.setQuantity(Convert.ToInt32(prise.Text));
            string a;
            a = prise.Text;
            String total1;
            if (a == "")
            {
                total.Content = "";
            }
            else
            {
                
                
                int b = int.Parse(a);
                total1 = Convert.ToString(bill.getTotal(b));
                total.Content = total1;
            }
        }

        private void Summ_Click(object sender, RoutedEventArgs e)
        {
            prise.Text = Convert.ToString(SumDLstBox());

        }

        private void BUY_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("You make an order!");

            
        }
    }
}
