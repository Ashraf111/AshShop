using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using AshShop.DAL.Model;

namespace AshShop.DAL.GetWay
{
    public class ProductGetWay:GetWay
    {
        
        /// <summary>
        ///Product add  into product table of database  
        /// </summary>

        public int AddProductGetWay(Product aProduct)
        {
            
            con.Open();
            Query = "insert into tblProduct(Product_Name,Product_Description,Product_Price,Product_Quantity,Product_Images,Product_Category) values('" + aProduct.ProductName + "','" + aProduct.ProductDescription + "'," + aProduct.ProductPrice + "," + aProduct.ProductQuntity + ",'" + aProduct.ProductImage + "','" + aProduct.ProductCategory + "')";
            cmd=new SqlCommand(Query,con);
            int rowAffected=cmd.ExecuteNonQuery();
            con.Close();
            return rowAffected;
        }
        /// <summary>
        ///Product List retrieve  from  product table of Database
        /// </summary>
     
        public List<Product> DisplayProductGetWay()
        {
            List<Product> aProductList=new List<Product>();
            con.Open();
            Query = "select * from tblProduct";
            cmd=new SqlCommand(Query,con);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Product aProduct=new Product();
                    aProduct.id = Convert.ToInt32(reader["Id"]);
                    aProduct.ProductName = reader["Product_Name"].ToString();
                    aProduct.ProductDescription = reader["Product_Description"].ToString();
                    aProduct.ProductPrice = Convert.ToInt32(reader["Product_Price"]);
                    aProduct.ProductQuntity = Convert.ToInt32(reader["Product_Quantity"]);
                    aProduct.ProductImage = reader["Product_Images"].ToString();
                    aProductList.Add(aProduct);
                }
            }

            con.Close();
            return aProductList;
        }
        /// <summary>
        ///Product List retrieve  from  product table of Database By Category
        /// </summary>

        public List<Product> DisplayProductGetWayByCategory(string requestCategory)
        {
            List<Product> aProductList = new List<Product>();
            con.Open();
            Query = "select * from tblProduct where Product_Category='"+requestCategory+"'";
            cmd = new SqlCommand(Query, con);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Product aProduct = new Product();
                    aProduct.id = Convert.ToInt32(reader["Id"]);
                    aProduct.ProductName = reader["Product_Name"].ToString();
                    aProduct.ProductDescription = reader["Product_Description"].ToString();
                    aProduct.ProductPrice = Convert.ToInt32(reader["Product_Price"]);
                    aProduct.ProductQuntity = Convert.ToInt32(reader["Product_Quantity"]);
                    aProduct.ProductImage = reader["Product_Images"].ToString();
                    aProductList.Add(aProduct);
                }
            }

            con.Close();
            return aProductList;
        }

        /// <summary>
        ///Product List retrieve  from  product table of Database By Search
        /// </summary>

        public List<Product> DisplayProductGetWayBySearch(string requestSearch)
        {
            List<Product> aProductList = new List<Product>();
            con.Open();
            Query = "select * from tblProduct where Product_Name like('%" + requestSearch + "%')";
            cmd = new SqlCommand(Query, con);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Product aProduct = new Product();
                    aProduct.id = Convert.ToInt32(reader["Id"]);
                    aProduct.ProductName = reader["Product_Name"].ToString();
                    aProduct.ProductDescription = reader["Product_Description"].ToString();
                    aProduct.ProductPrice = Convert.ToInt32(reader["Product_Price"]);
                    aProduct.ProductQuntity = Convert.ToInt32(reader["Product_Quantity"]);
                    aProduct.ProductImage = reader["Product_Images"].ToString();
                    aProductList.Add(aProduct);
                }
            }

            con.Close();
            return aProductList;
        }


        /// <summary>
        ///A Product retrieve  from  product table of Database By Product Id
        /// </summary>
     
        
        public List<Product> DisplayProductGetWayById(int id)
        {
            
            List<Product> aProductList = new List<Product>();
            con.Open();
            Query = "select * from tblProduct where tblProduct.id='"+id+"'";
            cmd = new SqlCommand(Query, con);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Product aProduct = new Product();
                    aProduct.id = Convert.ToInt32(reader["Id"]);
                    aProduct.ProductName = reader["Product_Name"].ToString();
                    aProduct.ProductDescription = reader["Product_Description"].ToString();
                    aProduct.ProductPrice = Convert.ToInt32(reader["Product_Price"]);
                    aProduct.ProductQuntity = Convert.ToInt32(reader["Product_Quantity"]);
                    aProduct.ProductImage = reader["Product_Images"].ToString();
                    aProductList.Add(aProduct);
                }
            }

            con.Close();
            return aProductList;
        }

        /// <summary>
        ///Add product in cooKies By id
        /// </summary>
        
        public Product GetProductGetWayById(int id)
        {

            Product aProduct = new Product();
            con.Open();
            Query = "select * from tblProduct where tblProduct.id='" + id + "'";
            cmd = new SqlCommand(Query, con);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    
                    aProduct.id = Convert.ToInt32(reader["Id"]);
                    aProduct.ProductName = reader["Product_Name"].ToString();
                    aProduct.ProductDescription = reader["Product_Description"].ToString();
                    aProduct.ProductPrice = Convert.ToInt32(reader["Product_Price"]);
                    aProduct.ProductQuntity = Convert.ToInt32(reader["Product_Quantity"]);
                    aProduct.ProductImage = reader["Product_Images"].ToString();
                    aProduct.ProductCategory = reader["Product_Category"].ToString();

                }
            }

            con.Close();
            return aProduct;
        }
        /// <summary>
        ///Update Qunty of product in product table
        /// </summary>
        
        public void UpdateQuantity(int id,int amount)
        {
            con.Open();
            Query = "update tblProduct set Product_Quantity=Product_Quantity-" + amount + "where Id="+id;
            cmd=new SqlCommand(Query,con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void IncreaseProductQuantity(int id, int amount)
        {
            con.Open();
            Query = "update tblProduct set Product_Quantity=Product_Quantity+" + amount + "where Id=" + id;
            cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}