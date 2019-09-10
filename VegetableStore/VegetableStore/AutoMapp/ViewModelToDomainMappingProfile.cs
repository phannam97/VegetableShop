using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VegetableStore.Models;
using VegetableStore.Models.ViewModels;

namespace VegetableStore.AutoMapp

{
    public class ViewModelToDomainMappingProfile :Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ProductViewModel, Product>()
           .ConstructUsing(c => new Product(c.Name, c.CategoryId ,c.Image, c.Price,c.Month,c.Quality,c.Vote
           , c.Description,  c.Tags, c.Status));
            CreateMap<BillViewModel, Bill>()
              .ConstructUsing(c => new Bill(c.Id, c.CustomerName, c.CustomerAddress,
              c.CustomerMobile, c.CustomerMessage, c.BillStatus,
              c.PaymentMethod, c.Status, c.CustomerId));

            CreateMap<BillDetailViewModel, BillDetail>()
              .ConstructUsing(c => new BillDetail(c.Id, c.BillId, c.ProductId,
              c.Price));
            CreateMap<ProductCategoryViewModel, ProductCategory>()
                .ConstructUsing(c => new ProductCategory(c.Name, c.Description, c.ParentId, c.HomeOrder, c.Image, c.HomeFlag,
                c.SortOrder, c.Status));
            CreateMap<BlogViewModel, Blog>()
           .ConstructUsing(c => new Blog(c.Title,  c.Image,c.DateCreated,c.Vote,
            c.Content, c.Tags, c.Status));
        }
        
    }
}
