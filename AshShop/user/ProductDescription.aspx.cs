using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AshShop.BLL;
using AshShop.DAL.Model;

namespace AshShop.user
{
    public partial class ProductDescription : System.Web.UI.Page
    {
        ProductManager aProductManager=new ProductManager();
        private int id;
       
        protected void Page_Load(object sender, EventArgs e)
            //Display a Product From List of Product By product ID
        {

                if (Request.QueryString["id"] != null)
                {
                    id = Convert.ToInt32(Request.QueryString["id"]);
                    ProductDescriptionRepeater.DataSource = aProductManager.DisplayProductManagerById(id);
                    ProductDescriptionRepeater.DataBind();

                }
                else
                {
                    Response.Redirect("DisplayProduct.aspx");

                }
            int a = getProductQuntity();
            if (a==0)
            {
                btnAddToCart.Visible = false;
                txtProductAmount.Visible = false;
                lblEnterProductText.Visible = false;
                lblProductAmount.Text = "There is no more product";
            }



        }

        public int getProductQuntity()
        {
            Product aProduct = aProductManager.GetProductManagerById(id);
            return aProduct.ProductQuntity;
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {

            Product aProducts = aProductManager.GetProductManagerById(id);
            if (txtProductAmount.Text == String.Empty || Convert.ToInt32(txtProductAmount.Text.Trim()) > aProducts.ProductQuntity)
            {

                lblProductAmount.Text = "Your Amount More than available";
                Response.Redirect("ProductDescription.aspx?id=" + id);
                
            }
            else
            {
                
                Product aProduct = aProductManager.GetProductManagerById(id);
                aProductManager.UpdateProduct(id, Convert.ToInt32(txtProductAmount.Text.Trim()));
                if (aProduct.ProductQuntity>0)
                {
                    if (Request.Cookies["aa"] == null)
                    {
                        Response.Cookies["aa"].Value = (Convert.ToInt32(aProduct.id) + "," + aProduct.ProductName + "," + aProduct.ProductDescription + "," + Convert.ToInt32(aProduct.ProductPrice) + "," + Convert.ToInt32(txtProductAmount.Text.Trim()) + "," + aProduct.ProductImage);
                        Response.Cookies["aa"].Expires = DateTime.Now.AddDays(1);
                    }
                    else
                    {
                        Response.Cookies["aa"].Value = Request.Cookies["aa"].Value + "|" + (Convert.ToInt32(aProduct.id) + "," + aProduct.ProductName + "," + aProduct.ProductDescription + "," + Convert.ToInt32(aProduct.ProductPrice) + "," + Convert.ToInt32(txtProductAmount.Text.Trim()) + "," + aProduct.ProductImage);
                        Response.Cookies["aa"].Expires = DateTime.Now.AddDays(1);
                    }
                }
                

            }
            


            Response.Redirect("ProductDescription.aspx?id=" + id);


        }
    }
}