using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using DemoBlazorServerApp.Services;
using DemoBlazorServerApp.Models;
using System.ComponentModel.DataAnnotations;

namespace DemoBlazorServerApp.Pages
{
    public partial class EditEmployee
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        [Inject]
        public IDepartmentService DepartmentService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public string id { get; set; } = "0";

        public string Header { get; set; } = string.Empty;
        public EmployeeModel Employee { get; set; } = new EmployeeModel();

        public List<DepartmentModel> Department { get; set; } = new List<DepartmentModel>();

        protected async override Task OnInitializedAsync()
        {
            Department = await DepartmentService.GetDepartmentAllAsync();
            Int32.TryParse(id, out int employeeid);
            if (employeeid != 0)
            {
                Header = "Edit Employee";
                Employee = await EmployeeService.GetEmployee(Int32.Parse(id)); 
            }
            else
            {
                Header = "Create Employee";
                Employee.Image = "Image/no-picture.png";
            }
            
        }

        protected async Task HandleValidSubmit()
        {
            Int32.TryParse(id, out int employeeid);
            if (Employee.id != 0)
            {
                await EmployeeService.EditEmployee(Employee.id, Employee);
            }
            else
            {
                await EmployeeService.CreateEmployee(Employee);
            }
            
            NavigationManager.NavigateTo("editemployee");
        }

    }
}
