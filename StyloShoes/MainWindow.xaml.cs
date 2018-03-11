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
using System.Windows.Navigation;
using System.Windows.Shapes;
using BussinesObject;
using PL;

namespace StyloShoes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            if (this.id.Text != "")
            {
                String username = this.id.Text;
                String userPass = this.pass.Password;

                PLayer verify = new PLayer();
                Member userObject = verify.VerifyUser(username, userPass);
                if (userObject == null)
                {
                    this.ErrorMessage.Content = "INCORRECT Username or Password!";
                    ErrorMessage.Visibility = Visibility.Visible;
                }
                else if (userObject.status == "admin")
                {
                    admin adminMember = new admin(userObject);
                    adminMember.Show();
                    this.Close();
                }
                else if (userObject.status == "staff")
                {
                    Staff StaffMember = new Staff(userObject);
                    StaffMember.Show();
                    this.Close();
                }
            }
            else
            {
                this.ErrorMessage.Content = "Enter Your ID and Password...";
                ErrorMessage.Visibility = Visibility.Visible;
            }
        }
    }
}
