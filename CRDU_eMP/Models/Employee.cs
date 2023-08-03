using System.ComponentModel.DataAnnotations.Schema;

namespace CRDU_eMP.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Salary { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        // Foreign key for Office
        [ForeignKey("Office")]
        public int OfficeId { get; set; }

        public Office Office { get; set; }

        // Navigation property for Emp_project (Many-to-Many relationship)
        public ICollection<EmpProject> EmpProjects { get; set; }
    }
}
