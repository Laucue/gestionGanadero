using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model;

public class SalesEntity
{
    [Key]
    public int IdSale { get; set; }

    [Required]
    public int IdAnimal { get; set; }

    [Required]
    public DateTime SaleDate { get; set; }

    [Required]
    [MaxLength(150)]
    public string BuyerName { get; set; }

    [Column(TypeName = "decimal(14,2)")]
    public decimal? Price { get; set; }

    [MaxLength(3)]
    public string Currency { get; set; } = "COP";

    [Column(TypeName = "decimal(10,2)")]
    public decimal? WeightKg { get; set; }

    public string Notes { get; set; }

    // Navigation properties
    [ForeignKey("IdAnimal")]
    public virtual AnimalsEntity Animal { get; set; }
}