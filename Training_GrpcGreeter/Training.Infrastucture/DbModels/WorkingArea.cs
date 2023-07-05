using System;
using System.Collections.Generic;

namespace Training.Infrastucture.DbModels;

public partial class WorkingArea
{
    public int Id { get; set; }

    public string? Zone { get; set; }

    public virtual ICollection<Accommodation> Accommodations { get; set; } = new List<Accommodation>();
}
