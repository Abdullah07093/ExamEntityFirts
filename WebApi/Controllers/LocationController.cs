using Microsoft.AspNetCore.Mvc;

namespace WEbApi.Controllers;

[ApiController]
[Route("[controller]")]
public class LocationController:ControllerBase{
    private readonly LocationService locationService;

    public LocationController(LocationService locationService)
    {
        this.locationService=locationService;
    }
    [HttpGet("GetLocations")]

public async Task<List<Location>> GetCountrys(){
    return await locationService.GetLocations();
}
    [HttpGet("GetLocationtById")]

public async Task<Location> GetCountryById(int id){
    return await locationService.GetLocationtById(id);
}

    [HttpPost("AddLocation")]

public async Task<Location> AddCountry(Location location){
    return await locationService.AddLocation( location);
}
  [HttpPut("UpdateLocation")]

public async Task<Location> UpdateCountry(Location location){
    return await locationService.UpdateLocation( location);
}
 [HttpDelete("DeleteLocation")]

public async Task<bool> DeleteCountry(int id){
    return await locationService.DeleteLocation( id);
}





}