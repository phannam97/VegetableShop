using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VegetableStore.Models.Enums;
using VegetableStore.Utilities;

namespace VegetableStore.Models.ViewModels
{
    public class CheckoutViewModel : BillViewModel    
    {
        public List<ShoppingCartViewModel> Carts { get; set; }
        public List<EnumModel> PaymentMethods
        {
            get
            {
                return ((PaymentMethod[])Enum.GetValues(typeof(PaymentMethod)))
                    .Select(c => new EnumModel
                    {
                        Value = (int)c,
                        Name = c.GetDescription()
                    }).ToList();
            }
        }
    }
}
