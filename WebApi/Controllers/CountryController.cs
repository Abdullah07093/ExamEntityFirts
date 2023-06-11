using Microsoft.AspNetCore.Mvc;

namespace WEbApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CountryController:ControllerBase{
    private readonly CountryService countryService;

    public CountryController(CountryService countryService)
    {
        this.countryService=countryService;
    }
    [HttpGet("GetCountry")]

public async Task<List<Country>> GetCountrys(){
    return await countryService.GetCountrys();
}
    [HttpGet("GetcountryById")]

public async Task<Country> GetCountryById(int id){
    return await countryService.GetCountryById(id);
}

    [HttpPost("AddCountry")]

public async Task<Country> AddCountry(Country country){
    return await countryService.AddCountry( country);
}
  [HttpPut("UpdateCountry")]

public async Task<Country> UpdateCountry(Country country){
    return await countryService.UpdateCountry( country);
}
 [HttpDelete("DeleteCountry")]

public async Task<bool> DeleteCountry(int id){
    return await countryService.DeleteCountry( id);
}





}