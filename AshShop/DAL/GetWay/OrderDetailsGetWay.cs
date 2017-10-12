using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using AshShop.DAL.Model;

namespace AshShop.DAL.GetWay
{
    public class OrderDetailsGetWay:GetWay
    {
        public void InsertOrderDetails(Product aProduct)
        {
            con.Open();
            Query = "insert into tblOrderDetail (Order_Id,Product_Name,Product_Price,Product_Quantity,Product_Image) values('"+aProduct.id+"','"+aProduct.ProductName+"','"+aProduct.ProductPrice+"','"+aProduct.ProductQuntity+"','"+aProduct.ProductImage+"') ";
            cmd=new SqlCommand(Query,con);
            cmd.ExecuteNonQuery();
            con.Close();
            
        }
        public List<OrderDetails> GetAllOrderDetails(int id)
        {
            List<OrderDetails> aOrderDetailList = new List<OrderDetails>();
            con.Open();
            Query = "select * from tblOrderDetail where Order_Id='"+id+"' order by Id desc";
            cmd = new SqlCommand(Query, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                OrderDetails aOrderDetails = new OrderDetails();
                aOrderDetails.OrderId = Convert.ToInt32(reader["Order_Id"]);
                aOrderDetails.ProductName = reader["Product_Name"].ToString();
                aOrderDetails.ProductPrice = Convert.ToInt32(reader["Product_Price"]);
                aOrderDetails.ProductQuantity = Convert.ToInt32(reader["Product_Quantity"]);
                aOrderDetails.ProductImage = reader["Product_Image"].ToString();

                aOrderDetailList.Add(aOrderDetails);

            }
            con.Close();
            return aOrderDetailList;
        }
    }
}