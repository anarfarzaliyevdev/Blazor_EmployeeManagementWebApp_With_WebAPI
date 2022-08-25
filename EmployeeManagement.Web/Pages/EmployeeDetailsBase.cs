using EmployeeManagement.Models;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeDetailsBase : ComponentBase
    {
        public Employee Employee { get; set; } = new Employee();
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        [Parameter]
        public string Id { get; set; }
        protected string Coordinates { get; set; }
        protected string ButtonText { get; set; } = "Hide footer";
        protected string HideCssClass { get; set; } =null;
        protected string CardBodyBGColor { get; set; } = "background-color:white";
        protected async override Task OnInitializedAsync()
        {
            Employee = await EmployeeService.GetEmployee(int.Parse(Id));
        }
        protected void Mouse_Move(MouseEventArgs e)
        {
            Coordinates = $"X: {e.ClientX} Y: {e.ClientY}";
        }
        protected void Show_Hide_Actions()
        {
            if (ButtonText == "Hide footer")
            {
                ButtonText = "Show footer";
                HideCssClass = "hide";
                
            }
            else
            {
                ButtonText = "Hide footer";
                HideCssClass = null;
            }
        }
    }
}
