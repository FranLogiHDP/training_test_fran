using Microsoft.EntityFrameworkCore;
using Training.Infrastucture.DbModels;

namespace Training.Infrastucture.Context;

public partial class TrainingDbContext : DbContext
{
    public TrainingDbContext(TrainingDbContext _trainingDbOptions)
    {
    }

    public TrainingDbContext(DbContextOptions<TrainingDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Accommodation> Accommodations { get; set; }

    public virtual DbSet<AccommodationTemplate> AccommodationTemplates { get; set; }

    public virtual DbSet<Booking> Bookings { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<ClientSendType> ClientSendTypes { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<SendType> SendTypes { get; set; }

    public virtual DbSet<WorkingArea> WorkingAreas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Accommodation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("accommodation_pkey");

            entity.ToTable("accommodation");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.AccommodationName)
                .HasMaxLength(600)
                .HasColumnName("accommodation_name");
            entity.Property(e => e.WorkingAreaId).HasColumnName("working_area_id");

            entity.HasOne(d => d.WorkingArea).WithMany(p => p.Accommodations)
                .HasForeignKey(d => d.WorkingAreaId)
                .HasConstraintName("accommodation_woking_area_fk");
        });

        modelBuilder.Entity<AccommodationTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("accommodation_template_pkey");

            entity.ToTable("accommodation_template");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.AccommodationId).HasColumnName("accommodation_id");
            entity.Property(e => e.Message)
                .HasMaxLength(255)
                .HasColumnName("message");
            entity.Property(e => e.SendTypeId).HasColumnName("send_type_id");

            entity.HasOne(d => d.Accommodation).WithMany(p => p.AccommodationTemplates)
                .HasForeignKey(d => d.AccommodationId)
                .HasConstraintName("accommodation_template_accommodation_fk");

            entity.HasOne(d => d.SendType).WithMany(p => p.AccommodationTemplates)
                .HasForeignKey(d => d.SendTypeId)
                .HasConstraintName("accommodation_template_type_send_type_fk");
        });

        modelBuilder.Entity<Booking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("booking_pkey");

            entity.ToTable("booking");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.AccommodationId).HasColumnName("accommodation_id");
            entity.Property(e => e.BookingDate).HasColumnName("booking_date");
            entity.Property(e => e.CheckinDate).HasColumnName("checkin_date");
            entity.Property(e => e.CheckoutDate).HasColumnName("checkout_date");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.SendTypeId).HasColumnName("send_type_id");

            entity.HasOne(d => d.Accommodation).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.AccommodationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("booking_accommodation_fk");

            entity.HasOne(d => d.Client).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("booking_client_fk");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("client_pkey");

            entity.ToTable("client");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.NumDocument)
                .HasMaxLength(15)
                .HasColumnName("num_document");
            entity.Property(e => e.Phone)
                .HasMaxLength(30)
                .HasColumnName("phone");
            entity.Property(e => e.Surname)
                .HasMaxLength(100)
                .HasColumnName("surname");
        });

        modelBuilder.Entity<ClientSendType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("client_send_type_pkey");

            entity.ToTable("client_send_type");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.SendTypeId).HasColumnName("send_type_id");

            entity.HasOne(d => d.Client).WithMany(p => p.ClientSendTypes)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("client_send_type_client_fk");

            entity.HasOne(d => d.SendType).WithMany(p => p.ClientSendTypes)
                .HasForeignKey(d => d.SendTypeId)
                .HasConstraintName("client_send_type_send_type_fk");
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("log_pkey");

            entity.ToTable("log");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.AccommodationId).HasColumnName("accommodation_id");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.Message)
                .HasMaxLength(255)
                .HasColumnName("message");
            entity.Property(e => e.SendTypeId).HasColumnName("send_type_id");

            entity.HasOne(d => d.Accommodation).WithMany(p => p.Logs)
                .HasForeignKey(d => d.AccommodationId)
                .HasConstraintName("log_accommodation_fk");

            entity.HasOne(d => d.Client).WithMany(p => p.Logs)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("log_client_fk");

            entity.HasOne(d => d.SendType).WithMany(p => p.Logs)
                .HasForeignKey(d => d.SendTypeId)
                .HasConstraintName("log_send_type_fk");
        });

        modelBuilder.Entity<SendType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("send_type_pkey");

            entity.ToTable("send_type");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.Message)
                .HasMaxLength(255)
                .HasColumnName("message");

            entity.HasOne(d => d.Client).WithMany(p => p.SendTypes)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("send_type_client_id");
        });

        modelBuilder.Entity<WorkingArea>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("working_area_pkey");

            entity.ToTable("working_area");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Zone)
                .HasMaxLength(255)
                .HasColumnName("zone");
        });
    }
}
