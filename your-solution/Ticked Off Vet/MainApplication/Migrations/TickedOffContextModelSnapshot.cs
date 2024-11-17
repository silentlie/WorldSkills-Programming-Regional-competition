﻿// <auto-generated />
using System;
using MainApplication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MainApplication.Migrations
{
    [DbContext(typeof(TickedOffContext))]
    partial class TickedOffContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MainApplication.Models.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("bookingID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"));

                    b.Property<DateTime?>("BookingDateTime")
                        .HasColumnType("datetime")
                        .HasColumnName("bookingDateTime");

                    b.Property<string>("Notes")
                        .HasColumnType("text")
                        .HasColumnName("notes");

                    b.Property<int?>("PetId")
                        .HasColumnType("int")
                        .HasColumnName("petID");

                    b.Property<int?>("StaffId")
                        .HasColumnType("int")
                        .HasColumnName("staffID");

                    b.Property<string>("Symptoms")
                        .HasColumnType("text")
                        .HasColumnName("symptoms");

                    b.Property<string>("Treatments")
                        .HasColumnType("text")
                        .HasColumnName("treatments");

                    b.HasKey("BookingId");

                    b.HasIndex("PetId");

                    b.HasIndex("StaffId");

                    b.ToTable("Booking", (string)null);
                });

            modelBuilder.Entity("MainApplication.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("customerID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<DateOnly?>("Dob")
                        .HasColumnType("date")
                        .HasColumnName("DOB");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("firstName");

                    b.Property<string>("Gender")
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)")
                        .HasColumnName("gender");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("lastName");

                    b.Property<string>("Phone1")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("phone1");

                    b.Property<string>("Phone2")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("phone2");

                    b.Property<string>("Postcode")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)")
                        .HasColumnName("postcode");

                    b.Property<string>("State")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)")
                        .HasColumnName("state");

                    b.Property<string>("Street1")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("street1");

                    b.Property<string>("Street2")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("street2");

                    b.Property<string>("Suburb")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)")
                        .HasColumnName("suburb");

                    b.Property<string>("Title")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("title");

                    b.HasKey("CustomerId");

                    b.HasIndex("State");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("MainApplication.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("itemID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemId"));

                    b.Property<string>("ItemDescription")
                        .HasColumnType("TEXT")
                        .HasColumnName("itemDescription");

                    b.Property<string>("ItemName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("itemName");

                    b.Property<int>("NumberOnHand")
                        .HasColumnType("int")
                        .HasColumnName("numberOnHand");

                    b.Property<int>("NumberOnOrder")
                        .HasColumnType("int")
                        .HasColumnName("numberOnOrder");

                    b.HasKey("ItemId");

                    b.ToTable("Inventory", (string)null);
                });

            modelBuilder.Entity("MainApplication.Models.Pet", b =>
                {
                    b.Property<int>("PetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("petID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PetId"));

                    b.Property<string>("Breed")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("breed");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("customerID");

                    b.Property<DateOnly?>("Dob")
                        .HasColumnType("date")
                        .HasColumnName("DOB");

                    b.Property<string>("Gender")
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)")
                        .HasColumnName("gender");

                    b.Property<string>("PetName")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)")
                        .HasColumnName("petName");

                    b.Property<string>("Species")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("species");

                    b.Property<double?>("Weight")
                        .HasColumnType("float")
                        .HasColumnName("weight");

                    b.HasKey("PetId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Pet", (string)null);
                });

            modelBuilder.Entity("MainApplication.Models.Staff", b =>
                {
                    b.Property<int>("StaffId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("staffID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StaffId"));

                    b.Property<DateOnly?>("Dob")
                        .HasColumnType("date")
                        .HasColumnName("DOB");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("firstName");

                    b.Property<string>("Gender")
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)")
                        .HasColumnName("gender");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("lastName");

                    b.Property<string>("Phone1")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("phone1");

                    b.Property<string>("Phone2")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("phone2");

                    b.Property<string>("Position")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("position");

                    b.Property<string>("Postcode")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)")
                        .HasColumnName("postcode");

                    b.Property<string>("State")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)")
                        .HasColumnName("state");

                    b.Property<string>("Street1")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("street1");

                    b.Property<string>("Street2")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("street2");

                    b.Property<string>("Suburb")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)")
                        .HasColumnName("suburb");

                    b.Property<string>("Title")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("title");

                    b.HasKey("StaffId");

                    b.HasIndex("State");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("MainApplication.Models.State", b =>
                {
                    b.Property<string>("State1")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)")
                        .HasColumnName("state");

                    b.HasKey("State1");

                    b.ToTable("State", (string)null);
                });

            modelBuilder.Entity("MainApplication.Models.Stay", b =>
                {
                    b.Property<int>("StayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("stayID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StayId"));

                    b.Property<int?>("PetId")
                        .HasColumnType("int")
                        .HasColumnName("petID");

                    b.Property<decimal?>("StayCost")
                        .HasColumnType("money")
                        .HasColumnName("stayCost");

                    b.Property<DateOnly?>("StayEndDate")
                        .HasColumnType("date")
                        .HasColumnName("stayEndDate");

                    b.Property<DateOnly?>("StayStartDate")
                        .HasColumnType("date")
                        .HasColumnName("stayStartDate");

                    b.HasKey("StayId");

                    b.HasIndex("PetId");

                    b.ToTable("Stay", (string)null);
                });

            modelBuilder.Entity("MainApplication.Models.Booking", b =>
                {
                    b.HasOne("MainApplication.Models.Pet", "Pet")
                        .WithMany("Bookings")
                        .HasForeignKey("PetId")
                        .HasConstraintName("FK_Booking_Pet");

                    b.HasOne("MainApplication.Models.Staff", "Staff")
                        .WithMany("Bookings")
                        .HasForeignKey("StaffId")
                        .HasConstraintName("FK_Booking_Staff");

                    b.Navigation("Pet");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("MainApplication.Models.Customer", b =>
                {
                    b.HasOne("MainApplication.Models.State", "StateNavigation")
                        .WithMany("Customers")
                        .HasForeignKey("State")
                        .HasConstraintName("FK_Customer_State");

                    b.Navigation("StateNavigation");
                });

            modelBuilder.Entity("MainApplication.Models.Pet", b =>
                {
                    b.HasOne("MainApplication.Models.Customer", "Customer")
                        .WithMany("Pets")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_Pet_Customer");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("MainApplication.Models.Staff", b =>
                {
                    b.HasOne("MainApplication.Models.State", "StateNavigation")
                        .WithMany("Staff")
                        .HasForeignKey("State")
                        .HasConstraintName("FK_Staff_State");

                    b.Navigation("StateNavigation");
                });

            modelBuilder.Entity("MainApplication.Models.Stay", b =>
                {
                    b.HasOne("MainApplication.Models.Pet", "Pet")
                        .WithMany("Stays")
                        .HasForeignKey("PetId")
                        .HasConstraintName("FK_Stay_Pet");

                    b.Navigation("Pet");
                });

            modelBuilder.Entity("MainApplication.Models.Customer", b =>
                {
                    b.Navigation("Pets");
                });

            modelBuilder.Entity("MainApplication.Models.Pet", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Stays");
                });

            modelBuilder.Entity("MainApplication.Models.Staff", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("MainApplication.Models.State", b =>
                {
                    b.Navigation("Customers");

                    b.Navigation("Staff");
                });
#pragma warning restore 612, 618
        }
    }
}
