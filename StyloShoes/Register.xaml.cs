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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            admin newAdmin = new admin();
            newAdmin.Show();
            this.Close();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            if (this.pass1.Password == this.pass2.Password)
            {
                Member newMember = new Member();
                newMember.username = username.Text;
                newMember.name = this.name.Text;
                newMember.pass = this.pass1.Password;
                newMember.status = this.status.Text;
                PLayer newLayer = new PLayer();
                int count = newLayer.RegisterNew(newMember);
                if(count > 0)
                {
                    this.Error.Content = "Member Registered!";
                    this.username.Text = "";
                    this.name.Text = "";
                    this.pass1.Password = "";
                    this.pass2.Password = "";
                    this.status.Text = "";
                }
                else
                {
                    this.Error.Content = "Member Couldn't Registered!";
                    this.username.Text = "";
                    this.name.Text = "";
                    this.pass1.Password = "";
                    this.pass2.Password = "";
                    this.status.Text = "";
                }
            }
            else
            {
                this.Error.Content = "Password Mismatch!";
            }
        }
    }
}
