using System.ComponentModel.DataAnnotations.Schema;

namespace VegetableStore.Models
{
    [Table("BillDetails")]
    public class BillDetail : DomainEntity<int>
    {
        public BillDetail(int id, int billId, int productId, decimal price)
        {
            Id = id;
            BillId = billId;
            ProductId = productId;
            Price = price;
        }

        public int BillId { set; get; }

        public int ProductId { set; get; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }

        [ForeignKey("BillId")]
        public virtual Bill Bill { set; get; }

        [ForeignKey("ProductId")]
        public virtual Product Product { set; get; }

        
    }
}
