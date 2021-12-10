#pragma checksum "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\Pages\EmployeeList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a580e1f417483ff8b8b6de448cb73e9ef309c68"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeelist")]
    public partial class EmployeeList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "Selected Employees Count - ");
            __builder.AddContent(2, 
#nullable restore
#line 2 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\Pages\EmployeeList.razor"
                                SelectedEmployeeCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "label");
            __builder.AddContent(5, "Show Footer ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "checkbox");
            __builder.AddAttribute(8, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 4 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\Pages\EmployeeList.razor"
                                                 ShowFooter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ShowFooter = __value, ShowFooter));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 5 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\Pages\EmployeeList.razor"
 if (Employees == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "<div class=\"container\"><div class=\"row justify-content-center\" style=\"flex-direction:column\"><div class=\" spinner-grow text-primary\"></div></div></div>");
#nullable restore
#line 12 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\Pages\EmployeeList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-deck");
#nullable restore
#line 17 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\Pages\EmployeeList.razor"
         foreach (var employee in Employees)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<DemoBlazorServerApp.Shared.DisplayEmployeeComponent>(13);
            __builder.AddAttribute(14, "Employee", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DemoBlazorServerApp.Models.EmployeeModel>(
#nullable restore
#line 19 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\Pages\EmployeeList.razor"
                                                employee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "ShowFooter", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\Pages\EmployeeList.razor"
                                                                      ShowFooter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "OnEmployeeSelection", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 20 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\Pages\EmployeeList.razor"
                                                           EmployeeSelectionChanged

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(17, "OnEmployeeDeleted", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 21 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\Pages\EmployeeList.razor"
                                                         EmployeeDeleted

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 22 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\Pages\EmployeeList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 25 "C:\Users\User\source\repos\DemoBlazorApp\DemoBlazorServerApp\Pages\EmployeeList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
