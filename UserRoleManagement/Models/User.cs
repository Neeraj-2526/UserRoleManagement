using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace UserRoleManagement.Models;

public partial class User
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    [JsonIgnore]
    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();
}
