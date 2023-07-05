using System;
using System.Collections.Generic;

namespace Training.Infrastucture.DbModels;

public partial class Booking
{
    public int Id { get; set; }

    public int ClientId { get; set; }

    public int AccommodationId { get; set; }

    public int SendTypeId { get; set; }

    public DateOnly CheckinDate { get; set; }

    public DateOnly CheckoutDate { get; set; }

    public DateOnly BookingDate { get; set; }

    public double? Price { get; set; }

    public virtual Accommodation Accommodation { get; set; } = null!;

    public virtual Client Client { get; set; } = null!;
}
