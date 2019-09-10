using AutoMapper;
using VegetableStore.Models;
using VegetableStore.Models.ViewModels;

namespace VegetableStore.AutoMapp
{
    internal class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductQuantity, ProductQuantityViewModel>().MaxDepth(2);
            CreateMap<ProductImage, ProductImageViewModel>().MaxDepth(2);
            CreateMap<Product, ProductViewModel>();
            CreateMap<Function, FunctionViewModel>();
            CreateMap<Bill, BillViewModel>();
            CreateMap<BillDetail, BillDetailViewModel>();
            CreateMap<ProductCategory, ProductCategoryViewModel>();
            CreateMap<Blog, BlogViewModel>();
        }
    }
}