using System;
using System.Collections.Generic;

namespace Training.Infrastucture.DbModels;

public partial class Accommodation
{
    public int Id { get; set; }

    public string? AccommodationName { get; set; }

    public int? WorkingAreaId { get; set; }

    public virtual ICollection<AccommodationTemplate> AccommodationTemplates { get; set; } = new List<AccommodationTemplate>();

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual ICollection<Log> Logs { get; set; } = new List<Log>();

    public virtual WorkingArea? WorkingArea { get; set; }
}
