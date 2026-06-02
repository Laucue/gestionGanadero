using System;
using System.ComponentModel.DataAnnotations;

namespace Model;

public class TreatmentsEntity
{
    [Key]
    public int IdTreatment { get; set; }

    [MaxLength(128)]
    public string Description { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
