using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AshShop.DAL.GetWay;
using AshShop.DAL.Model;


namespace AshShop.BLL
{
    public class AdminLoginManager
    {
        AdminLoginGetWay aAdminLoginGetWay=new AdminLoginGetWay();
       
        /// <summary>
        ///Business Logic To get Login Of admin
        /// </summary>
        public int LoginAdminManager(AdminLogin aAdminLogins )
        {
            int RowAffected = aAdminLoginGetWay.LoginAdminGetWay(aAdminLogins);
            return RowAffected;
        }

    }
}