using EmployeeManagement.Models;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        [Inject]
        private IEmployeeService EmployeeService { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
        public bool ShowFooter { get; set; } = true;
        public int SelectedEmployeeCount { get; set; } = 0;
        protected override async Task OnInitializedAsync()
        {

            Employees = (await EmployeeService.GetEmployees()).ToList();

        }

        protected void EmployeeCountChanged(bool isChecked)
        {
            if (isChecked)
            {
                SelectedEmployeeCount++;
            }
            else
            {
                SelectedEmployeeCount--;
            }
        }
        protected async Task Delete_Employee(int id)
        {
            await EmployeeService.DeleteEmployee(id);
            await OnInitializedAsync();
        }
    }
}
