#pragma checksum "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Donor\editaccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58c45e9874a9f8e8ce21d7d768dee1e37bbb749b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Donor_editaccount), @"mvc.1.0.view", @"/Views/Donor/editaccount.cshtml")]
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
#line 1 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\_ViewImports.cshtml"
using Blooddonation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\_ViewImports.cshtml"
using Blooddonation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58c45e9874a9f8e8ce21d7d768dee1e37bbb749b", @"/Views/Donor/editaccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67e771b9cd45c68150793946ee098399759e1c40", @"/Views/_ViewImports.cshtml")]
    public class Views_Donor_editaccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Donor\editaccount.cshtml"
  
    ViewData["Title"] = "editaccount";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58c45e9874a9f8e8ce21d7d768dee1e37bbb749b3572", async() => {
                WriteLiteral("\r\n\r\n    <link href=\"css/sidebar.css\" rel=\"stylesheet\">\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58c45e9874a9f8e8ce21d7d768dee1e37bbb749b4608", async() => {
                WriteLiteral(@"
    <div class=""side-navbar active-nav d-flex justify-content-between flex-wrap flex-column""
         id=""sidebar"">

        <ul class=""nav flex-column text-white w-100"">
            <a href=""/donor/dashbord"" class=""nav-link h3 text-white my-2"">
                Donor
            </a>
            <li class=""nav-link"">
                <i class=""bx bxs-dashboard""></i>
                <span class=""mx-2""><a class=""inner-anchor"" href=""/donor/dashbord""> Home</a></span>
            </li>

            <li class=""nav-link"">
                <i class=""bx bx-git-pull-request""></i>
                <span class=""mx-2""><a class=""inner-anchor"" href=""/donor/appointmentlist"">Appointment</a></span>
            </li>



            <li class=""nav-link"">
                <i class=""bx bx-git-pull-request""></i>
                <span class=""mx-2""><a class=""inner-anchor"" href=""/donor/donationrequestlist""> Request</a></span>
            </li>



            <li class=""nav-link"">
                <i class=""bx b");
                WriteLiteral(@"x-edit""></i>
                <span class=""mx-2""><a class=""inner-anchor"" href=""/donor/editaccount""> Edit Account</a></span>
            </li>

            <li class=""nav-link"">
                <i class=""bx bx-log-out""></i>
                <span class=""mx-2""><a class=""inner-anchor"" href=""/donor/logout""> Log Out </a></span>
            </li>
        </ul>

    </div>




    <!-- Main Wrapper -->
    <div class=""p-1 my-container active-cont"" style=""background-color:lightblue"">
        <!-- Top Nav -->
        <nav class=""navbar top-navbar navbar-light bg-light px-5"">
            <br />
        </nav>


        <br><br>
        <section class=""h-100"">
                <div class=""col-xxl-4 col-xl-5 col-lg-5 col-md-7 col-sm-9"">
                    <div class=""card shadow-lg"">
                        <div class=""card-body p-5"">
                            <h1 class=""fs-4 card-title fw-bold mb-4"">Edit Account <a href=""/donor/changepassword""> <button type=""submit"" class=""btn btn-primary ms-");
                WriteLiteral("auto\">ChangePasssword </button></a> </h1>\r\n                            \r\n\r\n\r\n");
#nullable restore
#line 74 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Donor\editaccount.cshtml"
                                 using (Html.BeginForm("editaccount", "donor", FormMethod.Post))
                                {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"mb-3\">\r\n                                    <label for=\"OldUsername\">OldUsername</label>\r\n                                    <input type=\"text\" id=\"OldUserName\" name=\"OldUserName\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=", 2672, "", 2696, 1);
#nullable restore
#line 79 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Donor\editaccount.cshtml"
WriteAttributeValue("", 2679, ViewBag.username, 2679, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n                                </div>\r\n");
                WriteLiteral(@"                                <div class=""mb-3"">
                                    <label for=""NewUsername"">NewUsername</label>
                                    <input type=""text"" id=""NewUsername"" name=""NewUsername"" class=""form-control"" />

                                </div>
");
                WriteLiteral(@"                                <div style=""align-self:auto; margin-left: 130px;"">
                                    <button type=""submit"" class=""btn btn-primary ms-auto"">
                                        Update
                                    </button>
                                    <br><br>
                                </div>
");
#nullable restore
#line 96 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\Donor\editaccount.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <br />\r\n\r\n\r\n                        </div>\r\n                    </div>\r\n            </div>\r\n        </section>\r\n        <br>\r\n\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
