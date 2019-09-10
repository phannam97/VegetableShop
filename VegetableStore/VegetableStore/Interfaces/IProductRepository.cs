using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VegetableStore.Models.ViewModels;
using VegetableStore.Utilities;

namespace VegetableStore.Interfaces
{
    public interface IProductRepository:IDisposable
    {
        List<ProductViewModel> GetAll();

        PagedResult<ProductViewModel> GetAllPaging(int? categoryId,string keyword, int page, int pageSize);

        PagedResult<ProductViewModel> GetAllByMonth(int? categoryId, int month, int page, int pageSize);
        PagedResult<ProductViewModel> GetAllBySlice(int? categoryId,  int page, int pageSize);
        PagedResult<ProductViewModel> GetAllByGop(int? categoryId, int page, int pageSize);
        ProductViewModel Add(ProductViewModel product);

        void Update(ProductViewModel product);

        void Delete(int id);

        ProductViewModel GetById(int id);

        void ImportExcel(string filePath, int categoryId);


        void Save();

        void AddQuantity(int productId, List<ProductQuantityViewModel> quantities);

        List<ProductQuantityViewModel> GetQuantities(int productId);

        void AddImages(int productId, string[] images);

        List<ProductImageViewModel> GetImages(int productId);

        List<ProductViewModel> GetLastest(int top);

        List<ProductViewModel> GetHotProduct(int top);   
        bool CheckAvailability(int productId);
        List<ProductViewModel> GetRelatedProducts(int id, int top);

        List<ProductViewModel> GetUpsellProducts(int top);
    }
}
