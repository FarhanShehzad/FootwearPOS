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
using System.IO;

namespace StyloShoes
{
    /// <summary>
    /// Interaction logic for CutomerService.xaml
    /// </summary>
    public partial class CutomerService : Window
    {
        public CutomerService()
        {
            InitializeComponent();
            this.uServiceDate.SelectedDate = DateTime.Today;
            this.uReturnDate.SelectedDate = DateTime.Today.AddDays(15);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Staff newWindow = new Staff();
            newWindow.Show();
            this.Close();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            PLayer newLayer = new PLayer();
            Sale toUpdate = newLayer.fetchSale(this.uid.Text);
            if (toUpdate != null)
            {
                uStatus.Content = "";
                this.uid.Text = toUpdate.id;
                this.uprice.Text = toUpdate.price.ToString();
                this.ucatagory.Text = toUpdate.catagory;
                this.usize.Text = toUpdate.size.ToString();
                this.ucolor.Text = toUpdate.color;
                this.ubrand.Text = toUpdate.brand;
                this.udpDate.SelectedDate = toUpdate.purchaseDate;
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
                this.uname.Text = "";
                this.uphone.Text = "";
                this.uaddress.Text = "";
                this.ucharges.Text = "";
            }
        }

        private void NewService_Click(object sender, RoutedEventArgs e)
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
            this.uname.Text = "";
            this.uphone.Text = "";
            this.ucharges.Text = "";
            this.uaddress.Text = "";
            this.uServiceDate.SelectedDate = DateTime.Today;
            this.uReturnDate.SelectedDate = DateTime.Today.AddDays(15);
        }

