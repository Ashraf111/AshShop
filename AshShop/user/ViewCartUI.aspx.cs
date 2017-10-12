using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AshShop.DAL.Model;

namespace AshShop.user
{
    public partial class ViewCartUI : System.Web.UI.Page
    {
        private string StoreCookies,aCookies;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            int Total_PaymentAccount=0;
           
           List<Product> aProductList=new List<Product>();
            if (Request.Cookies["aa"]!=null)
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
                   
                    aProductList.Add(aProduct);
                    Total_PaymentAccount = Total_PaymentAccount + (aProduct.ProductPrice*aProduct.ProductQuntity);


                }

              
            }
            if (Total_PaymentAccount<=0)
            {
                btnCheckOut.Visible = false;
                lblPaymentAmount.Text = "You have no any cart Item";
            }
            else
            {
                DataListViewCart.DataSource = aProductList;
                DataListViewCart.DataBind();
                lblPaymentAmount.Text = "You have to pay:" + Total_PaymentAccount;
            }
        }

        protected void btnCheckOut_Click(object sender, EventArgs e)
        {
            Session["CheckOutButton"] = "Yes";
            Response.Redirect("CheckOut.aspx");
        }



    }
}