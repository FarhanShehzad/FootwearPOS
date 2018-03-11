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
using PL;

namespace StyloShoes
{
    /// <summary>
    /// Interaction logic for UpdatePassword.xaml
    /// </summary>
    public partial class UpdatePassword : Window
    {
        private Member user;

        public UpdatePassword()
        {
            InitializeComponent();
        }

        public UpdatePassword(Member user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if(this.pass1.Password != this.pass2.Password)
            {
                this.Error.Content = "Password isn't same...";
            }
            else
            {
                PLayer newLayer = new PLayer();
                int count = newLayer.UpdatePassword(this.username.Text, this.pass1.Password);
                if(count > 0)
                {
                    this.Error.Content = "Password Updated!";
                }
                else
                {
                    this.Error.Content = "ERROR! ID doesn't found!";
                }
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            admin newAdmin = new admin();
            newAdmin.Show();
            this.Close();
        }
    }
}
