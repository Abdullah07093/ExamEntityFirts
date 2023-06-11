using Microsoft.EntityFrameworkCore;

public class JobHistoryService
{
    readonly DataContext context;
    public JobHistoryService(DataContext context)
    {
        this.context=context;
    }
    public async Task<List<JobHistory>> GetJobHistorys(){
        return await context.JobHistorys.ToListAsync();
    }

    public async Task<JobHistory> GetJobHistoryById(int id){
        return await context.JobHistorys.FindAsync(id);
    }

  public async Task<JobHistory> AddJobHistory(JobHistory history){
   await context.JobHistorys.AddAsync(history);
   await context.SaveChangesAsync();
   return history;
  }
  public async Task< JobHistory> UpdateJobHistory(JobHistory history){
    var find=await context.JobHistorys.FindAsync(history.StartDate);
 find.EdnDate=history.EdnDate;
 find.StartDate=history.StartDate;
    await context.SaveChangesAsync();
    return history;
  }
  public async Task<bool> DeleteJobHistory(int id){
    var find=await context.JobHistorys.FindAsync(id);
    context.JobHistorys.Remove(find);
    await context.SaveChangesAsync();
    return true;
  }

}