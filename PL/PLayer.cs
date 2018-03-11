using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesObject;
using BLL;


namespace PL
{
    public class PLayer
    {
        public Member VerifyUser(String username, string userPass)
        {
            BLLayer verify = new BLLayer();
            return verify.VerifyUser(username, userPass);
        }

        public int insertItem(Item newItem)
        {
            BLLayer insertItem = new BLLayer();
            return insertItem.insertItem(newItem);
        }

        public Item fetchItem(string uid)
        {
            BLLayer newLayer = new BLLayer();
            return newLayer.fetchItem(uid);
        }

        public int updateItem(Item newItem)
        {
            BLLayer newLayer = new BLLayer();
            return newLayer.udateItem(newItem);
        }

        public int DeleteItem(string id)
        {
            BLLayer newLayer = new BLLayer();
            return newLayer.DeleteItem(id);
        }

        public Sale fetchSale(string id)
        {
            BLLayer newLayer = new BLLayer();
            return newLayer.fetchSale(id);
        }

        public List<Sale> fetchAllSales()
        {
            BLLayer newLayer = new BLLayer();
            return newLayer.fetchAllSales();
        }

        public int UpdatePassword(String id, String pass)
        {
            BLLayer newLayer = new BLLayer();
            return newLayer.UpdatePassword(id, pass);
        }

        public int RegisterNew(Member newMember)
        {
            BLLayer newLayer = new BLLayer();
            return newLayer.RegisterNew(newMember);
        }

        public List<Item> fetchAllItems()
        {
            BLLayer newLayer = new BLLayer();
            return newLayer.fetchAllItems();
        }

        public List<Item> fetchAllItems(DateTime lowerDate, DateTime upperDate)
        {
            BLLayer newLayer = new BLLayer();
            return newLayer.fetchAllItems(lowerDate, upperDate);
        }

        public List<Sale> fetchAllSales(DateTime lowerDate, DateTime upperDate)
        {
            BLLayer newLayer = new BLLayer();
            return newLayer.fetchAllSales(lowerDate, upperDate);
        }

        public int NewSale(Item newItem)
        {
            BLLayer newLayer = new BLLayer();
            return newLayer.NewSale(newItem);
        }

        public int NewService(Service newService)
        {
            BLLayer newLayer = new BLLayer();
            return newLayer.NewService(newService);
        }

        public List<Service> fetchAllServices()
        {
            BLLayer newLayer = new BLLayer();
            return newLayer.fetchAllServices();
        }

        public Service fetchService(string id)
        {
            BLLayer newLayer = new BLLayer();
            return newLayer.fetchService(id);
        }

        public int UpdateService(Service newService)
        {
            BLLayer newLayer = new BLLayer();
            return newLayer.UpdateService(newService);
        }

        public List<Service> fetchAllServices(DateTime lowerDate, DateTime upperDate)
        {
            BLLayer newLayer = new BLLayer();
            return newLayer.fetchAllServices(lowerDate, upperDate);
        }
    }

}
