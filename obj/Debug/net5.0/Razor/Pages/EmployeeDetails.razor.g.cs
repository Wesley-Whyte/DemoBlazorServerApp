#pragma checksum "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\Pages\EmployeeDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad960f2d92116fb22324860b0e49cf8e99420b77"
// <auto-generated/>
#pragma warning disable 1591
namespace DemoBlazorServerApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\_Imports.razor"
using DemoBlazorServerApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\_Imports.razor"
using DemoBlazorServerApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\_Imports.razor"
using DemoBlazorServerApp.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeedetails/{id}")]
    public partial class EmployeeDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row justify-content-center");
#nullable restore
#line 5 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\Pages\EmployeeDetails.razor"
         if (Employee != null)
        { 

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-sm-8 card");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card-header text-center");
            __builder.OpenElement(8, "h1");
            __builder.AddContent(9, 
#nullable restore
#line 9 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\Pages\EmployeeDetails.razor"
                         Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(10, " ");
            __builder.AddContent(11, 
#nullable restore
#line 9 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\Pages\EmployeeDetails.razor"
                                             Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, " ");
            __builder.AddContent(13, 
#nullable restore
#line 9 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\Pages\EmployeeDetails.razor"
                                                                Coordinates

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "card-body text-center");
            __builder.OpenElement(17, "img");
            __builder.AddAttribute(18, "class", "card-img-top mb-2");
            __builder.AddAttribute(19, "src", 
#nullable restore
#line 12 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\Pages\EmployeeDetails.razor"
                                                         Employee.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(20, "onmousemove", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\Pages\EmployeeDetails.razor"
                                        Mouse_Move

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "h4");
            __builder.AddContent(23, "ID: ");
            __builder.AddContent(24, 
#nullable restore
#line 14 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\Pages\EmployeeDetails.razor"
                             Employee.id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "h4");
            __builder.AddContent(27, "Email: ");
            __builder.AddContent(28, 
#nullable restore
#line 15 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\Pages\EmployeeDetails.razor"
                                Employee.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "h4");
            __builder.AddContent(31, "DOB: ");
            __builder.AddContent(32, 
#nullable restore
#line 16 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\Pages\EmployeeDetails.razor"
                              Employee.DateOfBirth.Date.ToString("D")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.OpenElement(34, "h4");
            __builder.AddContent(35, "Phone number: ");
            __builder.AddContent(36, 
#nullable restore
#line 17 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\Pages\EmployeeDetails.razor"
                                       Employee.PhoneNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.OpenElement(38, "h4");
            __builder.AddContent(39, "Department: ");
            __builder.AddContent(40, 
#nullable restore
#line 18 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\Pages\EmployeeDetails.razor"
                                     Employee.Department.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.OpenElement(42, "h4");
            __builder.AddContent(43, "Gender: ");
            __builder.AddContent(44, 
#nullable restore
#line 19 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\Pages\EmployeeDetails.razor"
                                 Employee.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "class", "btn btn-outline-info");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\Pages\EmployeeDetails.razor"
                                                                    HideFooterButton_CLick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "id", "hide-footer");
            __builder.AddContent(50, 
#nullable restore
#line 20 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\Pages\EmployeeDetails.razor"
                                                                                                              ButtonText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "card-footer" + " text-center" + " " + (
#nullable restore
#line 22 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\Pages\EmployeeDetails.razor"
                                                     CssClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(54, "<a class=\"btn btn-outline-primary\" href=\"employeelist\">Back</a>\r\n                    ");
            __builder.OpenElement(55, "a");
            __builder.AddAttribute(56, "class", "btn btn-outline-primary");
            __builder.AddAttribute(57, "href", "editemployee/" + (
#nullable restore
#line 24 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\Pages\EmployeeDetails.razor"
                                                                           Employee.id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(58, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                    ");
            __builder.OpenElement(60, "button");
            __builder.AddAttribute(61, "class", "btn btn-outline-danger");
            __builder.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\Pages\EmployeeDetails.razor"
                                                                      DeleteClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(63, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 28 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\Pages\EmployeeDetails.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(64, "<div class=\" spinner-grow text-primary\"></div>");
#nullable restore
#line 32 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\Pages\EmployeeDetails.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n\r\n");
            __builder.OpenComponent<DemoBlazorServerApp.Shared.ConfirmModalComponent>(66);
            __builder.AddAttribute(67, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 36 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\Pages\EmployeeDetails.razor"
                                                                ConfirmDelete_Click

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(68, (__value) => {
#nullable restore
#line 36 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\Pages\EmployeeDetails.razor"
                             ConfirmModal = (DemoBlazorServerApp.Shared.ConfirmModalComponent)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
