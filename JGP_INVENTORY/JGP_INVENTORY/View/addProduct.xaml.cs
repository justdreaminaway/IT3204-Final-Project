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
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using JGP_INVENTORY.ViewModel;
using System.Configuration;

namespace JGP_INVENTORY.View
{
    /// <summary>
    /// Interaction logic for addProduct.xaml
    /// </summary>
    public partial class addProduct : Window
    {
        public addProduct()
        {
            InitializeComponent();
        }
        ProductViewModel vm = new ProductViewModel();
        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
        

        private void insertBtn_Click_1(object sender, RoutedEventArgs e)
        {
            int qty = Int32.Parse(prodQty.Text);
            int price = Int32.Parse(prodPrice.Text);
            vm.CallAddProduct(prodName.Text, qty, price);

            Hide();
        }
    }
}
