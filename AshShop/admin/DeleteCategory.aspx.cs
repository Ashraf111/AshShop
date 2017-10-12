using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AshShop.BLL;

namespace AshShop.admin
{
    public partial class DeleteCategory : System.Web.UI.Page
    {
        ProductCategoryManager aProductCategoryManager=new ProductCategoryManager();
        private string deleteCategoryQuery;
        protected void Page_Load(object sender, EventArgs e)
        {
            deleteCategoryQuery = Request.QueryString["category"];
            aProductCategoryManager.DeleteCategory(deleteCategoryQuery);
            Response.Redirect("AddCategory.aspx");

        }
    }
}