using System.ComponentModel.DataAnnotations;

public class JobGrade
{
     [Key] 
     public string GradeLevel { get; set; }
    public decimal LowestSalary { get; set; }
    public decimal HighestSalary { get; set; }
}