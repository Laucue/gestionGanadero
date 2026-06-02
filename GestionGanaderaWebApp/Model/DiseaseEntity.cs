using System;
using System.ComponentModel.DataAnnotations;

namespace Model;

public class DiseasesEntity
{
    [Key]
    public int IdDisease { get; set; }

    [MaxLength(128)]
    public string Name { get; set; }

    public string? Symptoms { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
