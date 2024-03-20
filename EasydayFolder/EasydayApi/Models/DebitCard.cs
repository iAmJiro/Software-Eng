using System.ComponentModel.DataAnnotations;
using Microsoft.Identity.Client;

public class DebitCard
{
    [Key]
    public int DebitCardID { get; set; }
    [Required]
    public string? CardHolder { get; set; }
    public string? CardNumber { get; set; }
    public DateOnly ExpiryDate { get; set; }
    [MinLength(16), MaxLength(16)]
    public string? CVV { get; set; }
    
}