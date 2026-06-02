using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model;

public class ActivityLogEntity
{
    [Key]
    public int IdAudit { get; set; }

    public int? IdUser { get; set; }

    [Required]
    [MaxLength(80)]
    public string Action { get; set; }

    [Required]
    [MaxLength(80)]
    public string Entity { get; set; }

    [Required]
    public int EntityId { get; set; }

    public DateTime Timestamp { get; set; } = DateTime.UtcNow;

    public string Details { get; set; }

    // Navigation properties
    [ForeignKey("IdUser")]
    public virtual UsersEntity User { get; set; }
}