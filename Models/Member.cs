﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace PrjFunNowWeb.Models;

public partial class Member
{
    public int MemberId { get; set; }

    public string FirstName { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public string Phone { get; set; }

    public DateTime? Birthday { get; set; }

    public int RoleId { get; set; }

    public string Image { get; set; }

    public string LastName { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<Dialog> Dialogs { get; set; } = new List<Dialog>();

    public virtual ICollection<HotelLike> HotelLikes { get; set; } = new List<HotelLike>();

    public virtual ICollection<Hotel> Hotels { get; set; } = new List<Hotel>();

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual ICollection<ReportReview> ReportReviews { get; set; } = new List<ReportReview>();

    public virtual Role Role { get; set; }

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
}