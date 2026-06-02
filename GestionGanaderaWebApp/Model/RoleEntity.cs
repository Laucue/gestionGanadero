using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model;

public class RolesEntity
{
    [Key]
    public int IdRole { get; set; }

    [Required]
    [MaxLength(80)]
    public string Name { get; set; }

    [Required]
    public string Permissions { get; set; } // JSON string

    // Navigation properties
    public virtual ICollection<UsersEntity> Users { get; set; }
}