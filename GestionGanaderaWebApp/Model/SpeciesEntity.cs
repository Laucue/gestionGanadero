using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Model;

public class PastureTypesEntity
{
     [Key]
     public int IdSpecies { get; set; }
    
     [Required]
     [MaxLength(120)]
     public string Name { get; set; }
    
     // Navigation properties
     public virtual ICollection<BreedsEntity> Breeds { get; set; }
     public virtual ICollection<AnimalsEntity> Animals { get; set; }
     public virtual ICollection<FeedingPlansEntity> FeedingPlans { get; set; }
    
}