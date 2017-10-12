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
    public partial class DisplayFullUserOrder : System.Web.UI.Page
    {
        OrderManager aOrderManager = new OrderManager();
        OrderDetailsManager aOrderDetailsManager = new OrderDetailsManager();
        private int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_email"]==null)
            {
                Response.Redirect("UserLogin.aspx");
            }
            repeaterDisplayOrder.DataSource = aOrderManager.GetAllOrder();
            repeaterDisplayOrder.DataBind();
            int totalamount = 0;
            id = Convert.ToInt32(Request.QueryString["id"]);
            List<DAL.Model.OrderDetails> a= aOrderDetailsManager.GetAllOrderDetails(id);
            //List<OrderDetails> aorOrderDetails = aOrderDetailsManager.GetAllOrderDetails(id);
            repeaterOrderDetails.DataSource = a;
            repeaterOrderDetails.DataBind();
            foreach (var aorder in a)
            {
                totalamount = totalamount + (aorder.ProductPrice * aorder.ProductQuantity);

            }
            lblTotalAmount.Text = "Total Amount:" + totalamount.ToString();
        }
    }
}