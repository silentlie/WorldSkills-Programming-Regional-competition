using System;
using System.Collections.Generic;

namespace MainApplication.Models;

public partial class Stay
{
    public int StayId { get; set; }

    public DateOnly? StayStartDate { get; set; }

    public DateOnly? StayEndDate { get; set; }

    public int? PetId { get; set; }

    public decimal? StayCost { get; set; }

    public virtual Pet? Pet { get; set; }
}
