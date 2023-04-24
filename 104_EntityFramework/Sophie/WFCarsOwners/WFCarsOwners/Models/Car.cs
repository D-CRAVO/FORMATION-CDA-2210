using System;
using System.Collections.Generic;

namespace WFCarsOwners.Models;

public partial class Car
{
    public int CarId { get; set; }

    public string CarName { get; set; } = null!;

    public int BrandId { get; set; }

    public virtual Brand Brand { get; set; } = null!;

    public virtual ICollection<Registration> Registrations { get; set; } = new List<Registration>();
}
