using CNRBEmployeHRM.Domain;
using Microsoft.AspNetCore.Components;

namespace CNRBEmployeHRM.Components
{
    public partial class EmployeeCard
    {
        [Parameter]
        public Employee Employee { get;set; } = default!;   
    }
}