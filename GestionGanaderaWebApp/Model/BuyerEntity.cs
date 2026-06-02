using System;
using System.ComponentModel.DataAnnotations;

namespace Model;

public class BuyersEntity
{
    [Key]
    public int IdBuyer { get; set; }

    [MaxLength(128)]
    public string Name { get; set; }

    public string? Notes { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
