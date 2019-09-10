using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VegetableStore.Utilities;

namespace VegetableStore.Models.ViewModels
{
    public class ListBlogViewModel
    {
        public PagedResult<BlogViewModel> Data { get; set; }
        public int? PageSize { set; get; }

        
        public List<SelectListItem> PageSizes { get; } = new List<SelectListItem>
        {
            new SelectListItem(){Value = "8",Text = "8"},
            new SelectListItem(){Value = "16",Text = "16"},
            new SelectListItem(){Value = "32",Text = "32"},
        };
    }
}
