#pragma checksum "C:\Users\User\Downloads\Acme.SimpleTaskSystem\4.2.0\src\Acme.SimpleTaskSystem.Web\Views\Shared\Components\TopMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edc5d10c5f17fb36d86225b9368f48d3d6cc6e9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TopMenu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TopMenu/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/TopMenu/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_TopMenu_Default))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\User\Downloads\Acme.SimpleTaskSystem\4.2.0\src\Acme.SimpleTaskSystem.Web\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#line 1 "C:\Users\User\Downloads\Acme.SimpleTaskSystem\4.2.0\src\Acme.SimpleTaskSystem.Web\Views\Shared\Components\TopMenu\Default.cshtml"
using Abp.Collections.Extensions;

#line default
#line hidden
#line 2 "C:\Users\User\Downloads\Acme.SimpleTaskSystem\4.2.0\src\Acme.SimpleTaskSystem.Web\Views\Shared\Components\TopMenu\Default.cshtml"
using Acme.SimpleTaskSystem.Web.Views.Shared.Components.TopMenu;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edc5d10c5f17fb36d86225b9368f48d3d6cc6e9b", @"/Views/Shared/Components/TopMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c27a29fc3216fab53422f05b41d5aea17dd0ff8d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TopMenu_Default : Acme.SimpleTaskSystem.Web.Views.SimpleTaskSystemRazorPage<TopMenuViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\User\Downloads\Acme.SimpleTaskSystem\4.2.0\src\Acme.SimpleTaskSystem.Web\Views\Shared\Components\TopMenu\Default.cshtml"
  
    //TODO: Get current virtual path
    var ApplicationPath = "/";

