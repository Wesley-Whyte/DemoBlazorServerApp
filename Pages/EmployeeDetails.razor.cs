using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using DemoBlazorServerApp.Models;
using DemoBlazorServerApp.Services;
using DemoBlazorServerApp.Shared;
using Microsoft.AspNetCore.Components.Web;

namespace DemoBlazorServerApp.Pages
{ 
    public partial class EmployeeDetails
    {
        [Parameter]
        public string id { get; set; }
        protected string ButtonText { get; set; } = "Hide Footer";
        protected string CssClass { get; set; } = null;
        public ConfirmModalComponent ConfirmModal { get; set; }

        protected string Coordinates { get; set; }

        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        public EmployeeModel Employee { get; set; } = null;
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Employee = await EmployeeService.GetEmployee(Int32.Parse(id));
        }

        protected void Mouse_Move(MouseEventArgs e)
        {
            Coordinates = $"X = {e.ClientX} Y = {e.ClientY}";
        }

        protected void HideFooterButton_CLick()
        {
            if (ButtonText == "Hide Footer")
            {
                ButtonText = "Show Footer";
                CssClass = "hide-footer";
            }
            else
            {
                ButtonText = "Hide Footer";
                CssClass = null;
            }
        }

        protected void DeleteClick()
        {
            ConfirmModal.Show();
        }

        protected async Task ConfirmDelete_Click(bool isDeleted)
        {
            if (isDeleted)
            {
                await EmployeeService.DeleteEmployee(Employee.id);
                NavigationManager.NavigateTo("employeelist"); 
            }
        }

    }
}
