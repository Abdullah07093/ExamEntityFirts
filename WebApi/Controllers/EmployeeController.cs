using Microsoft.AspNetCore.Mvc;

namespace WEbApi.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController:ControllerBase{
    private readonly EmployeeService employeeService;

    public EmployeeController(EmployeeService employeeService)
    {
        this.employeeService=employeeService;
    }
    [HttpGet("GetEmployee")]

public async Task<List<Employee>> GetRegions(){
    return await employeeService.GetEmployees();
}
    [HttpGet("GetemployeeById")]

public async Task<Employee> GetStudentsByID(int id){
    return await employeeService.GetEmployeeById(id);
}

    [HttpPost("AddEmployee")]

public async Task<Employee> AddStudent(Employee employee){
    return await employeeService.AddEmployee( employee);
}
  [HttpPut("Updateemployee")]

public async Task<Employee> UpdateEmployee(Employee employee){
    return await employeeService.UpdateEmployee( employee);
}
 [HttpDelete("Deleteemployee")]

public async Task<bool> DeleteEmployee(int id){
    return await employeeService.DeleteEmployee( id);
}





}