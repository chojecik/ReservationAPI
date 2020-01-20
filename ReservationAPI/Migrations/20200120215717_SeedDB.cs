using Microsoft.EntityFrameworkCore.Migrations;

namespace ReservationAPI.Migrations
{
    public partial class SeedDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO ReservationSlots (Resource, ReservationDate) VALUES ('Conference room', '2020-01-20 08:00:00')");
            migrationBuilder.Sql("INSERT INTO ReservationSlots (Resource, ReservationDate) VALUES ('Conference room', '2020-01-20 09:00:00')");
            migrationBuilder.Sql("INSERT INTO ReservationSlots (Resource, ReservationDate) VALUES ('Conference room', '2020-01-20 10:00:00')");
            migrationBuilder.Sql("INSERT INTO ReservationSlots (Resource, ReservationDate) VALUES ('Conference room', '2020-01-20 11:00:00')");
            migrationBuilder.Sql("INSERT INTO ReservationSlots (Resource, ReservationDate) VALUES ('Conference room', '2020-01-20 12:00:00')");
            migrationBuilder.Sql("INSERT INTO ReservationSlots (Resource, ReservationDate) VALUES ('Chill room', '2020-01-20 12:00:00')");
            migrationBuilder.Sql("INSERT INTO ReservationSlots (Resource, ReservationDate) VALUES ('Chill room', '2020-01-20 13:00:00')");
            migrationBuilder.Sql("INSERT INTO ReservationSlots (Resource, ReservationDate) VALUES ('Chill room', '2020-01-20 14:00:00')");
            migrationBuilder.Sql("INSERT INTO ReservationSlots (Resource, ReservationDate) VALUES ('Chill room', '2020-01-20 15:00:00')");
            migrationBuilder.Sql("INSERT INTO ReservationSlots (Resource, ReservationDate) VALUES ('Chill room', '2020-01-20 16:00:00')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
