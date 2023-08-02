using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRDU_eMP.Models
{
    [PrimaryKey("EmpId", "ProjId")]
    public class EmpProject
    {
        // Composite primary key

       

        public int EmpId { get; set; }
        public int ProjId { get; set; }

        // Navigation properties for Employee and Project
        public Employee Employee { get; set; }
        public Project Project { get; set; }

        [ForeignKey("WorkingHours")]
        public int WorkingHours { get; set; }
    }

}
