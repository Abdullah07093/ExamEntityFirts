using Microsoft.AspNetCore.Mvc;

namespace WEbApi.Controllers;

[ApiController]
[Route("[controller]")]
public class RegionController:ControllerBase{
    private readonly RegionService regionService;

    public RegionController(RegionService regionService)
    {
        this.regionService=regionService;
    }
    [HttpGet("GetRegions")]

public async Task<List<Region>> GetRegions(){
    return await regionService.GetRegions();
}
    [HttpGet("GetRegionById")]

public async Task<Region> GetRegionById(int id){
    return await regionService.GetRegionById(id);
}

    [HttpPost("AddRegion")]

public async Task<Region> AddRegion(Region student){
    return await regionService.AddRegion( student);
}
  [HttpPut("UpdateRegion")]

public async Task<Region> UpdateRegion(Region student){
    return await regionService.UpdateRegion( student);
}
 [HttpDelete("DeleteRegion")]

public async Task<bool> DeleteRegion(int id){
    return await regionService.DeleteRegion( id);
}





}