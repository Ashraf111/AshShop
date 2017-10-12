using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AshShop.DAL.GetWay;
using AshShop.DAL.Model;

namespace AshShop.BLL
{
    
    public class OrderManager
    {
        OrderGetWay aOrderGetWay=new OrderGetWay();

        public void InsertOrder(Client aClient)
        {
            aOrderGetWay.InsertOrder(aClient);
        }
        public int GetOrderId(Client aClient)
        {
            int orderid=aOrderGetWay.GetOrderIdOrder(aClient);
            return orderid;

        }

        public List<Order>  GetAllOrder()
        {
            List<Order> aOrderList = aOrderGetWay.GetAllOrder();
            return aOrderList;
        }
        public List<Order> GetAllUserOrder(string UserEmail)
        {
            List<Order> aOrderList = aOrderGetWay.GetAllUserOrder(UserEmail);
            return aOrderList;
        }

    }
}