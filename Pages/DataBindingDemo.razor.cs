using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoBlazorServerApp.Pages
{
    public partial class DataBindingDemo
    {

        public string Name { get; set; } = "Anthony";
        public string Description { get; set; } = "";

        protected void Name_Changed(ChangeEventArgs e)
        {
            Name = e.Value.ToString();
        }

    }
}
