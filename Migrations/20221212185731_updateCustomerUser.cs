using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIN_Ventures.Migrations
{
    public partial class updateCustomerUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e7a8add-af80-466b-878d-cdcbee2415ae",
                column: "ConcurrencyStamp",
                value: "1d96a1ae-d030-4bbc-b91e-5056751ff92c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                column: "ConcurrencyStamp",
                value: "472988e1-3498-46e7-9512-91f126828d64");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466b18cd-b94a-45cb-be05-aea6878443d8",
                column: "ConcurrencyStamp",
                value: "d1ea8654-7694-4903-96e0-8ab2b0c03661");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                column: "ConcurrencyStamp",
                value: "06e4e063-d81e-4392-b808-746ce9632646");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d31e9f4e-4166-41bf-b226-67da21879725",
                column: "ConcurrencyStamp",
                value: "24b39de2-9a6d-40ce-9e82-4800c620bb7c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6df5df50-d145-459f-8677-10bd11d6cbd5", "AQAAAAEAACcQAAAAEFTNCIs9F5OCvDD3oO6t5Un7BKmBPEyxQj7INnmQwb4D+oIaokTbkZgAlWhv7gK4MA==", "aeb50cf5-7454-44e4-bd3a-17878f4eb492" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0fb432c4-0e84-4abb-889b-12a0f663069c", "AQAAAAEAACcQAAAAELLamormaLyIneri5035rjOdkGXm1f3oz5fZcXweGdRKyc6dDxJJb3BkLN+OD/9XHg==", "e481883f-b1c0-4d08-899d-93360e0b13e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72975ccf-a641-4abf-a1c1-ee582a3aaacc", "AQAAAAEAACcQAAAAEHWv4CE+yv5oj7pc/JXS/zStO/+d/XZ7j+YZzDCAsAYHvq60jvKD4WmzDICLt2S1eQ==", "2c7d074e-fbb5-4372-98b0-521c9e2b1fec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db001d8f-ee2f-4065-88ef-9732b8b5fc99",
                columns: new[] { "ConcurrencyStamp", "IsSubscriber", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31dfe3cc-25b2-4bee-899a-c6c9c272d601", false, "AQAAAAEAACcQAAAAELK7XsoVkLBt8BAF9qiy3F4FW1CVchYwRpMkahNX/Gi4RkfBPTouWZGcW929KNhemQ==", "048fcdf7-6a9a-46df-a6ff-c82b9831725c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "163d57d7-8a53-46f0-8c37-90bc9fadddf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b118e50-6c8f-4660-b9e8-6c3803e4ddb5", "AQAAAAEAACcQAAAAEGFu/nizsNYeuFQC8Ie/IlDEqeBFGC1jm9BRjADFWKhMMpq1/47eSjV4Lyq0H8M6aA==", "83b37585-2e12-4d95-a4a4-d32c636c9a5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86dc77f5-a7a5-4743-8a25-82b4c6d52525",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1d3b0b2-0294-431e-9e05-6fb336160dab", "AQAAAAEAACcQAAAAEHICRh6ke3EyZ6oqDqZHsUjdQ5OKB9gA3Q6WAnp8CDDNuHek2ThwxDv9PYGIRGpHsA==", "e61b2a37-67a8-4f31-9776-93deb4dba1ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a06696c0-0976-4e0c-8f06-550fba6b624e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a131b6b-66e0-4a0f-a7d3-1fe059963622", "AQAAAAEAACcQAAAAEJwovmKGgZJr7fCZxF/fk1iG4PFGKZAqsJLtnB5f1aetxdTgf8RHtBIiXvNlaqDtsQ==", "c4d8d3ac-d8be-44eb-a13f-17b5581bac57" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2d899fd-5b46-42f7-8a2d-3b042c159807",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c98f5cb-b909-4a9a-b491-8f2493203aa4", "AQAAAAEAACcQAAAAEPTr+ffOytFHE2XzNIflSxqMnKzfh/G2ywrZOLdyuXbp3TJs1P//oowWw1t2NP7HnA==", "a048fc3f-3bde-4ef8-a98e-67438873f2a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1441e48-9e22-47d6-a6de-981461285925",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "663fb5b7-456c-450a-bb48-04c72576865b", "AQAAAAEAACcQAAAAECH80muad+TRqj+TN2RJJdK814v/iAQLmUI+PC2TrBclf2OLQEsYc9rBQ+VonmQFgg==", "aad3c91d-47cf-4d3a-9810-42e0e5e5058d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e7a8add-af80-466b-878d-cdcbee2415ae",
                column: "ConcurrencyStamp",
                value: "56023b8b-3199-467d-8d74-6e5960a28fe2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                column: "ConcurrencyStamp",
                value: "79cc15e7-e8f8-46d6-985d-26f21397d3e9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466b18cd-b94a-45cb-be05-aea6878443d8",
                column: "ConcurrencyStamp",
                value: "04269dd9-98e2-4633-9ce0-bff83a5f7650");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                column: "ConcurrencyStamp",
                value: "2f05b4db-de04-4d82-80bb-21e946943cc3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d31e9f4e-4166-41bf-b226-67da21879725",
                column: "ConcurrencyStamp",
                value: "cad37cb4-7eb3-4c12-8c5b-ae6f69f5bdc1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9dd66f5d-9735-4e0d-b1d4-aed29d1582a7", "AQAAAAEAACcQAAAAEMcO1SWRkO3DF6PjkgvW8Sf9bDYnbfltaFylOk1kh9yYSG5o2fLIIEzurvSgKZPFjg==", "48107ef8-8637-4eb8-806a-f3984b9039f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c160e963-8662-472c-9e9a-80fa0d2d6f00", "AQAAAAEAACcQAAAAEJBR7nFPIG7VeXEB78UckKB6VKvNgMOJg4+S85P4xHJOBvY5dQwhOCIXFh+D/vY4Wg==", "3db1f6f3-a252-4a27-967e-6c17cf27062c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05d66547-04a5-4812-9aa4-14cdb46ac76f", "AQAAAAEAACcQAAAAELIb9a6QlrfEZuJGstfahzq+OG2X9G2Q21LHvQBOffj47yVPrdSx4InE4ddwYqQ3Hw==", "88ffd990-b345-4edf-b321-593dbd673adf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db001d8f-ee2f-4065-88ef-9732b8b5fc99",
                columns: new[] { "ConcurrencyStamp", "IsSubscriber", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68314e72-5892-4ac6-bf3a-70b603637781", true, "AQAAAAEAACcQAAAAEEUcV+Fhlx9HUH1I8rOjhIuyjj2dpuH2tU6yDPaUQFwPgNJwu9/zWgOvXVCO+d3Qdg==", "5aa66c3b-1808-4b69-8913-8670eaeecbe0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "163d57d7-8a53-46f0-8c37-90bc9fadddf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22eb9b05-0366-4a5f-9286-a64b682ae405", "AQAAAAEAACcQAAAAENJA16ZrXqi6oCgaUtUUsn4wqA6GLG2kNqdzbIJ/bGunt0pU1guj4H8SGcrUICQbZQ==", "fb223d9a-0613-4bdb-a5f7-86582e0441b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86dc77f5-a7a5-4743-8a25-82b4c6d52525",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "975f8f9f-f548-4a89-9677-ce27f8ee0639", "AQAAAAEAACcQAAAAEBJCS2TDtTZlH0J9uLx+woWARXYZ1PpsENo4v4ceuPFa2nnalfovadhuysU2DUhghQ==", "4e57fcaa-f45c-456d-9588-d63b032825c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a06696c0-0976-4e0c-8f06-550fba6b624e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d229bbab-dd95-48cb-b6f6-e73bbb3447aa", "AQAAAAEAACcQAAAAEHtR75gu3thUO0FaAcSBTadZ9zBhtDySugM5r+97md8z32wyodauAJMBwBk9qT7wKg==", "746975a6-a9d3-4473-bd5f-f7e18243d861" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2d899fd-5b46-42f7-8a2d-3b042c159807",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84bce49d-2804-4ed0-af0d-aac4002a9f66", "AQAAAAEAACcQAAAAEPSPkRVaDEEVAqG4PQl7EezNiAvD+atqLogkb4k93mYqa1wNUNpkmM9mR0rtwRzJtw==", "189f34be-4557-46dd-976a-57b21afa9cfc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1441e48-9e22-47d6-a6de-981461285925",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "092de0f5-278e-4192-a7d1-ab2a4180d360", "AQAAAAEAACcQAAAAEKQ6KV6fOn3NLwS4QWtdBwBSpc0JUw3wPPLEHFfHw/qjxoPV2xH6QQ7xFg0apVUWwg==", "ce80bed4-ac73-4ba4-99f9-14c9f71798af" });
        }
    }
}
