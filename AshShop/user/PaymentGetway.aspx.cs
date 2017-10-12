using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AshShop.DAL.Model;
using AshShop.Extra_AppCode;


namespace AshShop.user
{
    public partial class PaymentGetway : System.Web.UI.Page
    {
       
        private string StoreCookies, aCookies,order_no;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_email"] == null)
            {
                Response.Redirect("UserLogin.aspx");
            }
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
                   
                    
                    Total_PaymentAccount = Total_PaymentAccount + (aProduct.ProductPrice*aProduct.ProductQuntity);


                }
                Session["TotalAmount"] = Total_PaymentAccount.ToString();

            }

            order_no = RandomImageName.GetRandomImageName(10).ToString();
            Session["order_no"] = order_no;
            //paypal implementation code
            Response.Write("<form target='paypal' action='https://www.sandbox.paypal.com/cgi-bin/webscr' method='post' name='buyCredits' id='buyCredits'>");
            Response.Write("<input type='hidden' name='cmd' value='_xclick'>");
            Response.Write("<input type='hidden' name='hosted_button_id' value='4CC5V5SMEWXCL'>");
            Response.Write("<input type='hidden' name='business' value='ashraf_12@gmail.com' >");
            Response.Write("<input type='hidden' name='currency_code' value='USD' >");
            Response.Write("<input type='hidden' name='item_name' value='payment for donate' >");
            Response.Write("<input type='hidden' name='item_number' value='0' >");
            Response.Write("<input type='hidden' name='amount' value='" + Session["TotalAmount"].ToString() + "' >");
            Response.Write("<input type='hidden' name='return' value='http://localhost:14573/user/PaymentSuccess.aspx?Order=" + order_no+ "'>");
            Response.Write("</form>");
            Response.Write("<script type='text/javascript'>");
            Response.Write("document.getElementById('buyCredits').submit();");
            Response.Write("</script>");



          

            //end implementation
            

        }
    }
}