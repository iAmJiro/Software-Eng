using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Http.Headers;

public class OrderProduct
{
    [Key]
    public int OrderProductID { get; set; }
    public int OrderID { get; set; }
    [ForeignKey("OrderID")]
    public Order? Order { get; set; }

    public int ProductID { get; set; }
    [ForeignKey("ProductID")]
    public Product? Product { get; set; }
}