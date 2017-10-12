using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Caching;
using AshShop.DAL.Model;


namespace AshShop.DAL.GetWay
{
    public class AdminLoginGetWay:GetWay
    {
       
        /// <summary>
        /// Admin Lgin with username and password
        /// </summary>
        public int LoginAdminGetWay(AdminLogin aAdminLogin )
        {
            int RowAffected=0;
            con.Open();
            Query = "select * from tblAdminLogin";
            cmd=new SqlCommand(Query,con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader["AdminName"].ToString()==aAdminLogin.AdminName&&reader["Password"].ToString()==aAdminLogin.Password)
                {
                    RowAffected = 1;
                }
            }

            con.Close();
            return RowAffected;
        }

    }
}