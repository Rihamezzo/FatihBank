using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FatihBank.Migrations
{
    public partial class updateMainAvgTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MSS_AVG_MainAvg_MSS_DEF_Exchange_Accounts_exchange_accountId",
                table: "MSS_AVG_MainAvg");

            migrationBuilder.RenameColumn(
                name: "exchange_accountId",
                table: "MSS_AVG_MainAvg",
                newName: "exchangeAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_MSS_AVG_MainAvg_exchange_accountId",
                table: "MSS_AVG_MainAvg",
                newName: "IX_MSS_AVG_MainAvg_exchangeAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_MSS_AVG_MainAvg_MSS_DEF_Exchange_Accounts_exchangeAccountId",
                table: "MSS_AVG_MainAvg",
                column: "exchangeAccountId",
                principalTable: "MSS_DEF_Exchange_Accounts",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MSS_AVG_MainAvg_MSS_DEF_Exchange_Accounts_exchangeAccountId",
                table: "MSS_AVG_MainAvg");

            migrationBuilder.RenameColumn(
                name: "exchangeAccountId",
                table: "MSS_AVG_MainAvg",
                newName: "exchange_accountId");

            migrationBuilder.RenameIndex(
                name: "IX_MSS_AVG_MainAvg_exchangeAccountId",
                table: "MSS_AVG_MainAvg",
                newName: "IX_MSS_AVG_MainAvg_exchange_accountId");

            migrationBuilder.AddForeignKey(
                name: "FK_MSS_AVG_MainAvg_MSS_DEF_Exchange_Accounts_exchange_accountId",
                table: "MSS_AVG_MainAvg",
                column: "exchange_accountId",
                principalTable: "MSS_DEF_Exchange_Accounts",
                principalColumn: "Id");
        }
    }
}
