using System.ComponentModel.DataAnnotations;

public class Location
{[Key]
    public int LocationId { get; set; }
    public string StreetAddress { get; set; }
    public string PostalCode { get; set; }
    public string City { get; set; }
    public string StateProvince { get; set; }
    public int CountryId { get; set; }
    public Country Country{ get; set; }
}