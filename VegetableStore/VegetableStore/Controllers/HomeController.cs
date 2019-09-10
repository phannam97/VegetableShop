using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Localization;
using VegetableStore.Interfaces;
using VegetableStore.Models;
using VegetableStore.Models.ViewModels;

namespace VegetableStore.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository _productRepository;
        IConfiguration _configuration;
        private readonly IStringLocalizer<HomeController> _localizer;

        public HomeController(IProductRepository productRepository, IStringLocalizer<HomeController> localizer, IConfiguration configuration)
        {
            _productRepository = productRepository;
            _localizer = localizer;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            
                //var title = _localizer["Title"];
                //var culture = HttpContext.Features.Get<IRequestCultureFeature>().RequestCulture.Culture.Name;
                ViewData["BodyClass"] = "cms-index-index cms-home-page";
                var homeVm = new HomeViewModel();
                homeVm.HotProducts = _productRepository.GetHotProduct(5);
                homeVm.TopSellProducts = _productRepository.GetLastest(5);
                
                return View(homeVm);
            
        }
        [HttpGet]
        public IActionResult GetById(int id)
        {
            var model = _productRepository.GetById(id);

            return new OkObjectResult(model);
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Gop(int id, int? pageSize, string sortBy, int page = 1)
        {
            var gop = new ListProductViewModel();
            if (pageSize == null)
                pageSize = _configuration.GetValue<int>("PageSize");
            gop.PageSize = pageSize;
            gop.SortType = sortBy;
            gop.Data = _productRepository.GetAllByGop(7, page, pageSize.Value);
            return View(gop);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
