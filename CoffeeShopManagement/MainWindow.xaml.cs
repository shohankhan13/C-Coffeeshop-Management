using System;
using System.Collections.Generic;
using System.ComponentModel;
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

using MySql.Data.MySqlClient;

namespace CoffeeShopManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HomeWindow hw = null;
        
        public MainWindow()
        {
            InitializeComponent();
            
        }

        void DataWindow_Closing(object sender, CancelEventArgs e)
        {
            if (hw != null)
            {
                hw.Close();
                hw = null;
            }

        }

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            try {

                string myConnection = "datasource=localhost;port=3306;username=root;password=";

                MySqlConnection mySqlConnection = new MySqlConnection(myConnection);
                MySqlCommand SelectCommand = new MySqlCommand("select * from coffeeshopms.userinfo where username='"+this.user_text.Text+"' and password='"+this.pass_text.Password+"' ;", mySqlConnection);
                MySqlDataReader myReader;
                

                mySqlConnection.Open();
                myReader = SelectCommand.ExecuteReader();

                
                if (myReader.Read())
                {
                    MessageBox.Show("Username and Password is correct!");
                    hw = new HomeWindow(this);
                    hw.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("invalid username or password!");
                }
                mySqlConnection.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnclear_Click(object sender, RoutedEventArgs e)
        {
            user_text.Clear();
            pass_text.Clear();
        }

        private void btnLoginExit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
