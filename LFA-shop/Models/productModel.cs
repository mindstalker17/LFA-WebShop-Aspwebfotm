using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LFA_shop.Models
{
    public class productModel
    {
        public int Product_id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
    }
}