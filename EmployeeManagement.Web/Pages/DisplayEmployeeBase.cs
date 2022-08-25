using Components;
using EmployeeManagement.Models;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class DisplayEmployeeBase:ComponentBase
    {
        [Parameter]
        public Employee Employee { get; set; }
        [Parameter]
        public bool ShowFooter { get; set; }
        [Parameter]
        public EventCallback<bool> EmployeeChange { get; set; }

        [Parameter]
        public EventCallback<int> OnEmployeeDelete { get; set; }
        protected ConfirmBase DeleteConfirmation { get; set; }
        [Inject]
        private IEmployeeService EmployeeService { get; set; }
        public async Task EmployeeCheckboxChanged(ChangeEventArgs e)
        {
            await EmployeeChange.InvokeAsync((bool)e.Value);
        }
        protected async Task Delete_Employee_Confirm(bool deleteConfirmed)
        {
            if (deleteConfirmed)
            {
                await EmployeeService.DeleteEmployee(Employee.Id);
                await OnEmployeeDelete.InvokeAsync(Employee.Id);
            }

        }
        protected void Delete_Click()
        {
            DeleteConfirmation.Show();
        }

        
    }
}
