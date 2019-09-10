using AutoMapper;
using AutoMapper.QueryableExtensions;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using VegetableStore.Interfaces;
using VegetableStore.Models;
using VegetableStore.Models.Enums;
using VegetableStore.Models.ViewModels;
using VegetableStore.Utilities;

namespace VegetableStore.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private IRepository<Product, int> _productRepository;
        private IRepository<ProductImage, int> _productImageRepository;
        private IUnitOfWork _unitOfWork;
        private IRepository<ProductQuantity, int> _productQuantityRepository;

        public ProductRepository(IRepository<Product, int> productRepository, IRepository<ProductImage, int> productImageRepository, IUnitOfWork unitOfWork, IRepository<ProductQuantity, int> productQuantityRepository)
        {
            _productRepository = productRepository;
            _productImageRepository = productImageRepository;
            _unitOfWork = unitOfWork;
            _productQuantityRepository = productQuantityRepository;
        }

        public ProductViewModel Add(ProductViewModel productVm)
        {
            var product = Mapper.Map<ProductViewModel, Product>(productVm);
            _productRepository.Add(product);

            return productVm;
        }
        public void AddQuantity(int productId, List<ProductQuantityViewModel> quantities)
        {
            _productQuantityRepository.RemoveMultiple(_productQuantityRepository.FindAll(x => x.ProductId == productId).ToList());
            foreach (var quantity in quantities)
            {
                _productQuantityRepository.Add(new ProductQuantity()
                {
                    ProductId = productId,
                    Quantity = quantity.Quantity
                });
            }
        }
        public void Delete(int id)
        {
            _productRepository.Remove(id);
        }
        public List<ProductViewModel> GetAll()
        {
            return _productRepository.FindAll().ProjectTo<ProductViewModel>().ToList();
        }

        public ProductViewModel GetById(int id)
        {
            var product = _productRepository.FindById(id);
            product.Vote += 1;
            _productRepository.Update(product);
            return Mapper.Map<Product, ProductViewModel>(product);
        }
        public List<ProductViewModel> GetRelatedProducts(int id, int top)
        {
            var product = _productRepository.FindById(id);
            return _productRepository.FindAll(x => x.Status == Status.Active
                && x.Id != id)
            .OrderByDescending(x => x.DateCreated)
            .Take(top)
            .ProjectTo<ProductViewModel>()
            .ToList();
        }

        public List<ProductViewModel> GetUpsellProducts(int top)
        {
            return _productRepository.FindAll(x => x.Price != null)
               .OrderByDescending(x => x.DateModified)
               .Take(top)
               .ProjectTo<ProductViewModel>().ToList();
        }
        public void ImportExcel(string filePath, int categoryId)
        {
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet workSheet = package.Workbook.Worksheets[1];
                Product product;
                for (int i = workSheet.Dimension.Start.Row + 1; i <= workSheet.Dimension.End.Row; i++)
                {
                    product = new Product();

                    product.Name = workSheet.Cells[i, 1].Value.ToString();

                    product.Description = workSheet.Cells[i, 2].Value.ToString();


                    decimal.TryParse(workSheet.Cells[i, 4].Value.ToString(), out var price);
                    product.Price = price;
                    decimal.TryParse(workSheet.Cells[i, 5].Value.ToString(), out var promotionPrice);


                    //product.Content = workSheet.Cells[i, 6].Value.ToString();



                    product.Status = Status.Active;

                    _productRepository.Add(product);
                }
            }
        }
        public PagedResult<ProductViewModel> GetAllPaging(int? categoryId, string keyword, int page, int pageSize)
        {
            var query = _productRepository.FindAll(x => x.Status == Status.Active);
            if (!string.IsNullOrEmpty(keyword))
                query = query.Where(x => x.Name.Contains(keyword));
            if (categoryId.HasValue)
                query = query.Where(x => x.CategoryId == categoryId.Value);

            int totalRow = query.Count();

            query = query.OrderByDescending(x => x.DateCreated)
                .Skip((page - 1) * pageSize).Take(pageSize);

            var data = query.ProjectTo<ProductViewModel>().ToList();

            var paginationSet = new PagedResult<ProductViewModel>()
            {
                Results = data,
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize
            };
            return paginationSet;
        }

        public PagedResult<ProductViewModel> GetAllByMonth(int? categoryId, int month, int page, int pageSize)
        {
            month = DateTime.Today.Month;
            var query = _productRepository.FindAll(x => x.Status == Status.Active);
            if (month < 4)
                query = query.Where(x => x.Month < 4);
            else if (month < 7)
                query = query.Where(x => x.Month < 7 && x.Month > 3);
            else if (month < 10)
                query = query.Where(x => x.Month < 10 && x.Month > 6);
            else query = query.Where(x => x.Month > 9);

            int totalRow = query.Count();

            query = query.OrderByDescending(x => x.DateCreated)
                .Skip((page - 1) * pageSize).Take(pageSize);

            var data = query.ProjectTo<ProductViewModel>().ToList();

            var paginationSet = new PagedResult<ProductViewModel>()
            {
                Results = data,
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize
            };
            return paginationSet;
        }
        public PagedResult<ProductViewModel> GetAllBySlice(int? categoryId, int page, int pageSize)
        {

            var query = _productRepository.FindAll(x => x.Status == Status.Active);

            if (categoryId.HasValue)
                query = query.Where(x => x.CategoryId == categoryId.Value);
            int totalRow = query.Count();

            query = query.OrderByDescending(x => x.DateCreated)
                .Skip((page - 1) * pageSize).Take(pageSize);

            var data = query.ProjectTo<ProductViewModel>().ToList();

            var paginationSet = new PagedResult<ProductViewModel>()
            {
                Results = data,
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize
            };
            return paginationSet;
        }
        public PagedResult<ProductViewModel> GetAllByGop(int? categoryId, int page, int pageSize)
        {

            var query = _productRepository.FindAll(x => x.Status == Status.Active);

            if (categoryId.HasValue)
                query = query.Where(x => x.CategoryId == categoryId.Value);
            int totalRow = query.Count();

            query = query.OrderByDescending(x => x.DateCreated)
                .Skip((page - 1) * pageSize).Take(pageSize);

            var data = query.ProjectTo<ProductViewModel>().ToList();

            var paginationSet = new PagedResult<ProductViewModel>()
            {
                Results = data,
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize
            };
            return paginationSet;
        }
        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(ProductViewModel productVm)
        {


            var product = Mapper.Map<ProductViewModel, Product>(productVm);

            _productRepository.Update(product);
        }
        public List<ProductImageViewModel> GetImages(int productId)
        {
            return _productImageRepository.FindAll(x => x.ProductId == productId)
                .ProjectTo<ProductImageViewModel>().ToList();
        }

        public void AddImages(int productId, string[] images)
        {
            _productImageRepository.RemoveMultiple(_productImageRepository.FindAll(x => x.ProductId == productId).ToList());
            foreach (var image in images)
            {
                _productImageRepository.Add(new ProductImage()
                {
                    Path = image,
                    ProductId = productId,
                    Caption = string.Empty
                });
            }
        }
        public List<ProductViewModel> GetLastest(int top)
        {
            return _productRepository.FindAll(x => x.Status == Status.Active && x.CategoryId == 7).OrderByDescending(x => x.DateCreated)
                .Take(top).ProjectTo<ProductViewModel>().ToList();
        }

        public List<ProductViewModel> GetHotProduct(int top)
        {
            return _productRepository.FindAll(x => x.Status == Status.Active && x.CategoryId != 1 && x.CategoryId != 7)
                .OrderByDescending(x => x.Vote)
                .Take(top)
                .ProjectTo<ProductViewModel>()
                .ToList();
        }
        public List<ProductQuantityViewModel> GetQuantities(int productId)
        {
            return _productQuantityRepository.FindAll(x => x.ProductId == productId).ProjectTo<ProductQuantityViewModel>().ToList();
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        public bool CheckAvailability(int productId)
        {
            var quantity = _productQuantityRepository.FindSingle(x => x.ProductId == productId);
            if (quantity == null)
                return false;
            return quantity.Quantity > 0;
        }
    }
}
