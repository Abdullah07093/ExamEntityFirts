using Microsoft.EntityFrameworkCore;


public class RegionService
{
    readonly DataContext context;
    public RegionService(DataContext context)
    {
        this.context=context;
    }
    public async Task<List<Region>> GetRegions(){
        return await context.Regions.ToListAsync();
    }

    public async Task<Region> GetRegionById(int id){
        return await context.Regions.FindAsync(id);
    }

  public async Task<Region> AddRegion(Region region){
   await context.Regions.AddAsync(region);
   await context.SaveChangesAsync();
   return region;
  }
  public async Task< Region> UpdateRegion(Region region){
    var find=await context.Regions.FindAsync(region.RegionId);
 find.RegionName=region.RegionName;
    await context.SaveChangesAsync();
    return region;
  }
  public async Task<bool> DeleteRegion(int id){
    var find=await context.Regions.FindAsync(id);
    context.Regions.Remove(find);
    await context.SaveChangesAsync();
    return true;
  }

}