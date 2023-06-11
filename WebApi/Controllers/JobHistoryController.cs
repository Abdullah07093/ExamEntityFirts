using Microsoft.AspNetCore.Mvc;

namespace WEbApi.Controllers;

[ApiController]
[Route("[controller]")]
public class JobHistoryController:ControllerBase{
    private readonly JobHistoryService jobHistory;

    public JobHistoryController(JobHistoryService jobHistory)
    {
        this.jobHistory=jobHistory;
    }
    [HttpGet("GetJobHistoryes")]

public async Task<List<JobHistory>> GetJobHistorys(){
    return await jobHistory.GetJobHistorys();
}
    [HttpGet("GetJobHistoryById")]

public async Task<JobHistory> GetJobHistoryById(int id){
    return await jobHistory.GetJobHistoryById(id);
}

    [HttpPost("AddJobHistory")]

public async Task<JobHistory> AddJobHistory(JobHistory student){
    return await jobHistory.AddJobHistory( student);
}
  [HttpPut("UpdateJobHistory")]

public async Task<JobHistory> UpdateJobHistory(JobHistory student){
    return await jobHistory.UpdateJobHistory( student);
}
 [HttpDelete("DeleteRegion")]

public async Task<bool> DeleteJobHistory(int id){
    return await jobHistory.DeleteJobHistory( id);
}





}