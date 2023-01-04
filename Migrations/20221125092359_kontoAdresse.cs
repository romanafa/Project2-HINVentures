using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIN_Ventures.Migrations
{
    public partial class kontoAdresse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccountAddress",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Freelancer_AccountAddress",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e7a8add-af80-466b-878d-cdcbee2415ae",
                column: "ConcurrencyStamp",
                value: "8a8227eb-c501-4bfd-a79c-4848259a2e3b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                column: "ConcurrencyStamp",
                value: "744f4965-6464-419e-80e8-e3c9afd2f513");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466b18cd-b94a-45cb-be05-aea6878443d8",
                column: "ConcurrencyStamp",
                value: "2579da7f-5b40-489b-b1cf-16e7fb247840");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                column: "ConcurrencyStamp",
                value: "2b04e3e1-f058-400f-ab21-63afc53f5123");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d31e9f4e-4166-41bf-b226-67da21879725",
                column: "ConcurrencyStamp",
                value: "b8451e2d-f0d3-4ab8-9931-2491523e62ff");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e95513e-f53c-402a-b438-81fdf53a6e81", "AQAAAAEAACcQAAAAEB2sYPSBTqwlus6qVw91FP51ggAueXT/QFfQPdM1KYr6CXSWFBZR6zA6kiAgy31+3A==", "846160ca-d47c-414a-a96a-f70d37ec41f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82a61ffc-3630-4091-9e56-4b672d61296a", "AQAAAAEAACcQAAAAEMfIuRO3FMLe6Ff3KJxkeGtRQAz/7J3XeRkbAS4TxHweFb5v0PijIUPCwgG46OR3vg==", "df080a7e-8187-4657-8be6-9fea9f71d1e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66f13c3c-c54c-42be-a599-54717955da8f", "AQAAAAEAACcQAAAAED0lkjlufsR9Zajyh22NGWb1/tqtlok7cPcBaOCIhZn+LCQRb5WQa8+oB6qjsKFRTg==", "64aab889-e388-4eb6-b1dc-fbd4e9abf751" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db001d8f-ee2f-4065-88ef-9732b8b5fc99",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c2c1da0-c2de-46c5-af13-451f11b19683", "AQAAAAEAACcQAAAAEEVujxLRJvHq2fq2R0ijzTchjPPksQYtrzvK5AwZW5/HtrxGjJcRUkJ9orAviL3uwA==", "3fd60fec-6e4f-41c1-a5fd-e4b60fa81c3b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1441e48-9e22-47d6-a6de-981461285925",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "571b7ce2-daf8-4a46-a49b-e5aa3379333c", "AQAAAAEAACcQAAAAEPyvZwy6pC4Akt4qIXruSXKaGnHXl2ajwwxpjPDUfiIt1AXaJvh5S15xPBKck+xP4A==", "94c605ce-8295-4d44-a47e-c4bc01ce74f5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountAddress",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Freelancer_AccountAddress",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e7a8add-af80-466b-878d-cdcbee2415ae",
                column: "ConcurrencyStamp",
                value: "0f81462e-a845-4c29-ac70-bf0bb61375b3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                column: "ConcurrencyStamp",
                value: "0a9cdd21-8efc-432b-9c9c-fac8718ea869");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466b18cd-b94a-45cb-be05-aea6878443d8",
                column: "ConcurrencyStamp",
                value: "622ae5e8-6ade-487b-ab9c-a42032c02e61");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                column: "ConcurrencyStamp",
                value: "9b00d1c0-0c0a-4791-b0d2-795767cb7414");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d31e9f4e-4166-41bf-b226-67da21879725",
                column: "ConcurrencyStamp",
                value: "cc9b30fb-16a9-424f-8d92-3675110fb074");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07c849c7-acdd-4d24-b49d-feba01796b2d", "AQAAAAEAACcQAAAAEFBrYtQ0sFmfMxkEVQLDY09x7JRIN4CSBY8W5W7lstdiSzk4w8UFOuQPg3YngL2Tew==", "c6966585-a8a5-4661-8394-0c21141eef15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9dcc9cf7-7728-4828-b80e-6e0ca9d82475", "AQAAAAEAACcQAAAAEHG9BMYs85LdUzdDYwtm1ME5w+NEHinHVzuJNr6xhZBKFVxmpoUfUfJjNtaxxHfcfg==", "bc7a5e2e-772d-4a76-badc-1cd27692dd30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "197c770b-d7e6-4c9b-8a85-55235410a5be", "AQAAAAEAACcQAAAAEK4OvAl4kAkOqNyEAGeS/GGHAVoLKEET935a3i8rLMt2CJOFTRFrLYTYs4AIfEg41Q==", "418d3699-091c-412e-9a0a-770c709ace71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db001d8f-ee2f-4065-88ef-9732b8b5fc99",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "797e1d76-cefc-424d-81ee-8e600681a903", "AQAAAAEAACcQAAAAEITlU1ZgqtlRJ+6pI7J7hklfrojxLHEn6eUZiGQk3wUtzbKxVodJQwHHd3QFSLx8wA==", "cc3788fb-29fc-4f02-9efb-9b6a85774e49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1441e48-9e22-47d6-a6de-981461285925",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f67b2982-161e-46d6-9f13-57dae00016f0", "AQAAAAEAACcQAAAAEOLbaxyoQG4W5vrF0hYwquis7Hnrv30XM+ASotBXi71ePYxDfyz1yWLj7YTqldSWrQ==", "becaa50a-d814-4844-8391-590d1adfb157" });
        }
    }
}
