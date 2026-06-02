using System;
using System.ComponentModel.DataAnnotations;

namespace Model;

public class BirthsEntity
{
    [Key]
    public int IdBirth { get; set; }

    public int? IdMother { get; set; }

    public DateTime BirthDate { get; set; } = DateTime.UtcNow;

    public int? NumberOfOffspring { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
