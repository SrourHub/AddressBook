#pragma checksum "/Users/kingali/Desktop/AddressBookApp/AddressBookApp/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e160e27e8256d740329d5e832519ab9f387ada6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/kingali/Desktop/AddressBookApp/AddressBookApp/Views/_ViewImports.cshtml"
using AddressBookApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/kingali/Desktop/AddressBookApp/AddressBookApp/Views/_ViewImports.cshtml"
using AddressBookApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e160e27e8256d740329d5e832519ab9f387ada6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e64abf958480e1150dd2e4944b9c8a4daf2e384f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/kingali/Desktop/AddressBookApp/AddressBookApp/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""jumbotron"">
    <h1>Address Book</h1>
</div>
<div class=""row"">
    <div class=""col-md-4"">
        <h2>Welcome</h2>
        <p>
            Address Book is a simple web application designed
            to preview a set of organizations and people involved
            with these organizations.
        </p>
    </div>
    <div class=""col-md-4"">
        <h2>How it Works</h2>
        <p>You can view the list of organizations/people by clicking on either ""Organizations"" or ""People"" on the top left corner.</p>
    </div>
    <div class=""col-md-4"">
        <h2>Thank You</h2>
        <p>
            This web application has been designed and implemented by Ali Srour.
            Contact: - Email Address: srourali07@gmail.com
                     - Phone Number:  0096176846119
        </p>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591