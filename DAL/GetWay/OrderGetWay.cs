using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using AshShop.DAL.Model;

namespace AshShop.DAL.GetWay
{
    public class OrderGetWay:GetWay
    {
        public void InsertOrder(Client aClient)
        {
            con.Open();
            Query = "insert into tblOrder(First_Name,Last_Name,Email,Address,City,Mobile_Number) values('"+aClient.FirstName+"','"+aClient.LastName+"','"+aClient.Email+"','"+aClient.Address+"','"+aClient.City+"','"+aClient.MobileNumber+"')";
            cmd=new SqlCommand(Query,con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public int  GetOrderIdOrder(Client aClient)
        {
            int order_id=0;
            con.Open();
            Query = "select top 1 * from tblOrder where email='"+aClient.Email+"' order by id desc";
            cmd = new SqlCommand(Query, con);
            reader=cmd.ExecuteReader();
            while (reader.Read())
            {
                 order_id = Convert.ToInt32(reader["Id"]);
                
            }
            con.Close();
            return order_id;
        }

        public List<Order> GetAllOrder()
        {
            List<Order> aOrderList=new List<Order>();
            con.Open();
            Query = "select * from tblOrder order by Id desc";
            cmd=new SqlCommand(Query,con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Order aOrder=new Order();
                aOrder.id = Convert.ToInt32(reader["Id"]);
                aOrder.FirstName = reader["First_Name"].ToString();
                aOrder.LastName = reader["Last_Name"].ToString();
                aOrder.Email = reader["Email"].ToString();
                aOrder.Address = reader["Address"].ToString();
                aOrder.City = reader["City"].ToString();
                aOrder.MobileNumber = reader["Mobile_Number"].ToString();
                aOrderList.Add(aOrder);

            }
            con.Close();
            return aOrderList;
        }
        public List<Order> GetAllUserOrder(string UserEmail)
        {
            List<Order> aOrderList = new List<Order>();
            con.Open();
            Query = "select * from tblOrder where email='" + UserEmail + "' order by Id desc";
            cmd = new SqlCommand(Query, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Order aOrder = new Order();
                aOrder.id = Convert.ToInt32(reader["Id"]);
                aOrder.FirstName = reader["First_Name"].ToString();
                aOrder.LastName = reader["Last_Name"].ToString();
                aOrder.Email = reader["Email"].ToString();
                aOrder.Address = reader["Address"].ToString();
                aOrder.City = reader["City"].ToString();
                aOrder.MobileNumber = reader["Mobile_Number"].ToString();
                aOrderList.Add(aOrder);

            }
            con.Close();
            return aOrderList;
        }
    }
}