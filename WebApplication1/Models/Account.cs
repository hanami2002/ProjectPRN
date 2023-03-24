using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Account
{
    public string UserName { get; set; } = null!;

    public string DisplayName { get; set; } = null!;

    public string? Password { get; set; }

    public int? Role { get; set; }
}
