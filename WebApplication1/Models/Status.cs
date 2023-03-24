using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Status
{
    public int Id { get; set; }

    public string? SttName { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();

    public virtual ICollection<Table> Tables { get; } = new List<Table>();
}
