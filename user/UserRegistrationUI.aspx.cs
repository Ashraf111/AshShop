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
    public partial class UserRegistrationUI : System.Web.UI.Page
    {
        ClientManager aClientManager = new ClientManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Client aClient = new Client();
            if (txtFirstName.Text == "")
            {

                txtFirstName.Focus();
                //lblNameValidate.Text = "Please Input Your First Name";
                return;
            }
            if (txtFirstName.Text != "")
            {
                aClient.FirstName = txtFirstName.Text.Trim();
                //lblNameValidate.Visible = false;
            }
            if (txtLastName.Text == "")
            {

                txtLastName.Focus();
                //lbllastnameValidate.Text = "Please Input Your Last Name";
                return;
            }

            if (txtLastName.Text != "")
            {
                aClient.LastName = txtLastName.Text.Trim();
                //lbllastnameValidate.Visible = false;
            }
            if (txtEmail.Text == "")
            {

                txtEmail.Focus();
                //lblvalidateEmail.Text = "Please Input Your Email";
                return;
            }

            if (txtEmail.Text != "")
            {
                aClient.Email = txtEmail.Text.Trim();
                //lblvalidateEmail.Visible = false;
            }
            if (txtAddress.Text == "")
            {

                txtAddress.Focus();
                //lblvalidateEmail.Text = "Please Input Your Email";
                return;
            }

            if (txtAddress.Text != "")
            {
                aClient.Address = txtAddress.Text.Trim();
                //lblvalidateEmail.Visible = false;
            }
            if (txtCity.Text == "")
            {

                txtCity.Focus();
                //lblvalidateEmail.Text = "Please Input Your Email";
                return;
            }

            if (txtCity.Text != "")
            {
                aClient.City = txtCity.Text.Trim();
                //lblvalidateEmail.Visible = false;
            }
            if (txtMobileNumber.Text == "")
            {

                txtMobileNumber.Focus();
                //lblvalidateEmail.Text = "Please Input Your Email";
                return;
            }

            if (txtMobileNumber.Text != "")
            {
                aClient.MobileNumber = txtMobileNumber.Text.Trim();
                //lblvalidateEmail.Visible = false;
            }

            if (txtPassword.Text == "")
            {

                txtPassword.Focus();
                //lblvalidatepassword.Text = "Please Input Your Password";
                return;
            }
            if (txtPassword.Text != "")
            {
                aClient.Password = txtPassword.Text.Trim();
                //lblvalidatepassword.Visible = false;
            }
            if (txtConfirmPassword.Text == "")
            {

                txtConfirmPassword.Focus();
                //lblvalidateconfirmpassword.Text = "Please Input Your confirm Password";
                return;
            }
            if (txtConfirmPassword.Text != "")
            {
                aClient.ConfirmPassword = txtConfirmPassword.Text.Trim();
                //lblvalidateconfirmpassword.Visible = false;
            }






            Client aClient1 = aClientManager.RegisterClient(aClient);
            lblRegistration.Text = aClient1.FirstName + " " + "Successfully Registered";
        }
    }
}