using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyShopingOrder.Models;

namespace MyShopingOrder.Helper
{
    public static class ImageUrlHelper
    {
        public static List<string> GetImageUrl()
        {
            var imageUrl = new List<string>()
            {
              "/Images/logo.jpg",
              "/Images/s-l500.jpg"
            };

            return imageUrl;
        }
    }
}