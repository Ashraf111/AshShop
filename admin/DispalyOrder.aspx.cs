using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AshShop.BLL;
using AshShop.DAL.Model;

namespace AshShop.admin
{
    public partial class DispalyOrder : System.Web.UI.Page
    {
        OrderManager aOrderManager=new OrderManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("AdminLoginUI.aspx");
            }
            
            repeaterDisplayOrder.DataSource= aOrderManager.GetAllOrder();
            repeaterDisplayOrder.DataBind();


        }
    }
}