using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Sockets;

public class Account
{
    [Key]
    public int AccountID { get; set; }
    [Required]
    public string? Role { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }


    public Address? Address { get; set ;}

    public int DebitCardID { get; set; }
    [ForeignKey("DebitCardID")]
    public DebitCard? DebitCard { get; set;}
}