using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VegetableStore.Models.ViewModels
{
    public class AppRoleViewModel
    {
        public Guid? Id { set; get; }

        public string Name { set; get; }

        public string Description { set; get; }
    }
}
