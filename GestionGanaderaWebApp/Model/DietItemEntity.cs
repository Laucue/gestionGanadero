using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model;

public class DietItemsEntity
{
    [Key]
    public int IdItem { get; set; }

    [Required]
    public int IdDiet { get; set; }

    [Required]
    [MaxLength(120)]
    public string Food { get; set; }

    [Column(TypeName = "decimal(10,3)")]
    public decimal? DailyAmountKg { get; set; }

    // Navigation properties
    [ForeignKey("IdDiet")]
    public virtual DietsEntity Diet { get; set; }
}
