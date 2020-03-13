﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.UI.Navigation;

namespace Lsw.Abp.AspNetCore.Mvc.UI.Theme.Stisla.Themes.Stisla.Components.Menu
{
    public class LeftNavbarMenuViewComponent : AbpViewComponent
    {
        private readonly IMenuManager _menuManager;

        public LeftNavbarMenuViewComponent(IMenuManager menuManager)
        {
            _menuManager = menuManager;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var menu = await _menuManager.GetAsync(StandardMenus.Main);
            return View("~/Themes/Stisla/Components/Menu/Default.cshtml", menu);
        }
    }
}
