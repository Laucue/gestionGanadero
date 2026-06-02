using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model;

public class UsersEntity
{
    [Key]
    public int IdUser { get; set; }

    [Required]
    [MaxLength(120)]
    public string FullName { get; set; }

    [Required]
    [MaxLength(160)]
    public string Email { get; set; }

    [MaxLength(40)]
    public string Phone { get; set; }

    [Required]
    [MaxLength(200)]
    public string PasswordHash { get; set; }

    public int? IdRole { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navigation properties
    [ForeignKey("IdRole")]
    public virtual RolesEntity Role { get; set; }

    public virtual ICollection<ActivityLogEntity> AuditLogs { get; set; }
}