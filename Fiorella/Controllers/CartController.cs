using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiorella.Services.Interfaces;
using Fiorella.ViewModels.Baskets;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Fiorella.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductService _productService;
        private readonly IHttpContextAccessor _accessor;

        public CartController(IProductService productService,
                              IHttpContextAccessor accessor)
        {
            _productService = productService;
            _accessor = accessor;
        }

        public async Task<IActionResult> Index()
        {
            List<BasketCartVM> basketdatas = JsonConvert.DeserializeObject<List<BasketCartVM>>(_accessor.HttpContext.Request.Cookies["basket"]);

            BasketCartVM model;

            foreach (var item in basketdatas)
            {
                 model = new()
                {
                    Id =item.Id,
                    Description=item.Description,
                    Price=item.Price

                };
            }

            return View(basketdatas);
        }
    }
}

