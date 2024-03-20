using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Address
{
    [Key]
    public int AddressID { get; set; }
    [Required]
    public int StreetNumber { get; set; }
    public string? StreetName { get; set; }
    public string? Suburb { get; set; }
    public string? City { get; set; }
    public string? PostCode { get; set; }
    public int AccountID { get; set ;}
    [ForeignKey("AccountID")]
    public Account? Account { get; set; }

}