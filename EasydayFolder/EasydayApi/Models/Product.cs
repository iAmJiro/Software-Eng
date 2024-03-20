using System.ComponentModel.DataAnnotations;

public class Product
{
    [Key]
    public int ProductID { get; set; }
    public string? Name { get; set; }
    public string? SerialNumber { get; set; }
    public string? Type { get; set; }
}