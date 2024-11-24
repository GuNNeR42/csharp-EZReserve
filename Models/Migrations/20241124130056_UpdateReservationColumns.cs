using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace csharp_EZReserve.Models.Migrations
{
    /// <inheritdoc />
    public partial class UpdateReservationColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "to",
                table: "reservations",
                newName: "reserve_to");

            migrationBuilder.RenameColumn(
                name: "from",
                table: "reservations",
                newName: "reserve_from");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "reserve_to",
                table: "reservations",
                newName: "to");

            migrationBuilder.RenameColumn(
                name: "reserve_from",
                table: "reservations",
                newName: "from");
        }
    }
}
