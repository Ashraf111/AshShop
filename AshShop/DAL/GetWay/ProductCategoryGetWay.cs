using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using AshShop.DAL.Model;

namespace AshShop.DAL.GetWay
{
    public class ProductCategoryGetWay:GetWay
    {
        public List<ProductCategory> LoadProductCategories()
        {
            List<ProductCategory> aProductCategories=new List<ProductCategory>();
            con.Open();
            Query = "select * from tblProductCategory";
            cmd=new SqlCommand(Query,con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ProductCategory aProductCategory=new ProductCategory();
                aProductCategory.id = Convert.ToInt32(reader["Id"]);
                aProductCategory.ProductCategoryName = reader["Product_Category"].ToString();
                aProductCategories.Add(aProductCategory);
            }
            con.Close();
            return aProductCategories;
        }
        public int InsertCategory(string aProductCategory)
        {
            con.Open();
            Query = "insert into tblProductCategory(Product_Category) values('"+aProductCategory+"')";
            cmd=new SqlCommand(Query,con);
           int rowAffected=cmd.ExecuteNonQuery();
            con.Close();
            return rowAffected;
        }
        public void DeleteCategory(string aProductCategory)
        {
            con.Open();
            Query = "delete from tblProductCategory where Product_Category='"+aProductCategory+"'";
            cmd = new SqlCommand(Query, con);
            int rowAffected = cmd.ExecuteNonQuery();
            con.Close();
           
        }
    }


}