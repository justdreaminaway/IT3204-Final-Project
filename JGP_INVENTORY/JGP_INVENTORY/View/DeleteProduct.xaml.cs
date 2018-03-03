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
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using JGP_INVENTORY.ViewModel;
using System.Configuration;

namespace JGP_INVENTORY.View
{
    /// <summary>
    /// Interaction logic for DeleteProduct.xaml
    /// </summary>
    public partial class DeleteProduct : Window
    {
        public DeleteProduct()
        {
            InitializeComponent();
        }
        ProductViewModel vm = new ProductViewModel();

        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            vm.CallDeleteProduct(prodName.Text);
            Hide();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
    }
}
