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
    /// Interaction logic for CoffeeWindow.xaml
    /// </summary>
    public partial class CoffeeWindow : Window
    {
        HomeWindow hw = null;

        public CoffeeWindow(HomeWindow passedwindow)
        {
            InitializeComponent();
            this.hw = passedwindow;
        }

        private void btnCoffeeSave_Click(object sender, RoutedEventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=;database=coffeeshopms;";

            string query = "INSERT INTO coffee (coffid,coffname,coffprice) VALUES ('"+this.coffid_txt.Text+"','"+this.coffname_txt.Text+"','"+this.coffprice_txt.Text+"') ";

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

        private void btnCoffeeDelete_Click(object sender, RoutedEventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=;database=coffeeshopms;";

            string query = "DELETE FROM coffee WHERE coffid='"+this.coffid_txt.Text+"'";

            MySqlConnection mySqlConnection = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand(query, mySqlConnection);
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

        private void btnCoffeeUpdate_Click(object sender, RoutedEventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=;database=coffeeshopms;";

            string query = "UPDATE coffee SET  coffid='" + this.coffid_txt.Text + "',coffname='" + this.coffname_txt.Text + "',coffprice='" + this.coffprice_txt.Text + "'  WHERE coffid='"+this.coffid_txt.Text+"'";

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

        private void btnCoffeeBack_Click(object sender, RoutedEventArgs e)
        {
            hw.Show();
            this.Hide();
        }

        private void btnCofExit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void btncoffshowall_Click(object sender, RoutedEventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=;database=coffeeshopms;";
            MySqlConnection mySqlConnection = new MySqlConnection(myConnection);



            try
            {
                mySqlConnection.Open();
                string query = "SELECT coffid,coffname,coffprice FROM coffee";
                MySqlCommand SelectCommand = new MySqlCommand(query, mySqlConnection);
                SelectCommand.ExecuteNonQuery();

                MySqlDataAdapter dataAdp = new MySqlDataAdapter(SelectCommand);
                DataTable dt = new DataTable("coffee");
                dataAdp.Fill(dt);
                coffDatagrid.ItemsSource = dt.DefaultView;
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
