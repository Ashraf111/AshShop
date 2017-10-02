using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using AshShop.DAL.GetWay;
using AshShop.DAL.Model;

namespace AshShop.BLL
{
    public class ClientManager
    {
        ClientGetWay aClientGetWay=new ClientGetWay();
        public Client RegisterClient(Client aClient)
        {
            Client aClient1 = aClientGetWay.RegisterClient(aClient);
            return aClient1;

        }

        public Client LoginClient(Client aClient)
        {
            Client aClient1 = aClientGetWay.LoginClient(aClient);
            return aClient1;
        }
        public int UpdateClient(Client aClient)
        {
           int rowAffected=aClientGetWay.UpdateClient(aClient);
            return rowAffected;

        }
    }
}