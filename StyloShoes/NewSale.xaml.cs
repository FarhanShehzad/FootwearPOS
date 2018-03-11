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
using System.IO;


namespace StyloShoes
{
    /// <summary>
    /// Interaction logic for NewSale.xaml
    /// </summary>
    public partial class NewSale : Window
    {
        public NewSale()
        {
            InitializeComponent();
            this.udpDate.SelectedDate = DateTime.Today;
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            PLayer newLayer = new PLayer();
            Item toUpdate = newLayer.fetchItem(this.uid.Text);
            if (toUpdate != null)
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
                this.uid.Text = "";
                this.uprice.Text = "";
                this.ucatagory.Text = "";
                this.usize.Text = "";
                this.ucolor.Text = "";
                this.ubrand.Text = "";
                this.udpDate.SelectedDate = DateTime.Today;
                this.reciept.Text = "";
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Staff newWindow = new Staff();
            newWindow.Show();
            this.Close();
        }

        private void NewSale_Click(object sender, RoutedEventArgs e)
        {
            uStatus.Content = "";
            this.uid.Text = "";
            this.uprice.Text = "";
            this.ucatagory.Text = "";
            this.usize.Text = "";
            this.ucolor.Text = "";
            this.ubrand.Text = "";
            this.udpDate.SelectedDate = DateTime.Today;
            this.reciept.Text = "";
        }

        private void ShowSales_Click(object sender, RoutedEventArgs e)
        {
            if(this.uprice.Text == "" || this.uid.Text == "")
            {
                uStatus.Content = "Please Verify the Product ID!";
            }
            else
            {
                reciept.Inlines.Add(new Run("\t         EFSI PURCHASE RECIEPT\n"));
                reciept.Inlines.Add(new Run("\t15/12 NEW MARKET, KISHOREGAN\n"));
                reciept.Inlines.Add(new Run("   Cell: +880-1711-360899 / +880-1919-360899\n"));
                reciept.Inlines.Add(new Run("Product ID\t\t" + this.uid.Text + "\n"));
                reciept.Inlines.Add(new Run("Price\t\t\t" + this.uprice.Text + "\n"));
                reciept.Inlines.Add(new Run("Color\t\t\t" + this.ucolor.Text + "\n"));
                reciept.Inlines.Add(new Run("Size\t\t\t" + this.ucatagory.Text + "\n"));
                reciept.Inlines.Add(new Run("Brand\t\t\t" + this.ubrand.Text + "\n"));
                reciept.Inlines.Add(new Run("Purchase Date\t\t" + this.udpDate.Text + "\n"));

            }
        }

        private void Purchase_Click(object sender, RoutedEventArgs e)
        {
            if (this.uprice.Text == "" || this.uid.Text == "")
            {
                uStatus.Content = "Please Verify the Product ID!";
            }
            else
            {
                Item newItem = new Item();
                newItem.id = this.uid.Text;
                newItem.price = Int32.Parse(this.uprice.Text);
                newItem.Catagory = this.ucatagory.Text;
                newItem.size = Int32.Parse(this.usize.Text);
                newItem.color = this.ucolor.Text;
                newItem.brand = this.ubrand.Text;
                newItem.date = DateTime.Today;
                PLayer newLayer = new PLayer();
                int count = newLayer.NewSale(newItem);
                if (count > 0)
                {
                    uStatus.Content = "Item Sold...";
                    this.uid.Text = "";
                    this.uprice.Text = "";
                    this.ucatagory.Text = "";
                    this.usize.Text = "";
                    this.ucolor.Text = "";
                    this.ubrand.Text = "";
                    this.udpDate.SelectedDate = DateTime.Today;
                    this.reciept.Text = "";
                }
                else
                {
                    uStatus.Content = "An Error Occurred...";
                    this.uid.Text = "";
                    this.uprice.Text = "";
                    this.ucatagory.Text = "";
                    this.usize.Text = "";
                    this.ucolor.Text = "";
                    this.ubrand.Text = "";
                    this.udpDate.SelectedDate = DateTime.Today;
                }
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (this.uprice.Text == "" || this.uid.Text == "")
            {
                uStatus.Content = "Please Verify the Product ID!";
            }
            else
            {
                FileStream fin;
                fin = new FileStream(this.uid.Text + ".txt", FileMode.OpenOrCreate, FileAccess.Write);                
                StreamWriter sr = new StreamWriter(fin);
                StringBuilder sb = new StringBuilder("\t   EFSI PURCHASE RECIEPT\n");
                sb.Append("\t15/12 NEW MARKET, KISHOREGAN\n");
                sb.Append("   Cell: +880-1711-360899 / +880-1919-360899\n");
                sb.Append("Product ID\t\t" + this.uid.Text + "\n");
                sb.Append("Price\t\t\t" + this.uprice.Text + "\n");
                sb.Append("Color\t\t\t" + this.ucolor.Text + "\n");
                sb.Append("Size\t\t\t" + this.ucatagory.Text + "\n");
                sb.Append("Brand\t\t\t" + this.ubrand.Text + "\n");
                sb.Append("Purchase Date\t" + this.udpDate.Text + "\n");
                sr.Write(sb);
                sr.Close();
                fin.Close();
                uStatus.Content = "Reciept Saved with Name: " + this.uid.Text + ".txt";
            }
        }
    }
}
