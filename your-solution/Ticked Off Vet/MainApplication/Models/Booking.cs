using System;
using System.Collections.Generic;

namespace MainApplication.Models;

public partial class Booking
{
    public int BookingId { get; set; }

    public int? PetId { get; set; }

    public int? StaffId { get; set; }

    public DateTime? BookingDateTime { get; set; }

    public string? Symptoms { get; set; }

    public string? Treatments { get; set; }

    public string? Notes { get; set; }

    public virtual Pet? Pet { get; set; }

    public virtual Staff? Staff { get; set; }
}
