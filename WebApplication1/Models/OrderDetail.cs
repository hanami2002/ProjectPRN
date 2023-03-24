using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class OrderDetail
{
    public int Id { get; set; }

    public int IdOrder { get; set; }

    public int IdFood { get; set; }

    public int? Counts { get; set; }

    public virtual Menu IdFoodNavigation { get; set; } = null!;

    public virtual Order IdOrderNavigation { get; set; } = null!;
}
