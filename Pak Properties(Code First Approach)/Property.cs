using System;
using System.Collections.Generic;

namespace WebApplication2;

public partial class Property
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string? City { get; set; }

    public string? Type { get; set; }

    public string? AreaSize { get; set; }

    public string? Address { get; set; }

    public string? Status { get; set; }

    public virtual User User { get; set; } = null!;
}
