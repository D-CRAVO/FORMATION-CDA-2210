using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WFCities.Models;

public partial class Country
{
    //[Key]
    public string CountryCode { get; set; } = null!;

    public string? CountryName { get; set; }

    public virtual ICollection<City> Cities { get; set; } = new List<City>();
}
