using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Order
{
    public int Id { get; set; }

    public int IdTable { get; set; }

    public DateTime DateCheckIn { get; set; }

    public DateTime? DateCheckOut { get; set; }

    public int StatusId { get; set; }

    public double? Total { get; set; }

    public virtual Table IdTableNavigation { get; set; } = null!;

    public virtual ICollection<OrderDetail> OrderDetails { get; } = new List<OrderDetail>();

    public virtual Status Status { get; set; } = null!;
}