#line default
#line hidden
#line 8 "C:\Users\User\Downloads\Acme.SimpleTaskSystem\4.2.0\src\Acme.SimpleTaskSystem.Web\Views\Shared\Components\TopMenu\Default.cshtml"
 foreach (var menuItem in Model.MainMenu.Items)
{

#line default
#line hidden
            BeginContext(246, 7, true);
            WriteLiteral("    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 253, "\"", 321, 1);
#line 10 "C:\Users\User\Downloads\Acme.SimpleTaskSystem\4.2.0\src\Acme.SimpleTaskSystem.Web\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 261, Model.ActiveMenuItemName == menuItem.Name ? "active" : "", 261, 60, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(322, 2, true);
            WriteLiteral(">\n");
            EndContext();
#line 11 "C:\Users\User\Downloads\Acme.SimpleTaskSystem\4.2.0\src\Acme.SimpleTaskSystem.Web\Views\Shared\Components\TopMenu\Default.cshtml"
         if (menuItem.Items.IsNullOrEmpty())
        {

#line default
#line hidden
            BeginContext(379, 14, true);
            WriteLiteral("            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 393, "\"", 450, 1);
#line 13 "C:\Users\User\Downloads\Acme.SimpleTaskSystem\4.2.0\src\Acme.SimpleTaskSystem.Web\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 400, Model.CalculateMenuUrl(ApplicationPath, menuItem), 400, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(451, 2, true);
            WriteLiteral(">\n");
            EndContext();
#line 14 "C:\Users\User\Downloads\Acme.SimpleTaskSystem\4.2.0\src\Acme.SimpleTaskSystem.Web\Views\Shared\Components\TopMenu\Default.cshtml"
                 if (!string.IsNullOrWhiteSpace(menuItem.Icon))
                {

#line default
#line hidden
            BeginContext(535, 22, true);
            WriteLiteral("                    <i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 557, "\"", 579, 1);
#line 16 "C:\Users\User\Downloads\Acme.SimpleTaskSystem\4.2.0\src\Acme.SimpleTaskSystem.Web\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 565, menuItem.Icon, 565, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(580, 6, true);
            WriteLiteral("></i>\n");
            EndContext();
#line 17 "C:\Users\User\Downloads\Acme.SimpleTaskSystem\4.2.0\src\Acme.SimpleTaskSystem.Web\Views\Shared\Components\TopMenu\Default.cshtml"
                }

#line default
#line hidden
            BeginContext(604, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(621, 20, false);
#line 18 "C:\Users\User\Downloads\Acme.SimpleTaskSystem\4.2.0\src\Acme.SimpleTaskSystem.Web\Views\Shared\Components\TopMenu\Default.cshtml"
           Write(menuItem.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(641, 18, true);
            WriteLiteral("\n            </a>\n");
            EndContext();
#line 20 "C:\Users\User\Downloads\Acme.SimpleTaskSystem\4.2.0\src\Acme.SimpleTaskSystem.Web\Views\Shared\Components\TopMenu\Default.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(692, 47, true);
            WriteLiteral("            <a href=\"\" data-toggle=\"dropdown\">\n");
            EndContext();
#line 24 "C:\Users\User\Downloads\Acme.SimpleTaskSystem\4.2.0\src\Acme.SimpleTaskSystem.Web\Views\Shared\Components\TopMenu\Default.cshtml"
                 if (!string.IsNullOrWhiteSpace(menuItem.Icon))
                {

#line default
#line hidden
            BeginContext(821, 22, true);
            WriteLiteral("                    <i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 843, "\"", 865, 1);
#line 26 "C:\Users\User\Downloads\Acme.SimpleTaskSystem\4.2.0\src\Acme.SimpleTaskSystem.Web\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 851, menuItem.Icon, 851, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(866, 6, true);
            WriteLiteral("></i>\n");
            EndContext();
#line 27 "C:\Users\User\Downloads\Acme.SimpleTaskSystem\4.2.0\src\Acme.SimpleTaskSystem.Web\Views\Shared\Components\TopMenu\Default.cshtml"
                }

#line default
#line hidden
            BeginContext(890, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(907, 20, false);
#line 28 "C:\Users\User\Downloads\Acme.SimpleTaskSystem\4.2.0\src\Acme.SimpleTaskSystem.Web\Views\Shared\Components\TopMenu\Default.cshtml"
           Write(menuItem.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(927, 57, true);
            WriteLiteral("\n            </a>\n            <ul class=\"dropdown-menu\">\n");
            EndContext();
#line 31 "C:\Users\User\Downloads\Acme.SimpleTaskSystem\4.2.0\src\Acme.SimpleTaskSystem.Web\Views\Shared\Components\TopMenu\Default.cshtml"
                 foreach (var subMenuItem in menuItem.Items)
                {

#line default
#line hidden
            BeginContext(1063, 51, true);
            WriteLiteral("                    <li>\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1114, "\"", 1174, 1);
#line 34 "C:\Users\User\Downloads\Acme.SimpleTaskSystem\4.2.0\src\Acme.SimpleTaskSystem.Web\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 1121, Model.CalculateMenuUrl(ApplicationPath, subMenuItem), 1121, 53, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1175, 2, true);
            WriteLiteral(">\n");
            EndContext();
#line 35 "C:\Users\User\Downloads\Acme.SimpleTaskSystem\4.2.0\src\Acme.SimpleTaskSystem.Web\Views\Shared\Components\TopMenu\Default.cshtml"
                             if (!string.IsNullOrWhiteSpace(subMenuItem.Icon))
                            {

#line default
#line hidden
            BeginContext(1286, 34, true);
            WriteLiteral("                                <i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1320, "\"", 1345, 1);
#line 37 "C:\Users\User\Downloads\Acme.SimpleTaskSystem\4.2.0\src\Acme.SimpleTaskSystem.Web\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 1328, subMenuItem.Icon, 1328, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1346, 6, true);
            WriteLiteral("></i>\n");
            EndContext();
#line 38 "C:\Users\User\Downloads\Acme.SimpleTaskSystem\4.2.0\src\Acme.SimpleTaskSystem.Web\Views\Shared\Components\TopMenu\Default.cshtml"
                            }

#line default
#line hidden
            BeginContext(1382, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1411, 23, false);
#line 39 "C:\Users\User\Downloads\Acme.SimpleTaskSystem\4.2.0\src\Acme.SimpleTaskSystem.Web\Views\Shared\Components\TopMenu\Default.cshtml"
                       Write(subMenuItem.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(1434, 56, true);
            WriteLiteral("\n                        </a>\n                    </li>\n");
            EndContext();
#line 42 "C:\Users\User\Downloads\Acme.SimpleTaskSystem\4.2.0\src\Acme.SimpleTaskSystem.Web\Views\Shared\Components\TopMenu\Default.cshtml"
                }

#line default
#line hidden
            BeginContext(1508, 18, true);
            WriteLiteral("            </ul>\n");
            EndContext();
#line 44 "C:\Users\User\Downloads\Acme.SimpleTaskSystem\4.2.0\src\Acme.SimpleTaskSystem.Web\Views\Shared\Components\TopMenu\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(1536, 10, true);
            WriteLiteral("    </li>\n");
            EndContext();
#line 46 "C:\Users\User\Downloads\Acme.SimpleTaskSystem\4.2.0\src\Acme.SimpleTaskSystem.Web\Views\Shared\Components\TopMenu\Default.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TopMenuViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591