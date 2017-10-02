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
    public partial class PaymentSuccess : System.Web.UI.Page
    {
        OrderDetailsManager aOrderDetailsManager=new OrderDetailsManager();
        private string StoreCookies, aCookies;
        OrderManager aOrderManager=new OrderManager();
        private string order_no;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_email"] == null)
            {
                Response.Redirect("UserLogin.aspx");
            }
            order_no = Request.QueryString["Order"].ToString();
            if (order_no == Session["order_no"].ToString())
            {
                Client aClient=new Client();
                aClient.FirstName = Session["user_FirstName"].ToString();
                aClient.LastName = Session["user_LastName"].ToString();
                aClient.Email = Session["user_email"].ToString();
                aClient.Address = Session["user_Address"].ToString();
                aClient.City = Session["user_City"].ToString();
                aClient.MobileNumber=Session["user_MobileNumber"].ToString();
                aOrderManager.InsertOrder(aClient);
                int order_id=aOrderManager.GetOrderId(aClient);
                
                if (Request.Cookies["aa"] != null)
                {
                    StoreCookies = Convert.ToString(Request.Cookies["aa"].Value);
                    string[] cookiesArray = StoreCookies.Split('|');
                    for (int i = 0; i < cookiesArray.Length; i++)
                    {
                        Product aProduct = new Product();
                        aCookies = Convert.ToString(cookiesArray[i]);
                        string[] aCookiesItem = aCookies.Split(',');

                        aProduct.id = order_id;
                        aProduct.ProductName = aCookiesItem[1];
                        aProduct.ProductDescription = aCookiesItem[2];
                        aProduct.ProductPrice = Convert.ToInt32(aCookiesItem[3]);
                        aProduct.ProductQuntity = Convert.ToInt32(aCookiesItem[4]);
                        aProduct.ProductImage = aCookiesItem[5];
                        aOrderDetailsManager.InsertOrderDetails(aProduct);





                    }

                }
                

            }

           


            else
            {
                Response.Redirect("UserLogin.aspx");
            }
            Session["user_email"] = "";
            Response.Cookies["aa"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["aa"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect("DisplayProduct.aspx");

        }
    }
}