using Microsoft.EntityFrameworkCore;

public class DataContext:DbContext
{
    public DataContext(DbContextOptions <DataContext> options): base(options)
    {
        
    }
    public DbSet<Employee> Employees{get;set;}
    public DbSet<Country> Countrys{get;set;}
    public DbSet<Department> Departments{get;set;}
    public DbSet<Job> Jobs{get;set;}
    public DbSet<JobGrade> JobGrades{get;set;}
    public DbSet<JobHistory> JobHistorys{get;set;}
    public DbSet<Location> Locations{get;set;}
    public DbSet<Region> Regions{get;set;}
}