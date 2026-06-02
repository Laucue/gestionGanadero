using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model;

public class VaccinesEntity
{
    [Key]
    public int IdVaccine { get; set; }

    [Required]
    [MaxLength(120)]
    public string Name { get; set; }

    [MaxLength(120)]
    public string Manufacturer { get; set; }

    [Column(TypeName = "decimal(10,2)")]
    public decimal? DefaultDoseMl { get; set; }

    public int? BoosterDays { get; set; }

    // Navigation properties
    public virtual ICollection<HealthRecordsEntity> HealthRecords { get; set; }
}