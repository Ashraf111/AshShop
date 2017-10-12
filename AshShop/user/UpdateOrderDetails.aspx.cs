using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AshShop.BLL;
using AshShop.DAL.Model;

namespace AshShop.user
{
    public partial class UpdateOrderDetails : System.Web.UI.Page
    {
        ClientManager aClientManager=new ClientManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_email"] == null)
            {
                Response.Redirect("UserLogin.aspx");
            }
            if (!IsPostBack)
            {
                txtFirstName.Text = Session["user_FirstName"].ToString();
                txtLastName.Text = Session["user_LastName"].ToString();
                txtAddress.Text = Session["user_Address"].ToString();
                txtCity.Text = Session["user_City"].ToString();
                txtMobileNumber.Text = Session["user_MobileNumber"].ToString();
            }

        }

        protected void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            Client aClient1=new Client();
            aClient1.FirstName = txtFirstName.Text;
            aClient1.LastName = txtLastName.Text;
            aClient1.Email = Session["user_email"].ToString();
            aClient1.Address = txtAddress.Text;
            aClient1.City = txtCity.Text;
            aClient1.MobileNumber = txtMobileNumber.Text;
           int rowAffected= aClientManager.UpdateClient(aClient1);

           if (rowAffected>0)
           {
               Response.Redirect("PaymentGetway.aspx");
           }
           else
           {
               lblUpdateOrderMessage.Text= "User not Updated";
           }

        }
    }
}