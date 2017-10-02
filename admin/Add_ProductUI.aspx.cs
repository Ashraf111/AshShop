using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AshShop.BLL;
using AshShop.DAL.Model;
using AshShop.Extra_AppCode;

namespace AshShop.admin
{
    public partial class Add_ProductUI : System.Web.UI.Page
    {
        ProductCategoryManager aProductCategoryManager=new ProductCategoryManager();
        ProductManager aProductManager = new ProductManager();
       
        private string getRnadomnumber;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"]== null)
            {
                Response.Redirect("AdminLoginUI.aspx");
            }
            if (!IsPostBack)
            {
                LoadProductCategory();
            }
        }

        public void LoadProductCategory()
        {
            List<ProductCategory> aProductCategories = aProductCategoryManager.LoadProductCategories();
            DropDownListProductCategory.DataSource = aProductCategories;
            DropDownListProductCategory.DataValueField = "ProductCategoryName";
            DropDownListProductCategory.DataTextField = "ProductCategoryName";
            DropDownListProductCategory.DataBind();
        }

        protected void btnAddProduct_Click(object sender, EventArgs e)
        {
            Product aProduct=new Product();

           getRnadomnumber=RandomImageName.GetRandomImageName(10).ToString();
           
            fileUploadProduct.SaveAs(Request.PhysicalApplicationPath+"./images/"+getRnadomnumber+fileUploadProduct.FileName.ToString());
            aProduct.ProductName = txtProductName.Text;
            aProduct.ProductDescription = txtProductDescription.Text;
            aProduct.ProductPrice = Convert.ToInt32(txtProdutPrice.Text);
            aProduct.ProductQuntity = Convert.ToInt32(txtProductQuntity.Text);
            aProduct.ProductImage="../images/"+getRnadomnumber+fileUploadProduct.FileName.ToString();
            aProduct.ProductCategory = DropDownListProductCategory.SelectedValue;
            int insertProduct = aProductManager.InsertProductManager(aProduct);
            if (insertProduct>0)
            {
                lblInsertProduct.Text = "Successfully add";
            }
            else
            {
                lblInsertProduct.Text = "Product not  added";
            }
        }

    }
}