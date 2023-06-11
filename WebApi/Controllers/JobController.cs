using Microsoft.AspNetCore.Mvc;

namespace WEbApi.Controllers;

[ApiController]
[Route("[controller]")]
public class JobController:ControllerBase{
    private readonly JobService jobService;

    public JobController(JobService jobService)
    {
        this.jobService=jobService;
    }
    [HttpGet("GetJobs")]

public async Task<List<Job>> GetJobs(){
    return await jobService.GetJobs();
}
    [HttpGet("GetJobByIdById")]

public async Task<Job> GetJobById(int id){
    return await jobService.GetJobByIdById(id);
}

    [HttpPost("AddJob")]

public async Task<Job> AddJob(Job jobGrade){
    return await jobService.AddJob( jobGrade);
}
  [HttpPut("UpdateJob")]

public async Task<Job> UpdateJob(Job jobGrade){
    return await jobService.UpdateJob( jobGrade);
}
 [HttpDelete("DeleteJob")]

public async Task<bool> DeleteJob(int id){
    return await jobService.DeleteJob( id);
}





}