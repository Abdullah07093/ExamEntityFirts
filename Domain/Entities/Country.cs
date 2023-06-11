using System.ComponentModel.DataAnnotations;

public class Country
{
    [Key]
    public int CountryId { get; set; }
    public string CountryName { get; set; }
    public int RegionId { get; set; }
    public Region Region { get; set; }
}