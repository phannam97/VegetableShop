using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using OfficeOpenXml;
using OfficeOpenXml.Table;
using VegetableStore.Interfaces;
using VegetableStore.Models.ViewModels;
using VegetableStore.Utilities;

namespace VegetableStore.Areas.Admin.Controllers
{
    public class ProductController : BaseController
    {
        private IProductRepository _productRepository;        
        private readonly IHostingEnvironment _hostingEnvironment;
        private IProductCategoryRepository _productCategoryRepository;

        public ProductController(IProductRepository productRepository, IHostingEnvironment hostingEnvironment, IProductCategoryRepository productCategoryRepository)
        {
            _productRepository = productRepository;
            _hostingEnvironment = hostingEnvironment;
            _productCategoryRepository = productCategoryRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAllCategories()
        {
            var model = _productCategoryRepository.GetAll();
            return new OkObjectResult(model);
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var model = _productRepository.GetAll();
            return new OkObjectResult(model);
        }
        [HttpGet]
        public IActionResult GetAllPaging(int? categoryId, string keyword, int page, int pageSize)
        {
            var model = _productRepository.GetAllPaging(categoryId, keyword, page, pageSize);
         
            return new OkObjectResult(model);
        }



        [HttpGet]
        public IActionResult GetById(int id)
        {
            var model = _productRepository.GetById(id);

            return new OkObjectResult(model);
        }

        [HttpPost]
        public IActionResult SaveEntity(ProductViewModel productVm)
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
                    _productRepository.Add(productVm);
                }
                else
                {
                    _productRepository.Update(productVm);
                }
                _productRepository.Save();
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
                _productRepository.Delete(id);
                _productRepository.Save();

                return new OkObjectResult(id);
            }
        }
        [HttpPost]
        public IActionResult SaveQuantities(int productId, List<ProductQuantityViewModel> quantities)
        {
            _productRepository.AddQuantity(productId, quantities);
            _productRepository.Save();
            return new OkObjectResult(quantities);
        }

        [HttpGet]
        public IActionResult GetQuantities(int productId)
        {
            var quantities = _productRepository.GetQuantities(productId);
            return new OkObjectResult(quantities);
        }
        [HttpPost]
        public IActionResult SaveImages(int productId, string[] images)
        {
            _productRepository.AddImages(productId, images);
            _productRepository.Save();
            return new OkObjectResult(images);
        }

        [HttpGet]
        public IActionResult GetImages(int productId)
        {
            var images = _productRepository.GetImages(productId);
            return new OkObjectResult(images);
        }     
        
        [HttpPost]
        public IActionResult ImportExcel(IList<IFormFile> files, int categoryId)
        {
            if (files != null && files.Count > 0)
            {
                var file = files[0];
                var filename = ContentDispositionHeaderValue
                                   .Parse(file.ContentDisposition)
                                   .FileName
                                   .Trim('"');

                string folder = _hostingEnvironment.WebRootPath + $@"\uploaded\excels";
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                string filePath = Path.Combine(folder, filename);

                using (FileStream fs = System.IO.File.Create(filePath))
                {
                    file.CopyTo(fs);
                    fs.Flush();
                }
                _productRepository.ImportExcel(filePath, categoryId);
                _productRepository.Save();
                return new OkObjectResult(filePath);
            }
            return new NoContentResult();
        }
        [HttpPost]
        public IActionResult ExportExcel()
        {
            string sWebRootFolder = _hostingEnvironment.WebRootPath;
            string directory = Path.Combine(sWebRootFolder, "export-files");
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            string sFileName = $"Product_{DateTime.Now:yyyyMMddhhmmss}.xlsx";
            string fileUrl = $"{Request.Scheme}://{Request.Host}/export-files/{sFileName}";
            FileInfo file = new FileInfo(Path.Combine(directory, sFileName));
            if (file.Exists)
            {
                file.Delete();
                file = new FileInfo(Path.Combine(sWebRootFolder, sFileName));
            }
            var products = _productRepository.GetAll();
            using (ExcelPackage package = new ExcelPackage(file))
            {
                // add a new worksheet to the empty workbook
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Products");
                worksheet.Cells["A1"].LoadFromCollection(products, true, TableStyles.Light1);
                worksheet.Cells.AutoFitColumns();
                package.Save(); //Save the workbook.
            }
            return new OkObjectResult(fileUrl);
        }
    }
}