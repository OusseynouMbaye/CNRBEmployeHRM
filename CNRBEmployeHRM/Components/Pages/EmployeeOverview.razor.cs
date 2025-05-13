using CNRBEmployeHRM.Domain;
using CNRBEmployeHRM.Services;

namespace CNRBEmployeHRM.Components.Pages
{
    public partial class EmployeeOverview
    {
        private List<Employee> Employees { get; set; } = default!;
        private Employee? _selectedEmployee;
        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(2000);
            Employees = MockDataService.Employees;
            await base.OnInitializedAsync();
        }

        private void ShowQuickViewPopup(Employee selectedEmployee)
        {
            _selectedEmployee = selectedEmployee;
        }
    }
}
