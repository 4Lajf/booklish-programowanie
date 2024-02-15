using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace booklish.Data.Migrations
{
    public partial class AddRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "INSERT INTO AspNetRoles (Id, Name, NormalizedName, ConcurrencyStamp) " +
                "VALUES ('1', 'Admin', 'ADMIN', '1'), " +
                "       ('2', 'User', 'USER', '2')"
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "DELETE FROM AspNetRoles WHERE Id = '1'; " + // Deletes the Admin role
                "DELETE FROM AspNetRoles WHERE Id = '2';"  // Deletes the User role
            );
        }
    }
}
