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
    /// Interaction logic for Staff.xaml
    /// </summary>
    public partial class Staff : Window
    {
        private Member userObject;

        public Staff()
        {
            InitializeComponent();
        }

        public Staff(Member userObject)
        {
            this.userObject = userObject;
            InitializeComponent();
        }

        private void NewSale_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NewSale newWindow = new NewSale();
            newWindow.Show();
            this.Close();
        }

        private void logout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow login = new MainWindow();
            login.Show();
            this.Close();
        }

        private void Reprots_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Reports newWindow = new Reports();
            newWindow.Show();
            this.Close();
        }

        private void CustomerService_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CutomerService newWindow = new CutomerService();
            newWindow.Show();
            this.Close();
        }
    }
}
