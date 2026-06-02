using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model;

public class HealthRecordsEntity
{
    [Key]
    public int IdHealthRecord { get; set; }

    [Required]
    public int IdAnimal { get; set; }

    [Required]
    [MaxLength(20)]
    public string EventType { get; set; } // VACCINE, TREATMENT, DISEASE, CHECKUP

    [Required]
    public DateTime EventDate { get; set; }

    public string Diagnosis { get; set; }

    public string Treatment { get; set; }

    [MaxLength(120)]
    public string Medication { get; set; }

    [Column(TypeName = "decimal(10,2)")]
    public decimal? Dose { get; set; }

    [MaxLength(32)]
    public string DoseUnit { get; set; }

    [MaxLength(120)]
    public string Veterinarian { get; set; }

    public int? IdVaccine { get; set; }

    [MaxLength(64)]
    public string Batch { get; set; }

    public DateTime? NextBoosterDate { get; set; }

    public string Notes { get; set; }

    // Navigation properties
    [ForeignKey("IdAnimal")]
    public virtual AnimalsEntity Animal { get; set; }

    [ForeignKey("IdVaccine")]
    public virtual VaccinesEntity Vaccine { get; set; }
}