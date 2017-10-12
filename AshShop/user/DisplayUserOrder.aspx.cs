using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AshShop.BLL;

namespace AshShop.user
{
    public partial class DisplayUserOrder : System.Web.UI.Page
    {
        OrderManager aOrderManager = new OrderManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["user_email"] == null)
            {
                Response.Redirect("UserLogin.aspx");
            }
            string UserEmail = Session["user_email"].ToString();
            repeaterDisplayOrder.DataSource = aOrderManager.GetAllUserOrder(UserEmail);
            repeaterDisplayOrder.DataBind();
        }
    }
}