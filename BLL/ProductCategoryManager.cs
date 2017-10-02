using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AshShop.DAL.GetWay;
using AshShop.DAL.Model;

namespace AshShop.BLL
{
    
    public class ProductCategoryManager
    {
        ProductCategoryGetWay aProductCategoryGetWay=new ProductCategoryGetWay();
        public List<ProductCategory> LoadProductCategories()
        {
            return aProductCategoryGetWay.LoadProductCategories();
        }

        public int InsertCategory(string aproductCategory)
        {
          int rowAffected= aProductCategoryGetWay.InsertCategory(aproductCategory);
            return rowAffected;
        }
        public void DeleteCategory(string aproductCategory)
        {
            aProductCategoryGetWay.DeleteCategory(aproductCategory);
           
        }
    }
}