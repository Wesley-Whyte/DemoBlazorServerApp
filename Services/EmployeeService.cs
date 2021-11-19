using DemoBlazorServerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

namespace DemoBlazorServerApp.Services
{
    public class EmployeeService : IEmployeeService
    {
        public string BaseURL { get; } = "https://localhost:44327/";

        public async Task CreateEmployee(EmployeeModel employee)
        {
            using (HttpResponseMessage response = await APIHelper.Client.PostAsJsonAsync<EmployeeModel>($"{BaseURL}api/Employees",employee))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task DeleteEmployee(int id)
        {
            using (HttpResponseMessage response = await APIHelper.Client.DeleteAsync($"{BaseURL}api/Employees/{id}"))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task EditEmployee(int id, EmployeeModel employee)
        {
            using (HttpResponseMessage response = await APIHelper.Client.PutAsJsonAsync<EmployeeModel>($"{BaseURL}api/Employees/{id}",employee))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task<EmployeeModel> GetEmployee(int id)
        {
            EmployeeModel output;
            string url = $"{BaseURL}api/Employees/{id}";
            using (HttpResponseMessage response = await APIHelper.Client.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    output = await response.Content.ReadAsAsync<EmployeeModel>();
                    return output;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task<List<EmployeeModel>> GetEmployees()
        {
            List<EmployeeModel> output;
            using (HttpResponseMessage response = await APIHelper.Client.GetAsync($"{BaseURL}api/Employees"))
            {
                if (response.IsSuccessStatusCode)
                {
                    output = await response.Content.ReadAsAsync<List<EmployeeModel>>();
                    return output;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
                
            }
        }
    }
}
