using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebWhatsAppClone.Migrations
{
    /// <inheritdoc />
    public partial class Migration26 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SubRegion",
                columns: new[] { "id", "area_km2", "code", "created_at", "created_by", "deleted_at", "deleted_by", "description", "geo_code", "is_active", "is_deleted", "is_updated", "key", "label", "largest_country", "most_populous_country", "name", "number_of_countries", "population", "population_density", "region_id", "smallest_country", "status_changed_at", "status_changed_by", "updated_at", "updated_by" },
                values: new object[,]
                {
                    { new Guid("11000000-0000-0000-0000-000000000001"), 4700000.0, "MAG", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Maghreb includes Morocco, Algeria, Tunisia, and Libya.", "015-1", true, false, false, "maghreb", "Maghreb", "Algeria", "Algeria", "Maghreb", 4, 104000000L, 22.100000000000001, new Guid("10000000-0000-0000-0000-000000000001"), "Tunisia", null, null, null, null },
                    { new Guid("11000000-0000-0000-0000-000000000002"), 2391800.0, "NIL", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Nile Valley includes Egypt and Sudan.", "015-2", true, false, false, "nile_valley", "Nile Valley", "Sudan", "Egypt", "Nile Valley", 2, 142000000L, 59.299999999999997, new Guid("10000000-0000-0000-0000-000000000001"), "Egypt", null, null, null, null },
                    { new Guid("11000000-0000-0000-0000-000000000003"), 1750000.0, "UPG", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Upper Guinea includes Mali, Guinea, Guinea-Bissau, Sierra Leone, Liberia, and Côte d'Ivoire.", "011-1", true, false, false, "upper_guinea", "Upper Guinea", "Mali", "Guinea", "Upper Guinea", 6, 86000000L, 49.100000000000001, new Guid("10000000-0000-0000-0000-000000000002"), "Guinea-Bissau", null, null, null, null },
                    { new Guid("11000000-0000-0000-0000-000000000004"), 900000.0, "LOG", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Lower Guinea includes Nigeria, Ghana, Togo, and Benin.", "011-2", true, false, false, "lower_guinea", "Lower Guinea", "Nigeria", "Nigeria", "Lower Guinea", 4, 97000000L, 107.8, new Guid("10000000-0000-0000-0000-000000000002"), "Benin", null, null, null, null },
                    { new Guid("11000000-0000-0000-0000-000000000005"), 2460000.0, "SAH", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Sahel includes Niger, Burkina Faso, Chad, Mauritania, Senegal, and Gambia.", "011-3", true, false, false, "sahel", "Sahel", "Niger", "Burkina Faso", "Sahel", 6, 65000000L, 26.399999999999999, new Guid("10000000-0000-0000-0000-000000000002"), "Gambia", null, null, null, null },
                    { new Guid("11000000-0000-0000-0000-000000000006"), 3700000.0, "CGB", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Congo Basin includes DR Congo, Republic of the Congo, Central African Republic, Gabon, and Cameroon.", "017-1", true, false, false, "congo_basin", "Congo Basin", "Democratic Republic of the Congo", "Democratic Republic of the Congo", "Congo Basin", 5, 120000000L, 32.399999999999999, new Guid("10000000-0000-0000-0000-000000000003"), "Central African Republic", null, null, null, null },
                    { new Guid("11000000-0000-0000-0000-000000000007"), 2700000.0, "GGI", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Gulf of Guinea Interior includes Chad, Equatorial Guinea, Angola (northern), and parts of Cameroon.", "017-2", true, false, false, "gulf_guinea_interior", "Gulf of Guinea Interior", "Chad", "Cameroon", "Gulf of Guinea Interior", 4, 48000000L, 17.800000000000001, new Guid("10000000-0000-0000-0000-000000000003"), "Equatorial Guinea", null, null, null, null },
                    { new Guid("11000000-0000-0000-0000-000000000008"), 2000000.0, "HOA", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Horn of Africa includes Ethiopia, Somalia, Eritrea, and Djibouti.", "014-1", true, false, false, "hoa", "Horn of Africa", "Ethiopia", "Ethiopia", "Horn of Africa", 4, 140000000L, 70.0, new Guid("10000000-0000-0000-0000-000000000004"), "Djibouti", null, null, null, null },
                    { new Guid("11000000-0000-0000-0000-000000000009"), 1500000.0, "GLR", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Great Lakes Region includes Kenya, Uganda, Tanzania, Rwanda, and Burundi.", "014-2", true, false, false, "glr", "Great Lakes Region", "Tanzania", "Tanzania", "Great Lakes Region", 5, 120000000L, 80.200000000000003, new Guid("10000000-0000-0000-0000-000000000004"), "Burundi", null, null, null, null },
                    { new Guid("11000000-0000-0000-0000-000000000010"), 670000.0, "IOI", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Indian Ocean Islands include Madagascar, Comoros, Mauritius, Seychelles, and others.", "014-3", true, false, false, "ioi", "Indian Ocean Islands", "Madagascar", "Madagascar", "Indian Ocean Islands", 7, 35000000L, 52.200000000000003, new Guid("10000000-0000-0000-0000-000000000004"), "Seychelles", null, null, null, null },
                    { new Guid("11000000-0000-0000-0000-000000000011"), 900000.0, "KAL", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Kalahari Region covers parts of Botswana, Namibia, and South Africa.", "018-1", true, false, false, "kal", "Kalahari Region", "Botswana", "Botswana", "Kalahari Region", 3, 2000000L, 2.2000000000000002, new Guid("10000000-0000-0000-0000-000000000005"), "Namibia", null, null, null, null },
                    { new Guid("11000000-0000-0000-0000-000000000012"), 300000.0, "HVL", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Highveld is a high plateau region mainly in South Africa.", "018-2", true, false, false, "hvl", "Highveld", "South Africa", "South Africa", "Highveld", 1, 15000000L, 50.0, new Guid("10000000-0000-0000-0000-000000000005"), "South Africa", null, null, null, null },
                    { new Guid("11000000-0000-0000-0000-000000000013"), 400000.0, "CAP", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Cape Region includes the Western and Eastern Cape provinces of South Africa.", "018-3", true, false, false, "cap", "Cape Region", "South Africa", "South Africa", "Cape Region", 1, 6000000L, 15.0, new Guid("10000000-0000-0000-0000-000000000005"), "South Africa", null, null, null, null },
                    { new Guid("21000000-0000-0000-0000-000000000001"), 1200000.0, "TRK", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Turkestan covers parts of Kazakhstan, Uzbekistan, and Turkmenistan.", "143-1", true, false, false, "trk", "Turkestan", "Kazakhstan", "Uzbekistan", "Turkestan", 2, 25000000L, 20.800000000000001, new Guid("20000000-0000-0000-0000-000000000001"), "Turkmenistan", null, null, null, null },
                    { new Guid("21000000-0000-0000-0000-000000000002"), 22000.0, "FRG", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Fergana Valley is a densely populated area spread across Uzbekistan, Kyrgyzstan, and Tajikistan.", "143-2", true, false, false, "frg", "Fergana Valley", "Uzbekistan", "Uzbekistan", "Fergana Valley", 3, 15000000L, 681.79999999999995, new Guid("20000000-0000-0000-0000-000000000001"), "Kyrgyzstan", null, null, null, null },
                    { new Guid("21000000-0000-0000-0000-000000000003"), 1800000.0, "KST", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Kazakh Steppe is a vast flatland that dominates northern Kazakhstan.", "143-3", true, false, false, "kst", "Kazakh Steppe", "Kazakhstan", "Kazakhstan", "Kazakh Steppe", 1, 9000000L, 5.0, new Guid("20000000-0000-0000-0000-000000000001"), "Kazakhstan", null, null, null, null },
                    { new Guid("22000000-0000-0000-0000-000000000001"), 500000.0, "LEV", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Levant covers Lebanon, Syria, Jordan, Palestine, and Israel.", "145-1", true, false, false, "lev", "Levant", "Syria", "Syria", "Levant", 5, 72000000L, 144.0, new Guid("20000000-0000-0000-0000-000000000002"), "Palestine", null, null, null, null },
                    { new Guid("22000000-0000-0000-0000-000000000002"), 3300000.0, "ARP", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Arabian Peninsula includes Saudi Arabia, Yemen, Oman, UAE, Qatar, Kuwait, Bahrain.", "145-2", true, false, false, "arp", "Arabian Peninsula", "Saudi Arabia", "Saudi Arabia", "Arabian Peninsula", 7, 87000000L, 26.399999999999999, new Guid("20000000-0000-0000-0000-000000000002"), "Bahrain", null, null, null, null },
                    { new Guid("22000000-0000-0000-0000-000000000003"), 440000.0, "CAC", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Caucasus includes Georgia, Armenia, and Azerbaijan.", "145-3", true, false, false, "cac", "Caucasus", "Azerbaijan", "Azerbaijan", "Caucasus", 3, 18000000L, 40.899999999999999, new Guid("20000000-0000-0000-0000-000000000002"), "Armenia", null, null, null, null },
                    { new Guid("22000000-0000-0000-0000-000000000004"), 900000.0, "MES", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Mesopotamia covers Iraq and parts of Syria.", "145-4", true, false, false, "mes", "Mesopotamia", "Iraq", "Iraq", "Mesopotamia", 2, 45000000L, 50.0, new Guid("20000000-0000-0000-0000-000000000002"), "Syria", null, null, null, null },
                    { new Guid("23000000-0000-0000-0000-000000000001"), 2000000.0, "ECH", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "East China includes densely populated and economically significant eastern provinces of China.", "030-1", true, false, false, "ech", "East China", "China", "China", "East China", 1, 600000000L, 300.0, new Guid("20000000-0000-0000-0000-000000000003"), "China", null, null, null, null },
                    { new Guid("23000000-0000-0000-0000-000000000002"), 500000.0, "NEA", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Northeast Asia refers to the Korean Peninsula, comprising North and South Korea.", "030-2", true, false, false, "nea", "Northeast Asia", "South Korea", "South Korea", "Northeast Asia", 2, 77000000L, 154.0, new Guid("20000000-0000-0000-0000-000000000003"), "North Korea", null, null, null, null },
                    { new Guid("23000000-0000-0000-0000-000000000003"), 800000.0, "MAN", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Manchuria is a historical region in Northeast China, includes Liaoning, Jilin, Heilongjiang.", "030-3", true, false, false, "man", "Manchuria", "China", "China", "Manchuria", 1, 105000000L, 131.30000000000001, new Guid("20000000-0000-0000-0000-000000000003"), "China", null, null, null, null },
                    { new Guid("23000000-0000-0000-0000-000000000004"), 378000.0, "JAP", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Japanese Archipelago includes all major islands of Japan: Honshu, Hokkaido, Kyushu, Shikoku.", "030-4", true, false, false, "jap", "Japanese Archipelago", "Japan", "Japan", "Japanese Archipelago", 1, 125000000L, 330.69999999999999, new Guid("20000000-0000-0000-0000-000000000003"), "Japan", null, null, null, null },
                    { new Guid("24000000-0000-0000-0000-000000000001"), 2300000.0, "MSEA", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Includes Vietnam, Laos, Cambodia, Thailand, and Myanmar. Also known as Indochina.", "035-1", true, false, false, "msea", "Mainland Southeast Asia", "Myanmar", "Vietnam", "Mainland Southeast Asia (Indochina)", 5, 250000000L, 108.7, new Guid("20000000-0000-0000-0000-000000000004"), "Laos", null, null, null, null },
                    { new Guid("24000000-0000-0000-0000-000000000002"), 2190000.0, "ISEA", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Includes Indonesia, Philippines, Malaysia, Singapore, and Brunei. Also known as Insular Southeast Asia.", "035-2", true, false, false, "isea", "Maritime Southeast Asia", "Indonesia", "Indonesia", "Maritime Southeast Asia (Insular)", 5, 440000000L, 200.90000000000001, new Guid("20000000-0000-0000-0000-000000000004"), "Brunei", null, null, null, null },
                    { new Guid("25000000-0000-0000-0000-000000000001"), 4500000.0, "ISC", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Includes India, Pakistan, Bangladesh, Nepal, Bhutan, and surrounding areas.", "034-1", true, false, false, "isc", "Indian Subcontinent", "India", "India", "Indian Subcontinent", 7, 1800000000L, 400.19999999999999, new Guid("20000000-0000-0000-0000-000000000005"), "Bhutan", null, null, null, null },
                    { new Guid("25000000-0000-0000-0000-000000000002"), 1000000.0, "IGP", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "A large and fertile plain encompassing northern India, parts of Pakistan, and Nepal.", "034-2", true, false, false, "igp", "Indo-Gangetic Plain", "India", "India", "Indo-Gangetic Plain", 3, 700000000L, 700.0, new Guid("20000000-0000-0000-0000-000000000005"), "Nepal", null, null, null, null },
                    { new Guid("25000000-0000-0000-0000-000000000003"), 595000.0, "HIM", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Mountainous region including parts of India, Nepal, Bhutan, and China.", "034-3", true, false, false, "himalaya", "Himalayan Region", "India", "India", "Himalayan Region", 4, 60000000L, 100.8, new Guid("20000000-0000-0000-0000-000000000005"), "Bhutan", null, null, null, null },
                    { new Guid("25000000-0000-0000-0000-000000000004"), 1500000.0, "DPL", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "A large plateau in southern India, known for its dry and elevated terrain.", "034-4", true, false, false, "dp", "Deccan Plateau", "India", "India", "Deccan Plateau", 1, 300000000L, 200.30000000000001, new Guid("20000000-0000-0000-0000-000000000005"), "India", null, null, null, null },
                    { new Guid("25000000-0000-0000-0000-000000000005"), 65610.0, "SLZ", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Island nation south of India. Distinct ecology and culture.", "034-5", true, false, false, "slz", "Sri Lankan Zone", "Sri Lanka", "Sri Lanka", "Sri Lankan Zone", 1, 22000000L, 335.5, new Guid("20000000-0000-0000-0000-000000000005"), "Sri Lanka", null, null, null, null },
                    { new Guid("30010000-0000-0000-0000-000000000001"), 1300000.0, "FNS", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Geological region comprising Norway, Sweden, Finland, and parts of Russia.", "154-1", true, false, false, "fns", "Fennoscandia", "Sweden", "Sweden", "Fennoscandia", 3, 27000000L, 20.800000000000001, new Guid("30000000-0000-0000-0000-000000000001"), "Norway", null, null, null, null },
                    { new Guid("30010000-0000-0000-0000-000000000002"), 315000.0, "BRI", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Group of islands including Great Britain, Ireland and surrounding isles.", "154-2", true, false, false, "bri", "British Isles", "United Kingdom", "United Kingdom", "British Isles", 2, 70000000L, 222.19999999999999, new Guid("30000000-0000-0000-0000-000000000001"), "Ireland", null, null, null, null },
                    { new Guid("30010000-0000-0000-0000-000000000003"), 175000.0, "BAL", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Includes Estonia, Latvia, and Lithuania along the eastern Baltic Sea.", "154-3", true, false, false, "bal", "Baltic States", "Lithuania", "Lithuania", "Baltic States", 3, 6000000L, 34.200000000000003, new Guid("30000000-0000-0000-0000-000000000001"), "Estonia", null, null, null, null },
                    { new Guid("30020000-0000-0000-0000-000000000001"), 550000.0, "BALK", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Southeastern Europe including countries on the Balkan Peninsula.", "039-1", true, false, false, "balk", "Balkans", "Romania", "Romania", "Balkans", 12, 55000000L, 100.0, new Guid("30000000-0000-0000-0000-000000000002"), "Montenegro", null, null, null, null },
                    { new Guid("30020000-0000-0000-0000-000000000002"), 582000.0, "IBER", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Includes Spain, Portugal, and Andorra.", "039-2", true, false, false, "iber", "Iberian Peninsula", "Spain", "Spain", "Iberian Peninsula", 3, 60000000L, 103.09999999999999, new Guid("30000000-0000-0000-0000-000000000002"), "Andorra", null, null, null, null },
                    { new Guid("30020000-0000-0000-0000-000000000003"), 301000.0, "ITAL", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Geographic region including Italy, San Marino and Vatican City.", "039-3", true, false, false, "ital", "Italian Peninsula", "Italy", "Italy", "Italian Peninsula", 3, 60000000L, 199.30000000000001, new Guid("30000000-0000-0000-0000-000000000002"), "San Marino", null, null, null, null },
                    { new Guid("30030000-0000-0000-0000-000000000001"), 75000.0, "BNX", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Economic union of Belgium, Netherlands, and Luxembourg.", "155-1", true, false, false, "bnx", "Benelux", "Belgium", "Netherlands", "Benelux", 3, 30000000L, 400.10000000000002, new Guid("30000000-0000-0000-0000-000000000003"), "Luxembourg", null, null, null, null },
                    { new Guid("30030000-0000-0000-0000-000000000002"), 190000.0, "ALP", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Region around the Alps including Switzerland, Austria, and others.", "155-2", true, false, false, "alp", "Alpine Region", "France", "Switzerland", "Alpine Region", 5, 15000000L, 78.900000000000006, new Guid("30000000-0000-0000-0000-000000000003"), "Liechtenstein", null, null, null, null },
                    { new Guid("30040000-0000-0000-0000-000000000001"), 12500000.0, "ESL", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Includes Russia, Ukraine, and Belarus - East Slavic speaking nations.", "151-1", true, false, false, "esl", "East Slavic", "Russia", "Russia", "East Slavic", 3, 240000000L, 19.199999999999999, new Guid("30000000-0000-0000-0000-000000000004"), "Belarus", null, null, null, null },
                    { new Guid("30040000-0000-0000-0000-000000000002"), 370000.0, "CARP", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Region around the Carpathian Mountains: Slovakia, Romania, Ukraine, etc.", "151-2", true, false, false, "carp", "Carpathian Region", "Poland", "Poland", "Carpathian Region", 5, 38000000L, 102.5, new Guid("30000000-0000-0000-0000-000000000004"), "Slovakia", null, null, null, null },
                    { new Guid("40010000-0000-0000-0000-000000000001"), 19000000.0, "ANG", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "English-speaking part of North America: Canada and the United States.", "021-1", true, false, false, "ang", "Anglo-America", "Canada", "USA", "Anglo-America", 2, 330000000L, 17.399999999999999, new Guid("40000000-0000-0000-0000-000000000001"), "USA", null, null, null, null },
                    { new Guid("40010000-0000-0000-0000-000000000002"), 1500000.0, "FRA", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "French-speaking regions in North America, especially Quebec.", "021-2", true, false, false, "fra", "French America", "Canada", "Canada", "French America", 1, 8000000L, 5.2999999999999998, new Guid("40000000-0000-0000-0000-000000000001"), "Canada", null, null, null, null },
                    { new Guid("40020000-0000-0000-0000-000000000001"), 523000.0, "IST", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Connects North and South America through countries like Panama and Costa Rica.", "013-1", true, false, false, "ist", "Isthmus Subregion", "Nicaragua", "Guatemala", "Isthmus Subregion", 7, 180000000L, 343.0, new Guid("40000000-0000-0000-0000-000000000002"), "Belize", null, null, null, null },
                    { new Guid("40030000-0000-0000-0000-000000000001"), 207000.0, "GAI", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Main islands of the Caribbean including Cuba, Jamaica, Hispaniola, and Puerto Rico.", "029-1", true, false, false, "gai", "Greater Antilles", "Cuba", "Cuba", "Greater Antilles", 5, 39000000L, 188.40000000000001, new Guid("40000000-0000-0000-0000-000000000003"), "Jamaica", null, null, null, null },
                    { new Guid("40030000-0000-0000-0000-000000000002"), 15000.0, "LAI", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Smaller islands including Grenada, Saint Lucia, Dominica, and others.", "029-2", true, false, false, "lai", "Lesser Antilles", "Trinidad and Tobago", "Trinidad and Tobago", "Lesser Antilles", 9, 4000000L, 266.69999999999999, new Guid("40000000-0000-0000-0000-000000000003"), "Saint Kitts and Nevis", null, null, null, null },
                    { new Guid("40030000-0000-0000-0000-000000000003"), 10500.0, "LEE", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Northern islands of the Lesser Antilles.", "029-3", true, false, false, "lee", "Leeward Islands", "Antigua and Barbuda", "Antigua and Barbuda", "Leeward Islands", 6, 1200000L, 114.3, new Guid("40000000-0000-0000-0000-000000000003"), "Montserrat", null, null, null, null },
                    { new Guid("40030000-0000-0000-0000-000000000004"), 12000.0, "WIN", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Southern islands of the Lesser Antilles.", "029-4", true, false, false, "win", "Windward Islands", "Saint Lucia", "Saint Lucia", "Windward Islands", 5, 1800000L, 150.0, new Guid("40000000-0000-0000-0000-000000000003"), "Grenada", null, null, null, null },
                    { new Guid("50010000-0000-0000-0000-000000000001"), 4900000.0, "AND", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Countries along the Andes Mountains: Colombia, Ecuador, Peru, Bolivia, and Chile.", "005-1", true, false, false, "and", "Andean States", "Peru", "Colombia", "Andean States", 5, 120000000L, 24.5, new Guid("50000000-0000-0000-0000-000000000001"), "Ecuador", null, null, null, null },
                    { new Guid("50010000-0000-0000-0000-000000000002"), 500000.0, "GUI", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Eastern coastal region of northern South America: Guyana, Suriname, French Guiana.", "005-2", true, false, false, "gui", "Guianas", "Guyana", "Guyana", "Guianas", 3, 2000000L, 4.0, new Guid("50000000-0000-0000-0000-000000000001"), "Suriname", null, null, null, null },
                    { new Guid("50010000-0000-0000-0000-000000000003"), 7100000.0, "SOC", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Southernmost part of South America including Argentina, Chile, Paraguay, Uruguay.", "005-3", true, false, false, "soc", "Southern Cone", "Argentina", "Argentina", "Southern Cone", 4, 190000000L, 26.699999999999999, new Guid("50000000-0000-0000-0000-000000000001"), "Uruguay", null, null, null, null },
                    { new Guid("50010000-0000-0000-0000-000000000004"), 5800000.0, "BHL", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "A vast region of eastern, central and southern Brazil.", "005-4", true, false, false, "bhl", "Brazilian Highlands", "Brazil", "Brazil", "Brazilian Highlands", 1, 120000000L, 20.699999999999999, new Guid("50000000-0000-0000-0000-000000000001"), "Brazil", null, null, null, null },
                    { new Guid("50010000-0000-0000-0000-000000000005"), 7000000.0, "AMB", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Tropical rainforest region covering much of northern South America.", "005-5", true, false, false, "amb", "Amazon Basin", "Brazil", "Brazil", "Amazon Basin", 9, 34000000L, 4.7999999999999998, new Guid("50000000-0000-0000-0000-000000000001"), "Ecuador", null, null, null, null },
                    { new Guid("60010000-0000-0000-0000-000000000001"), 4000000.0, "EAUS", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Eastern part of Australia including major cities like Sydney and Brisbane.", "053-1", true, false, false, "eaus", "Eastern Australia", "Australia", "Australia", "Eastern Australia", 1, 20000000L, 5.0, new Guid("60000000-0000-0000-0000-000000000001"), "Australia", null, null, null, null },
                    { new Guid("60010000-0000-0000-0000-000000000002"), 2800000.0, "WAUS", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Western half of Australia with sparse population and large mining areas.", "053-2", true, false, false, "waus", "Western Australia", "Australia", "Australia", "Western Australia", 1, 2700000L, 1.0, new Guid("60000000-0000-0000-0000-000000000001"), "Australia", null, null, null, null },
                    { new Guid("60010000-0000-0000-0000-000000000003"), 270000.0, "NZL", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "North Island and South Island of New Zealand.", "053-3", true, false, false, "nzl", "New Zealand", "New Zealand", "New Zealand", "New Zealand", 1, 5000000L, 18.5, new Guid("60000000-0000-0000-0000-000000000001"), "New Zealand", null, null, null, null },
                    { new Guid("60020000-0000-0000-0000-000000000001"), 50000.0, "BIS", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Group of islands northeast of Papua New Guinea.", "054-1", true, false, false, "bis", "Bismarck Archipelago", "Papua New Guinea", "Papua New Guinea", "Bismarck Archipelago", 1, 1200000L, 24.0, new Guid("60000000-0000-0000-0000-000000000002"), "Papua New Guinea", null, null, null, null },
                    { new Guid("60020000-0000-0000-0000-000000000002"), 28000.0, "SOL", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Arc-shaped chain of volcanic islands in Melanesia.", "054-2", true, false, false, "sol", "Solomon Islands Arc", "Solomon Islands", "Solomon Islands", "Solomon Islands Arc", 1, 700000L, 25.0, new Guid("60000000-0000-0000-0000-000000000002"), "Solomon Islands", null, null, null, null },
                    { new Guid("60030000-0000-0000-0000-000000000001"), 1100.0, "CAR", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Group of small islands scattered across western Pacific.", "057-1", true, false, false, "car", "Caroline Islands", "Federated States of Micronesia", "FSM", "Caroline Islands", 3, 500000L, 450.0, new Guid("60000000-0000-0000-0000-000000000003"), "Nauru", null, null, null, null },
                    { new Guid("60030000-0000-0000-0000-000000000002"), 180.0, "MAR", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Low-lying islands and atolls in central Pacific Ocean.", "057-2", true, false, false, "mar", "Marshall Islands", "Marshall Islands", "Marshall Islands", "Marshall Islands", 1, 60000L, 330.0, new Guid("60000000-0000-0000-0000-000000000003"), "Marshall Islands", null, null, null, null },
                    { new Guid("60030000-0000-0000-0000-000000000003"), 1000.0, "MAI", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Volcanic archipelago in western Pacific Ocean.", "057-3", true, false, false, "mai", "Mariana Islands", "Guam", "Guam", "Mariana Islands", 1, 200000L, 200.0, new Guid("60000000-0000-0000-0000-000000000003"), "Northern Mariana Islands", null, null, null, null },
                    { new Guid("60040000-0000-0000-0000-000000000001"), 3000.0, "SAM", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Island group in Polynesia split between independent Samoa and American Samoa.", "061-1", true, false, false, "sam", "Samoan Islands", "Samoa", "Samoa", "Samoan Islands", 2, 250000L, 83.299999999999997, new Guid("60000000-0000-0000-0000-000000000004"), "American Samoa", null, null, null, null },
                    { new Guid("60040000-0000-0000-0000-000000000002"), 1600.0, "SOC", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Major island group in French Polynesia including Tahiti.", "061-2", true, false, false, "soc", "Society Islands", "French Polynesia", "French Polynesia", "Society Islands", 1, 280000L, 175.0, new Guid("60000000-0000-0000-0000-000000000004"), "French Polynesia", null, null, null, null },
                    { new Guid("60040000-0000-0000-0000-000000000003"), 1050.0, "MARQ", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Isolated volcanic island group in northern French Polynesia.", "061-3", true, false, false, "marq", "Marquesas", "French Polynesia", "French Polynesia", "Marquesas", 1, 9000L, 8.5999999999999996, new Guid("60000000-0000-0000-0000-000000000004"), "French Polynesia", null, null, null, null },
                    { new Guid("70010000-0000-0000-0000-000000000001"), 10000000.0, "EANT", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "The eastern part of Antarctica, mostly covered by ice sheets.", "010-1", true, false, false, "east_ant", "East Antarctica", "", "", "East Antarctica", 0, 0L, 0.0, new Guid("70000000-0000-0000-0000-000000000001"), "", null, null, null, null },
                    { new Guid("70010000-0000-0000-0000-000000000002"), 4000000.0, "WANT", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "The western part of Antarctica, including the Transantarctic Mountains.", "010-2", true, false, false, "west_ant", "West Antarctica", "", "", "West Antarctica", 0, 0L, 0.0, new Guid("70000000-0000-0000-0000-000000000001"), "", null, null, null, null },
                    { new Guid("70010000-0000-0000-0000-000000000003"), 522000.0, "PANT", new DateTimeOffset(new DateTime(2025, 1, 30, 13, 45, 23, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "The northernmost part of mainland Antarctica, extending toward South America.", "010-3", true, false, false, "pen_ant", "Antarctic Peninsula", "", "", "Antarctic Peninsula", 0, 0L, 0.0, new Guid("70000000-0000-0000-0000-000000000001"), "", null, null, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("11000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("11000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("11000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("11000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("11000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("11000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("11000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("11000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("11000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("11000000-0000-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("11000000-0000-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("11000000-0000-0000-0000-000000000012"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("11000000-0000-0000-0000-000000000013"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("21000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("22000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("22000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("22000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("22000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("23000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("23000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("23000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("23000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("24000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("24000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("25000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("25000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("25000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("25000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("25000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("30010000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("30010000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("30010000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("30020000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("30020000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("30020000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("30030000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("30030000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("30040000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("30040000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("40010000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("40010000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("40020000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("40030000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("40030000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("40030000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("40030000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("50010000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("50010000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("50010000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("50010000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("50010000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("60010000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("60010000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("60010000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("60020000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("60020000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("60030000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("60030000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("60030000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("60040000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("60040000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("60040000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("70010000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("70010000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "SubRegion",
                keyColumn: "id",
                keyValue: new Guid("70010000-0000-0000-0000-000000000003"));
        }
    }
}
