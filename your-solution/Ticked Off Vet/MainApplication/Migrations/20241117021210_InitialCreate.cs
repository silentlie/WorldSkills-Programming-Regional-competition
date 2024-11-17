using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MainApplication.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    itemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    itemName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    itemDescription = table.Column<string>(type: "TEXT", nullable: true),
                    numberOnHand = table.Column<int>(type: "int", nullable: false),
                    numberOnOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.itemID);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    state = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.state);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    customerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    firstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    lastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    gender = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    DOB = table.Column<DateOnly>(type: "date", nullable: true),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    phone1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    phone2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    street1 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    street2 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    suburb = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    state = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    postcode = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.customerID);
                    table.ForeignKey(
                        name: "FK_Customer_State",
                        column: x => x.state,
                        principalTable: "State",
                        principalColumn: "state");
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    staffID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    firstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    lastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    gender = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    DOB = table.Column<DateOnly>(type: "date", nullable: true),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    phone1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    phone2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    street1 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    street2 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    suburb = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    state = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    postcode = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    position = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.staffID);
                    table.ForeignKey(
                        name: "FK_Staff_State",
                        column: x => x.state,
                        principalTable: "State",
                        principalColumn: "state");
                });

            migrationBuilder.CreateTable(
                name: "Pet",
                columns: table => new
                {
                    petID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    petName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    species = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    breed = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DOB = table.Column<DateOnly>(type: "date", nullable: true),
                    gender = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    weight = table.Column<double>(type: "float", nullable: true),
                    customerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pet", x => x.petID);
                    table.ForeignKey(
                        name: "FK_Pet_Customer",
                        column: x => x.customerID,
                        principalTable: "Customer",
                        principalColumn: "customerID");
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    bookingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    petID = table.Column<int>(type: "int", nullable: true),
                    staffID = table.Column<int>(type: "int", nullable: true),
                    bookingDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    symptoms = table.Column<string>(type: "text", nullable: true),
                    treatments = table.Column<string>(type: "text", nullable: true),
                    notes = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.bookingID);
                    table.ForeignKey(
                        name: "FK_Booking_Pet",
                        column: x => x.petID,
                        principalTable: "Pet",
                        principalColumn: "petID");
                    table.ForeignKey(
                        name: "FK_Booking_Staff",
                        column: x => x.staffID,
                        principalTable: "Staff",
                        principalColumn: "staffID");
                });

            migrationBuilder.CreateTable(
                name: "Stay",
                columns: table => new
                {
                    stayID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    stayStartDate = table.Column<DateOnly>(type: "date", nullable: true),
                    stayEndDate = table.Column<DateOnly>(type: "date", nullable: true),
                    petID = table.Column<int>(type: "int", nullable: true),
                    stayCost = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stay", x => x.stayID);
                    table.ForeignKey(
                        name: "FK_Stay_Pet",
                        column: x => x.petID,
                        principalTable: "Pet",
                        principalColumn: "petID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_petID",
                table: "Booking",
                column: "petID");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_staffID",
                table: "Booking",
                column: "staffID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_state",
                table: "Customer",
                column: "state");

            migrationBuilder.CreateIndex(
                name: "IX_Pet_customerID",
                table: "Pet",
                column: "customerID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_state",
                table: "Staff",
                column: "state");

            migrationBuilder.CreateIndex(
                name: "IX_Stay_petID",
                table: "Stay",
                column: "petID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "Stay");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Pet");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "State");
        }
    }
}
