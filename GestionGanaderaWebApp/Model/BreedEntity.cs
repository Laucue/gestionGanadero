using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Model;

public class BreedsEntity
{
    [Key]
    public int IdBreed { get; set; }

    [Required]
    public int IdSpecies { get; set; }

    [Required]
    [MaxLength(120)]
    public string Name { get; set; }

    // Navigation properties
    [ForeignKey("IdSpecies")]
    public virtual PastureTypesEntity SpeciesEntity { get; set; }
    public virtual ICollection<AnimalsEntity> Animals { get; set; } 
}