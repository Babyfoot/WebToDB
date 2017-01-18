using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAppConToSQL
{
    public class DB
    {
        public string ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";

        public void Inserts(String Name, String City, String Phone, String Mail)
        {
            string QueryString = "Insert into dbo.Contact (Name,City,Phone,Mail) Values ('" + Name + "','" + City + "','" + Phone + "','" + Mail + "')";
            SqlConnection con = new SqlConnection(ConStr);
            SqlCommand cmd = new SqlCommand(QueryString, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Update()
        {
        }

        public void Delete()
        {
        }
    }
}