#pragma checksum "C:\Users\Frank\source\repos\lab3\Lab3\Lab3\Views\Home\DisplayPerson.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6566adaa3bdb5500f37b891b40ca1f7fe596cae2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DisplayPerson), @"mvc.1.0.view", @"/Views/Home/DisplayPerson.cshtml")]
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
#line 1 "C:\Users\Frank\source\repos\lab3\Lab3\Lab3\Views\_ViewImports.cshtml"
using Lab3;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6566adaa3bdb5500f37b891b40ca1f7fe596cae2", @"/Views/Home/DisplayPerson.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0026fa3d308ec0e5ca053f9f604abd473f8e3067", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DisplayPerson : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab3.Models.Person>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Frank\source\repos\lab3\Lab3\Lab3\Views\Home\DisplayPerson.cshtml"
  
    Layout = "_Layout";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h3>Display Person Data</h3>\r\n<table>\r\n    <tr>\r\n        <td>\r\n            First Name:\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 15 "C:\Users\Frank\source\repos\lab3\Lab3\Lab3\Views\Home\DisplayPerson.cshtml"
       Write(Model.firstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td>\r\n            Last Name:\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 24 "C:\Users\Frank\source\repos\lab3\Lab3\Lab3\Views\Home\DisplayPerson.cshtml"
       Write(Model.lastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td>\r\n            Age:\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 33 "C:\Users\Frank\source\repos\lab3\Lab3\Lab3\Views\Home\DisplayPerson.cshtml"
       Write(Model.age);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td>\r\n            Email Address:\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 42 "C:\Users\Frank\source\repos\lab3\Lab3\Lab3\Views\Home\DisplayPerson.cshtml"
       Write(Model.emailAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td>\r\n            Date of Birth:\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 51 "C:\Users\Frank\source\repos\lab3\Lab3\Lab3\Views\Home\DisplayPerson.cshtml"
       Write(Model.dateOfBirth);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td>\r\n            Password:\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 60 "C:\Users\Frank\source\repos\lab3\Lab3\Lab3\Views\Home\DisplayPerson.cshtml"
       Write(Model.password);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td>\r\n            Description:\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 69 "C:\Users\Frank\source\repos\lab3\Lab3\Lab3\Views\Home\DisplayPerson.cshtml"
       Write(Model.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n</table>\r\n<br />\r\n<br />\r\n<br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab3.Models.Person> Html { get; private set; }
    }
}
#pragma warning restore 1591
