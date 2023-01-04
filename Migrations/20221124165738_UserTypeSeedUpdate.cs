using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIN_Ventures.Migrations
{
    public partial class UserTypeSeedUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4", "2a6c7358-6dea-434c-8c16-f762a5db6289" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3e52d2ba-8811-452a-be8e-0b2cc408c510", "d75d7f29-1bf7-432a-9b10-fd2fb0d0fb7a" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d75d7f29-1bf7-432a-9b10-fd2fb0d0fb7a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a6c7358-6dea-434c-8c16-f762a5db6289");

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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsSubscriber", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "db001d8f-ee2f-4065-88ef-9732b8b5fc99", 0, "797e1d76-cefc-424d-81ee-8e600681a903", "Customer", "customer@customer.no", false, "Klient", true, "Bruker", false, null, "CUSTOMER@CUSTOMER.NO", "CUSTOMER@CUSTOMER.NO", "AQAAAAEAACcQAAAAEITlU1ZgqtlRJ+6pI7J7hklfrojxLHEn6eUZiGQk3wUtzbKxVodJQwHHd3QFSLx8wA==", null, false, "cc3788fb-29fc-4f02-9efb-9b6a85774e49", false, "customer@customer.no" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c1441e48-9e22-47d6-a6de-981461285925", 0, "f67b2982-161e-46d6-9f13-57dae00016f0", "Freelancer", "freelancer@freelancer.no", false, "Freelancer", "Bruker", false, null, "FREELANCER@FREELANCER.NO", "FREELANCER@FREELANCER.NO", "AQAAAAEAACcQAAAAEOLbaxyoQG4W5vrF0hYwquis7Hnrv30XM+ASotBXi71ePYxDfyz1yWLj7YTqldSWrQ==", null, false, "becaa50a-d814-4844-8391-590d1adfb157", false, "freelancer@freelancer.no" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4", "c1441e48-9e22-47d6-a6de-981461285925" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3e52d2ba-8811-452a-be8e-0b2cc408c510", "db001d8f-ee2f-4065-88ef-9732b8b5fc99" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4", "c1441e48-9e22-47d6-a6de-981461285925" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3e52d2ba-8811-452a-be8e-0b2cc408c510", "db001d8f-ee2f-4065-88ef-9732b8b5fc99" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db001d8f-ee2f-4065-88ef-9732b8b5fc99");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1441e48-9e22-47d6-a6de-981461285925");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e7a8add-af80-466b-878d-cdcbee2415ae",
                column: "ConcurrencyStamp",
                value: "309aa272-5ad0-4c22-9859-f62914e78926");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                column: "ConcurrencyStamp",
                value: "13601b0b-092b-47a9-8942-f46872ca1f48");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466b18cd-b94a-45cb-be05-aea6878443d8",
                column: "ConcurrencyStamp",
                value: "381a4de1-1792-4dcb-8c6a-df1ac56c3013");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                column: "ConcurrencyStamp",
                value: "281d8a42-7d0e-4128-a754-d163eb1d99d4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d31e9f4e-4166-41bf-b226-67da21879725",
                column: "ConcurrencyStamp",
                value: "37158b60-93b8-42cb-b787-6d59b12b837f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e55bb45-b948-43be-9ea0-cc0de7fc17f1", "AQAAAAEAACcQAAAAEMEPUs47+mybT8SO6G7jRZLHVOv7CjI4sioALOQ/0nCX2Eifu+VDb8AEuv/wO9WyUA==", "4f853622-b527-4ed8-a220-6173f136907e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e8dd20e-b1fc-4df9-9f8d-2ec82a76ae67", "AQAAAAEAACcQAAAAEINlctgzsJ/gm8K4CxVYEM8jttsB97Nx3xxgNQWwxa6dNwVt6XaRajscZJ5UHt9R1w==", "841e5386-c84b-4a03-a9b4-2d35885e9ee9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f051d19-2032-466d-bdf3-42c4b369b023", "AQAAAAEAACcQAAAAELZB6uPogsO/c4AwkxzR9ehyhz9p0ou2J5LBkFtZChzHP8MGdEM/NYZjANmppVAUKg==", "1df2082c-18d4-4cd6-a861-5f5f95cd6c42" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "IsSubscriber", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d75d7f29-1bf7-432a-9b10-fd2fb0d0fb7a", 0, "a4607f53-777c-4a10-a987-6f80d5de6814", "Customer", "customer@customer.no", false, "Klient", true, "Bruker", false, null, "CUSTOMER@CUSTOMER.NO", "CUSTOMER@CUSTOMER.NO", "AQAAAAEAACcQAAAAEFSkY15IKPf9VISxE7MPyWoyT04y2MvceYpXPAVxm2HXBHlI3bCmrcDYStlzcwq6FA==", null, false, "e4556cdd-886e-4d6a-b689-cf9b97acc53f", false, "customer@customer.no" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2a6c7358-6dea-434c-8c16-f762a5db6289", 0, "0711ad2c-6803-4626-823b-94dd3e6d702c", "Freelancer", "freelancer@freelancer.no", false, "Freelancer", "Bruker", false, null, "FREELANCER@FREELANCER.NO", "FREELANCER@FREELANCER.NO", "AQAAAAEAACcQAAAAEG17hA3oAA/+Ri/PgMVq+dF6LWCccH/+/27pXgMgUY9weyzSqw1R7a6NQLEW4snHKg==", null, false, "72c59bd3-3828-479d-9365-88c0e663e635", false, "freelancer@freelancer.no" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4", "2a6c7358-6dea-434c-8c16-f762a5db6289" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3e52d2ba-8811-452a-be8e-0b2cc408c510", "d75d7f29-1bf7-432a-9b10-fd2fb0d0fb7a" });
        }
    }
}
