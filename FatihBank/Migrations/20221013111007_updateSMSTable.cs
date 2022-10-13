using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FatihBank.Migrations
{
    public partial class updateSMSTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MSS_DEF_SMS_MSS_DEF_Customers_sent_to_CustomerId",
                table: "MSS_DEF_SMS");

            migrationBuilder.RenameColumn(
                name: "sent_to_CustomerId",
                table: "MSS_DEF_SMS",
                newName: "sentToCustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_MSS_DEF_SMS_sent_to_CustomerId",
                table: "MSS_DEF_SMS",
                newName: "IX_MSS_DEF_SMS_sentToCustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_MSS_DEF_SMS_MSS_DEF_Customers_sentToCustomerId",
                table: "MSS_DEF_SMS",
                column: "sentToCustomerId",
                principalTable: "MSS_DEF_Customers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MSS_DEF_SMS_MSS_DEF_Customers_sentToCustomerId",
                table: "MSS_DEF_SMS");

            migrationBuilder.RenameColumn(
                name: "sentToCustomerId",
                table: "MSS_DEF_SMS",
                newName: "sent_to_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_MSS_DEF_SMS_sentToCustomerId",
                table: "MSS_DEF_SMS",
                newName: "IX_MSS_DEF_SMS_sent_to_CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_MSS_DEF_SMS_MSS_DEF_Customers_sent_to_CustomerId",
                table: "MSS_DEF_SMS",
                column: "sent_to_CustomerId",
                principalTable: "MSS_DEF_Customers",
                principalColumn: "Id");
        }
    }
}
