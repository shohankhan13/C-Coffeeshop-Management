using System;
using System.Collections.Generic;
using System.Text;
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
    /// Interaction logic for HomeWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {
        MainWindow mw = null;
        
        public HomeWindow(MainWindow mw)
        {
            InitializeComponent();
            this.mw = mw;
        }

        

        private void btncustomer_Click(object sender, RoutedEventArgs e)
        {
            CustomerWIndow cw = new CustomerWIndow(this, mw);
            cw.Show();
            this.Hide();
        }

        private void btnemployee_Click(object sender, RoutedEventArgs e)
        {
            EmployeeWindow ew= new EmployeeWindow(this, mw);
            ew.Show();
            this.Hide();

        }

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            //MainWindow mw = new MainWindow();
            mw.Show();
            //mainwindow.Show();
            this.Hide();
        }

        private void btncoffee_Click(object sender, RoutedEventArgs e)
        {
            CoffeeWindow cfw = new CoffeeWindow(this);
            cfw.Show();
            this.Hide();
        }

        private void btnlogout_Click(object sender, RoutedEventArgs e)
        {
            mw.Show();
            this.Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
