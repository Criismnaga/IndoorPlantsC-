using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IndoorPLantsC.Migrations
{
    /// <inheritdoc />
    public partial class Adiçãodemaisumusuário2quetemplanta1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"

                INSERT INTO PlantUser (PlantsPlantId, UsersUserId)
                VALUES
                   (1, 2), (1,3);
            ");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
