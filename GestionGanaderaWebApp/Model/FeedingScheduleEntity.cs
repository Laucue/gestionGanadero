using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model;

public class FeedingSchedulesEntity
{
    [Key]
    public int IdSchedule { get; set; }

    public int? IdAnimal { get; set; }

    public int? IdSpecies { get; set; }

    public int? IdDiet { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    [MaxLength(8)]
    public string Time { get; set; }

    // Navigation properties
    [ForeignKey("IdAnimal")]
    public virtual AnimalsEntity Animal { get; set; }

    [ForeignKey("IdSpecies")]
    public virtual PastureTypesEntity Species { get; set; }

    [ForeignKey("IdDiet")]
    public virtual DietsEntity Diet { get; set; }
}