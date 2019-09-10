using System.Collections.Generic;
using VegetableStore.Models.Enums;
using VegetableStore.Models.ViewModels;
using VegetableStore.Utilities;

namespace VegetableStore.Interfaces
{
    public interface IBillRepository
    {
        void Create(BillViewModel billVm);
        void Update(BillViewModel billVm);
        List<BillViewModel> GetBills();
        PagedResult<BillViewModel> GetAllPaging(string startDate, string endDate, string keyword,
            int pageIndex, int pageSize);
        void RemoveBill(int id);
        BillViewModel GetDetail(int billId);

        BillDetailViewModel CreateDetail(BillDetailViewModel billDetailVm);

        void DeleteDetail(int productId, int billId);

        void UpdateStatus(int orderId, BillStatus status);

        List<BillDetailViewModel> GetBillDetails(int billId);
     
        void Save();
    }
}