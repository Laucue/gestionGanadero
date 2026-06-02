using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model;

public class BreedingRecordsEntity
{
    [Key]
    public int IdReproductionRecord { get; set; }

    [Required]
    public int IdAnimal { get; set; }

    [Required]
    [MaxLength(20)]
    public string EventType { get; set; } // HEAT, INSEMINATION, PREGNANCY_CHECK, BIRTH

    [Required]
    public DateTime EventDate { get; set; }

    public int? IdPartner { get; set; }

    [MaxLength(20)]
    public string Method { get; set; } // NATURAL, AI

    [MaxLength(64)]
    public string Result { get; set; }

    public int? OffspringCount { get; set; }

    public string Notes { get; set; }

    // Navigation properties
    [ForeignKey("IdAnimal")]
    public virtual AnimalsEntity Animal { get; set; }

    [ForeignKey("IdPartner")]
    public virtual AnimalsEntity Partner { get; set; }
}