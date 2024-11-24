using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace csharp_EZReserve.Models.Migrations
{
    /// <inheritdoc />
    public partial class CreateCustomerReservationView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            CREATE VIEW customer_reservation_view AS
            SELECT 
                customers.id AS customer_id,
                customers.first_name AS first_name,
                customers.last_name AS last_name,
                customers.email AS email,
                reservations.id AS reservation_id,
                reservations.room AS room,
                reservations.reserve_from AS reservation_from,
                reservations.reserve_to AS reservation_to
            FROM
                customers
            INNER JOIN
                reservations ON customers.id = reservations.customer_id;
        ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW customer_reservation_view;");
        }
    }
}
