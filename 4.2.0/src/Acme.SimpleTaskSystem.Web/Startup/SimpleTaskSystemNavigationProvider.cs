﻿using Abp.Application.Navigation;
using Abp.Localization;

namespace Acme.SimpleTaskSystem.Web.Startup
{
    /// <summary>
    /// This class defines menus for the application.
    /// </summary>
    public class SimpleTaskSystemNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.Home,
                        L("HomePage"),
                        url: "",
                        icon: "fa fa-home"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.About,
                        L("About"),
                        url: "Home/About",
                        icon: "fa fa-info"
                        )
                );
            //.AddItem(
            //        new MenuItemDefinition(
            //            PageNames.Create,
            //            L("Create"),
            //            url: "Employees/Create",
            //            icon: "fa fa-info"
            //            )
            //        );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, SimpleTaskSystemConsts.LocalizationSourceName);
        }
    }
}