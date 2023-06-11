using Microsoft.AspNetCore.Mvc;

namespace WEbApi.Controllers;

[ApiController]
[Route("[controller]")]
public class DepartmentController:ControllerBase{
    private readonly DepartmentService departmentService;

    public DepartmentController(DepartmentService departmentService)
    {
        this.departmentService=departmentService;
    }
    [HttpGet("GetDepartments")]

public async Task<List<Department>> GetCountrys(){
    return await departmentService.GetDepartments();
}
    [HttpGet("GetDepartmentById")]

public async Task<Department> GetCountryById(int id){
    return await departmentService.GetDepartmentById(id);
}

    [HttpPost("AddDepartment")]

public async Task<Department> AddDepartment(Department department){
    return await departmentService.AddDepartment( department);
}
  [HttpPut("UpdateDepartment")]

public async Task<Department> UpdateDepartment(Department department){
    return await departmentService.UpdateDepartment( department);
}
 [HttpDelete("DeleteDepartment")]

public async Task<bool> DeleteDepartment(int id){
    return await departmentService.DeleteDepartment( id);
}





}