using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model;

public class FeedingPlansEntity
{
    [Key]
    public int IdPlan { get; set; }

    [Required]
    [MaxLength(120)]
    public string Name { get; set; }

    public int? IdSpecies { get; set; }

    public string Description { get; set; }

    // Navigation properties
    [ForeignKey("IdSpecies")]
    public virtual PastureTypesEntity Species { get; set; }

    public virtual ICollection<DietsEntity> Diets { get; set; }
}