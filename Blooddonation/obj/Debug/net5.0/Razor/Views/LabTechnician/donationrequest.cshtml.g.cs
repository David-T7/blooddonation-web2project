#pragma checksum "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\LabTechnician\donationrequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "578597319e3d8b3b72cd30229099649bdef06ac8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LabTechnician_donationrequest), @"mvc.1.0.view", @"/Views/LabTechnician/donationrequest.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"578597319e3d8b3b72cd30229099649bdef06ac8", @"/Views/LabTechnician/donationrequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67e771b9cd45c68150793946ee098399759e1c40", @"/Views/_ViewImports.cshtml")]
    public class Views_LabTechnician_donationrequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\LabTechnician\donationrequest.cshtml"
   ViewData["Title"] = "donationrequest"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "578597319e3d8b3b72cd30229099649bdef06ac83644", async() => {
                WriteLiteral("\r\n\r\n\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "578597319e3d8b3b72cd30229099649bdef06ac84622", async() => {
                WriteLiteral(@"
    <div class=""side-navbar active-nav d-flex justify-content-between flex-wrap flex-column""
         id=""sidebar"">

        <ul class=""nav flex-column text-white w-100"">
            <a href=""/labtechnician/dashbord"" class=""nav-link h3 text-white my-2"">
                Labtech
            </a>

            <li class=""nav-link"">
                <i class=""bx bxs-dashboard""></i>
                <span class=""mx-2""><a class=""inner-anchor"" href=""/labtechnician/dashbord""> Home</a></span>
            </li>

            <li class=""nav-link"">
                <i class=""bx bx-git-pull-request""></i>
                <span class=""mx-2""><a class=""inner-anchor"" href=""/labtechnician/donationrequest"">Request Result</a></span>
            </li>



            <li class=""nav-link"">
                <i class=""bx bx-git-pull-request""></i>
                <span class=""mx-2""><a class=""inner-anchor"" href=""/labtechnician/bloods""> Bloods</a></span>
            </li>



            <li class=""nav-link"">
     ");
                WriteLiteral(@"           <i class=""bx bx-edit""></i>
                <span class=""mx-2""><a class=""inner-anchor"" href=""/labtechnician/editaccount""> Edit Account</a></span>
            </li>

            <li class=""nav-link"">
                <i class=""bx bx-log-out""></i>
                <span class=""mx-2""><a class=""inner-anchor"" href=""/labtechnician/logout""> Log Out </a></span>
            </li>
        </ul>

    </div>




    <!-- Main Wrapper -->
    <div class=""p-1 my-container active-cont"" style=""background-color:lightblue"">
        <!-- Top Nav -->
        <nav class=""navbar top-navbar navbar-light bg-light px-5"">
            <br />
        </nav>

        <br />


        <table class=""styled-table"">

            <thead>
                <tr>
                    <th>Date</th>
                    <th>Status</th>
                    <th>Appointment</th>
                    <th></th>
                    <th></th>
                    <th></th>
                </tr>


            </thea");
                WriteLiteral("d>\r\n\r\n            <tbody>\r\n\r\n\r\n");
#nullable restore
#line 84 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\LabTechnician\donationrequest.cshtml"
                 foreach (var request in Model.donationrequestlist)
                {

                    int match = 0;

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td> ");
#nullable restore
#line 89 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\LabTechnician\donationrequest.cshtml"
                    Write(request.RequestDate);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 90 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\LabTechnician\donationrequest.cshtml"
                    Write(request.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral("  </td>\r\n\r\n");
#nullable restore
#line 92 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\LabTechnician\donationrequest.cshtml"
                     foreach (var appointment in Model.appointmentlist)
                    {

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\LabTechnician\donationrequest.cshtml"
                         if (request.Status == "accepted" && request.ReqeustResultId == appointment.ReqeustResultId)
                        {
                            match += 1;

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <td>");
#nullable restore
#line 98 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\LabTechnician\donationrequest.cshtml"
                           Write(appointment.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 99 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\LabTechnician\donationrequest.cshtml"
                             if (appointment.Status == "accepted")
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td> <a");
                BeginWriteAttribute("href", " href=\"", 2940, "\"", 3012, 4);
                WriteAttributeValue("", 2947, "/labtechnician/addblood/", 2947, 24, true);
#nullable restore
#line 101 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\LabTechnician\donationrequest.cshtml"
WriteAttributeValue("", 2971, request.DonorId, 2971, 16, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2987, "/", 2987, 1, true);
#nullable restore
#line 101 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\LabTechnician\donationrequest.cshtml"
WriteAttributeValue("", 2988, request.ReqeustResultId, 2988, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> <button type=\"button\" class=\"btn btn-primary btn-sm\" style=\"background-color: red;\">AddBlood</button></a></td>\r\n");
#nullable restore
#line 102 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\LabTechnician\donationrequest.cshtml"

                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\LabTechnician\donationrequest.cshtml"
                             if (appointment.Status == "rejected" || appointment.Status == "finished")
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td>  <button type=\"button\" disabled class=\"btn btn-primary btn-sm\" style=\"background-color: red;\">AddBlood</button></td>\r\n");
#nullable restore
#line 107 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\LabTechnician\donationrequest.cshtml"


                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\LabTechnician\donationrequest.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\LabTechnician\donationrequest.cshtml"
                         

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 113 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\LabTechnician\donationrequest.cshtml"
                     if (match == 0)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <td>NotMade</td>\r\n                        <td>  <button type=\"button\" disabled class=\"btn btn-primary btn-sm\" style=\"background-color: red;\">AddBlood</button></td>\r\n");
#nullable restore
#line 117 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\LabTechnician\donationrequest.cshtml"

                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                    <td><a");
                BeginWriteAttribute("href", " href=\"", 3842, "\"", 3890, 2);
                WriteAttributeValue("", 3849, "/labtechnician/donorinfo/", 3849, 25, true);
#nullable restore
#line 121 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\LabTechnician\donationrequest.cshtml"
WriteAttributeValue("", 3874, request.DonorId, 3874, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> <button type=\"button\" class=\"btn btn-primary ms-auto\" style=\"background-color:green\">DonorInfo</button></a></td>\r\n\r\n\r\n                    <td> <a");
                BeginWriteAttribute("href", " href=\"", 4038, "\"", 4087, 2);
                WriteAttributeValue("", 4045, "/labtechnician/blockdonor/", 4045, 26, true);
#nullable restore
#line 124 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\LabTechnician\donationrequest.cshtml"
WriteAttributeValue("", 4071, request.DonorId, 4071, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> <button type=\"button\" class=\"btn btn-primary btn-sm\" style=\"background-color: red;\">Block</button></a></td>\r\n\r\n\r\n\r\n                </tr>\r\n");
#nullable restore
#line 129 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\LabTechnician\donationrequest.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 131 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\LabTechnician\donationrequest.cshtml"
                 if (Model == null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>No</td>\r\n                        <td>Donation</td>\r\n                        <td>Request</td>\r\n                        <td></td>\r\n                    </tr>\r\n");
#nullable restore
#line 139 "C:\Users\tesfa\OneDrive\Desktop\Webproject\Blooddonation\Blooddonation\Views\LabTechnician\donationrequest.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n            </tbody>\r\n\r\n\r\n        </table>\r\n\r\n        <br /><br />\r\n        <br /><br />\r\n        <br /><br />\r\n\r\n\r\n\r\n    </div>\r\n\r\n");
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
            WriteLiteral("\r\n</html>");
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