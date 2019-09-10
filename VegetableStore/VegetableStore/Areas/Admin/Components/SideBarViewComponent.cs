using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using VegetableStore.Extensions;
using VegetableStore.Interfaces;
using VegetableStore.Models.ViewModels;
using VegetableStore.Utilities;

namespace VegetableStore.Areas.Admin.Components
{
    public class SideBarViewComponent: ViewComponent
    {
        private IFunctionRepository _functionRepository;

        public SideBarViewComponent(IFunctionRepository functionRepository)
        {
            _functionRepository = functionRepository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var roles = ((ClaimsPrincipal)User).GetSpecificClaim("Roles");
            List<FunctionViewModel> functions;
            if (roles.Split(";").Contains(CommonConstants.AppRole.AdminRole))
            {
                functions = await _functionRepository.GetAll(string.Empty);
            }
            else
            {
                //TODO: Get by permission
                functions = await _functionRepository.GetAll(string.Empty);
            }
            return View(functions);
        }
    }
}
