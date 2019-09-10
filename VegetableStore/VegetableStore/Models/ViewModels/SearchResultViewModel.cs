using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VegetableStore.Models.ViewModels
{
    public class SearchResultViewModel : ListProductViewModel
    {
        public string Keyword { get; set; }
    }
}
