using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VegetableStore.Interfaces;
using VegetableStore.Models.Enums;

namespace VegetableStore.Controllers.Components
{
    public class CategoryMenuViewComponent : ViewComponent
    {
        private IProductCategoryRepository _productCategoryRepository;
        private IMemoryCache _memoryCache;

        public CategoryMenuViewComponent(IProductCategoryRepository productCategoryRepository, IMemoryCache memoryCache)
        {
            _productCategoryRepository = productCategoryRepository;
            _memoryCache = memoryCache;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = _memoryCache.GetOrCreate(CacheKeys.ProductCategories, entry => {
                entry.SlidingExpiration = TimeSpan.FromHours(2);
                return _productCategoryRepository.GetAll();
            });

            return View(categories);
        }
    }
}
