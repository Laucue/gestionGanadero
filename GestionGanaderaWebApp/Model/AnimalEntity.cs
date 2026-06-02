
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model;

public class AnimalsEntity
{
    [Key]
    public int IdAnimal { get; set; }

    [Required]
    [MaxLength(64)]
    public string EarringCode { get; set; }

    [Required]
    public int IdSpecies { get; set; }

    public int? IdBreed { get; set; }

    [Required]
    [MaxLength(1)]
    public string Sex { get; set; } // M, F, I

    public DateTime? BirthDate { get; set; }

    [Required]
    [MaxLength(20)]
    public string Status { get; set; } = "ACTIVE";

    [MaxLength(80)]
    public string Color { get; set; }

    public string Notes { get; set; }

    public int? IdFather { get; set; }

    public int? IdMother { get; set; }

    public int? IdLocation { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    // Navigation properties
    [ForeignKey("IdSpecies")]
    public virtual PastureTypesEntity Species { get; set; }

    [ForeignKey("IdBreed")]
    public virtual BreedsEntity Breed { get; set; }

    [ForeignKey("IdLocation")]
    public virtual LocationsEntity Location { get; set; }

    [ForeignKey("IdFather")]
    public virtual AnimalsEntity Father { get; set; }

    [ForeignKey("IdMother")]
    public virtual AnimalsEntity Mother { get; set; }

    // Collections
    public virtual ICollection<HealthRecordsEntity> HealthRecords { get; set; }
    public virtual ICollection<BreedingRecordsEntity> ReproductionRecords { get; set; }
    public virtual ICollection<SalesEntity> Sales { get; set; }
    public virtual ICollection<FeedingSchedulesEntity> FeedingSchedules { get; set; }

    // Children for father and mother
    public virtual ICollection<AnimalsEntity> FatherChildren { get; set; }
    public virtual ICollection<AnimalsEntity> MotherChildren { get; set; }
}