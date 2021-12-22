using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using DemoBlazorServerApp.Models;
using DemoBlazorServerApp.Services;

namespace DemoBlazorServerApp.Pages
{
    public partial class TableGrid
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        public List<EmployeeModel> Employees { get; set; } = new List<EmployeeModel>();


        protected override async Task OnInitializedAsync()
        {
            Employees = await EmployeeService.GetEmployees();
        }
    }
}
