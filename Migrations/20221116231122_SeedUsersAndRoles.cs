using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIN_Ventures.Migrations
{
    public partial class SeedUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2e7a8add-af80-466b-878d-cdcbee2415ae", "5836cd4b-293d-4af3-8ce1-82ce78f043d9", "Admin", "ADMIN" },
                    { "3e52d2ba-8811-452a-be8e-0b2cc408c510", "b77a03db-cef9-41d7-b118-de13d65c206b", "Customer", "CUSTOMER" },
                    { "466b18cd-b94a-45cb-be05-aea6878443d8", "0b07c5f0-28b3-479e-b076-c02e4e1960da", "SeniorDeveloper", "SENIORDEVELOPER" },
                    { "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4", "35a09239-93de-43e3-b39a-704f28777aa8", "Freelancer", "FREELANCER" },
                    { "d31e9f4e-4166-41bf-b226-67da21879725", "2d2efc5d-7f62-4e89-9474-cc65578c2cdc", "HINEmployee", "HINEMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2a6c7358-6dea-434c-8c16-f762a5db6289", 0, "7e6e3a48-5d38-493e-8883-2381279ccce8", "ApplicationUser", "freelancer@freelancer.no", false, "Freelancer", "Bruker", false, null, "FREELANCER@FREELANCER.NO", "FREELANCER@FREELANCER.NO", "AQAAAAEAACcQAAAAEOEErdLLYJ27UIQbbCn0hbATGw8nMVK+yYlNH9hbbTEKGm82DTTcO7NUqgx1mthCKA==", null, false, "39425864-2df6-476a-9636-cf97c9c7cbcf", false, "freelancer@freelancer.no" },
                    { "608f98cc-681c-42d0-8ee0-5d889584cb8a", 0, "495476a1-f8e2-494b-8495-dd7c92895135", "ApplicationUser", "employee@hinventures.no", false, "Ansatt", "HINVentures", false, null, "EMPLOYEE@HINVENTURES.NO", "EMPLOYEE@HINVENTURES.NO", "AQAAAAEAACcQAAAAEOvzcIMRierIoMjhGh2WAC5C5v91XIXkbnf5YFWOVy+/lWZYoDGZQCxlsByKuSGPEA==", null, false, "deed907f-4fdf-484e-b6ec-230cf47b1149", false, "employee@hinventures.no" },
                    { "d75d7f29-1bf7-432a-9b10-fd2fb0d0fb7a", 0, "e137eb03-55fd-4064-9aa4-668f20ea2b8a", "ApplicationUser", "customer@customer.no", false, "Klient", "Bruker", false, null, "CUSTOMER@CUSTOMER.NO", "CUSTOMER@CUSTOMER.NO", "AQAAAAEAACcQAAAAECXdpfBbeIcbcok1hIv9U5dCzcAdIi38mlRwKSMGJqshFVXvQxmhH+QPwjgcKWE/4Q==", null, false, "a9453e0d-e655-4b80-af36-02e471a1730c", false, "customer@customer.no" },
                    { "e3d0c038-508b-4c80-8fd7-7e56b0f74188", 0, "531835b5-c791-49dd-a269-7e157bd208aa", "ApplicationUser", "senior@hinventures.no", false, "Senior", "Utvikler", false, null, "SENIOR@HINVENTURES.NO", "SENIOR@HINVENTURES.NO", "AQAAAAEAACcQAAAAENdjofmCdFeJM2uxdPzWfYLy8A1KnwfSdciN7wuwZiSoc0Z6wvrNl5I8vF4aqd0gtw==", null, false, "2d303893-99ed-4a79-846a-2a3f2ffa1464", false, "senior@hinventures.no" },
                    { "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c", 0, "c3a006bc-408f-40c1-aff7-4c2706f3a99f", "ApplicationUser", "admin@hinventures.no", false, "Admin", "Bruker", false, null, "ADMIN@HINVENTURES.NO", "ADMIN@HINVENTURES.NO", "AQAAAAEAACcQAAAAEMfwLC+MKz9uHf3A++MCrpmy2HvafEYHOb+jMs/OKyM047cWftK2iz+Dfa7UbkhqbA==", null, false, "73d6fcdf-0dfa-4090-80d7-280f94d8565c", false, "admin@hinventures.no" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4", "2a6c7358-6dea-434c-8c16-f762a5db6289" },
                    { "d31e9f4e-4166-41bf-b226-67da21879725", "608f98cc-681c-42d0-8ee0-5d889584cb8a" },
                    { "3e52d2ba-8811-452a-be8e-0b2cc408c510", "d75d7f29-1bf7-432a-9b10-fd2fb0d0fb7a" },
                    { "466b18cd-b94a-45cb-be05-aea6878443d8", "e3d0c038-508b-4c80-8fd7-7e56b0f74188" },
                    { "2e7a8add-af80-466b-878d-cdcbee2415ae", "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4", "2a6c7358-6dea-434c-8c16-f762a5db6289" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d31e9f4e-4166-41bf-b226-67da21879725", "608f98cc-681c-42d0-8ee0-5d889584cb8a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3e52d2ba-8811-452a-be8e-0b2cc408c510", "d75d7f29-1bf7-432a-9b10-fd2fb0d0fb7a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "466b18cd-b94a-45cb-be05-aea6878443d8", "e3d0c038-508b-4c80-8fd7-7e56b0f74188" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2e7a8add-af80-466b-878d-cdcbee2415ae", "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e7a8add-af80-466b-878d-cdcbee2415ae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e52d2ba-8811-452a-be8e-0b2cc408c510");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466b18cd-b94a-45cb-be05-aea6878443d8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d31e9f4e-4166-41bf-b226-67da21879725");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a6c7358-6dea-434c-8c16-f762a5db6289");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "608f98cc-681c-42d0-8ee0-5d889584cb8a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d75d7f29-1bf7-432a-9b10-fd2fb0d0fb7a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3d0c038-508b-4c80-8fd7-7e56b0f74188");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
