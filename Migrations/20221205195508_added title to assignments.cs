using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIN_Ventures.Migrations
{
    public partial class addedtitletoassignments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Assignments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Assignments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e7a8add-af80-466b-878d-cdcbee2415ae",
                column: "ConcurrencyStamp",
                value: "49efc7e1-e828-4520-9f6e-10f6766c8f98");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                column: "ConcurrencyStamp",
                value: "b79ef463-2ea3-40b8-a5b7-4e6df5fc765d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466b18cd-b94a-45cb-be05-aea6878443d8",
                column: "ConcurrencyStamp",
                value: "4f36f86e-badb-4078-bcde-ce9c818795df");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                column: "ConcurrencyStamp",
                value: "c31eb599-0432-44a4-acdb-9c5c3f58fd49");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d31e9f4e-4166-41bf-b226-67da21879725",
                column: "ConcurrencyStamp",
                value: "1fdd8588-6d92-4f07-a18b-42d8c72cabc1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a32b1ee5-d08d-49d3-b3ea-ac9beb629b46", "AQAAAAEAACcQAAAAEAH4FQyXlRNGTb/vdTHzX5Vn0fVJSaTHpJsCHMB0xOaxCJs4gyA2ZvRn+BCQDdXTPQ==", "e34b31a2-ce65-419e-8305-65f7f948f6b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9811366-4d1a-49e1-a2f5-a24bfab49baa", "AQAAAAEAACcQAAAAEFjHKHB59boMa2SXDjNQhM27o621t+a2ia9Mi+Agj57I+p3tUb2F+2MaTAsM8oVxjg==", "37b81ed9-bfa1-46ca-9aa5-9425c874be1b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "108e1b97-2037-444b-b85d-bf8e15b310a5", "AQAAAAEAACcQAAAAEKsVPQMCeAj3qFRv3k+H+DkTi0fgGSNVKD5UAzZ9pqLrOT7tT1Yd4u3a+hamc7gRKg==", "0a8580cf-04d8-46ce-b461-9b0867fa65b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db001d8f-ee2f-4065-88ef-9732b8b5fc99",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f81f748b-cb8c-49cc-8b33-538a472369c2", "AQAAAAEAACcQAAAAEIVG8MQuq0T8x8FqozRWhp8PRnLMJM1gNonh3c4TNmh1645QnIeZs76CarrukoV61w==", "82f43de2-4060-4f4c-bd79-ddd8042663b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1441e48-9e22-47d6-a6de-981461285925",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8e934df-494e-459d-bf25-b873d275699b", "AQAAAAEAACcQAAAAEDTIgs4GfSS2JVHLTjUj2fbj5LK59DcPEgMPn5T7Ntrakdhq7pMrj+dvFxlUfy+9oA==", "42e81585-70c6-4cf4-8775-a56aec33bdad" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Assignments");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Assignments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e7a8add-af80-466b-878d-cdcbee2415ae",
                column: "ConcurrencyStamp",
                value: "44156a3b-ee8b-4ae8-8bd5-32f9363f1883");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                column: "ConcurrencyStamp",
                value: "ea45fd0b-5b9e-4f62-8605-b29659dced18");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466b18cd-b94a-45cb-be05-aea6878443d8",
                column: "ConcurrencyStamp",
                value: "b41204d7-caf5-4d81-ac17-d0495577e5f8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                column: "ConcurrencyStamp",
                value: "e726df7c-2c1e-4214-9818-40e0c90bf9f4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d31e9f4e-4166-41bf-b226-67da21879725",
                column: "ConcurrencyStamp",
                value: "8eec0417-2008-4be1-89e7-d40ad3d20ee0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1880eedf-7920-491f-b13f-b2521e609eea", "AQAAAAEAACcQAAAAEPI6jGPHg23d5mtfNUVvHvZuVEhOw1+pOWOZM9jWGqpU1cJ/e4uFWlJl3Mx/RhMPOg==", "766c84e5-3709-4989-a439-4bcd7dbf9ea7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c3e62da-0743-49fe-8aef-119e09eda4a5", "AQAAAAEAACcQAAAAEOUR4pLDRYySJNymesvCFsVIBiZz+mxaMPAoEYnTBv1Hr2bnYQUNYw8IY9lyNbhzyw==", "19f10dcf-72db-4308-aaca-842327603a09" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09235375-c213-49da-87f9-24c7ecdc5650", "AQAAAAEAACcQAAAAELrFzYyCLob+RUyWhVMrnqnJvr4G/wVmpJkwt2BUKwSH4+LYo+5YmFKtuySULD1jGQ==", "fbff110f-d415-4a94-a7b9-7e46cc73589b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db001d8f-ee2f-4065-88ef-9732b8b5fc99",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f931592-ff7c-4e18-96bf-96475c4879cc", "AQAAAAEAACcQAAAAEDM9nlcp3tqqqLbb8hKcDLnKYXlGUnb7860al/IsseBJm2lGVNY/34vnYjRWTe8n8Q==", "f5bd72ae-3945-46a1-903a-1d869ab53779" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1441e48-9e22-47d6-a6de-981461285925",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b9bba6b-a5b1-47c4-b8e3-7f8b5899d85c", "AQAAAAEAACcQAAAAEJDeZzWd0pSVBC9MXClT7n35wh/OQKcKJN2b3Gw1esfmLgrgD8Dxwu8XU69B7HGBaQ==", "ea37795f-56d2-4a7c-9762-d7aba49aa0ac" });
        }
    }
}
