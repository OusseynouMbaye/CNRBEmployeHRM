using CNRBEmployeHRM.Domain;

namespace CNRBEmployeHRM.Services
{
    public class MockDataService
    {
        public static List<Employee>? _employees = default!;
        public static List<JobCategory> _jobCategories = default!;

        public static List<Employee>? Employees
        {
            get
            {
                _jobCategories ??= InitializeMockJobCategories();
                _employees ??= InitializeMockEmployees();

                return _employees;
            }
        }

        private static List<Employee> InitializeMockEmployees()
        {
            //_jobCategories ??= InitializeMockJobCategories(); // Ensure job categories are initialized

            var e1 = new Employee
            {
                EmployeId = 1,
                FirstName = "Maxim",
                LastName = "Alexander",
                Designation = "Entraineur ecole natation",
                BirthDate = new DateTime(1980, 10, 5),
                IsOnHoliday = false,
                Gender = Gender.Male,
                Email = "Maxim@cnrb.com",
                PhoneNumber = "5554443232",
            };

            var e2 = new Employee
            {
                EmployeId = 2,
                FirstName = "Mathilde",
                LastName = "Bernard",
                Designation = "Entraineure groupe d'age",
                BirthDate = new DateTime(1981, 10, 5),
                IsOnHoliday = true,
                Gender = Gender.Female,
                Email = "Mathilde@cnrb.com",
                PhoneNumber = "9998887676",
                JobCategory = _jobCategories[2],
                JobCategoryId = _jobCategories[2].JobCategoryId,
            };

            return new List<Employee> { e1, e2 };
        }

        private static List<JobCategory> InitializeMockJobCategories() =>
        new List<JobCategory>
        {
                new JobCategory { JobCategoryId = 1, JobCategoryName = "Entraineur chef", JobCategoryDescription = "Entraineur du groupe Elite" },
                new JobCategory { JobCategoryId = 2, JobCategoryName = "Entraineur adjoint", JobCategoryDescription = "Entraineur du groupe d'age" },
                new JobCategory { JobCategoryId = 3, JobCategoryName = "Entraineur ecole natation", JobCategoryDescription = "Entraineur du groupe ecole natation" },
                new JobCategory { JobCategoryId = 4, JobCategoryName = "Entraineur maitre", JobCategoryDescription = "Entraineur du groupe maitre" },
                new JobCategory { JobCategoryId = 5, JobCategoryName = "Entraineur benevole", JobCategoryDescription = "Entraineur benevole" },
                new JobCategory { JobCategoryId = 6, JobCategoryName = "Entraineur du groupe Olympique Speciaux", JobCategoryDescription = "Entraineur Olympique Speciaux " }
        };
    }
}
