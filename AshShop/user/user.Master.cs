using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AshShop.BLL;
using AshShop.DAL.Model;

namespace AshShop.user
{
    public partial class user : System.Web.UI.MasterPage
    {
        ProductCategoryManager aProductCategoryManager=new ProductCategoryManager();
        private string StoreCookies, aCookies;
        protected void Page_Load(object sender, EventArgs e)
        {
            int Total_PaymentAccount = 0,Total_Item=0;
            List<ProductCategory> aProductCategories = aProductCategoryManager.LoadProductCategories();
            DataListProductCategory.DataSource = aProductCategories;
            DataListProductCategory.DataBind();
            List<Product> aProductList = new List<Product>();
            if (Request.Cookies["aa"] != null)
            {
                StoreCookies = Convert.ToString(Request.Cookies["aa"].Value);
                string[] cookiesArray = StoreCookies.Split('|');
                for (int i = 0; i < cookiesArray.Length; i++)
                {
                    Product aProduct = new Product();
                    aCookies = Convert.ToString(cookiesArray[i]);
                    string[] aCookiesItem = aCookies.Split(',');
                    aProduct.CookiesId = i;
                    aProduct.id = (Convert.ToInt32(aCookiesItem[0]));
                    aProduct.ProductName = aCookiesItem[1];
                    aProduct.ProductDescription = aCookiesItem[2];
                    aProduct.ProductPrice = Convert.ToInt32(aCookiesItem[3]);
                    aProduct.ProductQuntity = Convert.ToInt32(aCookiesItem[4]);
                    aProduct.ProductImage = aCookiesItem[5];

                   
                    Total_PaymentAccount = Total_PaymentAccount + (aProduct.ProductPrice * aProduct.ProductQuntity);
                    Total_Item = Total_Item + aProduct.ProductQuntity;

                }

                lblTotalItem.Text = Total_Item.ToString();
                lblTotalCost.Text = Total_PaymentAccount.ToString();
            }

        }
    }
}