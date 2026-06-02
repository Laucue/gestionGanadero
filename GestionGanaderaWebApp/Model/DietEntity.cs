using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model;

public class DietsEntity
{
    [Key]
    public int IdDiet { get; set; }

    public int? IdPlan { get; set; }

    [Required]
    [MaxLength(120)]
    public string Name { get; set; }

    public string Description { get; set; }

    // Navigation properties
    [ForeignKey("IdPlan")]
    public virtual FeedingPlansEntity FeedingPlan { get; set; }

    public virtual ICollection<DietItemsEntity> DietItems { get; set; }
    public virtual ICollection<FeedingSchedulesEntity> FeedingSchedules { get; set; }
}