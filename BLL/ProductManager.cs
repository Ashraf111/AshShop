using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AshShop.DAL.GetWay;
using AshShop.DAL.Model;

namespace AshShop.BLL
{
    public class ProductManager
    {
        ProductGetWay aProductGetWay=new ProductGetWay();
        
        /// <summary>
        ///Business logic to add  Product
        /// </summary>

        public int InsertProductManager(Product aProduct)
        {
            int RowAffected = aProductGetWay.AddProductGetWay(aProduct);
            return RowAffected;
        }
        /// <summary>
        ///Business logic to Get  Product List 
        /// </summary>
       
        public List<Product> DisplayProductManager()
        {
            List<Product> productList = aProductGetWay.DisplayProductGetWay();
            return productList;
        }
        /// <summary>
        ///Business logic to Get  Product List By Category 
        /// </summary>

        public List<Product> DisplayProductManagerByCategory(string requestCategory)
        {
            List<Product> productList = aProductGetWay.DisplayProductGetWayByCategory(requestCategory);
            return productList;
        }
        /// <summary>
        ///Business logic to Get  Product List By Search 
        /// </summary>

        public List<Product> DisplayProductManagerBySearch(string requestCategory)
        {
            List<Product> productList = aProductGetWay.DisplayProductGetWayBySearch(requestCategory);
            return productList;
        }
        /// <summary>
        ///Business logic to Get a Product From List of Product By product ID
        /// </summary>
        
        public List<Product> DisplayProductManagerById(int id)
        {
            List<Product> productList = aProductGetWay.DisplayProductGetWayById(id);
            return productList;
        }
        public Product GetProductManagerById(int id)
        {
            Product aProduct = aProductGetWay.GetProductGetWayById(id);
            return aProduct;
        }

        /// <summary>
        ///Update Product Quantity
        /// </summary>
        public void UpdateProduct(int id,int amount)
        {
            aProductGetWay.UpdateQuantity(id,amount);
        }
        public void IncreaseProductQuantity(int id, int amount)
        {
            aProductGetWay.IncreaseProductQuantity(id, amount);
        }
    }
}