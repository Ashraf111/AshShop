using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using AshShop.DAL.Model;

namespace AshShop.DAL.GetWay
{
    public class ClientGetWay:GetWay
    {
        public Client RegisterClient(Client aClient)
        {
            con.Open();
            Query = "insert into tblUserRegistration(First_Name,Last_Name,Email,Address,City,Mobile_Number,Password,Confirm_Password) values('"+aClient.FirstName+"','"+aClient.LastName+"','"+aClient.Email+"','"+aClient.Address+"','"+aClient.City+"','"+aClient.MobileNumber+"','"+aClient.Password+"','"+aClient.ConfirmPassword+"')";
            cmd=new SqlCommand(Query,con);
            cmd.ExecuteNonQuery();
            con.Close();
            return aClient;
        }
        public Client LoginClient(Client aClient)
        {
            Client aClient1=new Client();
            con.Open();
            Query = "select * from tblUserRegistration";
            cmd = new SqlCommand(Query, con);
            reader=cmd.ExecuteReader();

            while (reader.Read())
            {
                if (aClient.Email == reader["Email"].ToString() && aClient.Password== reader["Password"].ToString())
                {

                    aClient1.FirstName = reader["First_Name"].ToString();
                    aClient1.LastName = reader["Last_Name"].ToString();
                    aClient1.Email = reader["Email"].ToString();
                    aClient1.Address = reader["Address"].ToString();
                    aClient1.City = reader["City"].ToString();
                    aClient1.MobileNumber = reader["Mobile_Number"].ToString();
                    aClient1.Password = reader["Password"].ToString();

                    return aClient1;


                }

            }
            con.Close();
            return null;

        }
        public int UpdateClient(Client aClient)
        {
            con.Open();
            Query = "update tblUserRegistration set First_Name='"+aClient.FirstName+"', Last_Name='"+aClient.LastName+"',Address='"+aClient.Address+"',City='"+aClient.City+"',Mobile_Number='"+aClient.MobileNumber+"' where Email='"+aClient.Email+"'";
            cmd = new SqlCommand(Query, con);
            int rowAffected= cmd.ExecuteNonQuery();
            con.Close();
            return rowAffected;

        }
    }
}