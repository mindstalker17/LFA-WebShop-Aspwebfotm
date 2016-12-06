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
    public partial class Category : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<categoryModel> cat = new List<categoryModel>();
            SqlConnection conn = new SqlConnection(@"Persist Security Info=False;User ID=sa;password=mindstalker17;Initial Catalog=LFA-shop;Data Source=DESKTOP-J5G526A\SQLEXPRESS;");
            SqlDataReader rdr = null;
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from tbl_category", conn);

            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                categoryModel each = new categoryModel();
                each.Id = (int)rdr[0];
                each.Name =(string) rdr[1];
                cat.Add(each);
            }

             conn.Close();
            category_gridview.DataSource = cat;
            category_gridview.DataBind();
        }
    }
}