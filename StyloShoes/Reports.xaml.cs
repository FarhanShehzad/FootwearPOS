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
    /// Interaction logic for Reports.xaml
    /// </summary>
    public partial class Reports : Window
    {
        public Reports()
        {
            InitializeComponent();
            this.Pick1.SelectedDate = DateTime.Today;
            this.Pick2.SelectedDate = DateTime.Today;
            this.sPick1.SelectedDate = DateTime.Today;
            this.sPick2.SelectedDate = DateTime.Today;
            this.gPick1.SelectedDate = DateTime.Today;
            this.gPick2.SelectedDate = DateTime.Today;
        }

        private void StockReport_Selected(object sender, RoutedEventArgs e)
        {
            PLayer newLayer = new PLayer();
            List<Item> ls = newLayer.fetchAllItems();
            this.myls.ItemsSource = ls;
        }

        private void StockReport_Click(object sender, RoutedEventArgs e)
        {
            DateTime lowerDate = this.Pick1.SelectedDate.Value.Date;
            DateTime upperDate = this.Pick2.SelectedDate.Value.Date;
            PLayer newLayer = new PLayer();
            List<Item> ls = newLayer.fetchAllItems(lowerDate, upperDate);
            this.myls.ItemsSource = ls;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Staff newWindow = new Staff();
            newWindow.Show();
            this.Close();
        }

        private void SalesReport_Selected(object sender, RoutedEventArgs e)
        {
            PLayer newLayer = new PLayer();
            List<Sale> ls = newLayer.fetchAllSales();
            this.smyls.ItemsSource = ls;
            
        }

        private void SearchSales_Click(object sender, RoutedEventArgs e)
        {
            DateTime lowerDate = this.sPick1.SelectedDate.Value.Date;
            DateTime upperDate = this.sPick2.SelectedDate.Value.Date;
            PLayer newLayer = new PLayer();
            List<Sale> ls = newLayer.fetchAllSales(lowerDate, upperDate);
            this.smyls.ItemsSource = ls;
        }

        private void ServiceReport_Selected(object sender, RoutedEventArgs e)
        {
            PLayer newLayer = new PLayer();
            List<Service> ls = newLayer.fetchAllServices();
            
            this.gmyls.ItemsSource = ls;
        }

        private void SearchServices_Click(object sender, RoutedEventArgs e)
        {
            DateTime lowerDate = this.gPick1.SelectedDate.Value.Date;
            DateTime upperDate = this.gPick2.SelectedDate.Value.Date;
            PLayer newLayer = new PLayer();
            List<Service> ls = newLayer.fetchAllServices(lowerDate, upperDate);
            
            this.gmyls.ItemsSource = ls;
        }
    }
}
