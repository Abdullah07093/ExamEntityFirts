using Microsoft.AspNetCore.Mvc;

namespace WEbApi.Controllers;

[ApiController]
[Route("[controller]")]
public class JobGradeController:ControllerBase{
    private readonly JobGradeService jobGradeService;

    public JobGradeController(JobGradeService jobGradeService)
    {
        this.jobGradeService=jobGradeService;
    }
    [HttpGet("GetEmployee")]

public async Task<List<JobGrade>> GetJobGrades(){
    return await jobGradeService.GetJobGrades();
}
    [HttpGet("GetemployeeById")]

public async Task<JobGrade> GetJobGradeById(int id){
    return await jobGradeService.GetJobGradeById(id);
}

    [HttpPost("AddEmployee")]

public async Task<JobGrade> AddStudent(JobGrade jobGrade){
    return await jobGradeService.AddJobGrade( jobGrade);
}
  [HttpPut("Updateemployee")]

public async Task<JobGrade> UpdateJobGrade(JobGrade jobGrade){
    return await jobGradeService.UpdateJobGrade( jobGrade);
}
 [HttpDelete("Deleteemployee")]

public async Task<bool> DeleteJobGrade(int id){
    return await jobGradeService.DeleteJobGrade( id);
}





}