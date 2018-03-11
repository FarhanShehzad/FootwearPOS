using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesObject;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DAL
{
    public class DALayer
    {

        public Member fetchData(String username, String userPass = null)
        {
            Member accessedUser = new Member();
            String ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alibh\OneDrive\Pictures\Documents\Visual Studio 2015\Projects\StyloShoes\DAL\stylo.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String query;
            if(userPass != null)
            {
                query = "SELECt * from dbo.members where username = @username and password = @userPass";
            }
            else
            {
                query = "SELECt * from dbo.members where username = @username";
            }

            SqlCommand cmd = new SqlCommand(query, con);
            SqlParameter p1 = new SqlParameter("username", username);
            SqlParameter p2 = new SqlParameter("userPass", userPass);

            if (userPass != null)
            {
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
            }
            else
            {
                cmd.Parameters.Add(p1);
            }

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                accessedUser.id = (int)dr[0];
                accessedUser.username = (String)dr[1];
                accessedUser.name = (String)dr[2];
                accessedUser.pass = (String)dr[3];
                accessedUser.status = (String)dr[4];
                 
            }
            else
            {
                accessedUser = null;
            }
            con.Close();
            return accessedUser;
        }

        public Sale FetchSale(string id)
        {
            Sale accessedSale = new Sale();
            String ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alibh\OneDrive\Pictures\Documents\Visual Studio 2015\Projects\StyloShoes\DAL\stylo.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String query = "select * from dbo.sales where id='" + id + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                accessedSale.id = (String)dr[1];
                accessedSale.price = (int)dr[2];
                accessedSale.catagory = (String)dr[3];
                accessedSale.size = (int)dr[4];
                accessedSale.color = (String)dr[5];
                accessedSale.brand = (String)dr[6];
                accessedSale.purchaseDate = (DateTime)dr[7];
            }
            else
            {
                accessedSale = null;
            }

            con.Close();
            return accessedSale;
        }

        public List<Service> FetchAllServices()
        {
            List<Service> ls = new List<Service>();
            String ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alibh\OneDrive\Pictures\Documents\Visual Studio 2015\Projects\StyloShoes\DAL\stylo.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String query = "select * from dbo.services";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Service accessedService = new Service();
                accessedService.pk = (Int32)dr[0];
                accessedService.id = (String)dr[1];
                accessedService.price = (Int32)dr[2];
                accessedService.color = (String)dr[3];
                accessedService.size = (int)dr[4];
                accessedService.catagory = (String)dr[5];
                accessedService.brand = (String)dr[6];
                accessedService.customerName = (String)dr[7];
                accessedService.address = (String)dr[8];
                accessedService.phone = (String)dr[9];
                accessedService.purchaseDate = (DateTime)dr[10];
                accessedService.serviceDate = (DateTime)dr[11];
                accessedService.returnDate = (DateTime)dr[12];
                accessedService.serviceCharges = (int)dr[13];
                ls.Add(accessedService);
            }
            con.Close();
            return ls;
        }

        public List<Service> FetchAllServices(DateTime lowerDate, DateTime upperDate)
        {
            List<Service> ls = new List<Service>();
            String ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alibh\OneDrive\Pictures\Documents\Visual Studio 2015\Projects\StyloShoes\DAL\stylo.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String query = "select * from dbo.services where entry_date BETWEEN '" + lowerDate + "' AND '" + upperDate + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Service accessedService = new Service();
                accessedService.pk = (Int32)dr[0];
                accessedService.id = (String)dr[1];
                accessedService.price = (Int32)dr[2];
                accessedService.color = (String)dr[3];
                accessedService.size = (int)dr[4];
                accessedService.catagory = (String)dr[5];
                accessedService.brand = (String)dr[6];
                accessedService.customerName = (String)dr[7];
                accessedService.address = (String)dr[8];
                accessedService.phone = (String)dr[9];
                accessedService.purchaseDate = (DateTime)dr[10];
                accessedService.serviceDate = (DateTime)dr[11];
                accessedService.returnDate = (DateTime)dr[12];
                accessedService.serviceCharges = (int)dr[13];
                ls.Add(accessedService);
            }
            con.Close();
            return ls;
        }

        public int UpdateService(Service newService)
        {
            String ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alibh\OneDrive\Pictures\Documents\Visual Studio 2015\Projects\StyloShoes\DAL\stylo.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String query = "UPDATE dbo.services SET price = @price, catagory = @catagory, size = @size, color = @color, brand = @brand, purchase_date = @purchase_date, service_date = @service_date, return_date = @return_date, charges = @charges, customer_name = @customer_name, address = @address, phone = @phone WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlParameter p1 = new SqlParameter("id", newService.id);
            SqlParameter p2 = new SqlParameter("price", newService.price);
            SqlParameter p3 = new SqlParameter("catagory", newService.catagory);
            SqlParameter p4 = new SqlParameter("size", newService.size);
            SqlParameter p5 = new SqlParameter("color", newService.color);
            SqlParameter p6 = new SqlParameter("brand", newService.brand);
            SqlParameter p7 = new SqlParameter("purchase_date", newService.purchaseDate);
            SqlParameter p8 = new SqlParameter("customer_name", newService.customerName);
            SqlParameter p9 = new SqlParameter("address", newService.address);
            SqlParameter p10 = new SqlParameter("phone", newService.phone);
            SqlParameter p11 = new SqlParameter("charges", newService.serviceCharges);
            SqlParameter p12 = new SqlParameter("service_date", newService.serviceDate);
            SqlParameter p13 = new SqlParameter("return_date", newService.returnDate);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
            cmd.Parameters.Add(p8);
            cmd.Parameters.Add(p9);
            cmd.Parameters.Add(p10);
            cmd.Parameters.Add(p11);
            cmd.Parameters.Add(p12);
            cmd.Parameters.Add(p13);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public Service fetchService(string id)
        {
            Service accessedService = new Service();
            String ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alibh\OneDrive\Pictures\Documents\Visual Studio 2015\Projects\StyloShoes\DAL\stylo.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String query = "select * from dbo.services where id='" + id + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                accessedService.id = (String)dr[1];
                accessedService.price = (Int32)dr[2];
                accessedService.color = (String)dr[3];
                accessedService.size = (int)dr[4];
                accessedService.catagory = (String)dr[5];
                accessedService.brand = (String)dr[6];
                accessedService.customerName = (String)dr[7];
                accessedService.address = (String)dr[8];
                accessedService.phone = (String)dr[9];
                accessedService.purchaseDate = (DateTime)dr[10];
                accessedService.serviceDate = (DateTime)dr[11];
                accessedService.returnDate = (DateTime)dr[12];
                accessedService.serviceCharges = (int)dr[13];
            }
            else
            {
                accessedService = null;
            }

            con.Close();
            return accessedService;
        }

        public int NewService(Service newService)
        {
            String ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alibh\OneDrive\Pictures\Documents\Visual Studio 2015\Projects\StyloShoes\DAL\stylo.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            String query = "INSERT INTO [dbo].[services] ([id], [price], [color], [size], [catagory], [brand], [customer_name], [address], [phone], [purchase_date], [service_date], [return_date], [charges]) VALUES (@id, @price, @color, @size, @catagory, @brand, @customerName, @address, @phone, @purchaseDate, @serviceDate, @returnDate, @charges)";
            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);
            SqlParameter p1 = new SqlParameter("id", newService.id);
            SqlParameter p2 = new SqlParameter("price", newService.price);
            SqlParameter p3 = new SqlParameter("catagory", newService.catagory);
            SqlParameter p4 = new SqlParameter("size", newService.size);
            SqlParameter p5 = new SqlParameter("color", newService.color);
            SqlParameter p6 = new SqlParameter("brand", newService.brand);
            SqlParameter p7 = new SqlParameter("purchaseDate", newService.purchaseDate);
            SqlParameter p8 = new SqlParameter("customerName", newService.customerName);
            SqlParameter p9 = new SqlParameter("address", newService.address);
            SqlParameter p10 = new SqlParameter("phone", newService.phone);
            SqlParameter p11 = new SqlParameter("serviceDate", newService.serviceDate);
            SqlParameter p12 = new SqlParameter("returnDate", newService.returnDate);
            SqlParameter p13 = new SqlParameter("charges", newService.serviceCharges);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
            cmd.Parameters.Add(p8);
            cmd.Parameters.Add(p9);
            cmd.Parameters.Add(p10);
            cmd.Parameters.Add(p11);
            cmd.Parameters.Add(p12);
            cmd.Parameters.Add(p13);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public int RegisterNew(Member newMember)
        {
            String ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alibh\OneDrive\Pictures\Documents\Visual Studio 2015\Projects\StyloShoes\DAL\stylo.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String query = "INSERT INTO [dbo].[members] ([username], [name], [password], [status]) VALUES (@username, @name, @password, @status)";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlParameter p1 = new SqlParameter("username", newMember.username);
            SqlParameter p2 = new SqlParameter("name", newMember.name);
            SqlParameter p3 = new SqlParameter("password", newMember.pass);
            SqlParameter p4 = new SqlParameter("status", newMember.status);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public int NewSale(Item newItem)
        {
            int j;
            String ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alibh\OneDrive\Pictures\Documents\Visual Studio 2015\Projects\StyloShoes\DAL\stylo.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String query = "delete from dbo.items where id='" + newItem.id + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            int i = cmd.ExecuteNonQuery();
            if(i > 0)
            {
                String query1 = "INSERT INTO [dbo].[sales] ([id], [price], [catagory], [size], [color], [brand], [purchase_date]) VALUES (@id, @price, @catagory, @size, @color, @brand, @purchase_date)";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                SqlParameter p1 = new SqlParameter("id", newItem.id);
                SqlParameter p2 = new SqlParameter("price", newItem.price);
                SqlParameter p3 = new SqlParameter("catagory", newItem.Catagory);
                SqlParameter p4 = new SqlParameter("size", newItem.size);
                SqlParameter p5 = new SqlParameter("color", newItem.color);
                SqlParameter p6 = new SqlParameter("brand", newItem.brand);
                SqlParameter p7 = new SqlParameter("purchase_date", newItem.date);
                cmd1.Parameters.Add(p1);
                cmd1.Parameters.Add(p2);
                cmd1.Parameters.Add(p3);
                cmd1.Parameters.Add(p4);
                cmd1.Parameters.Add(p5);
                cmd1.Parameters.Add(p6);
                cmd1.Parameters.Add(p7);
                j = cmd1.ExecuteNonQuery();
            }
            else
            {
                j = 0;
            }
            return j;
        }

        public int UpdatePassword(String id, string pass)
        {
            
            String ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alibh\OneDrive\Pictures\Documents\Visual Studio 2015\Projects\StyloShoes\DAL\stylo.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String query = "update dbo.members SET password = '"+ pass +"' where username = '" + id + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            int count = cmd.ExecuteNonQuery();
            con.Close();
            return count;
        }

        public List<Sale> FetchAllSales(DateTime lowerDate, DateTime upperDate)
        {
            List<Sale> ls = new List<Sale>();
            String ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alibh\OneDrive\Pictures\Documents\Visual Studio 2015\Projects\StyloShoes\DAL\stylo.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String query = "select * from dbo.sales where purchase_date BETWEEN '" + lowerDate + "' AND '" + upperDate + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Sale accessedSale = new Sale();
                accessedSale.id = (String)dr[1];
                accessedSale.price = (int)dr[2];
                accessedSale.catagory = (String)dr[3];
                accessedSale.size = (int)dr[4];
                accessedSale.color = (String)dr[5];
                accessedSale.brand = (String)dr[6];
                accessedSale.purchaseDate = (DateTime)dr[7];
                ls.Add(accessedSale);
            }

            con.Close();
            return ls;
        }

        public List<Sale> FetchAllSales()
        {
            List<Sale> ls = new List<Sale>();
            String ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alibh\OneDrive\Pictures\Documents\Visual Studio 2015\Projects\StyloShoes\DAL\stylo.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String query = "select * from dbo.sales";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                    Sale accessedSale = new Sale();
                    accessedSale.id = (String)dr[1];
                    accessedSale.price = (int)dr[2];
                    accessedSale.catagory = (String)dr[3];
                    accessedSale.size = (int)dr[4];
                    accessedSale.color = (String)dr[5];
                    accessedSale.brand = (String)dr[6];
                    accessedSale.purchaseDate = (DateTime)dr[7];
                    ls.Add(accessedSale);
            }
            dr.Close();
            con.Close();
            return ls;
        }

        public List<Item> FetchAllItems(DateTime lowerDate, DateTime upperDate)
        {
            List<Item> ls = new List<Item>();

            String ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alibh\OneDrive\Pictures\Documents\Visual Studio 2015\Projects\StyloShoes\DAL\stylo.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String query = "select * from dbo.items where entry_date BETWEEN '"+ lowerDate + "' AND '"+ upperDate + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Item accessedItem = new Item();
                accessedItem.id = (String)dr[0];
                accessedItem.price = (int)dr[1];
                accessedItem.Catagory = (String)dr[2];
                accessedItem.size = (int)dr[3];
                accessedItem.color = (String)dr[4];
                accessedItem.brand = (String)dr[5];
                accessedItem.date = (DateTime)dr[6];
                ls.Add(accessedItem);
            }


            con.Close();
            return ls;
        }

        public List<Item> FetchAllItems()
        {
            List<Item> ls = new List<Item>();
            String ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alibh\OneDrive\Pictures\Documents\Visual Studio 2015\Projects\StyloShoes\DAL\stylo.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String query = "select * from dbo.items";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Item accessedItem = new Item();
                accessedItem.id = (String)dr[0];
                accessedItem.price = (int)dr[1];
                accessedItem.Catagory = (String)dr[2];
                accessedItem.size = (int)dr[3];
                accessedItem.color = (String)dr[4];
                accessedItem.brand = (String)dr[5];
                accessedItem.date = (DateTime)dr[6];
                ls.Add(accessedItem);
            }
            con.Close();
            return ls;
        }

        public int DeleteItem(string id)
        {
            String ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alibh\OneDrive\Pictures\Documents\Visual Studio 2015\Projects\StyloShoes\DAL\stylo.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String query = "delete from dbo.items where id='" + id + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public int updateItem(Item newItem)
        {
            String ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alibh\OneDrive\Pictures\Documents\Visual Studio 2015\Projects\StyloShoes\DAL\stylo.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String query = "UPDATE dbo.items SET price = @price, catagory = @catagory, size = @size, color = @color, brand = @brand, entry_date = @entry_date WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlParameter p1 = new SqlParameter("id", newItem.id);
            SqlParameter p2 = new SqlParameter("price", newItem.price);
            SqlParameter p3 = new SqlParameter("catagory", newItem.Catagory);
            SqlParameter p4 = new SqlParameter("size", newItem.size);
            SqlParameter p5 = new SqlParameter("color", newItem.color);
            SqlParameter p6 = new SqlParameter("brand", newItem.brand);
            SqlParameter p7 = new SqlParameter("entry_date", newItem.date);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public Item fetchItem(string uid)
        {
            Item accessedItem = new Item();
            String ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alibh\OneDrive\Pictures\Documents\Visual Studio 2015\Projects\StyloShoes\DAL\stylo.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String query = "select * from dbo.items where id='"+ uid+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                accessedItem.id = (String)dr[0];
                accessedItem.price = (int)dr[1];
                accessedItem.Catagory = (String)dr[2];
                accessedItem.size = (int)dr[3];
                accessedItem.color = (String)dr[4];
                accessedItem.brand = (String)dr[5];
                accessedItem.date = (DateTime)dr[6];
            }
            else
            {
                accessedItem = null;
            }

            con.Close();
            return accessedItem;
        }

        public int insertItem(Item newItem)
        {
            String ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alibh\OneDrive\Pictures\Documents\Visual Studio 2015\Projects\StyloShoes\DAL\stylo.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            String query = "INSERT INTO [dbo].[items] ([id], [price], [catagory], [size], [color], [brand], [entry_date]) VALUES (@id, @price, @catagory, @size, @color, @brand, @entry_date)";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlParameter p1 = new SqlParameter("id", newItem.id);
            SqlParameter p2 = new SqlParameter("price", newItem.price);
            SqlParameter p3 = new SqlParameter("catagory", newItem.Catagory);
            SqlParameter p4 = new SqlParameter("size", newItem.size);
            SqlParameter p5 = new SqlParameter("color", newItem.color);
            SqlParameter p6 = new SqlParameter("brand", newItem.brand);
            SqlParameter p7 = new SqlParameter("entry_date", newItem.date);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}
