﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace PrjFunNowWeb.Models;

public partial class Country
{
    public int CountryId { get; set; }

    public string CountryName { get; set; }

    public virtual ICollection<City> Cities { get; set; } = new List<City>();
}