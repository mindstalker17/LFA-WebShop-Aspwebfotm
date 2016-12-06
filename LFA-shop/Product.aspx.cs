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
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<productModel> cat = new List<productModel>();
            SqlConnection conn = new SqlConnection(@"Persist Security Info=False;User ID=sa;password=mindstalker17;Initial Catalog=LFA-shop;Data Source=DESKTOP-J5G526A\SQLEXPRESS;");
            SqlDataReader rdr = null;
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from tbl_product", conn);

            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                productModel each = new productModel();
                each.Product_id = (int)rdr[0];
                each.Name = (string)rdr[1];
                each.Description = (string)rdr[2];
                each.Image = (string)rdr[3];
                each.Price = (int)rdr[4];
                cat.Add(each);
            }

            conn.Close();
            product_gridview.DataSource = cat;
            product_gridview.DataBind();

        }
    }
}