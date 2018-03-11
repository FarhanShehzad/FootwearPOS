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
using PL;
using BussinesObject;

namespace StyloShoes
{
    /// <summary>
    /// Interaction logic for SalesReport.xaml
    /// </summary>
    public partial class SalesReport : Window
    {
        public SalesReport()
        {
            InitializeComponent();
            this.Pick1.SelectedDate = DateTime.Today;
            this.Pick2.SelectedDate = DateTime.Today;
        }


        private void Back_Click(object sender, RoutedEventArgs e)
        {
            admin newAdmin = new admin();
            newAdmin.Show();
            this.Close();
        }

        private void SalesReport_Click(object sender, RoutedEventArgs e)
        {
            PLayer newLayer = new PLayer();
            List<Sale> ls = newLayer.fetchAllSales();
            this.myls.ItemsSource = ls;
        }

        private void SearchSales_Click(object sender, RoutedEventArgs e)
        {
            DateTime lowerDate = this.Pick1.SelectedDate.Value.Date;
            DateTime upperDate = this.Pick2.SelectedDate.Value.Date;
            PLayer newLayer = new PLayer();
            List<Sale> ls = newLayer.fetchAllSales(lowerDate, upperDate);
            this.myls.ItemsSource = ls;
        }
    }
}
