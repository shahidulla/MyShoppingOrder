using System.Collections.Generic;
using MyShopingOrder.Helper;

namespace MyShopingOrder.Models
{
    public class ImageUrl
    {
        public  List<string> ImageUrlList { get; set; }

        public ImageUrl()
        {
            
            ImageUrlList =ImageUrlHelper.GetImageUrl();
        }
    }
}