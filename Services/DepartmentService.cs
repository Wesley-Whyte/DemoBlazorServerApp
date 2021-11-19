using DemoBlazorServerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

namespace DemoBlazorServerApp.Services
{
    public class DepartmentService : IDepartmentService
    {
        public string BaseURL { get; } = "https://localhost:44327/";
        public async Task<List<DepartmentModel>> GetDepartmentAllAsync()
        {
            List<DepartmentModel> output;
            using (HttpResponseMessage responce = await APIHelper.Client.GetAsync($"{BaseURL}api/Departments"))
            {
                if (responce.IsSuccessStatusCode)
                {
                    output = await responce.Content.ReadAsAsync<List<DepartmentModel>>();
                    return output;
                }
                else
                {
                    throw new Exception(responce.ReasonPhrase);
                }
            }
        }

        public async Task<DepartmentModel> GetDepartmentAsync(int id)
        {
            using (HttpResponseMessage responce = await APIHelper.Client.GetAsync($"{BaseURL}api/Departments"))
            {
                DepartmentModel output;
                if (responce.IsSuccessStatusCode)
                {
                    output = await responce.Content.ReadAsAsync<DepartmentModel>();
                    return output;
                }
                else
                {
                    throw new Exception(responce.ReasonPhrase);
                }
            }
        }
    }
}
