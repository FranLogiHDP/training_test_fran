namespace Training.Infrastucture.DbModels;

public partial class Client
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public string? Phone { get; set; }

    public string? NumDocument { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual ICollection<ClientSendType> ClientSendTypes { get; set; } = new List<ClientSendType>();

    public virtual ICollection<Log> Logs { get; set; } = new List<Log>();

    public virtual ICollection<SendType> SendTypes { get; set; } = new List<SendType>();
}
