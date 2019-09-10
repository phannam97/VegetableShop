using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using VegetableStore.Interfaces;
using VegetableStore.Models.ViewModels;
using VegetableStore.Repositories;

namespace VegetableStore.Areas.Admin.Controllers
{
    public class BlogController : BaseController
    {

        private readonly IBlogRepository _blogRepository;

        public BlogController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAllPaging(string startDate, string endDate, string keyword, int page, int pageSize)
        {
            var model = _blogRepository.GetAllPaging( page, pageSize);
            return new OkObjectResult(model);
        }

        [HttpPost]
        public IActionResult SaveEntity(BlogViewModel productVm)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new BadRequestObjectResult(allErrors);
            }
            else
            {
                if (productVm.Id == 0)
                {
                    _blogRepository.Add(productVm);
                }
                else
                {
                    _blogRepository.Update(productVm);
                }
                _blogRepository.Save();
                return new OkObjectResult(productVm);
            }
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return new BadRequestObjectResult(ModelState);
            }
            else
            {
                _blogRepository.Delete(id);
                _blogRepository.Save();

                return new OkObjectResult(id);
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var model = _blogRepository.GetAll();
            return new OkObjectResult(model);
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var model = _blogRepository.GetById(id);

            return new OkObjectResult(model);
        }


        [HttpPost]
        public IActionResult SaveImages(int productId, string[] images)
        {
            _blogRepository.AddImages(productId, images);
            _blogRepository.Save();
            return new OkObjectResult(images);
        }

        [HttpGet]
        public IActionResult GetImages(int productId)
        {
            var images = _blogRepository.GetImages(productId);
            return new OkObjectResult(images);
        }

    }
}