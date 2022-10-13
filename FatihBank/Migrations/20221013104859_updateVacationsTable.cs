using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FatihBank.Migrations
{
    public partial class updateVacationsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MSS_ATT_Vacations_MSS_ATT_VacationsTypes_vacationsTypeId",
                table: "MSS_ATT_Vacations");

            migrationBuilder.DropColumn(
                name: "vacationTypeId",
                table: "MSS_ATT_Vacations");

            migrationBuilder.AlterColumn<int>(
                name: "vacationsTypeId",
                table: "MSS_ATT_Vacations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_MSS_ATT_Vacations_MSS_ATT_VacationsTypes_vacationsTypeId",
                table: "MSS_ATT_Vacations",
                column: "vacationsTypeId",
                principalTable: "MSS_ATT_VacationsTypes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MSS_ATT_Vacations_MSS_ATT_VacationsTypes_vacationsTypeId",
                table: "MSS_ATT_Vacations");

            migrationBuilder.AlterColumn<int>(
                name: "vacationsTypeId",
                table: "MSS_ATT_Vacations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "vacationTypeId",
                table: "MSS_ATT_Vacations",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MSS_ATT_Vacations_MSS_ATT_VacationsTypes_vacationsTypeId",
                table: "MSS_ATT_Vacations",
                column: "vacationsTypeId",
                principalTable: "MSS_ATT_VacationsTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
