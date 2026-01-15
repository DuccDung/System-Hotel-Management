using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SystemHotelManagement.Models;

public partial class SystemHotelManagementContext : DbContext
{
    public SystemHotelManagementContext()
    {
    }

    public SystemHotelManagementContext(DbContextOptions<SystemHotelManagementContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Booking> Bookings { get; set; }

    public virtual DbSet<BookingGuest> BookingGuests { get; set; }

    public virtual DbSet<CashTransaction> CashTransactions { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<RoomType> RoomTypes { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<ServiceUsage> ServiceUsages { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=ADMIN-PC\\MSSQLSERVER1;Initial Catalog=SystemHotelManagement;User ID=sa;Password=Dung@123;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.AccountId).HasName("PK__Accounts__349DA5A68E0E18A4");

            entity.HasIndex(e => e.Username, "UQ__Accounts__536C85E48F4DB0BE").IsUnique();

            entity.HasIndex(e => e.EmployeeId, "UQ__Accounts__7AD04F10E27BCC87").IsUnique();

            entity.Property(e => e.PasswordHash).HasMaxLength(255);
            entity.Property(e => e.PasswordSalt).HasMaxLength(255);
            entity.Property(e => e.Username).HasMaxLength(50);

            entity.HasOne(d => d.Employee).WithOne(p => p.Account)
                .HasForeignKey<Account>(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Accounts_Employees");
        });

        modelBuilder.Entity<Booking>(entity =>
        {
            entity.HasKey(e => e.BookingId).HasName("PK__Bookings__73951AEDD5C8C2E7");

            entity.HasIndex(e => new { e.CheckInPlan, e.CheckOutPlan }, "IX_Bookings_CheckInPlan_CheckOutPlan");

            entity.HasIndex(e => new { e.RoomId, e.Status }, "IX_Bookings_RoomId_Status");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Deposit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Note).HasMaxLength(255);

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_Bookings_Employees");

            entity.HasOne(d => d.Customer).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Bookings_Customers");

            entity.HasOne(d => d.Room).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Bookings_Rooms");
        });

        modelBuilder.Entity<BookingGuest>(entity =>
        {
            entity.HasKey(e => e.BookingGuestId).HasName("PK__BookingG__1101F9D8066AE8B3");

            entity.Property(e => e.GuestName).HasMaxLength(100);
            entity.Property(e => e.IdNumber).HasMaxLength(30);
            entity.Property(e => e.Phone).HasMaxLength(20);

            entity.HasOne(d => d.Booking).WithMany(p => p.BookingGuests)
                .HasForeignKey(d => d.BookingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BookingGuests_Bookings");
        });

        modelBuilder.Entity<CashTransaction>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PK__CashTran__55433A6B6AF80A36");

            entity.HasIndex(e => e.TransactionDate, "IX_CashTransactions_Date");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.TransactionDate).HasDefaultValueSql("(sysdatetime())");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.CashTransactions)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_CashTransactions_Employees");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__A4AE64D896E062DA");

            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FullName).HasMaxLength(100);
            entity.Property(e => e.IdNumber).HasMaxLength(30);
            entity.Property(e => e.MemberLevel).HasMaxLength(30);
            entity.Property(e => e.Phone).HasMaxLength(20);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__7AD04F115370F538");

            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FullName).HasMaxLength(100);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.Role)
                .HasMaxLength(30)
                .HasDefaultValue("Staff");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("PK__Payments__9B556A388D5801D9");

            entity.HasIndex(e => e.PaidAt, "IX_Payments_PaidAt");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Method)
                .HasMaxLength(20)
                .HasDefaultValue("Cash");
            entity.Property(e => e.Note).HasMaxLength(255);
            entity.Property(e => e.PaidAt).HasDefaultValueSql("(sysdatetime())");

            entity.HasOne(d => d.Booking).WithMany(p => p.Payments)
                .HasForeignKey(d => d.BookingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Payments_Bookings");

            entity.HasOne(d => d.ReceivedByNavigation).WithMany(p => p.Payments)
                .HasForeignKey(d => d.ReceivedBy)
                .HasConstraintName("FK_Payments_Employees");
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.HasKey(e => e.RoomId).HasName("PK__Rooms__32863939C2DF23BD");

            entity.HasIndex(e => e.RoomCode, "UQ__Rooms__4F9D52318E7656B6").IsUnique();

            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Note).HasMaxLength(255);
            entity.Property(e => e.RoomCode).HasMaxLength(20);

            entity.HasOne(d => d.RoomType).WithMany(p => p.Rooms)
                .HasForeignKey(d => d.RoomTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rooms_RoomTypes");
        });

        modelBuilder.Entity<RoomType>(entity =>
        {
            entity.HasKey(e => e.RoomTypeId).HasName("PK__RoomType__BCC896313C2A91FF");

            entity.Property(e => e.BasePrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Capacity).HasDefaultValue(1);
            entity.Property(e => e.Note).HasMaxLength(255);
            entity.Property(e => e.TypeName).HasMaxLength(50);
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.ServiceId).HasName("PK__Services__C51BB00A8D5C6FFB");

            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ServiceName).HasMaxLength(100);
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<ServiceUsage>(entity =>
        {
            entity.HasKey(e => e.ServiceUsageId).HasName("PK__ServiceU__650316FDC2D562B3");

            entity.Property(e => e.Note).HasMaxLength(255);
            entity.Property(e => e.Quantity).HasDefaultValue(1);
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UsedAt).HasDefaultValueSql("(sysdatetime())");

            entity.HasOne(d => d.Booking).WithMany(p => p.ServiceUsages)
                .HasForeignKey(d => d.BookingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiceUsages_Bookings");

            entity.HasOne(d => d.Service).WithMany(p => p.ServiceUsages)
                .HasForeignKey(d => d.ServiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiceUsages_Services");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
