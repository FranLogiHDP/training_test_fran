using System;
using System.Collections.Generic;

namespace Training.Infrastucture.DbModels;

public partial class ClientSendType
{
    public int Id { get; set; }

    public int? SendTypeId { get; set; }

    public int? ClientId { get; set; }

    public virtual Client? Client { get; set; }

    public virtual SendType? SendType { get; set; }
}
