using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using VegetableStore.Models.Enums;
using VegetableStore.Models.ViewModels;

namespace VegetableStore.Models
{
    [Table("Products")]
    public class Product:DomainEntity<int>
    {
        public Product()
        {
        }

        public Product(string name, int categoryId, string image, decimal price, int month, int quality, int vote, string description, string tags, Status status)
        {
            Name = name;
            CategoryId = categoryId;
            Image = image;
            Price = price;
            Month = month;
            Quality = quality;
            Vote = vote;
            Description = description;
            Tags = tags;
            Status = status;
        }

        [StringLength(255)]
        [Required]
        public string Name { get; set; }
        [ForeignKey("CategoryId")]
        public virtual ProductCategory ProductCategory { set; get; }
        [Required]
        public int Month { get; set; }
        public int CategoryId { get; set; }
        [StringLength(255)]
        public string Image { get; set; }

        [DefaultValue(0)]
        public decimal Price { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        //public string Content { get; set; }
        
        [StringLength(255)]
        public string Tags { get; set; }        
        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
        //public DateTime DateEnd { set; get; }
        public int Quality { get; set; }
        public int Vote { get; set; }
        public Status Status { set; get; }
    }


}
