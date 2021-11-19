using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoBlazorServerApp.Models;

namespace DemoBlazorServerApp.Services
{
    public interface IDepartmentService
    {
        Task<DepartmentModel> GetDepartmentAsync(int id);

        Task<List<DepartmentModel>> GetDepartmentAllAsync();
    }
}
