using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fiorella.Models;
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

            var basketDatasJson = _accessor.HttpContext.Request.Cookies["basket"];

            if (string.IsNullOrEmpty(basketDatasJson))
            {
                return View(new List<BasketCartVM>());
            }

            List<BasketCartVM> basketDatas = JsonConvert.DeserializeObject<List<BasketCartVM>>(basketDatasJson);

            return View(basketDatas);

        }

        
        
    }
}

