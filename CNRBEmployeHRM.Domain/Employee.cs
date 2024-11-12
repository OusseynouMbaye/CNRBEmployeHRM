using System.ComponentModel.DataAnnotations.Schema;

namespace CNRBEmployeHRM.Domain
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Designation { get; set; } = string.Empty;
        public DateTime? BirthDate { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public Gender? Gender { get; set; }
        public bool IsOnHoliday { get; set; } = false;
        public int? JobCategoryId { get; set; }
        public JobCategory? JobCategory { get; set; }

        [NotMapped]
        public byte[]? ImagePicture { get; set; }  
        public string? ImageName { get; set; }
    }
}
