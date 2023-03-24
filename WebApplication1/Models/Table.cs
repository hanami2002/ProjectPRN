using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Table
{
    public int Id { get; set; }

    public string NameTable { get; set; } = null!;

    public int StatusId { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();

    public virtual Status Status { get; set; } = null!;
}
