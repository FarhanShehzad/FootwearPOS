using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesObject
{
    public class Member
    {
        public int id { get; set; }
        public String username { get; set; }
        public String name { get; set; }
        public String pass { get; set; }
        public String status { get; set; }
    }
    public class Item
    {
        public String id { get; set; }
        public int price { get; set; }
        public String Catagory { get; set; }
        public int size { get; set; }
        public String color { get; set; }
        public String brand { get; set; }
        public DateTime date { get; set; }
    }

    public class Sale
    {
        public String id { get; set; }
        public int price { get; set; }
        public String catagory { get; set; }
        public int  size { get; set; }
        public String color { get; set; }
        public String brand { get; set; }
        public DateTime purchaseDate { get; set; }
    }

    public class Service
    {
        public int pk { get; set; }
        public String id { get; set; }
        public int price { get; set; }
        public String catagory { get; set; }
        public int size { get; set; }
        public String color { get; set; }
        public String brand { get; set; }
        public DateTime purchaseDate { get; set; }
        public String customerName { get; set; }
        public String address { get; set; }
        public String phone { get; set; }
        public DateTime serviceDate { get; set; }
        public DateTime returnDate { get; set; }
        public int serviceCharges { get; set; }
    }
}
