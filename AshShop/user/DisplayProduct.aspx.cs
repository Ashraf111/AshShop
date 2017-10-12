using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AshShop.BLL;

namespace AshShop.user
{
    public partial class DisplayProduct : System.Web.UI.Page
    {
        private string requestQuery, requestSeachProduct;
        ProductManager aProductManager=new ProductManager();
        //Dis Product List
        protected void Page_Load(object sender, EventArgs e)
        {
            requestSeachProduct = Request.QueryString["search"];
            requestQuery =Request.QueryString["category"] ;
            if (requestQuery == null)
            {
                ProductRepeater.DataSource = aProductManager.DisplayProductManager();
                ProductRepeater.DataBind();
            }
            else
            {
                ProductRepeater.DataSource = aProductManager.DisplayProductManagerByCategory(requestQuery);
                ProductRepeater.DataBind();
            }
            if (requestQuery == null && requestSeachProduct!=null)
            {
                ProductRepeater.DataSource = aProductManager.DisplayProductManagerBySearch(requestSeachProduct);
                ProductRepeater.DataBind();
            }
            
        }
    }
}