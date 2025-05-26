using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IndoorPLantsC.Migrations
{
    /// <inheritdoc />
    public partial class InitialDataForPlantsAndUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                INSERT INTO Users (UserId, Name, LastName, BirthdayDate, ResidenceType, AvailableTime, ExperiencELevel)
                VALUES 
                    (1, 'Ana', 'Silva', '1990-05-15', 'Apartamento', 3.5, 2),
                    (2, 'Carlos', 'Oliveira', '1985-08-22', 'Casa', 5.0, 3),
                    (3, 'Beatriz', 'Souza', '2000-11-02', 'Apartamento', 2.0, 1);

                INSERT INTO Plants (PlantId, CientificName, PopularName, Family, IsPoisonous, WateringFrequency)
                VALUES 
                    (1, 'Ficus lyrata', 'Figueira-lira', 'Moraceae', 0, 7),
                    (2, 'Sansevieria trifasciata', 'Espada-de-São-Jorge', 'Asparagaceae', 1, 10),
                    (3, 'Chlorophytum comosum', 'Clorofito', 'Asparagaceae', 0, 5),
                    (4, 'Monstera deliciosa', 'Costela-de-Adão', 'Araceae', 1, 7),
                    (5, 'Dracaena fragrans', 'Pau-d’água', 'Asparagaceae', 1, 8),
                    (6, 'Calathea orbifolia', 'Calatéia', 'Marantaceae', 0, 6);

                INSERT INTO PlantUser (PlantsPlantId, UsersUserId)
                VALUES
                    (1, 1), (2, 1), (3, 2), (4, 2), (5, 3), (6, 3);
            ");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
