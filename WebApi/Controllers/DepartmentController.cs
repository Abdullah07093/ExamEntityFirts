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
    [HttpGet("GetCountry")]

public async Task<List<Department>> GetCountrys(){
    return await departmentService.GetDepartments();
}
    [HttpGet("GetcountryById")]

public async Task<Department> GetCountryById(int id){
    return await departmentService.GetDepartmentById(id);
}

    [HttpPost("AddCountry")]

public async Task<Department> AddDepartment(Department department){
    return await departmentService.AddDepartment( department);
}
  [HttpPut("UpdateCountry")]

public async Task<Department> UpdateDepartment(Department department){
    return await departmentService.UpdateDepartment( department);
}
 [HttpDelete("DeleteCountry")]

public async Task<bool> DeleteDepartment(int id){
    return await departmentService.DeleteDepartment( id);
}





}