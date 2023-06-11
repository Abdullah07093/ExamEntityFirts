using System.ComponentModel.DataAnnotations;

public class Job
{
     [Key] 
    public int JobId { get; set; }
    public string JobTitle { get; set; }
    public decimal MinSalary { get; set; }
    public decimal MaxSalary { get; set; }
 

}