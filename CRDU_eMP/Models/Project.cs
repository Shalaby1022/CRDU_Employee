namespace CRDU_eMP.Models
{
    public class Project
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        // Navigation property for Emp_project (Many-to-Many relationship)
        public ICollection<EmpProject> EmpProjects { get; set; }
    }

}
