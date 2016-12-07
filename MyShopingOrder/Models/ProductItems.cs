using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Web;

namespace MyShopingOrder.Models
{
    public class ProductItems
    {   [DisplayName("Product Id")]
        public string ProductId { get; set; }
        [DisplayName("Product Description")]
        public string ProductDescription { get; set; }
        [DisplayName("Product Image")]
        public string ImageUrl { get; set; }
        [DisplayName("Units")]
        public string Units { get; set; }
    }
}