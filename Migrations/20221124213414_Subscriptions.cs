using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIN_Ventures.Migrations
{
    public partial class Subscriptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    SubscriptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriptionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfLines = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    SubscriptionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.SubscriptionId);
                    table.ForeignKey(
                        name: "FK_Subscriptions_AspNetUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e7a8add-af80-466b-878d-cdcbee2415ae",
                column: "ConcurrencyStamp",
                value: "c63b69d3-b947-4f1b-8643-45702120ccc8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                column: "ConcurrencyStamp",
                value: "6244dfde-8460-493b-bf0d-72ffe9bebe2d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466b18cd-b94a-45cb-be05-aea6878443d8",
                column: "ConcurrencyStamp",
                value: "e713a4bb-c3ea-42bd-8123-a58a2f98a636");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                column: "ConcurrencyStamp",
                value: "dd2e7e6f-3b60-4416-b086-2fc3fbd5637d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d31e9f4e-4166-41bf-b226-67da21879725",
                column: "ConcurrencyStamp",
                value: "cdb19240-12d0-4a8d-bd52-038c63ef50b0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fee66cd0-c35d-46f4-8fc8-f7e103200874", "AQAAAAEAACcQAAAAEM+ZlO0sU49mKrz8g5lkqIMS0NBmioKDIT+lVOD+I4XFCejA1+7RxjsKRAP00z+zNA==", "eb7e0964-82ce-444c-94a3-31c008377090" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7d8d71b-f434-48c4-af27-2f74d781936a", "AQAAAAEAACcQAAAAEMnmUJMp5zGKYlM8xmoEa8ozMUU06aHKmu9+4uJh+GH1sGM1tcttFLGfQ6zjNEw2xg==", "0ca80451-d109-4414-bdc0-6336bed8e4af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c066e24-381a-45ff-a564-693d68217c9d", "AQAAAAEAACcQAAAAEHei4qMN1ry1QNk9SsNGDM/r6jTFyH06ccU/Oxz4P6XlJBZgWDn4Z/x0qpWDhcP6FA==", "e8334966-3634-41a6-ba91-24337026e5e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db001d8f-ee2f-4065-88ef-9732b8b5fc99",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d57ca9d3-d347-47f9-a485-cbdbad5e7382", "AQAAAAEAACcQAAAAEO/KUrFwc17tztDyTH6u0SmjeFD8lO/YHu+JuBwtKHX+705kqbTfRed4/K3dmXA0Ig==", "284e7b7f-e38e-4c35-8251-ae8aa8101aba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1441e48-9e22-47d6-a6de-981461285925",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "613c7002-1624-40b3-a7a0-78a68407f9ed", "AQAAAAEAACcQAAAAEIG92G3qjU6WEj+zQcf+96YGohhzA3oM2rNw8fAVArYrgee0UC/HSXzrPr+5Py9X6w==", "4e7bd1c6-63cf-4579-9c72-fe5a3ee67fe5" });

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_CustomerId",
                table: "Subscriptions",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subscriptions");

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
