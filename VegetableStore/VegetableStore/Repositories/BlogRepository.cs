using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VegetableStore.Interfaces;
using VegetableStore.Models;
using VegetableStore.Models.Enums;
using VegetableStore.Models.ViewModels;
using VegetableStore.Utilities;

namespace VegetableStore.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        private IRepository<Blog, int> _blogRepository;
        private IRepository<BlogImage, int> _blogImageRepository;
        private IUnitOfWork _unitOfWork;

        public BlogRepository(IRepository<Blog, int> blogRepository, IRepository<BlogImage, int> blogImageRepository, IUnitOfWork unitOfWork)
        {
            _blogRepository = blogRepository;
            _blogImageRepository = blogImageRepository;
            _unitOfWork = unitOfWork;
        }
        public PagedResult<BlogViewModel> GetAllPaging(int page, int pageSize)
        {
            var query = _blogRepository.FindAll(x => x.Status == Status.Active);

            int totalRow = query.Count();

            var data = query.OrderByDescending(x => x.DateCreated)
                .Skip((page - 1) * pageSize).Take(pageSize).ProjectTo<BlogViewModel>().ToList();

            //var data = query.ProjectTo<BlogViewModel>().ToList();

            var paginationSet = new PagedResult<BlogViewModel>()
            {
                Results = data,
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize
            };
            return paginationSet;
        }
        public List<BlogViewModel> GetAll()
        {
            return _blogRepository.FindAll().ProjectTo<BlogViewModel>().ToList();
        }
        public void AddImages(int blogId, string[] images)
        {
            _blogImageRepository.RemoveMultiple(_blogImageRepository.FindAll(x => x.BlogId == blogId).ToList());
            foreach (var image in images)
            {
                _blogImageRepository.Add(new BlogImage()
                {
                    Path = image,
                    BlogId = blogId,
                });
            }
        }
        public BlogViewModel Add(BlogViewModel blogVm)
        {
            var blog = Mapper.Map<BlogViewModel, Blog>(blogVm);
            _blogRepository.Add(blog);

            return blogVm;
        }
        public void Delete(int id)
        {
            _blogRepository.Remove(id);
        }
        public void Save()
        {
            _unitOfWork.Commit();
        }
        public void Update(BlogViewModel productVm)
        {


            var product = Mapper.Map<BlogViewModel, Blog>(productVm);

            _blogRepository.Update(product);
        }
        public List<BlogImageViewModel> GetImages(int blogId)
        {
            return _blogImageRepository.FindAll(x => x.BlogId == blogId)
                .ProjectTo<BlogImageViewModel>().ToList();
        }
        public BlogViewModel GetById(int id)
        {
            var blog = _blogRepository.FindById(id);
            blog.Vote += 1;
            _blogRepository.Update(blog);
            return Mapper.Map<Blog, BlogViewModel>(blog);
        }


        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
