using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using DemoBlazorServerApp.Models;
using DemoBlazorServerApp.Services;

namespace DemoBlazorServerApp.Pages
{
    public partial class ListView
    {
        [Inject]
        public IDepartmentService DepartmentService { get; set; }

        public List<DepartmentModel> Departments { get; set; } = new List<DepartmentModel>();

        protected override async Task OnInitializedAsync()
        {
            Departments = await DepartmentService.GetDepartmentAllAsync();
        }

    }
}
