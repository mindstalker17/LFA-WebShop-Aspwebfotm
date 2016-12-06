using LFA_shop.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LFA_shop
{
    public partial class user : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<userModel> lst = new List<userModel>();
            SqlConnection conn = new SqlConnection(@"Persist Security Info=False;User ID=sa;password=mindstalker17;Initial Catalog=LFA-shop;Data Source=DESKTOP-J5G526A\SQLEXPRESS;");
            SqlDataReader rdr = null;
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from tbl_user",conn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                userModel each = new userModel();
                each.fullname = (string)rdr[3];
                each.address = (string)rdr[4];
                each.phone = (int)rdr[5];
                each.username = (string)rdr[1];
                each.password = (string)rdr[2];
                lst.Add(each);
            }
            conn.Close();
            user_GridView.DataSource = lst;
            user_GridView.DataBind();


        }
    }
}