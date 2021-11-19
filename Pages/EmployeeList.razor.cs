using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoBlazorServerApp.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using DemoBlazorServerApp.Services;

namespace DemoBlazorServerApp.Pages
{
    public partial class EmployeeList
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        public List<EmployeeModel> Employees { get; set; }
        public bool ShowFooter { get; set; } = true;
        protected int SelectedEmployeeCount { get; set; } = 0;

        protected async override Task OnInitializedAsync()
        {
            Employees = await EmployeeService.GetEmployees();
        }

        protected void EmployeeSelectionChanged(bool isSelected)
        {
            if (isSelected)
            {
                SelectedEmployeeCount++;
            }
            else
            {
                SelectedEmployeeCount--;
            }
        }

        protected async Task EmployeeDeleted()
        {
            Employees = await EmployeeService.GetEmployees();
        }
    }
}
