using System;
using System.ComponentModel.DataAnnotations;

namespace Model;

public class MedicalCheckupsEntity
{
    [Key]
    public int IdMedicalCheckup { get; set; }

    public int? IdAnimal { get; set; }

    public DateTime CheckupDate { get; set; } = DateTime.UtcNow;

    public string? Notes { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
