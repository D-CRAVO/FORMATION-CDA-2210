using System;
using System.Collections.Generic;

namespace WFCarsOwners.Models;

public partial class Owner
{
    public int OwnerId { get; set; }

    public string OwnerLastname { get; set; } = null!;

    public string OwnerFirstname { get; set; } = null!;

    public virtual ICollection<Registration> Registrations { get; set; } = new List<Registration>();
}
