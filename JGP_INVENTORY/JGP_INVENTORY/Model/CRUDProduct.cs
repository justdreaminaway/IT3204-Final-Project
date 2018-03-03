using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using System.Configuration;
using JGP_INVENTORY.View;


namespace JGP_INVENTORY.Model
{
    class CRUDProduct
    {
        MySqlConnection conn = new
        MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

        public void AddProduct(String prod_name, int prod_qty, int prod_price)
        {
            //SqlConnection con = new SqlConnection("Data Source=TESTPURU;Initial Catalog=Data;User ID=sa;Password=wintellect");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO product (prod_name, prod_qty, prod_price, prod_id) VALUES ('"+prod_name+"', '"+prod_qty+"', '"+prod_price+"', NULL)", conn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void EditProduct(String prod_name, int prod_qty, String prod_price, int prod_id)
        {
            SqlConnection con = new SqlConnection("Data Source=TESTPURU;Initial Catalog=Data;User ID=sa;Password=wintellect");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE product SET prod_name = "+prod_name+", prod_qty = "+prod_qty+" , prod_price = "+prod_price+" WHERE prod_id = "+prod_id , con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void DeleteProduct(String prod_name)

        {
            //SqlConnection con = new SqlConnection("Data Source=TESTPURU;Initial Catalog=Data;User ID=sa;Password=wintellect");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM product WHERE prod_name = '"+prod_name+"'", conn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public DataSet SearchProduct(String prod_name)
        {
           // SqlConnection con = new SqlConnection("Data Source=TESTPURU;Initial Catalog=Data;User ID=sa;Password=wintellect");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM product WHERE prod_name = "+prod_name, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds, "LoadDataBinding");
            return ds;
        }
        public DataSet DisplayProduct()
        {
            /*
            SqlConnection con = new SqlConnection("Data Source=TESTPURU;Initial Catalog=Data;User ID=sa;Password=wintellect");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM product", con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            */

            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM product", conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds, "LoadDataBinding");
            conn.Close();
            return ds;
        }
        public String Register(String User, String Password, String ConfirmPass )
        {
            String text;
            if (User.Length == 0)
            {
                text = "Enter a username.";
                return text;
                //textBoxEmail.Focus();
            }
            /* else if (!Regex.IsMatch(textBoxEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
             {
                 errormessage.Text = "Enter a valid email.";
                 textBoxEmail.Select(0, textBoxEmail.Text.Length);
                 textBoxEmail.Focus();
             }*/
            else
            {
                //  string firstname = textBoxFirstName.Text;
                //  string lastname = textBoxLastName.Text;
                string email = User;
                string password = Password;
                if (Password.Length == 0)
                {
                    text = "Enter password.";
                    return text;
                   // passwordBox1.Focus();
                }
                else if (ConfirmPass.Length == 0)
                {
                    text = "Enter Confirm password.";
                    return text;
                  //  passwordBoxConfirm.Focus();
                }
                else if (Password != ConfirmPass)
                {
                    text = "Confirm password must be same as password.";
                    return text;
                   // ConfirmPass.Focus();
                }
                else
                {
                    text = "";
                    // string address = textBoxAddress.Text;
                    // SqlConnection con = new SqlConnection("Data Source=TESTPURU;Initial Catalog=Data;User ID=sa;Password=wintellect");
                    conn.Open();

                    // Call the function from the View Model, then the View Model will call the 
                    // Model to execute these codes below and return the results here



                    /*
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM product", conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adp.Fill(ds, "LoadDataBinding");
                    dataGridCustomers.DataContext = ds;
                    */
                    MySqlCommand cmd = new MySqlCommand("Insert into users (Username,Password) values('" + email + "','" + password + "')", conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    text = "You have Registered successfully.";
                    
                  //  Reset();
                    return text;
                }
            }
        }
        public String Login(String User, String Pass)
        {
            String Text;
            if (User.Length == 0)
            {
                Text = "Enter your username.";
                //textBoxEmail.Focus();
            }
            else
            {
                string email = User;
                string password = Pass;
                // SqlConnection con = new SqlConnection("Data Source=TESTPURU;Initial Catalog=Data;User ID=sa;Password=wintellect");
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("Select * from users where username='" + email + "'  and password='" + password + "'", conn);
                cmd.CommandType = CommandType.Text;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    
                    string username = dataSet.Tables[0].Rows[0]["Username"].ToString();
                    // page.Welcome(username);//Sending value from one form to another form.
                    //page.Welcome.Content = username;
                    Text = username;
                }
                else
                {
                    Text = "Sorry! Please enter existing username/password.";
                }
                conn.Close();
              
            }
            return Text;
        }
     
    }
}
