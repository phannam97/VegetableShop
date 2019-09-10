namespace VegetableStore.Models.ViewModels
{
    public class BillDetailViewModel
    {
        public int Id { get; set; }

        public int BillId { set; get; }

        public int ProductId { set; get; }

        public decimal Price { set; get; }
        public int Quantity { set; get; }
        public BillViewModel Bill { set; get; }

        public ProductViewModel Product { set; get; }
       
    }
}