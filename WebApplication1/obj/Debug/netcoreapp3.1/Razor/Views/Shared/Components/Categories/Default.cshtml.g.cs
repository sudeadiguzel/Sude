#pragma checksum "C:\Users\Sude Adiguzel\source\repos\WebApplication1\WebApplication1\Views\Shared\Components\Categories\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20cea6e2089b08aeb0afba6987a5ecd75bd5b13b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Categories_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Categories/Default.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Sude Adiguzel\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sude Adiguzel\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Sude Adiguzel\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20cea6e2089b08aeb0afba6987a5ecd75bd5b13b", @"/Views/Shared/Components/Categories/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfc24eb37e021bbfe040184b04852f506f26f1c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Categories_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"list-group\">\r\n        <a href=\"/product/list\" class=\"list-group-item list-group-item-action\">All Products</a>\r\n");
#nullable restore
#line 5 "C:\Users\Sude Adiguzel\source\repos\WebApplication1\WebApplication1\Views\Shared\Components\Categories\Default.cshtml"
        foreach (var category in Model) { 

#line default
#line hidden
#nullable disable
            WriteLiteral("           <a");
            BeginWriteAttribute("href", " href=\"", 205, "\"", 246, 2);
            WriteAttributeValue("", 212, "/product/list/", 212, 14, true);
#nullable restore
#line 6 "C:\Users\Sude Adiguzel\source\repos\WebApplication1\WebApplication1\Views\Shared\Components\Categories\Default.cshtml"
WriteAttributeValue("", 226, category.CategoryId, 226, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", "\r\n           class=\"", 247, "\"", 379, 3);
            WriteAttributeValue("", 267, "list-group-item", 267, 15, true);
            WriteAttributeValue(" ", 282, "list-group-item-action", 283, 23, true);
#nullable restore
#line 7 "C:\Users\Sude Adiguzel\source\repos\WebApplication1\WebApplication1\Views\Shared\Components\Categories\Default.cshtml"
WriteAttributeValue(" ", 305, ViewBag.SelectedCategory == category.CategoryId.ToString()?"active":"", 306, 73, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
#nullable restore
#line 8 "C:\Users\Sude Adiguzel\source\repos\WebApplication1\WebApplication1\Views\Shared\Components\Categories\Default.cshtml"
       Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </a>\r\n");
#nullable restore
#line 10 "C:\Users\Sude Adiguzel\source\repos\WebApplication1\WebApplication1\Views\Shared\Components\Categories\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
