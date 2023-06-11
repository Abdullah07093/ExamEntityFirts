using Microsoft.EntityFrameworkCore;

public class LocationService
{
    readonly DataContext context;
    public LocationService(DataContext context)
    {
        this.context=context;
    }
    public async Task<List<Location>> GetLocations(){
        return await context.Locations.ToListAsync();
    }

    public async Task<Location> GetLocationtById(int id){
        return await context.Locations.FindAsync(id);
    }

  public async Task<Location> AddLocation(Location location){
   await context.Locations.AddAsync(location);
   await context.SaveChangesAsync();
   return location;
  }
  public async Task< Location> UpdateLocation(Location location){
    var find=await context.Locations.FindAsync(location.LocationId);
 find.StreetAddress=location.StreetAddress;
 find.PostalCode=location.PostalCode;
    await context.SaveChangesAsync();
    return location;
  }
  public async Task<bool> DeleteLocation(int id){
    var find=await context.Locations.FindAsync(id);
    context.Locations.Remove(find);
    await context.SaveChangesAsync();
    return true;
  }

}