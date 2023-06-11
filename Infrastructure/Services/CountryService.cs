using Microsoft.EntityFrameworkCore;

public class CountryService
{
    readonly DataContext context;
    public CountryService(DataContext context)
    {
        this.context=context;
    }
    public async Task<List<Country>> GetCountrys(){
        return await context.Countrys.ToListAsync();
    }

    public async Task<Country> GetCountryById(int id){
        return await context.Countrys.FindAsync(id);
    }

  public async Task<Country> AddCountry(Country country){
   await context.Countrys.AddAsync(country);
   await context.SaveChangesAsync();
   return country;
  }
  public async Task< Country> UpdateCountry(Country country){
    var find=await context.Countrys.FindAsync(country.CountryId);
 find.CountryName=country.CountryName;
    await context.SaveChangesAsync();
    return country;
  }
  public async Task<bool> DeleteCountry(int id){
    var find=await context.Countrys.FindAsync(id);
    context.Countrys.Remove(find);
    await context.SaveChangesAsync();
    return true;
  }

}