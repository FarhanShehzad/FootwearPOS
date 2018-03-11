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
using BussinesObject;

namespace StyloShoes
{
    /// <summary>
    /// Interaction logic for admin.xaml
    /// </summary>
    public partial class admin : Window
    {
        private Member user;

        public admin()
        {
            InitializeComponent();
        }

        public admin(Member userObject)
        {
            this.user = userObject;
            InitializeComponent();
        }

        private void logout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow login = new MainWindow();
            login.Show();
            this.Close();
        }

        private void ManageStock_Click(object sender, RoutedEventArgs e)
        {
            ManageStock newWindow = new ManageStock();
            newWindow.Show();
            this.Close();
        }

        private void sales_report_png_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SalesReport newWindow = new SalesReport();
            newWindow.Show();
            this.Close();
        }

        private void Services_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void ChangePass_Click(object sender, MouseButtonEventArgs e)
        {
            UpdatePassword newWindow = new UpdatePassword(user);
            newWindow.Show();
            this.Close();
        }

        private void Staff_Click(object sender, MouseButtonEventArgs e)
        {
            Register newWindow = new Register();
            newWindow.Show();
            this.Close();
        }
    }
}
