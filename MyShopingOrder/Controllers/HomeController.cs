using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyShopingOrder.Models;

namespace MyShopingOrder.Controllers
{
    public class HomeController : Controller
    {
    
        // GET: Home
        public ActionResult Index()
        {
            var imageUrl = new ImageUrl();
            var model = new List<ProductItems>
            {
             new ProductItems()
             {
               ProductId  = "ABCD",
               ProductDescription = "Form to send Money",
               Units = "0",
               ImageUrl =imageUrl.ImageUrlList[0] //"/Images/logo.jpg"
             },
             new ProductItems()
             {
               ProductId  = "EFGH",
               ProductDescription = "Form to Receive Money",
               Units = "0",
               ImageUrl =imageUrl.ImageUrlList[1]//"/Images/logo.jpg"
             },

              new ProductItems()
             {
               ProductId  = "ABCD",
               ProductDescription = "Form to send Money",
               Units = "0",
               ImageUrl =imageUrl.ImageUrlList[0] //"/Images/logo.jpg"
             },
             new ProductItems()
             {
               ProductId  = "EFGH",
               ProductDescription = "Form to Receive Money",
               Units = "0",
               ImageUrl =imageUrl.ImageUrlList[1]//"/Images/logo.jpg"
             },

              new ProductItems()
             {
               ProductId  = "ABCD",
               ProductDescription = "Form to send Money",
               Units = "0",
               ImageUrl =imageUrl.ImageUrlList[0] //"/Images/logo.jpg"
             },
             new ProductItems()
             {
               ProductId  = "EFGH",
               ProductDescription = "Form to Receive Money",
               Units = "0",
               ImageUrl =imageUrl.ImageUrlList[1]//"/Images/logo.jpg"
             },

              new ProductItems()
             {
               ProductId  = "ABCD",
               ProductDescription = "Form to send Money",
               Units = "0",
               ImageUrl =imageUrl.ImageUrlList[0] //"/Images/logo.jpg"
             },
             new ProductItems()
             {
               ProductId  = "EFGH",
               ProductDescription = "Form to Receive Money",
               Units = "0",
               ImageUrl =imageUrl.ImageUrlList[1]//"/Images/logo.jpg"
             }
            };
            return View(model);
        }

        public ActionResult Order()
        {
            return View();
        }
        public ActionResult OrderDetails()
        {
            var date1 = Request["firstDate"];
            var date2 = Request["lastDate"];
            var imageUrl = new ImageUrl();
            var model = new List<ProductItems>
            {
             new ProductItems()
             {
               ProductId  = "ABCD",
               ProductDescription = "Form to send Money",
               Units = "0",
               ImageUrl =imageUrl.ImageUrlList[0] //"/Images/logo.jpg"
             },
             new ProductItems()
             {
               ProductId  = "EFGH",
               ProductDescription = "Form to Receive Money",
               Units = "0",
               ImageUrl =imageUrl.ImageUrlList[1]//"/Images/logo.jpg"
             },

              new ProductItems()
             {
               ProductId  = "ABCD",
               ProductDescription = "Form to send Money",
               Units = "0",
               ImageUrl =imageUrl.ImageUrlList[0] //"/Images/logo.jpg"
             },
             new ProductItems()
             {
               ProductId  = "EFGH",
               ProductDescription = "Form to Receive Money",
               Units = "0",
               ImageUrl =imageUrl.ImageUrlList[1]//"/Images/logo.jpg"
             },

              new ProductItems()
             {
               ProductId  = "ABCD",
               ProductDescription = "Form to send Money",
               Units = "0",
               ImageUrl =imageUrl.ImageUrlList[0] //"/Images/logo.jpg"
             },
             new ProductItems()
             {
               ProductId  = "EFGH",
               ProductDescription = "Form to Receive Money",
               Units = "0",
               ImageUrl =imageUrl.ImageUrlList[1]//"/Images/logo.jpg"
             },

              new ProductItems()
             {
               ProductId  = "ABCD",
               ProductDescription = "Form to send Money",
               Units = "0",
               ImageUrl =imageUrl.ImageUrlList[0] //"/Images/logo.jpg"
             },
             new ProductItems()
             {
               ProductId  = "EFGH",
               ProductDescription = "Form to Receive Money",
               Units = "0",
               ImageUrl =imageUrl.ImageUrlList[1]//"/Images/logo.jpg"
             }
            };
            return PartialView("OrderDetails",model);
        }
    }
}