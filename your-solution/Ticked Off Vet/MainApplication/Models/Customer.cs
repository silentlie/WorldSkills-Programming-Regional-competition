using System;
using System.Collections.Generic;

namespace MainApplication.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? Title { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Gender { get; set; }

    public DateOnly? Dob { get; set; }

    public string? Email { get; set; }

    public string? Phone1 { get; set; }

    public string? Phone2 { get; set; }

    public string? Street1 { get; set; }

    public string? Street2 { get; set; }

    public string? Suburb { get; set; }

    public string? State { get; set; }

    public string? Postcode { get; set; }

    public virtual ICollection<Pet> Pets { get; set; } = new List<Pet>();

    public virtual State? StateNavigation { get; set; }
}
