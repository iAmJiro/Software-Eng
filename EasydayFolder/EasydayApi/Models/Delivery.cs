using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Delivery
{
    [Key]
    public int DeliveryID { get; set; }
    public string? Tracking { get; set; }
    public int OrderID { get; set; }
    [ForeignKey("OrderID")]
    public Order? Order { get; set; }
}