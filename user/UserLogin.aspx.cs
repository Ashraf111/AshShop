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
    public partial class UserLogin : System.Web.UI.Page
    {
        ClientManager aClientManager=new ClientManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUserLogin_Click(object sender, EventArgs e)
        {
           Client aClient=new Client();
            if (txtLoginEmail.Text.Trim() == "")
            {
                txtLoginEmail.Focus();
                //lblvalidateloginEmail.Text = "Please Input Email";
                return;
            }
            if (txtLoginEmail.Text.Trim() != "")
            {
                aClient.Email = txtLoginEmail.Text.Trim();
            }
            if (txtLoginPassword.Text.Trim() == "")
            {
                txtLoginPassword.Focus();
                //lblloginpassword.Text = "Please Input Password";
                return;
            }
            if (txtLoginPassword.Text.Trim() != "")
            {
                aClient.Password = txtLoginPassword.Text.Trim();
            }


             aClient =aClientManager.LoginClient(aClient);

            if (aClient!=null)
            {
                if (Session["CheckOutButton"]=="Yes")
                {
                    Session["user_FirstName"] = aClient.FirstName;
                    Session["user_LastName"] = aClient.LastName;
                    Session["user_email"] = aClient.Email;
                    Session["user_Address"] = aClient.Address;
                    Session["user_City"] = aClient.City;
                    Session["user_MobileNumber"] = aClient.MobileNumber;
                    Session["Password"] = aClient.Password;

                    Response.Redirect("UpdateOrderDetails.aspx");
                }
                else
                {
                    Session["user_FirstName"] = aClient.FirstName;
                    Session["user_LastName"] = aClient.LastName;
                    Session["user_email"] = aClient.Email;
                    Session["user_Address"] = aClient.Address;
                    Session["user_City"] = aClient.City;
                    Session["user_MobileNumber"] = aClient.MobileNumber;
                    Session["Password"] = aClient.Password;
                    Response.Redirect("DisplayUserOrder.aspx");
                }

            }
            else
            {
                lblLoginMessage.Text = "User Not Exist";
            }
        }
    }
}