using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AshShop.BLL;
using AshShop.DAL.GetWay;
using AshShop.DAL.Model;

namespace AshShop.admin
{
    public partial class AdminLoginUI : System.Web.UI.Page
    {
        AdminLoginManager aAdminLoginManager=new AdminLoginManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Admin Login 

        protected void btnAdminLogin_Click(object sender, EventArgs e)
        {
            AdminLogin aAdmin=new AdminLogin();
            aAdmin.AdminName = txtUserName.Text.Trim();
            aAdmin.Password = txtUserPassword.Text.Trim();
            Session["admin"] = aAdmin.AdminName;
            int RowExist = aAdminLoginManager.LoginAdminManager(aAdmin);
            if (RowExist==0)
            {
                lblAdminLoginMessage.Text = "Your Name Or password is wrong";
            }
            else
            {
                Response.Redirect("../admin/Add_ProductUI.aspx");
            }
        }
    }
}