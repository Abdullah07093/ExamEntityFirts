using System.ComponentModel.DataAnnotations;

public class JobHistory
{
    [Key]
    public DateOnly StartDate { get; set; }
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }
    public DateOnly EdnDate { get; set; }
    public DateOnly JobId { get; set; }
    public Job Job{ get; set; }
    public int DepartmentId{ get; set; }
    public Department Department{ get; set; }
}