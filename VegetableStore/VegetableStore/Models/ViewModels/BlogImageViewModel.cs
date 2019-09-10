using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VegetableStore.Models.ViewModels
{
    public class BlogImageViewModel
    {
        public int Id { get; set; }

        public int BlogId { get; set; }

        public BlogViewModel Blog { get; set; }

        public string Path { get; set; }
    }
}
