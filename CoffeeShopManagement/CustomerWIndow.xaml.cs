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
using MySql.Data.MySqlClient;
using System.Data;

namespace CoffeeShopManagement
{
    /// <summary>
    /// Interaction logic for CustomerWIndow.xaml
    /// </summary>
    public partial class CustomerWIndow : Window
    {

        HomeWindow hw = null;
        MainWindow mw = null;
       

        public CustomerWIndow(HomeWindow passedwindow,MainWindow login)
        {
            InitializeComponent();
            this.hw = passedwindow;
            this.mw = login;

           
        }

       

        private void btnCustdelete_Click(object sender, RoutedEventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=;database=coffeeshopms;";

            string query = "DELETE FROM ordertable WHERE ordrno='"+this.ordrno_txt.Text+"'";

            MySqlConnection mySqlConnection = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand(query,mySqlConnection);
            MySqlDataReader myReader;

            try
            {
                mySqlConnection.Open();
                myReader = SelectCommand.ExecuteReader();
                MessageBox.Show("deleted!");
                mySqlConnection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCustupdate_Click(object sender, RoutedEventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=;database=coffeeshopms;";

            string query = "UPDATE ordertable SET custname='"+this.custname_txt.Text+"',ordrno='"+this.ordrno_txt.Text+"',ordrdetls='"+this.ordrdtls_txt.Text+"',contactno='"+this.custcntct_txt.Text+"',totalbill='"+this.bill_txt.Text+"' WHERE ordrno='"+this.ordrno_txt.Text+"' ";

            MySqlConnection mySqlConnection = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand(query, mySqlConnection);
            MySqlDataReader myReader;

            try
            {
                mySqlConnection.Open();
                myReader = SelectCommand.ExecuteReader();
                MessageBox.Show("updated!");
                mySqlConnection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCustsave_Click(object sender, RoutedEventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=;database=coffeeshopms;";

            string query = "INSERT INTO ordertable (custname,ordrno,ordrdetls,contactno,totalbill) VALUES ('"+this.custname_txt.Text+"','"+this.ordrno_txt.Text+"','"+this.ordrdtls_txt.Text+"','"+this.custcntct_txt.Text+"','"+this.bill_txt.Text+"') ";

            MySqlConnection mySqlConnection = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand(query, mySqlConnection);
            MySqlDataReader myReader;

            try
            {
                mySqlConnection.Open();
                myReader = SelectCommand.ExecuteReader();
                MessageBox.Show("saved!");
                mySqlConnection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        private void btnCustback_Click(object sender, RoutedEventArgs e)
        {
            hw.Show();
            this.Hide();
           
        }

        private void btnCustlogout_Click(object sender, RoutedEventArgs e)
        {
            mw.Show();
            this.Hide();
        }

        private void btnCustExit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void btncustshowall_Click(object sender, RoutedEventArgs e)
        {


            string myConnection = "datasource=localhost;port=3306;username=root;password=;database=coffeeshopms;";
            MySqlConnection mySqlConnection = new MySqlConnection(myConnection);
            
            

            try
            {
                mySqlConnection.Open();
                string query = "SELECT custname,ordrno,ordrdetls,contactno,totalbill FROM ordertable";
                MySqlCommand SelectCommand = new MySqlCommand(query, mySqlConnection);
                SelectCommand.ExecuteNonQuery();

                MySqlDataAdapter dataAdp = new MySqlDataAdapter(SelectCommand);
                DataTable dt = new DataTable("ordetable");
                dataAdp.Fill(dt);
                custDatagrid.ItemsSource = dt.DefaultView;
                dataAdp.Update(dt);

                mySqlConnection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
