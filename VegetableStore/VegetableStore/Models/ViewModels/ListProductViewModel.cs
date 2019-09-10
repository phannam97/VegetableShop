using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VegetableStore.Utilities;

namespace VegetableStore.Models.ViewModels
{
    public class ListProductViewModel
    {
        public ProductCategoryViewModel Category { set; get; }
        public PagedResult<ProductViewModel> Data { get; set; }
        public int? PageSize { set; get; }
        public string SortType { set; get; }
        public List<SelectListItem> SortTypes { get; } = new List<SelectListItem>
        {
           new SelectListItem(){Value = "atoz",Text = "Theo tên sản phẩm (a - z)"},
            new SelectListItem(){Value = "ztoa",Text = "Theo tên sản phẩm (z - a)"},
            new SelectListItem(){Value = "lowtohigh",Text = "Theo giá (thấp - cao)"},
            new SelectListItem(){Value = "hightolow",Text = "Theo giá (cao - thấp)"}
        };
        public List<SelectListItem> PageSizes { get; } = new List<SelectListItem>
        {
            new SelectListItem(){Value = "8",Text = "8"},
            new SelectListItem(){Value = "16",Text = "16"},
            new SelectListItem(){Value = "32",Text = "32"},
        };
    }
}

