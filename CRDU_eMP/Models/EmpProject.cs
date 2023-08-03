using CRDU_eMP.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class EmpProject
{
    // Composite primary key
    [Key, Column(Order = 1)]
    public int EmpId { get; set; }

    [Key, Column(Order = 2)]
    public int ProjId { get; set; }

    [ForeignKey("Employee")]
    public int WorkingHours { get; set; }

    // Navigation properties for Employee and Project
    public Employee Employee { get; set; }
    public Project Project { get; set; }
}
