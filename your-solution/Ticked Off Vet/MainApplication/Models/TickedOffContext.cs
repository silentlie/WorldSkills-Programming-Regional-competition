using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MainApplication.Models;

public partial class TickedOffContext : DbContext
{
    public TickedOffContext()
    {
    }

    public TickedOffContext(DbContextOptions<TickedOffContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Booking> Bookings { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Pet> Pets { get; set; }

    public virtual DbSet<Staff> Staff { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<Stay> Stays { get; set; }

    public virtual DbSet<Item> Inventory { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=TickedOff;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Booking>(entity =>
        {
            entity.ToTable("Booking");

            entity.Property(e => e.BookingId)
                .ValueGeneratedOnAdd()
                .HasColumnName("bookingID");
            entity.Property(e => e.BookingDateTime)
                .HasColumnType("datetime")
                .HasColumnName("bookingDateTime");
            entity.Property(e => e.Notes)
                .HasColumnType("text")
                .HasColumnName("notes");
            entity.Property(e => e.PetId).HasColumnName("petID");
            entity.Property(e => e.StaffId).HasColumnName("staffID");
            entity.Property(e => e.Symptoms)
                .HasColumnType("text")
                .HasColumnName("symptoms");
            entity.Property(e => e.Treatments)
                .HasColumnType("text")
                .HasColumnName("treatments");

            entity.HasOne(d => d.Pet).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.PetId)
                .HasConstraintName("FK_Booking_Pet");

            entity.HasOne(d => d.Staff).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.StaffId)
                .HasConstraintName("FK_Booking_Staff");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("Customer");

            entity.Property(e => e.CustomerId)
                .ValueGeneratedOnAdd()
                .HasColumnName("customerID");
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("firstName");
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .HasColumnName("gender");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("lastName");
            entity.Property(e => e.Phone1)
                .HasMaxLength(20)
                .HasColumnName("phone1");
            entity.Property(e => e.Phone2)
                .HasMaxLength(20)
                .HasColumnName("phone2");
            entity.Property(e => e.Postcode)
                .HasMaxLength(4)
                .HasColumnName("postcode");
            entity.Property(e => e.State)
                .HasMaxLength(3)
                .HasColumnName("state");
            entity.Property(e => e.Street1)
                .HasMaxLength(150)
                .HasColumnName("street1");
            entity.Property(e => e.Street2)
                .HasMaxLength(150)
                .HasColumnName("street2");
            entity.Property(e => e.Suburb)
                .HasMaxLength(80)
                .HasColumnName("suburb");
            entity.Property(e => e.Title)
                .HasMaxLength(10)
                .HasColumnName("title");

            entity.HasOne(d => d.StateNavigation).WithMany(p => p.Customers)
                .HasForeignKey(d => d.State)
                .HasConstraintName("FK_Customer_State");
        });

        modelBuilder.Entity<Pet>(entity =>
        {
            entity.ToTable("Pet");

            entity.Property(e => e.PetId)
                .ValueGeneratedOnAdd()
                .HasColumnName("petID");
            entity.Property(e => e.Breed)
                .HasMaxLength(50)
                .HasColumnName("breed");
            entity.Property(e => e.CustomerId).HasColumnName("customerID");
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .HasColumnName("gender");
            entity.Property(e => e.PetName)
                .HasMaxLength(80)
                .HasColumnName("petName");
            entity.Property(e => e.Species)
                .HasMaxLength(50)
                .HasColumnName("species");
            entity.Property(e => e.Weight).HasColumnName("weight");

            entity.HasOne(d => d.Customer).WithMany(p => p.Pets)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_Pet_Customer");
        });

        modelBuilder.Entity<Staff>(entity =>
        {
            entity.Property(e => e.StaffId)
                .ValueGeneratedOnAdd()
                .HasColumnName("staffID");
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("firstName");
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .HasColumnName("gender");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("lastName");
            entity.Property(e => e.Phone1)
                .HasMaxLength(20)
                .HasColumnName("phone1");
            entity.Property(e => e.Phone2)
                .HasMaxLength(20)
                .HasColumnName("phone2");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .HasColumnName("position");
            entity.Property(e => e.Postcode)
                .HasMaxLength(4)
                .HasColumnName("postcode");
            entity.Property(e => e.State)
                .HasMaxLength(3)
                .HasColumnName("state");
            entity.Property(e => e.Street1)
                .HasMaxLength(150)
                .HasColumnName("street1");
            entity.Property(e => e.Street2)
                .HasMaxLength(150)
                .HasColumnName("street2");
            entity.Property(e => e.Suburb)
                .HasMaxLength(80)
                .HasColumnName("suburb");
            entity.Property(e => e.Title)
                .HasMaxLength(10)
                .HasColumnName("title");

            entity.HasOne(d => d.StateNavigation).WithMany(p => p.Staff)
                .HasForeignKey(d => d.State)
                .HasConstraintName("FK_Staff_State");
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.HasKey(e => e.State1);

            entity.ToTable("State");

            entity.Property(e => e.State1)
                .HasMaxLength(3)
                .HasColumnName("state");
        });

        modelBuilder.Entity<Stay>(entity =>
        {
            entity.ToTable("Stay");

            entity.Property(e => e.StayId)
                .ValueGeneratedOnAdd()
                .HasColumnName("stayID");
            entity.Property(e => e.PetId).HasColumnName("petID");
            entity.Property(e => e.StayCost)
                .HasColumnType("money")
                .HasColumnName("stayCost");
            entity.Property(e => e.StayEndDate).HasColumnName("stayEndDate");
            entity.Property(e => e.StayStartDate).HasColumnName("stayStartDate");

            entity.HasOne(d => d.Pet).WithMany(p => p.Stays)
                .HasForeignKey(d => d.PetId)
                .HasConstraintName("FK_Stay_Pet");
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.ToTable("Inventory");
            entity.Property(e => e.ItemId)
                .ValueGeneratedOnAdd()
                .HasColumnName("itemID");
            entity.Property(e => e.ItemName).HasMaxLength(50).HasColumnName("itemName");
            entity.Property(e => e.ItemDescription).HasColumnType("TEXT").HasColumnName("itemDescription");
            entity.Property(e => e.NumberOnHand).HasColumnName("numberOnHand");
            entity.Property(e => e.NumberOnOrder).HasColumnName("numberOnOrder");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
