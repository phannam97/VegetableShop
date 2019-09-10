using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using OfficeOpenXml;
using OfficeOpenXml.Table;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using VegetableStore.Interfaces;
using VegetableStore.Models.ViewModels;

namespace VegetableStore.Areas.Admin.Controllers
{
    public class ProductCategoryController : BaseController
    {
        private IProductRepository _productRepository;
        private IProductCategoryRepository _productCategoryRepository;
        private readonly IHostingEnvironment _hostingEnvironment;

        public ProductCategoryController(IProductRepository productRepository, IProductCategoryRepository productCategoryRepository, IHostingEnvironment hostingEnvironment)
        {
            _productRepository = productRepository;
            _productCategoryRepository = productCategoryRepository;
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }


        #region Get Data API
        [HttpGet]
        public IActionResult GetById(int id)
        {
            var model = _productCategoryRepository.GetById(id);

            return new ObjectResult(model);
        }
        [HttpPost]
        public IActionResult SaveEntity(ProductCategoryViewModel productVm)
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
                    _productCategoryRepository.Add(productVm);
                }
                else
                {
                    _productCategoryRepository.Update(productVm);
                }
                _productCategoryRepository.Save();
                return new OkObjectResult(productVm);

            }
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return new BadRequestResult();
            }
            else
            {
                _productCategoryRepository.Delete(id);
                _productCategoryRepository.Save();
                return new OkObjectResult(id);
            }
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var model = _productCategoryRepository.GetAll();
            return new OkObjectResult(model);
        }

        [HttpPost]
        public IActionResult UpdateParentId(int sourceId, int targetId, Dictionary<int, int> items)
        {
            if (!ModelState.IsValid)
            {
                return new BadRequestObjectResult(ModelState);
            }
            else
            {
                if (sourceId == targetId)
                {
                    return new BadRequestResult();
                }
                else
                {
                    _productCategoryRepository.UpdateParentId(sourceId, targetId, items);
                    _productCategoryRepository.Save();
                    return new OkResult();
                }
            }
        }

        [HttpPost]
        public IActionResult ReOrder(int sourceId, int targetId)
        {
            if (!ModelState.IsValid)
            {
                return new BadRequestObjectResult(ModelState);
            }
            else
            {
                if (sourceId == targetId)
                {
                    return new BadRequestResult();
                }
                else
                {
                    _productCategoryRepository.ReOrder(sourceId, targetId);
                    _productCategoryRepository.Save();
                    return new OkResult();
                }
            }
        }

        #endregion

    }
}
