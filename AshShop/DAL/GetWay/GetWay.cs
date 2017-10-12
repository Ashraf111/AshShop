using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace AshShop.DAL.GetWay
{
    /// <summary>
    /// Getway class is to connect all class into database
    /// </summary>

    public class GetWay
    {
        private string str = WebConfigurationManager.ConnectionStrings["AshShopDB"].ConnectionString;
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataReader reader;
        public string Query;

        public GetWay()
        {
            con=new SqlConnection(str);
        }


    }
}