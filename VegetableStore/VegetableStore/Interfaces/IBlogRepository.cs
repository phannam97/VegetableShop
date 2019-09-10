using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VegetableStore.Models.ViewModels;
using VegetableStore.Utilities;

namespace VegetableStore.Interfaces
{
    public interface IBlogRepository : IDisposable
    {
        void Update(BlogViewModel blog);
        void Delete(int id);
        void Save();
        void AddImages(int blogId, string[] images);
        BlogViewModel GetById(int id);
        List<BlogViewModel> GetAll();
        List<BlogImageViewModel> GetImages(int blogId);
        BlogViewModel Add(BlogViewModel blog);
        PagedResult<BlogViewModel> GetAllPaging( int page, int pageSize);
    }
}
