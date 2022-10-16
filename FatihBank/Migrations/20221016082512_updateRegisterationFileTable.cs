using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FatihBank.Migrations
{
    public partial class updateRegisterationFileTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MSS_INF_RegisterationFile_MSS_INF_Action_Types_Action_typeId",
                table: "MSS_INF_RegisterationFile");

            migrationBuilder.RenameColumn(
                name: "Action_typeId",
                table: "MSS_INF_RegisterationFile",
                newName: "ActionTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_MSS_INF_RegisterationFile_Action_typeId",
                table: "MSS_INF_RegisterationFile",
                newName: "IX_MSS_INF_RegisterationFile_ActionTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_MSS_INF_RegisterationFile_MSS_INF_Action_Types_ActionTypeId",
                table: "MSS_INF_RegisterationFile",
                column: "ActionTypeId",
                principalTable: "MSS_INF_Action_Types",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MSS_INF_RegisterationFile_MSS_INF_Action_Types_ActionTypeId",
                table: "MSS_INF_RegisterationFile");

            migrationBuilder.RenameColumn(
                name: "ActionTypeId",
                table: "MSS_INF_RegisterationFile",
                newName: "Action_typeId");

            migrationBuilder.RenameIndex(
                name: "IX_MSS_INF_RegisterationFile_ActionTypeId",
                table: "MSS_INF_RegisterationFile",
                newName: "IX_MSS_INF_RegisterationFile_Action_typeId");

            migrationBuilder.AddForeignKey(
                name: "FK_MSS_INF_RegisterationFile_MSS_INF_Action_Types_Action_typeId",
                table: "MSS_INF_RegisterationFile",
                column: "Action_typeId",
                principalTable: "MSS_INF_Action_Types",
                principalColumn: "Id");
        }
    }
}
