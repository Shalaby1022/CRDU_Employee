namespace CRDU_eMP.Models
{
    public class Office
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        // Navigation property for Employee (One-to-Many relationship)
        public ICollection<Employee> Employees { get; set; }
    }

}
