using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIN_Ventures.Migrations
{
    public partial class seededaccountforblockIo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "AccountAddress", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2N7eG8ZNiyem2rLUF2RVkqrTBhgV6rWmXAc", "4b398ea1-962c-4bd3-9c85-11262b9c1c76", "AQAAAAEAACcQAAAAEExqkrqsa9gMc8LC/77iKWBoCvAEcZZuHgVV/0kmys+FmDXMLXtHLkKqsB1qBmZM2w==", "607d3bc0-8382-449a-b5f4-0b571c58c989" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1441e48-9e22-47d6-a6de-981461285925",
                columns: new[] { "Freelancer_AccountAddress", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2NFhZSZY2zpHCiAHGLbD9iVYfdZkg9yYkef", "e12ba062-7da0-4a37-b701-d3819213090c", "AQAAAAEAACcQAAAAENWbNrrLdWJNp7Thg25QHU/GNqS+NNSTyWXRUwkBcdp0J4C7O/mFDvHgHKBoDCm8ww==", "4d400a96-4508-4a2f-a010-d5253ec14c01" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "AccountAddress", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "9c2c1da0-c2de-46c5-af13-451f11b19683", "AQAAAAEAACcQAAAAEEVujxLRJvHq2fq2R0ijzTchjPPksQYtrzvK5AwZW5/HtrxGjJcRUkJ9orAviL3uwA==", "3fd60fec-6e4f-41c1-a5fd-e4b60fa81c3b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1441e48-9e22-47d6-a6de-981461285925",
                columns: new[] { "Freelancer_AccountAddress", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { null, "571b7ce2-daf8-4a46-a49b-e5aa3379333c", "AQAAAAEAACcQAAAAEPyvZwy6pC4Akt4qIXruSXKaGnHXl2ajwwxpjPDUfiIt1AXaJvh5S15xPBKck+xP4A==", "94c605ce-8295-4d44-a47e-c4bc01ce74f5" });
        }
    }
}
