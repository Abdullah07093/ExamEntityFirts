using Microsoft.EntityFrameworkCore;

public class JobService
{
    readonly DataContext context;
    public JobService(DataContext context)
    {
        this.context=context;
    }
    public async Task<List<Job>> GetJobs(){
        return await context.Jobs.ToListAsync();
    }

    public async Task<Job> GetJobByIdById(int id){
        return await context.Jobs.FindAsync(id);
    }

  public async Task<Job> AddJob(Job job){
   await context.Jobs.AddAsync(job);
   await context.SaveChangesAsync();
   return job;
  }
  public async Task< Job> UpdateJob(Job job){
    var find=await context.Jobs.FindAsync(job.JobId);
 find.JobTitle=job.JobTitle;
 find.MaxSalary=job.MaxSalary;
 find.MinSalary=job.MinSalary;
    await context.SaveChangesAsync();
    return job;
  }
  public async Task<bool> DeleteJob(int id){
    var find=await context.Jobs.FindAsync(id);
    context.Jobs.Remove(find);
    await context.SaveChangesAsync();
    return true;
  }

}