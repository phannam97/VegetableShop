using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using VegetableStore.Models.Enums;

namespace VegetableStore.Models.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [StringLength(255)]
        [Required]
        public string Name { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [StringLength(255)]
        public string Image { get; set; }
        public int Month { get; set; }
        [Required]
        [DefaultValue(0)]
        public decimal Price { get; set; }
        public ProductCategoryViewModel ProductCategory { set; get; }
        [StringLength(255)]
        public string Description { get; set; }
        public int Quality { get; set; }
        public int Vote { get; set; }
        [StringLength(255)]
        public string Tags { get; set; }
        public string Content { get; set; }
        public Status Status { set; get; }
        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
    }
}
