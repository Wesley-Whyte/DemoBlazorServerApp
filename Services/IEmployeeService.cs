using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoBlazorServerApp.Models;

namespace DemoBlazorServerApp.Services
{
    public interface IEmployeeService
    {
        public Task<EmployeeModel> GetEmployee(int id);

        public Task<List<EmployeeModel>> GetEmployees();

        public Task EditEmployee(int id, EmployeeModel employee);

        public Task CreateEmployee(EmployeeModel employee);

        public Task DeleteEmployee(int id);
        
    }
}
