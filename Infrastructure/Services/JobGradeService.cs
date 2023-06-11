using Microsoft.EntityFrameworkCore;

public class JobGradeService
{
    readonly DataContext context;
    public JobGradeService(DataContext context)
    {
        this.context=context;
    }
    public async Task<List<JobGrade>> GetJobGrades(){
        return await context.JobGrades.ToListAsync();
    }

    public async Task<JobGrade> GetJobGradeById(int id){
        return await context.JobGrades.FindAsync(id);
    }

  public async Task<JobGrade> AddJobGrade(JobGrade jobGrade){
   await context.JobGrades.AddAsync(jobGrade);
   await context.SaveChangesAsync();
   return jobGrade;
  }
  public async Task< JobGrade> UpdateJobGrade(JobGrade jobGrade){
    var find=await context.JobGrades.FindAsync(jobGrade.GradeLevel);
 find.LowestSalary=jobGrade.LowestSalary;
 find.HighestSalary=jobGrade.HighestSalary;
    await context.SaveChangesAsync();
    return jobGrade;
  }
  public async Task<bool> DeleteJobGrade(int id){
    var find=await context.JobGrades.FindAsync(id);
    context.JobGrades.Remove(find);
    await context.SaveChangesAsync();
    return true;
  }

}