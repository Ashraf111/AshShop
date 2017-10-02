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
    public partial class AddCategory : System.Web.UI.Page
    {
        ProductCategoryManager aProductCategoryManager=new ProductCategoryManager();
        ProductCategory aProductCategory=new ProductCategory();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("AdminLoginUI.aspx");
            }
            List<ProductCategory> aProductCategories = aProductCategoryManager.LoadProductCategories();
            DataListDeleteProductCategory.DataSource = aProductCategories;
            DataListDeleteProductCategory.DataBind();
        }

        protected void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (txtAddCategory.Text!=null)
            {
                aProductCategory.ProductCategoryName = txtAddCategory.Text;
            }
            else
            {
                txtAddCategory.Focus();
            }
           
           int rowAffected= aProductCategoryManager.InsertCategory(aProductCategory.ProductCategoryName);
           if (rowAffected>0)
           {

               lblCategoryAddMessage.Text = "Category Successfull Added";
           }
           else
           {
               lblCategoryAddMessage.Text = "Category Not Added";
           }

        }
    }
}