        private void ShowService_Click(object sender, RoutedEventArgs e)
        {
            if (this.uprice.Text == "" || this.uid.Text == "" || this.uname.Text == "" || this.ucharges.Text == "" || this.uphone.Text == "")
            {
                uStatus.Content = "Some Fields are Missing!";
            }
            else
            {
                reciept.Inlines.Add(new Run("\t         Stylo PURCHASE RECIEPT\n"));
                reciept.Inlines.Add(new Run("\t15/12 NEW MARKET, KISHOREGAN\n"));
                reciept.Inlines.Add(new Run("   Cell: +880-1711-360899 / +880-1919-360899\n"));
                reciept.Inlines.Add(new Run("Product ID\t\t" + this.uid.Text + "\n"));
                reciept.Inlines.Add(new Run("Purchase Date\t\t" + this.udpDate.Text + "\n"));
                reciept.Inlines.Add(new Run("Customer Name\t\t" + this.uname.Text + "\n"));
                reciept.Inlines.Add(new Run("Address\t\t\t" + this.uaddress.Text + "\n"));
                reciept.Inlines.Add(new Run("Phone\t\t\t" + this.uphone.Text + "\n"));
                reciept.Inlines.Add(new Run("Service Date\t\t" + this.uServiceDate.Text + "\n"));
                reciept.Inlines.Add(new Run("Return Date\t\t\t" + this.uReturnDate.Text + "\n"));
                reciept.Inlines.Add(new Run("Service Charges\t\t" + this.ucharges.Text + "\n"));
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (this.uprice.Text == "" || this.uid.Text == "" || this.uname.Text == "" || this.ucharges.Text == "" || this.uphone.Text == "")
            {
                uStatus.Content = "Some Fields are Missing!";
            }
            else
            {
                FileStream fin;
                fin = new FileStream("Service_"+this.uid.Text + ".txt", FileMode.OpenOrCreate, FileAccess.Write);
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
                sb.Append("Customer Name\t\t\t" + this.uname.Text + "\n");
                sb.Append("Address\t\t" + this.uaddress.Text + "\n");
                sb.Append("Phone\t\t\t" + this.uphone.Text + "\n");
                sb.Append("Service Date\t\t" + this.uServiceDate.Text + "\n");
                sb.Append("Return Date\t\t\t" + this.uReturnDate.Text + "\n");
                sb.Append("Service Charges\t\t" + this.ucharges.Text + "\n");
                sr.Write(sb);
                sr.Close();
                fin.Close();
                uStatus.Content = "Reciept Saved with Name: Service_" + this.uid.Text + ".txt";
            }
        }

        private void AddService_Click(object sender, RoutedEventArgs e)
        {
            if (this.uprice.Text == "" || this.uid.Text == "" || this.uname.Text == "" || this.ucharges.Text == "" || this.uphone.Text == "")
            {
                uStatus.Content = "Some Fields are Missing!";
            }
            else
            {
                Service newService = new Service();
                newService.id = this.uid.Text;
                newService.price = Int32.Parse(this.uprice.Text);
                newService.catagory = this.ucatagory.Text;
                newService.size = Int32.Parse(this.usize.Text);
                newService.color = this.ucolor.Text;
                newService.brand = this.ubrand.Text;
                newService.purchaseDate = this.udpDate.SelectedDate.Value.Date;
                newService.serviceDate = this.uServiceDate.SelectedDate.Value.Date;
                newService.returnDate = this.uReturnDate.SelectedDate.Value.Date;
                newService.serviceCharges = Int32.Parse(this.ucharges.Text);
                newService.customerName = this.uname.Text;
                newService.address = this.uaddress.Text;
                newService.phone = this.uphone.Text;
                PLayer newLayer = new PLayer();
                int count = newLayer.NewService(newService);
                if (count > 0)
                {
                    uStatus.Content = "Service Added...";
                    this.uid.Text = "";
                    this.uprice.Text = "";
                    this.ucatagory.Text = "";
                    this.usize.Text = "";
                    this.ucolor.Text = "";
                    this.ubrand.Text = "";
                    this.udpDate.SelectedDate = DateTime.Today;
                    this.reciept.Text = "";
                    this.uname.Text = "";
                    this.uphone.Text = "";
                    this.ucharges.Text = "";
                    this.uaddress.Text = "";
                    this.uServiceDate.SelectedDate = DateTime.Today;
                    this.uReturnDate.SelectedDate = DateTime.Today.AddDays(15);
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
                    this.reciept.Text = "";
                    this.uname.Text = "";
                    this.uphone.Text = "";
                    this.ucharges.Text = "";
                    this.uaddress.Text = "";
                    this.uServiceDate.SelectedDate = DateTime.Today;
                    this.uReturnDate.SelectedDate = DateTime.Today.AddDays(15);
                }
            }
        }

        private void Search1_Click(object sender, RoutedEventArgs e)
        {
            PLayer newLayer = new PLayer();
            Service toUpdate = newLayer.fetchService(this.id.Text);
            if (toUpdate != null)
            {
                Status.Content = "";
                this.id.Text = toUpdate.id;
                this.price.Text = toUpdate.price.ToString() ;
                this.catagory.Text = toUpdate.catagory;
                this.size.Text = toUpdate.size.ToString();
                this.color.Text = toUpdate.color;
                this.brand.Text = toUpdate.brand;
                this.dpDate.SelectedDate = toUpdate.purchaseDate;
                this.ReturnDate.SelectedDate = toUpdate.returnDate;
                this.ServiceDate.SelectedDate = toUpdate.serviceDate;
                this.name.Text = toUpdate.customerName;
                this.phone.Text = toUpdate.phone;
                this.charges.Text = toUpdate.serviceCharges.ToString() ;
                this.address.Text = toUpdate.address;
            }
            else
            {
                Status.Content = "INCORRECT ID";
                this.id.Text = "";
                this.price.Text = "";
                this.catagory.Text = "";
                this.size.Text = "";
                this.color.Text = "";
                this.brand.Text = "";
                this.dpDate.SelectedDate = DateTime.Today;
                this.name.Text = "";
                this.phone.Text = "";
                this.address.Text = "";
                this.charges.Text = "";
            }
        }

        private void UpdateService_Click(object sender, RoutedEventArgs e)
        {
            if (this.price.Text == "" || this.id.Text == "" || this.name.Text == "" || this.charges.Text == "" || this.phone.Text == "")
            {
                Status.Content = "Some Fields are Missing!";
            }
            else
            {
                Service newService = new Service();
                newService.id = this.id.Text;
                newService.price = Int32.Parse(this.price.Text);
                newService.catagory = this.catagory.Text;
                newService.size = Int32.Parse(this.size.Text);
                newService.color = this.color.Text;
                newService.brand = this.brand.Text;
                newService.purchaseDate = this.dpDate.SelectedDate.Value.Date;
                newService.serviceDate = this.ServiceDate.SelectedDate.Value.Date;
                newService.returnDate = this.ReturnDate.SelectedDate.Value.Date;
                newService.serviceCharges = Int32.Parse(this.charges.Text);
                newService.customerName = this.name.Text;
                newService.address = this.address.Text;
                newService.phone = this.phone.Text;
                PLayer newLayer = new PLayer();
                int count = newLayer.UpdateService(newService);
                if (count > 0)
                {
                    Status.Content = "Service Updated...";
                    this.id.Text = "";
                    this.price.Text = "";
                    this.catagory.Text = "";
                    this.size.Text = "";
                    this.color.Text = "";
                    this.brand.Text = "";
                    this.dpDate.SelectedDate = DateTime.Today;
                    this.name.Text = "";
                    this.phone.Text = "";
                    this.charges.Text = "";
                    this.address.Text = "";
                    this.ServiceDate.SelectedDate = DateTime.Today;
                    this.ReturnDate.SelectedDate = DateTime.Today.AddDays(15);
                }
                else
                {
                    Status.Content = "An Error Occurred...";
                    this.id.Text = "";
                    this.price.Text = "";
                    this.catagory.Text = "";
                    this.size.Text = "";
                    this.color.Text = "";
                    this.brand.Text = "";
                    this.dpDate.SelectedDate = DateTime.Today;
                    this.name.Text = "";
                    this.phone.Text = "";
                    this.charges.Text = "";
                    this.address.Text = "";
                    this.ServiceDate.SelectedDate = DateTime.Today;
                    this.ReturnDate.SelectedDate = DateTime.Today.AddDays(15);
                }
            }
        }

        private void Search2_Click(object sender, RoutedEventArgs e)
        {
            PLayer newLayer = new PLayer();
            Service toUpdate = newLayer.fetchService(this.vid.Text);
            if (toUpdate != null)
            {
                vStatus.Content = "";
                this.vid.Text = toUpdate.id;
                this.vprice.Text = toUpdate.price.ToString();
                this.vcatagory.Text = toUpdate.catagory;
                this.vsize.Text = toUpdate.size.ToString();
                this.vcolor.Text = toUpdate.color;
                this.vbrand.Text = toUpdate.brand;
                this.vdpDate.SelectedDate = toUpdate.purchaseDate;
                this.vReturnDate.SelectedDate = toUpdate.returnDate;
                this.vServiceDate.SelectedDate = toUpdate.serviceDate;
                this.vname.Text = toUpdate.customerName;
                this.vphone.Text = toUpdate.phone;
                this.vcharges.Text = toUpdate.serviceCharges.ToString();
                this.vaddress.Text = toUpdate.address;
            }
            else
            {
                vStatus.Content = "INCORRECT ID";
                this.vid.Text = "";
                this.vprice.Text = "";
                this.vcatagory.Text = "";
                this.vsize.Text = "";
                this.vcolor.Text = "";
                this.vbrand.Text = "";
                this.vdpDate.SelectedDate = DateTime.Today;
                this.vname.Text = "";
                this.vphone.Text = "";
                this.vaddress.Text = "";
                this.vcharges.Text = "";
            }
        }


    }
}
