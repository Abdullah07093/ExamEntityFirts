using System.ComponentModel.DataAnnotations;

public class Employee
{    [Key]
    public int EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public DateOnly HireDate { get; set; }
    public int JobId { get; set; }
    public Job Job { get; set; }
    public decimal Salary { get; set; }
    public int CommissionPCT { get; set; }
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
}