#pragma checksum "D:\Ocelot\Shata\GateWayProgress\CustomerMvc\Views\Home\Customer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39d78b9238fb971df379eabc57addf478a3dc725"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Customer), @"mvc.1.0.view", @"/Views/Home/Customer.cshtml")]
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
#line 1 "D:\Ocelot\Shata\GateWayProgress\CustomerMvc\Views\_ViewImports.cshtml"
using CustomerMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Ocelot\Shata\GateWayProgress\CustomerMvc\Views\_ViewImports.cshtml"
using CustomerMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39d78b9238fb971df379eabc57addf478a3dc725", @"/Views/Home/Customer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b033cd4e98d1aa7ca481bb8d9afff06f5d4ec2c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Customer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CustomerMvc.Models.Customer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Ocelot\Shata\GateWayProgress\CustomerMvc\Views\Home\Customer.cshtml"
  
    ViewData["Title"] = "Customer";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Customer</h1>\r\n\r\n<table>\r\n\r\n");
#nullable restore
#line 12 "D:\Ocelot\Shata\GateWayProgress\CustomerMvc\Views\Home\Customer.cshtml"
 foreach (var item in Model) 
{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 16 "D:\Ocelot\Shata\GateWayProgress\CustomerMvc\Views\Home\Customer.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 19 "D:\Ocelot\Shata\GateWayProgress\CustomerMvc\Views\Home\Customer.cshtml"
           Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 22 "D:\Ocelot\Shata\GateWayProgress\CustomerMvc\Views\Home\Customer.cshtml"
           Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n               ");
#nullable restore
#line 25 "D:\Ocelot\Shata\GateWayProgress\CustomerMvc\Views\Home\Customer.cshtml"
          Write(item.EmailAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n           \r\n                </tr>\r\n");
#nullable restore
#line 29 "D:\Ocelot\Shata\GateWayProgress\CustomerMvc\Views\Home\Customer.cshtml"
                
   }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CustomerMvc.Models.Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
