using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using VegetableStore.Interfaces;
using VegetableStore.Models.ViewModels;
using VegetableStore.Repositories;

namespace VegetableStore.Controllers
{
    public class ProductController : Controller
    {
        IProductRepository _productRepository;
        IBillRepository _billRepository;
        IConfiguration _configuration;
        IProductCategoryRepository _productCategoryRepository;

        public ProductController(IProductRepository productRepository, IBillRepository billRepository, IConfiguration configuration, IProductCategoryRepository productCategoryRepository)
        {
            _productRepository = productRepository;
            _billRepository = billRepository;
            _configuration = configuration;
            _productCategoryRepository = productCategoryRepository;
        }

        [Route("products.html")]
        public IActionResult Index(int? pageSize, string drop, int page = 1)
        {
            var products = new ListProductViewModel();
            if (pageSize == null)
                pageSize = _configuration.GetValue<int>("PageSize");
            products.PageSize = pageSize;
            products.SortType = drop;
            products.Data = _productRepository.GetAllPaging(null, "", page, pageSize.Value);
            if (drop == "hightolow")
            {
                products.Data.Results = products.Data.Results.OrderByDescending(x => x.Price).ToList();
            }
            if (drop == "lowtohigh")
            {
                products.Data.Results = products.Data.Results.OrderByDescending(x => x.Price).Reverse().ToList();
            }
            if (drop == "atoz")
            {
                products.Data.Results = products.Data.Results.OrderByDescending(x => x.Name).Reverse().ToList();
            }
            if (drop == "ztoa")
            {
                products.Data.Results = products.Data.Results.OrderByDescending(x => x.Name).ToList();
            }
            return View(products);
        }
        [Route("search.html")]
        public IActionResult Search(string keyword, int? pageSize, string drop, int page = 1)
        {
            if (keyword != "")
            {
                var result = new SearchResultViewModel();
                if (pageSize == null)
                    pageSize = _configuration.GetValue<int>("PageSize");

                result.PageSize = pageSize;
                result.SortType = drop;
                result.Data = _productRepository.GetAllPaging(null, keyword, page, pageSize.Value);
                result.Keyword = keyword;
                if (drop == "hightolow")
                {
                    result.Data.Results = result.Data.Results.OrderByDescending(x => x.Price).ToList();
                }
                if (drop == "lowtohigh")
                {
                    result.Data.Results = result.Data.Results.OrderByDescending(x => x.Price).Reverse().ToList();
                }
                if (drop == "atoz")
                {
                    result.Data.Results = result.Data.Results.OrderByDescending(x => x.Name).Reverse().ToList();
                }
                if (drop == "ztoa")
                {
                    result.Data.Results = result.Data.Results.OrderByDescending(x => x.Name).ToList();
                }
                return View(result);
            }
            return View();
        }
        [HttpGet]
        public IActionResult GetById(int id)
        {
            var model = _productRepository.GetById(id);
            _productRepository.Save();
            return new OkObjectResult(model);
        }
        [Route("{name}-c.{id}.html")]
        public IActionResult Catalog(int id, int? pageSize, string drop, int page = 1)
        {
            var catalog = new ListProductViewModel();

            if (pageSize == null)
                pageSize = _configuration.GetValue<int>("PageSize");

            catalog.PageSize = pageSize;
            catalog.SortType = drop;
            if (id == 6)
                catalog.Data = _productRepository.GetAllByMonth(id, 0, page, pageSize.Value);

            else
                catalog.Data = _productRepository.GetAllPaging(id, string.Empty, page, pageSize.Value);
            catalog.Category = _productCategoryRepository.GetById(id);
            if (drop == "hightolow")
            {
                catalog.Data.Results = catalog.Data.Results.OrderByDescending(x => x.Price).ToList();
            }
            if (drop == "lowtohigh")
            {
                catalog.Data.Results = catalog.Data.Results.OrderByDescending(x => x.Price).Reverse().ToList();
            }
            if (drop == "atoz")
            {
                catalog.Data.Results = catalog.Data.Results.OrderByDescending(x => x.Name).Reverse().ToList();
            }
            if (drop == "ztoa")
            {
                catalog.Data.Results = catalog.Data.Results.OrderByDescending(x => x.Name).ToList();
            }
            return View(catalog);
        }

        [Route("{name}-p.{id}.html", Name = "ProductDetail")]
        public IActionResult Details(int id)
        {
            ViewData["BodyClass"] = "product-page";
            var model = new DetailViewModel();
            model.Product = _productRepository.GetById(id);
            model.HotProducts = _productRepository.GetHotProduct(4);
            return View(model);
        }
        [Route("{name}-s.{id}.html", Name = "CommingProductDetail")]
        public IActionResult CommingDetails(int id)
        {
            ViewData["BodyClass"] = "product-page";
            var model = new DetailViewModel();
            model.Product = _productRepository.GetById(id);
            model.HotProducts = _productRepository.GetHotProduct(4);

            return View(model);
        }
    }
}