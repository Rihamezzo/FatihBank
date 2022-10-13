using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FatihBank.Migrations
{
    public partial class updateVouchersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MSS_DEF_Vouchers_MSS_DEF_Currencies_Currency1Id",
                table: "MSS_DEF_Vouchers");

            migrationBuilder.DropForeignKey(
                name: "FK_MSS_DEF_Vouchers_MSS_DEF_Currencies_Currency2Id",
                table: "MSS_DEF_Vouchers");

            migrationBuilder.RenameColumn(
                name: "Currency2Id",
                table: "MSS_DEF_Vouchers",
                newName: "CurrencyModel2Id");

            migrationBuilder.RenameColumn(
                name: "Currency1Id",
                table: "MSS_DEF_Vouchers",
                newName: "CurrencyModel1Id");

            migrationBuilder.RenameIndex(
                name: "IX_MSS_DEF_Vouchers_Currency2Id",
                table: "MSS_DEF_Vouchers",
                newName: "IX_MSS_DEF_Vouchers_CurrencyModel2Id");

            migrationBuilder.RenameIndex(
                name: "IX_MSS_DEF_Vouchers_Currency1Id",
                table: "MSS_DEF_Vouchers",
                newName: "IX_MSS_DEF_Vouchers_CurrencyModel1Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MSS_DEF_Vouchers_MSS_DEF_Currencies_CurrencyModel1Id",
                table: "MSS_DEF_Vouchers",
                column: "CurrencyModel1Id",
                principalTable: "MSS_DEF_Currencies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MSS_DEF_Vouchers_MSS_DEF_Currencies_CurrencyModel2Id",
                table: "MSS_DEF_Vouchers",
                column: "CurrencyModel2Id",
                principalTable: "MSS_DEF_Currencies",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MSS_DEF_Vouchers_MSS_DEF_Currencies_CurrencyModel1Id",
                table: "MSS_DEF_Vouchers");

            migrationBuilder.DropForeignKey(
                name: "FK_MSS_DEF_Vouchers_MSS_DEF_Currencies_CurrencyModel2Id",
                table: "MSS_DEF_Vouchers");

            migrationBuilder.RenameColumn(
                name: "CurrencyModel2Id",
                table: "MSS_DEF_Vouchers",
                newName: "Currency2Id");

            migrationBuilder.RenameColumn(
                name: "CurrencyModel1Id",
                table: "MSS_DEF_Vouchers",
                newName: "Currency1Id");

            migrationBuilder.RenameIndex(
                name: "IX_MSS_DEF_Vouchers_CurrencyModel2Id",
                table: "MSS_DEF_Vouchers",
                newName: "IX_MSS_DEF_Vouchers_Currency2Id");

            migrationBuilder.RenameIndex(
                name: "IX_MSS_DEF_Vouchers_CurrencyModel1Id",
                table: "MSS_DEF_Vouchers",
                newName: "IX_MSS_DEF_Vouchers_Currency1Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MSS_DEF_Vouchers_MSS_DEF_Currencies_Currency1Id",
                table: "MSS_DEF_Vouchers",
                column: "Currency1Id",
                principalTable: "MSS_DEF_Currencies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MSS_DEF_Vouchers_MSS_DEF_Currencies_Currency2Id",
                table: "MSS_DEF_Vouchers",
                column: "Currency2Id",
                principalTable: "MSS_DEF_Currencies",
                principalColumn: "Id");
        }
    }
}
