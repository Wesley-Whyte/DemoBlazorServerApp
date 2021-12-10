using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoBlazorServerApp.Models;
using DemoBlazorServerApp.Services;
using Microsoft.AspNetCore.Components;

namespace DemoBlazorServerApp.Pages
{
    public partial class RadioButtons
    {
        public Country Country { get; set; } = new Country();
    }
}
