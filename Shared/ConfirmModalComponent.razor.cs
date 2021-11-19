using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace DemoBlazorServerApp.Shared
{
    public partial class ConfirmModalComponent
    {

        public bool ShowConfirmation { get; set; }

        [Parameter]
        public string id { get; set; }

        [Parameter]
        public EventCallback<bool> ConfirmationChanged { get; set; }

        public void Show()
        {
            ShowConfirmation = true;
            StateHasChanged();
        }

        protected async Task OnConfirmationChanged(bool value)
        {
            ShowConfirmation = false;
            await ConfirmationChanged.InvokeAsync(value);
        }
    }
}
