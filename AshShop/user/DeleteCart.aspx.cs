using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AshShop.BLL;
using AshShop.DAL.Model;
using System.Data;
using System.Data.SqlClient;

namespace AshShop.user
{
    public partial class DeleteCart : System.Web.UI.Page
     {
        ProductManager aProductManager=new ProductManager();
         string s;
         string t;
         string[] a = new string[6];
         int id;
         string Product_Name, Product_Description, Product_Images;
         private int Product_id, Product_Price, Product_Quantity;
         int _count = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["id"]);
            DataTable dt = new DataTable();
            dt.Rows.Clear();
            dt.Columns.AddRange(new DataColumn[6] { new DataColumn("Id"), new DataColumn("Product_Name"), new DataColumn("Product_Description"), new DataColumn("Product_Price"), new DataColumn("Product_Quantity"), new DataColumn("Product_Images") });
            if (Request.Cookies["aa"] != null)
            {
                s = Convert.ToString(Request.Cookies["aa"].Value);
                string[] strArr = s.Split('|');
                for (int i = 0; i < strArr.Length; i++)
                {
                    t = Convert.ToString(strArr[i].ToString());
                    string[] strArr1 = t.Split(',');
                    for (int j = 0; j < strArr1.Length; j++)
                    {
                        a[j] = strArr1[j].ToString();

                    }
                    dt.Rows.Add(Convert.ToInt32(a[0]),a[1], a[2], Convert.ToInt32(a[3]),Convert.ToInt32(a[4]), a[5]);

                }
            }
           
            foreach (DataRow dr in dt.Rows)
            {
                if (_count==id)
                {
                    Product_id = Convert.ToInt32(dr["Id"]);
                    Product_Quantity = Convert.ToInt32(dr["Product_Quantity"]);
                }
                _count = _count + 1;

            }
            aProductManager.IncreaseProductQuantity(Product_id, Product_Quantity);
            dt.Rows.RemoveAt(id);


                Response.Cookies["aa"].Expires = DateTime.Now.AddDays(-10d);
               
      
        
            foreach (DataRow dr in dt.Rows)
            {
                Product_id = Convert.ToInt32(dr["Id"]);
                Product_Name = dr["Product_Name"].ToString();
                Product_Description = dr["Product_Description"].ToString();
                Product_Price = Convert.ToInt32(dr["Product_Price"]);
                Product_Quantity = Convert.ToInt32(dr["Product_Quantity"]);
                Product_Images = dr["Product_Images"].ToString();


                if (Response.Cookies["aa"].Value == null)
                {
                    Response.Cookies["aa"].Value = (Convert.ToInt32(Product_id) + "," + Product_Name + "," +
                                                    Product_Description + "," + Convert.ToInt32(Product_Price) + "," +
                                                    Convert.ToInt32(Product_Quantity) + "," + Product_Images);
                    Response.Cookies["aa"].Expires = DateTime.Now.AddDays(1);
                }
                else
                {
                    Response.Cookies["aa"].Value =Response.Cookies["aa"].Value+"|"+(Convert.ToInt32(Product_id) + "," + Product_Name + "," +
                                Product_Description + "," + Convert.ToInt32(Product_Price) + "," +
                                Convert.ToInt32(Product_Quantity) + "," + Product_Images);
                    Response.Cookies["aa"].Expires = DateTime.Now.AddDays(1);
                }

            }




            Response.Redirect("ViewCartUI.aspx");





        }
    }
}