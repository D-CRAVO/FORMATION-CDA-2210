using System;
using System.Collections.Generic;

namespace WFCarsOwners.Models;

public partial class Registration
{
    public int CarId { get; set; }

    public int CarOwnerId { get; set; }

    public string CarRegistration { get; set; } = null!;

    public virtual Car Car { get; set; } = null!;

    public virtual Owner CarOwner { get; set; } = null!;
}
