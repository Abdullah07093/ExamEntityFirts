using Microsoft.EntityFrameworkCore;

public class DepartmentService
{
    readonly DataContext context;
    public DepartmentService(DataContext context)
    {
        this.context=context;
    }
    public async Task<List<Department>> GetDepartments(){
        return await context.Departments.ToListAsync();
    }

    public async Task<Department> GetDepartmentById(int id){
        return await context.Departments.FindAsync(id);
    }

  public async Task<Department> AddDepartment(Department department){
   await context.Departments.AddAsync(department);
   await context.SaveChangesAsync();
   return department;
  }
  public async Task< Department> UpdateDepartment(Department department){
    var find=await context.Departments.FindAsync(department.DepartmentId);
 find.DepartmentName=department.DepartmentName;
    await context.SaveChangesAsync();
    return department;
  }
  public async Task<bool> DeleteDepartment(int id){
    var find=await context.Departments.FindAsync(id);
    context.Departments.Remove(find);
    await context.SaveChangesAsync();
    return true;
  }

}