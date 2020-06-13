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

namespace CoffeeShopManagement
{
    /// <summary>
    /// Interaction logic for EmployeeWindow.xaml
    /// </summary>
    public partial class EmployeeWindow : Window
    {

        HomeWindow hw = null;
        MainWindow mw = null;

        public EmployeeWindow(HomeWindow passedwindow,MainWindow login)
        {
            InitializeComponent();
            this.hw = passedwindow;
            this.mw = login;
        }

        private void btnEmpSave_Click(object sender, RoutedEventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=;database=coffeeshopms;";

            string query = "INSERT INTO employee (empid,empname,empdesi,empsal,empphn,empadd,empnid) VALUES ('"+this.empid_txt.Text+"','"+this.empname_txt.Text+"','"+this.empdesi_txt.Text+"','"+this.empsal_txt.Text+"','"+this.empphn_txt.Text+"','"+this.empadd_txt.Text+"','"+this.empnid_txt.Text+"')";

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

        private void btnEmpDelete_Click(object sender, RoutedEventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=;database=coffeeshopms;";

            string query = "DELETE FROM employee WHERE empid='"+this.empid_txt.Text+"'";

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

        private void btnEmpUpdate_Click(object sender, RoutedEventArgs e)
        {
            string myConnection = "datasource=localhost;port=3306;username=root;password=;database=coffeeshopms;";

            string query = "UPDATE employee SET  empid='" + this.empid_txt.Text + "',empname='" + this.empname_txt.Text + "',empdesi='" + this.empdesi_txt.Text + "',empsal='" + this.empsal_txt.Text + "',empphn='" + this.empphn_txt.Text + "',empadd='" + this.empadd_txt.Text + "',empnid='" + this.empnid_txt.Text + "'  WHERE empid='"+this.empid_txt.Text+"' ";

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

        private void btnEmpLogout_Click(object sender, RoutedEventArgs e)
        {
            mw.Show();
            this.Hide();
        }

        private void btnEmpBack_Click(object sender, RoutedEventArgs e)
        {
            hw.Show();
            this.Hide();
        }

        private void btnEmpExit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
