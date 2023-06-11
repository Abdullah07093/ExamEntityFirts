using Microsoft.EntityFrameworkCore;

public class EmployeeService
{
    readonly DataContext context;
    public EmployeeService(DataContext context)
    {
        this.context=context;
    }
    public async Task<List<Employee>> GetEmployees(){
        return await context.Employees.ToListAsync();
    }

    public async Task<Employee> GetEmployeeById(int id){
        return await context.Employees.FindAsync(id);
    }

  public async Task<Employee> AddEmployee(Employee employee){
   await context.Employees.AddAsync(employee);
   await context.SaveChangesAsync();
   return employee;
  }
  public async Task< Employee> UpdateEmployee(Employee employee){
    var find=await context.Employees.FindAsync(employee.EmployeeId);
 find.FirstName=employee.FirstName;
 find.LastName=employee.LastName;
    await context.SaveChangesAsync();
    return employee;
  }
  public async Task<bool> DeleteEmployee(int id){
    var find=await context.Employees.FindAsync(id);
    context.Employees.Remove(find);
    await context.SaveChangesAsync();
    return true;
  }

}