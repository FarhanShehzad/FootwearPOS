using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesObject;
using DAL;

namespace BLL
{
    public class BLLayer
    {
        public Member VerifyUser(String username, string userPass)
        {
            DALayer accessUser = new DALayer();
            return accessUser.fetchData(username, userPass);
        }

        public int insertItem(Item newItem)
        {
            DALayer AddItem = new DALayer();
            return AddItem.insertItem(newItem);
        }

        public Item fetchItem(string uid)
        {
            DALayer newLayer = new DALayer();
            return newLayer.fetchItem(uid);
        }

        public int udateItem(Item newItem)
        {
            DALayer newLayer = new DALayer();
            return newLayer.updateItem(newItem);
        }

        public int DeleteItem(string id)
        {
            DALayer newLayer = new DALayer();
            return newLayer.DeleteItem(id);
        }

        public List<Item> fetchAllItems()
        {
            DALayer newLayer = new DALayer();
            return newLayer.FetchAllItems();
        }

        public Sale fetchSale(string id)
        {
            DALayer newLayer = new DALayer();
            return newLayer.FetchSale(id);
        }

        public List<Sale> fetchAllSales()
        {
            DALayer newLayer = new DALayer();
            return newLayer.FetchAllSales();
        }

        public int UpdatePassword(String id, string pass)
        {
            DALayer newLayer = new DALayer();
            return newLayer.UpdatePassword(id, pass);
        }

        public int RegisterNew(Member newMember)
        {
            DALayer newLayer = new DALayer();
            return newLayer.RegisterNew(newMember);
        }

        public List<Item> fetchAllItems(DateTime lowerDate, DateTime upperDate)
        {
            DALayer newLayer = new DALayer();
            return newLayer.FetchAllItems(lowerDate, upperDate);
        }

        public List<Sale> fetchAllSales(DateTime lowerDate, DateTime upperDate)
        {
            DALayer newLayer = new DALayer();
            return newLayer.FetchAllSales(lowerDate, upperDate);
        }

        public int NewSale(Item newItem)
        {
            DALayer newLayer = new DALayer();
            return newLayer.NewSale(newItem);
        }

        public int NewService(Service newService)
        {
            DALayer newLayer = new DALayer();
            return newLayer.NewService(newService);
        }

        public Service fetchService(string id)
        {
            DALayer newLayer = new DALayer();
            return newLayer.fetchService(id);
        }

        public List<Service> fetchAllServices()
        {
            DALayer newLayer = new DALayer();
            return newLayer.FetchAllServices();
        }

        public int UpdateService(Service newService)
        {
            DALayer newLayer = new DALayer();
            return newLayer.UpdateService(newService);
        }

        public List<Service> fetchAllServices(DateTime lowerDate, DateTime upperDate)
        {
            DALayer newLayer = new DALayer();
            return newLayer.FetchAllServices(lowerDate, upperDate);
        }
    }
}
