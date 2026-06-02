using System;
using System.ComponentModel.DataAnnotations;

namespace Model;

public class SaleDetailsEntity
{
    [Key]
    public int IdSaleDetail { get; set; }

    public int IdSale { get; set; }

    public decimal Amount { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
