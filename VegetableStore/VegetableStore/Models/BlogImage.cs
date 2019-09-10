using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VegetableStore.Models
{
    [Table("BlogImages")]
    public class BlogImage: DomainEntity<int>
    {
        public int BlogId { get; set; }

        [ForeignKey("BlogId")]
        public virtual Blog Blog { get; set; }

        [StringLength(250)]
        public string Path { get; set; }
    }
}
