﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace PrjFunNowWeb.Models;

public partial class HotelEquipmentReference
{
    public int HotelEquipmentReferenceId { get; set; }

    public int HotelId { get; set; }

    public int HotelEquipmentId { get; set; }

    public virtual Hotel Hotel { get; set; }

    public virtual HotelEquipment HotelEquipment { get; set; }
}