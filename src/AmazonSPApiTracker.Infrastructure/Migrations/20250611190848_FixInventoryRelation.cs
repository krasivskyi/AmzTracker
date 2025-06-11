using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AmazonSPApiTracker.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixInventoryRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Skus_SkuId1",
                table: "Inventories");

            migrationBuilder.DropIndex(
                name: "IX_Inventories_SkuId1",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "SkuId1",
                table: "Inventories");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Skus_SkuId",
                table: "Inventories",
                column: "SkuId",
                principalTable: "Skus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Skus_SkuId",
                table: "Inventories");

            migrationBuilder.AddColumn<string>(
                name: "SkuId1",
                table: "Inventories",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_SkuId1",
                table: "Inventories",
                column: "SkuId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Skus_SkuId1",
                table: "Inventories",
                column: "SkuId1",
                principalTable: "Skus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
