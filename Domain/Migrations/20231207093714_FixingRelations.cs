using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    /// <inheritdoc />
    public partial class FixingRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Amenities_Properties_PropertyId",
                table: "Amenities");

            migrationBuilder.DropIndex(
                name: "IX_Amenities_PropertyId",
                table: "Amenities");

            migrationBuilder.DropColumn(
                name: "PropertyId",
                table: "Amenities");

            migrationBuilder.CreateTable(
                name: "AmenityProperty",
                columns: table => new
                {
                    AmenitiesId = table.Column<int>(type: "int", nullable: false),
                    PropertiesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmenityProperty", x => new { x.AmenitiesId, x.PropertiesId });
                    table.ForeignKey(
                        name: "FK_AmenityProperty_Amenities_AmenitiesId",
                        column: x => x.AmenitiesId,
                        principalTable: "Amenities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AmenityProperty_Properties_PropertiesId",
                        column: x => x.PropertiesId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AmenityProperty_PropertiesId",
                table: "AmenityProperty",
                column: "PropertiesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AmenityProperty");

            migrationBuilder.AddColumn<int>(
                name: "PropertyId",
                table: "Amenities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Amenities_PropertyId",
                table: "Amenities",
                column: "PropertyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Amenities_Properties_PropertyId",
                table: "Amenities",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id");
        }
    }
}
