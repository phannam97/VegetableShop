using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VegetableStore.Models.ViewModels
{
    public class ProductQuantityViewModel
    {
        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public ProductViewModel Product { get; set; }
    }
}
