using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;
using JGP_INVENTORY.ViewModel;

namespace JGP_INVENTORY.View
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
       // MySqlConnection Connection
        MySqlConnection conn = new
        MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        ProductViewModel vm = new ProductViewModel();
        addProduct addprod = new addProduct();
        DeleteProduct delprod = new DeleteProduct();
        public Page2()
        {
            InitializeComponent();
        }
        private void btnloaddata_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Call the function from the View Model, then the View Model will call the 
                // Model to execute these codes below and return the results here

                dataGridCustomers.DataContext = vm.CallDisplayProduct();
                
                /*
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM product", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "LoadDataBinding");
                dataGridCustomers.DataContext = ds;
                */
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            
        }

        private void searchBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dataGridCustomers.DataContext = vm.CallSearchProduct(searchBox.Text.ToString());
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            addprod.Show();
        }

        private void Close()
        {
            throw new NotImplementedException();
        }

        internal void Show()
        {
            throw new NotImplementedException();
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            delprod.Show();
        }
    }
}
