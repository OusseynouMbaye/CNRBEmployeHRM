using CNRBEmployeHRM.Domain;
using CNRBEmployeHRM.Services;
using Microsoft.AspNetCore.Components;

namespace CNRBEmployeHRM.Components.Pages
{
    public partial class EmployeDetail
    {
        [Parameter]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = new Employee();

        protected override void OnInitialized()
        {
            Task.Delay(2000);
            Employee = MockDataService.Employees.Single(e=> e.EmployeeId == EmployeeId);
            //Employee = MockDataService.Employees?.SingleOrDefault(e => e.EmployeId == EmployeeId) ?? new Employee();
        }
    }
}