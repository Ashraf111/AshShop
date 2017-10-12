using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AshShop.user
{
    public partial class UserAccount : System.Web.UI.Page
    {
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
    }
}