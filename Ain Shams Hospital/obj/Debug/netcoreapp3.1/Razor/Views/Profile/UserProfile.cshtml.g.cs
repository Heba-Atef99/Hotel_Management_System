#pragma checksum "E:\Software Project\My Local Project\Ain Shams University\Views\Profile\UserProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "454d10aca1a90add6c45f1565585818717c013b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_UserProfile), @"mvc.1.0.view", @"/Views/Profile/UserProfile.cshtml")]
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
#line 1 "E:\Software Project\My Local Project\Ain Shams University\Views\_ViewImports.cshtml"
using Ain_Shams_Hospital;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Software Project\My Local Project\Ain Shams University\Views\_ViewImports.cshtml"
using Ain_Shams_Hospital.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Software Project\My Local Project\Ain Shams University\Views\_ViewImports.cshtml"
using Ain_Shams_Hospital.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"454d10aca1a90add6c45f1565585818717c013b6", @"/Views/Profile/UserProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23c69ec494828cf325b64c7c4bec3df379c1a229", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_UserProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ain_Shams_Hospital.Data.Entities.Registration>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Software Project\My Local Project\Ain Shams University\Views\Profile\UserProfile.cshtml"
  
    ViewData["Title"] = "UserProfile";
    Layout = "_PatientLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>My Profile</h1>\r\n\r\n<div>\r\n    \r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "E:\Software Project\My Local Project\Ain Shams University\Views\Profile\UserProfile.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "E:\Software Project\My Local Project\Ain Shams University\Views\Profile\UserProfile.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "E:\Software Project\My Local Project\Ain Shams University\Views\Profile\UserProfile.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "E:\Software Project\My Local Project\Ain Shams University\Views\Profile\UserProfile.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "E:\Software Project\My Local Project\Ain Shams University\Views\Profile\UserProfile.cshtml"
       Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "E:\Software Project\My Local Project\Ain Shams University\Views\Profile\UserProfile.cshtml"
       Write(Html.DisplayFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 35 "E:\Software Project\My Local Project\Ain Shams University\Views\Profile\UserProfile.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "454d10aca1a90add6c45f1565585818717c013b66331", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ain_Shams_Hospital.Data.Entities.Registration> Html { get; private set; }
    }
}
#pragma warning restore 1591
