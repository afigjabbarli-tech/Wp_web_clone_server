using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebWhatsAppClone.Migrations
{
    /// <inheritdoc />
    public partial class Migration25 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubRegion",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    key = table.Column<string>(type: "text", nullable: false),
                    label = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    code = table.Column<string>(type: "text", nullable: false),
                    geo_code = table.Column<string>(type: "text", nullable: false),
                    area_km2 = table.Column<double>(type: "double precision", nullable: false),
                    population = table.Column<long>(type: "bigint", nullable: false),
                    number_of_countries = table.Column<int>(type: "integer", nullable: false),
                    largest_country = table.Column<string>(type: "text", nullable: false),
                    smallest_country = table.Column<string>(type: "text", nullable: false),
                    most_populous_country = table.Column<string>(type: "text", nullable: false),
                    population_density = table.Column<double>(type: "double precision", nullable: true),
                    description = table.Column<string>(type: "text", nullable: false),
                    region_id = table.Column<Guid>(type: "uuid", nullable: false),
                    created_by = table.Column<Guid>(type: "uuid", nullable: true),
                    created_at = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    is_updated = table.Column<bool>(type: "boolean", nullable: false),
                    updated_by = table.Column<Guid>(type: "uuid", nullable: true),
                    updated_at = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    status_changed_at = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    status_changed_by = table.Column<Guid>(type: "uuid", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    deleted_at = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    deleted_by = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubRegion", x => x.id);
                    table.ForeignKey(
                        name: "FK_SubRegion_Regions_region_id",
                        column: x => x.region_id,
                        principalTable: "Regions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubRegion_region_id",
                table: "SubRegion",
                column: "region_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubRegion");
        }
    }
}
