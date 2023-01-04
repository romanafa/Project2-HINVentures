using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIN_Ventures.Migrations
{
    public partial class seededassignments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "AssignmentId", "Created", "CustomerId", "Deadline", "Description", "FreelancerId", "IsActive", "IsCompleted", "Progress" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "En spennende oppdrag", null, true, false, 0 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "En krevende oppdrag", null, true, false, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e7a8add-af80-466b-878d-cdcbee2415ae",
                column: "ConcurrencyStamp",
                value: "7193f472-44a3-4510-80de-51d25be5fe43");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                column: "ConcurrencyStamp",
                value: "abe5c59a-273f-4bae-b8ca-8fe7c28f04bb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466b18cd-b94a-45cb-be05-aea6878443d8",
                column: "ConcurrencyStamp",
                value: "0a011fd4-600c-462b-bd63-458ec0489ac9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                column: "ConcurrencyStamp",
                value: "aaba36f1-f463-4921-85ce-73443e972f78");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d31e9f4e-4166-41bf-b226-67da21879725",
                column: "ConcurrencyStamp",
                value: "0ee6065a-a134-4065-bce1-9e77544f69a9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "324ec967-37df-46f7-9dec-8806e6ec4b36", "AQAAAAEAACcQAAAAEH9rqUobMQSJG7MTL2URIxysUK0q3wiHCPVTjDe/dGv/P7EsOqn2RhC6P+hgEE3G8g==", "0782bb05-4d33-47e2-be41-e19d17366a46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4afefa78-fc46-42eb-b47e-4e2737c27124", "AQAAAAEAACcQAAAAEIcelcHtpbU0wCnJc4RkRhsQ0PrBI441PFE5C3iB0z8vQSN8aEfKEQCEGDZCI+FMxg==", "437b7f93-141e-4f55-ace1-f0120ab01bcd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f6fdcb8-42cb-46c4-86f8-158dfec822c3", "AQAAAAEAACcQAAAAEJ/YdTOjDP8CWkTzeE4fGf/PpzTwZVrnTMvfatr5rVQidqpz2KQdDk4kzkbSJC0pfQ==", "38121ab7-32c1-4cd9-b432-ef327165eda7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db001d8f-ee2f-4065-88ef-9732b8b5fc99",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b398ea1-962c-4bd3-9c85-11262b9c1c76", "AQAAAAEAACcQAAAAEExqkrqsa9gMc8LC/77iKWBoCvAEcZZuHgVV/0kmys+FmDXMLXtHLkKqsB1qBmZM2w==", "607d3bc0-8382-449a-b5f4-0b571c58c989" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1441e48-9e22-47d6-a6de-981461285925",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e12ba062-7da0-4a37-b701-d3819213090c", "AQAAAAEAACcQAAAAENWbNrrLdWJNp7Thg25QHU/GNqS+NNSTyWXRUwkBcdp0J4C7O/mFDvHgHKBoDCm8ww==", "4d400a96-4508-4a2f-a010-d5253ec14c01" });
        }
    }
}
