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
    /// Interaction logic for ManageStock.xaml
    /// </summary>
    public partial class ManageStock : Window
    {
        public ManageStock()
        {
            InitializeComponent();
            dpDate.SelectedDate = DateTime.Today;
            udpDate.SelectedDate = DateTime.Today;
            this.Pick1.SelectedDate = DateTime.Today;
            this.Pick2.SelectedDate = DateTime.Today;
        }

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            Item newItem = new Item();
            newItem.id = this.id.Text;
            newItem.price = Int32.Parse(this.price.Text);
            newItem.Catagory = this.catagory.Text;
            newItem.size = Int32.Parse(this.size.Text);
            newItem.color = this.color.Text;
            newItem.brand = this.brand.Text;
            newItem.date = DateTime.Today;
            PLayer AddItem = new PLayer();
            int count = AddItem.insertItem(newItem);
            if (count > 0)
            {
                Status.Content = "Item Inserted";
                this.id.Text = "";
                this.price.Text = "";
                this.catagory.Text = "";
                this.size.Text = "";
                this.color.Text = "";
                this.brand.Text = "";
                this.dpDate.SelectedDate = DateTime.Today;
            }
            else
            {
                Status.Content = "No Item inserted...";
                this.id.Text = "";
                this.price.Text = "";
                this.catagory.Text = "";
                this.size.Text = "";
                this.color.Text = "";
                this.brand.Text = "";
                this.dpDate.SelectedDate = DateTime.Today;
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            admin newAdmin = new admin();
            newAdmin.Show();
            this.Close(); 
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            PLayer newLayer = new PLayer();
            Item toUpdate = newLayer.fetchItem(this.uid.Text);
            if(toUpdate != null)
            {
                uStatus.Content = " ";
                this.uid.Text = toUpdate.id;
                this.uprice.Text = toUpdate.price.ToString();
                this.ucatagory.Text = toUpdate.Catagory;
                this.usize.Text = toUpdate.size.ToString();
                this.ucolor.Text = toUpdate.color;
                this.ubrand.Text = toUpdate.brand;
                this.udpDate.SelectedDate = toUpdate.date;
            }
            else
            {
                uStatus.Content = "INCORRECT ID";
            }
        }

        private void UpdateItem_Click(object sender, RoutedEventArgs e)
        {
            Item newItem = new Item();
            newItem.id = this.uid.Text;
            newItem.price = Int32.Parse(this.uprice.Text);
            newItem.Catagory = this.ucatagory.Text;
            newItem.size = Int32.Parse(this.usize.Text);
            newItem.color = this.ucolor.Text;
            newItem.brand = this.ubrand.Text;
            newItem.date = this.udpDate.SelectedDate.Value.Date;
            PLayer toUpdate = new PLayer();
            int count = toUpdate.updateItem(newItem);
            if (count > 0)
            {
                uStatus.Content = "Item Updated";
                this.uid.Text = "";
                this.uprice.Text = "";
                this.ucatagory.Text = "";
                this.usize.Text = "";
                this.ucolor.Text = "";
                this.ubrand.Text = "";
                this.udpDate.SelectedDate = DateTime.Today;
            }
            else
            {
                uStatus.Content = "No Item Updated...";
                this.uid.Text = "";
                this.uprice.Text = "";
                this.ucatagory.Text = "";
                this.usize.Text = "";
                this.ucolor.Text = "";
                this.ubrand.Text = "";
                this.udpDate.SelectedDate = DateTime.Today;
            }
        }

        private void DeleteItem_Click(object sender, RoutedEventArgs e)
        {
            PLayer newLayer = new PLayer();
            int count = newLayer.DeleteItem(this.did.Text);
            if (count > 0)
            {
                dStatus.Content = "Item Deleted";
                this.did.Text = "";
                this.dprice.Text = "";
                this.dcatagory.Text = "";
                this.dsize.Text = "";
                this.dcolor.Text = "";
                this.dbrand.Text = "";
                this.ddpDate.SelectedDate = DateTime.Today;

            }
            else
            {
                dStatus.Content = "No Item Deleted...";
                this.did.Text = "";
                this.dprice.Text = "";
                this.dcatagory.Text = "";
                this.dsize.Text = "";
                this.dcolor.Text = "";
                this.dbrand.Text = "";
                this.ddpDate.SelectedDate = DateTime.Today;
            }
        }

        private void dSearch_Click(object sender, RoutedEventArgs e)
        {
            PLayer newLayer = new PLayer();
            Item toUpdate = newLayer.fetchItem(this.did.Text);
            if (toUpdate != null)
            {
                dStatus.Content = " ";
                this.did.Text = toUpdate.id;
                this.dprice.Text = toUpdate.price.ToString();
                this.dcatagory.Text = toUpdate.Catagory;
                this.dsize.Text = toUpdate.size.ToString();
                this.dcolor.Text = toUpdate.color;
                this.dbrand.Text = toUpdate.brand;
                this.ddpDate.SelectedDate = toUpdate.date;
            }
            else
            {
                dStatus.Content = "INCORRECT ID";
            }
        }

        private void StockReport_Click(object sender, RoutedEventArgs e)
        {
            DateTime lowerDate = this.Pick1.SelectedDate.Value.Date;
            DateTime upperDate = this.Pick2.SelectedDate.Value.Date;
            PLayer newLayer = new PLayer();
            List<Item> ls = newLayer.fetchAllItems(lowerDate, upperDate);
            this.myls.ItemsSource = ls;
        }

        private void TabItem_Selected(object sender, RoutedEventArgs e)
        {
            PLayer newLayer = new PLayer();
            List<Item> ls = newLayer.fetchAllItems();
            this.myls.ItemsSource = ls;
        }
    }
}
