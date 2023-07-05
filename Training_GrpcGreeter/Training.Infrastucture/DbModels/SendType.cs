using System;
using System.Collections.Generic;

namespace Training.Infrastucture.DbModels;

public partial class SendType
{
    public int Id { get; set; }

    public string? Message { get; set; }

    public int? ClientId { get; set; }

    public virtual ICollection<AccommodationTemplate> AccommodationTemplates { get; set; } = new List<AccommodationTemplate>();

    public virtual Client? Client { get; set; }

    public virtual ICollection<ClientSendType> ClientSendTypes { get; set; } = new List<ClientSendType>();

    public virtual ICollection<Log> Logs { get; set; } = new List<Log>();
}
