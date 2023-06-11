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
    [HttpGet("GetJobGrades")]

public async Task<List<JobGrade>> GetJobGrades(){
    return await jobGradeService.GetJobGrades();
}
    [HttpGet("GetJobGradeById")]

public async Task<JobGrade> GetJobGradeById(int id){
    return await jobGradeService.GetJobGradeById(id);
}

    [HttpPost("AddJobGrade")]

public async Task<JobGrade> AddJobGrade(JobGrade jobGrade){
    return await jobGradeService.AddJobGrade( jobGrade);
}
  [HttpPut("UpdateJobGrade")]

public async Task<JobGrade> UpdateJobGrade(JobGrade jobGrade){
    return await jobGradeService.UpdateJobGrade( jobGrade);
}
 [HttpDelete("DeleteJobGrade")]

public async Task<bool> DeleteJobGrade(int id){
    return await jobGradeService.DeleteJobGrade( id);
}





}