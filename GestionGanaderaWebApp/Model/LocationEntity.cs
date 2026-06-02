using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model;

public class LocationsEntity
{
    [Key]
    public int IdLocation { get; set; }
    
    [Required]
    [MaxLength(150)]
    public string Name { get; set; }
    
    [Column(TypeName = "decimal(10,2)")]
    public decimal? AreaHectares { get; set; }
    
    [MaxLength(120)]
    public string PastureType { get; set; }
    
    [Column(TypeName = "decimal(9,6)")]
    public decimal Latitude { get; set; }
    
    [Column(TypeName = "decimal(9,6)")]
    public decimal Longitude { get; set; }
    
    public string Description { get; set; }
    
    // Navigation properties
    public virtual ICollection<AnimalsEntity> Animals { get; set; }
}