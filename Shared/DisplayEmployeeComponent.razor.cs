using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using DemoBlazorServerApp.Models;
using DemoBlazorServerApp.Services;

namespace DemoBlazorServerApp.Shared
{
    public partial class DisplayEmployeeComponent
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        [Parameter]
        public EmployeeModel Employee { get; set; }
        [Parameter] 
        public bool ShowFooter { get; set; }
        [Parameter]
        public EventCallback<bool> OnEmployeeSelection { get; set; }
        [Parameter]
        public EventCallback<int> OnEmployeeDeleted { get; set; }
        public ConfirmModalComponent ConfirmModal { get; set; }

        protected async void CheckBox_Changed(ChangeEventArgs e)
        {
            await OnEmployeeSelection.InvokeAsync((bool)e.Value);
        }

        protected void DeleteClick()
        {
            ConfirmModal.Show();
        }

        protected async Task ConfirmDelete_Click(bool isdeleted)
        {
            if (isdeleted)
            {
                await EmployeeService.DeleteEmployee(Employee.id);
                await OnEmployeeDeleted.InvokeAsync(Employee.id); 
            }
        }
    }
}
