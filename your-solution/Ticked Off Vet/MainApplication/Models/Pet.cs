using System;
using System.Collections.Generic;

namespace MainApplication.Models;

public partial class Pet
{
    public int PetId { get; set; }

    public string? PetName { get; set; }

    public string? Species { get; set; }

    public string? Breed { get; set; }

    public DateOnly? Dob { get; set; }

    public string? Gender { get; set; }

    public double? Weight { get; set; }

    public int? CustomerId { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<Stay> Stays { get; set; } = new List<Stay>();
}
