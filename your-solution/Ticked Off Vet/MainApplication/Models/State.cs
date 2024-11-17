using System;
using System.Collections.Generic;

namespace MainApplication.Models;

public partial class State
{
    public string State1 { get; set; } = null!;

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    public virtual ICollection<Staff> Staff { get; set; } = new List<Staff>();
}
