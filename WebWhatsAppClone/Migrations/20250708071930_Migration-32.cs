using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebWhatsAppClone.Migrations
{
    /// <inheritdoc />
    public partial class Migration32 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CountryPhoneCode_Country_country_id",
                table: "CountryPhoneCode");

            migrationBuilder.DropForeignKey(
                name: "FK_CountryPhoneCode_PhoneCode_phone_code_id",
                table: "CountryPhoneCode");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhoneCode",
                table: "PhoneCode");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CountryPhoneCode",
                table: "CountryPhoneCode");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Country",
                table: "Country");

            migrationBuilder.RenameTable(
                name: "PhoneCode",
                newName: "PhoneCodes");

            migrationBuilder.RenameTable(
                name: "CountryPhoneCode",
                newName: "CountryPhoneCodes");

            migrationBuilder.RenameTable(
                name: "Country",
                newName: "Countries");

            migrationBuilder.RenameIndex(
                name: "IX_CountryPhoneCode_phone_code_id",
                table: "CountryPhoneCodes",
                newName: "IX_CountryPhoneCodes_phone_code_id");

            migrationBuilder.AddColumn<string>(
                name: "key",
                table: "Countries",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhoneCodes",
                table: "PhoneCodes",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CountryPhoneCodes",
                table: "CountryPhoneCodes",
                columns: new[] { "country_id", "phone_code_id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "id");

            migrationBuilder.CreateTable(
                name: "SubRegionCountries",
                columns: table => new
                {
                    sub_region_id = table.Column<Guid>(type: "uuid", nullable: false),
                    country_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubRegionCountries", x => new { x.sub_region_id, x.country_id });
                    table.ForeignKey(
                        name: "FK_SubRegionCountries_Countries_country_id",
                        column: x => x.country_id,
                        principalTable: "Countries",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubRegionCountries_SubRegions_sub_region_id",
                        column: x => x.sub_region_id,
                        principalTable: "SubRegions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubRegionCountries_country_id",
                table: "SubRegionCountries",
                column: "country_id");

            migrationBuilder.AddForeignKey(
                name: "FK_CountryPhoneCodes_Countries_country_id",
                table: "CountryPhoneCodes",
                column: "country_id",
                principalTable: "Countries",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CountryPhoneCodes_PhoneCodes_phone_code_id",
                table: "CountryPhoneCodes",
                column: "phone_code_id",
                principalTable: "PhoneCodes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CountryPhoneCodes_Countries_country_id",
                table: "CountryPhoneCodes");

            migrationBuilder.DropForeignKey(
                name: "FK_CountryPhoneCodes_PhoneCodes_phone_code_id",
                table: "CountryPhoneCodes");

            migrationBuilder.DropTable(
                name: "SubRegionCountries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhoneCodes",
                table: "PhoneCodes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CountryPhoneCodes",
                table: "CountryPhoneCodes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "key",
                table: "Countries");

            migrationBuilder.RenameTable(
                name: "PhoneCodes",
                newName: "PhoneCode");

            migrationBuilder.RenameTable(
                name: "CountryPhoneCodes",
                newName: "CountryPhoneCode");

            migrationBuilder.RenameTable(
                name: "Countries",
                newName: "Country");

            migrationBuilder.RenameIndex(
                name: "IX_CountryPhoneCodes_phone_code_id",
                table: "CountryPhoneCode",
                newName: "IX_CountryPhoneCode_phone_code_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhoneCode",
                table: "PhoneCode",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CountryPhoneCode",
                table: "CountryPhoneCode",
                columns: new[] { "country_id", "phone_code_id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Country",
                table: "Country",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_CountryPhoneCode_Country_country_id",
                table: "CountryPhoneCode",
                column: "country_id",
                principalTable: "Country",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CountryPhoneCode_PhoneCode_phone_code_id",
                table: "CountryPhoneCode",
                column: "phone_code_id",
                principalTable: "PhoneCode",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
