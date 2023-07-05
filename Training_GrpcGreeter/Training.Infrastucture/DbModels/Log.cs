using System;
using System.Collections.Generic;

namespace Training.Infrastucture.DbModels;

public partial class Log
{
    public int Id { get; set; }

    public int? ClientId { get; set; }

    public int? AccommodationId { get; set; }

    public int? SendTypeId { get; set; }

    public string? Message { get; set; }

    public virtual Accommodation? Accommodation { get; set; }

    public virtual Client? Client { get; set; }

    public virtual SendType? SendType { get; set; }
}
