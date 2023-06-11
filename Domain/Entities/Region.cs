using System.ComponentModel.DataAnnotations;

public class Region
{
    [Key]
    public int RegionId { get; set; }
    public string RegionName { get; set; }
}