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
    public class BlogController : Controller
    {
        IConfiguration _configuration;
        IBlogRepository _blogRepository;

        public BlogController(IConfiguration configuration, IBlogRepository blogRepository)
        {
            _configuration = configuration;
            _blogRepository = blogRepository;
        }

        [Route("blog.html")]
        public IActionResult Blog(int? pageSize,  int page = 1)
        {
            var products = new ListBlogViewModel();
            if (pageSize == null)
                pageSize = _configuration.GetValue<int>("PageSize");
            products.PageSize = pageSize;
            products.Data = _blogRepository.GetAllPaging( page, pageSize.Value);
            return View(products);
        }

        [Route("blog-{id}.html", Name = "blogDetail")]
        public IActionResult BlogDetails(int id)
        {
            ViewData["BodyClass"] = "blog-page";
            var model = new BlogViewModel();
            model = _blogRepository.GetById(id);
            _blogRepository.Save();
            return View(model);
        }
    }
}