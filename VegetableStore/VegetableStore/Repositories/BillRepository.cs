using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using VegetableStore.Interfaces;
using VegetableStore.Models;
using VegetableStore.Models.Enums;
using VegetableStore.Models.ViewModels;
using VegetableStore.Utilities;

namespace VegetableStore.Repositories
{
    public class BillRepository: IBillRepository
    {
        private readonly IRepository<Bill, int> _orderRepository;
        private readonly IRepository<BillDetail, int> _orderDetailRepository;
        private readonly IRepository<Product, int> _productRepository;
        private readonly IUnitOfWork _unitOfWork;

        public BillRepository(IRepository<Bill, int> orderRepository, IRepository<BillDetail, int> orderDetailRepository, IRepository<Product, int> productRepository, IUnitOfWork unitOfWork)
        {
            _orderRepository = orderRepository;
            _orderDetailRepository = orderDetailRepository;
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
        }

        public void Create(BillViewModel billVm)
        {
            var order = Mapper.Map<BillViewModel, Bill>(billVm);
            var orderDetails = Mapper.Map<List<BillDetailViewModel>, List<BillDetail>>(billVm.BillDetails);
            foreach (var detail in orderDetails)
            {
                var product = _productRepository.FindById(detail.ProductId);
                detail.Price = product.Price;
            }
            order.BillDetails = orderDetails;
            _orderRepository.Add(order);
        }

        public void Update(BillViewModel billVm)
        {
            //Mapping to order domain
            var order = Mapper.Map<BillViewModel, Bill>(billVm);

            //Get order Detail
            var newDetails = order.BillDetails;

            //new details added
            var addedDetails = newDetails.Where(x => x.Id == 0).ToList();

            //get updated details
            var updatedDetails = newDetails.Where(x => x.Id != 0).ToList();

            //Existed details
            var existedDetails = _orderDetailRepository.FindAll(x => x.BillId == billVm.Id);

            //Clear db
            order.BillDetails.Clear();

            foreach (var detail in updatedDetails)
            {
                var product = _productRepository.FindById(detail.ProductId);
                detail.Price = product.Price;
                _orderDetailRepository.Update(detail);
            }
            
            foreach (var detail in addedDetails)
            {
                var product = _productRepository.FindById(detail.ProductId);
                detail.Price = product.Price;
                _orderDetailRepository.Add(detail);
            }
            order.BillDetails = existedDetails.ToList();
            if (order.BillStatus == BillStatus.Completed)
            {
                foreach (var item in order.BillDetails)
                {
                    var product = _productRepository.FindById(item.ProductId);
                    product.Quality -= item.Quantity;
                    product.Vote++;
                    _productRepository.Update(product);
                }

            }
            _orderDetailRepository.RemoveMultiple(existedDetails.Except(updatedDetails).ToList());

            _orderRepository.Update(order);
        }

        public void UpdateStatus(int billId, BillStatus status)
        {
            var order = _orderRepository.FindById(billId);
            order.BillStatus = status;
            order.BillDetails= _orderDetailRepository.FindAll(x => x.BillId == billId).ToList();
            if (status == BillStatus.Completed)
            {
                foreach(var item in order.BillDetails)
                {
                    var product = item.Product;
                    product.Quality -= item.Quantity;
                    _productRepository.Update(product);
                }
                
            }
            _orderRepository.Update(order);
        }
        public List<BillViewModel> GetBills()
        {
            var bill = _orderRepository.FindAll();
            var billVm = Mapper.Map<List<Bill>, List<BillViewModel>>(bill.ToList());
            foreach(var item in billVm)
            {
                var billDetailVm = _orderDetailRepository.FindAll(x => x.BillId == item.Id).ProjectTo<BillDetailViewModel>().ToList();
                item.BillDetails = billDetailVm;
            }
            
            return billVm;
        }
     

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public PagedResult<BillViewModel> GetAllPaging(string startDate, string endDate, string keyword
            , int pageIndex, int pageSize)
        {
                var query = _orderRepository.FindAll();
                if (!string.IsNullOrEmpty(startDate))
                {
                    DateTime start = DateTime.ParseExact(startDate, "dd/MM/yyyy", CultureInfo.GetCultureInfo("vi-VN"));
                    query = query.Where(x => x.DateCreated >= start);
                }
                if (!string.IsNullOrEmpty(endDate))
                {
                    DateTime end = DateTime.ParseExact(endDate, "dd/MM/yyyy", CultureInfo.GetCultureInfo("vi-VN"));
                    query = query.Where(x => x.DateCreated <= end);
                }
                if (!string.IsNullOrEmpty(keyword))
                {
                    query = query.Where(x => x.CustomerName.Contains(keyword) || x.CustomerMobile.Contains(keyword));
                }
                var totalRow = query.Count();
                var data = query.OrderByDescending(x => x.DateCreated)
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize)
                    .ProjectTo<BillViewModel>()
                    .ToList();
            return new PagedResult<BillViewModel>()
                {
                    CurrentPage = pageIndex,
                    PageSize = pageSize,
                    Results = data,
                    RowCount = totalRow
                };
        }

        public BillViewModel GetDetail(int billId)
        {
            var bill = _orderRepository.FindSingle(x => x.Id == billId);
            var billVm = Mapper.Map<Bill, BillViewModel>(bill);
            var billDetailVm = _orderDetailRepository.FindAll(x => x.BillId == billId).ProjectTo<BillDetailViewModel>().ToList();
            billVm.BillDetails = billDetailVm;
            return billVm;
        }

        public List<BillDetailViewModel> GetBillDetails(int billId)
        {
            return _orderDetailRepository
                .FindAll(x => x.BillId == billId, c => c.Bill, c => c.Product)
                .ProjectTo<BillDetailViewModel>().ToList();
        }
        public void RemoveBill(int id)
        {
            var bill = _orderRepository.FindById(id);
            _orderRepository.Remove(bill);
        }
       
        public BillDetailViewModel CreateDetail(BillDetailViewModel billDetailVm)
        {
            var billDetail = Mapper.Map<BillDetailViewModel, BillDetail>(billDetailVm);
            _orderDetailRepository.Add(billDetail);
            return billDetailVm;
        }

        public void DeleteDetail(int productId, int billId)
        {
            var detail = _orderDetailRepository.FindSingle(x => x.ProductId == productId
           && x.BillId == billId);
            _orderDetailRepository.Remove(detail);
        }
    }
}
