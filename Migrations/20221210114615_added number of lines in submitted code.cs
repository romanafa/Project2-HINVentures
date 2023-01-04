using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIN_Ventures.Migrations
{
    public partial class addednumberoflinesinsubmittedcode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfLines",
                table: "SubmittedCodes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e7a8add-af80-466b-878d-cdcbee2415ae",
                column: "ConcurrencyStamp",
                value: "ef9fb582-4452-4f4a-8458-63f5c06c3af1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                column: "ConcurrencyStamp",
                value: "352a6694-fcb9-4d86-a3d5-823f8e30ffbe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466b18cd-b94a-45cb-be05-aea6878443d8",
                column: "ConcurrencyStamp",
                value: "661898ce-a8d4-42af-8dc2-1521dff30fdf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                column: "ConcurrencyStamp",
                value: "c365a250-6b11-4fe5-b644-7459d1742828");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d31e9f4e-4166-41bf-b226-67da21879725",
                column: "ConcurrencyStamp",
                value: "e298f471-402b-4a77-9571-22b6eba99f78");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eedb6470-3226-4142-a47c-f2d42dce922a", "AQAAAAEAACcQAAAAEOkKNxUxZ0Wdf8MomEV2Eq3+m9DntVZwE/KMbLTZrJdUYJ1g3nC3WVfBkmfi34G1MQ==", "303e6ed7-9349-4e9e-b576-d61e4fa2fdc5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0e9bc86-4e48-4d9a-a862-5f72dcd78d72", "AQAAAAEAACcQAAAAEGBfx98bVdbxNw2tkHDBhl/x/kye2RiZ1ycJxyR2vr6Fftbj/1l4Er5MttWz87emrQ==", "f3b34fc7-56ad-45f8-ae59-3b788241f3cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b979ef47-ab72-4f25-beb4-654b5b550311", "AQAAAAEAACcQAAAAEP1zS0NLGMyjxPCP8eBGdMq64y0nz8nqFno3tTLB8rUqjhXceaJmfvyBefPMlEDUkA==", "94a4cd4b-aa7c-49f2-b3de-a66bf2e91b27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db001d8f-ee2f-4065-88ef-9732b8b5fc99",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6922ac83-a307-4f32-ae4f-a6a61e6f8bf6", "AQAAAAEAACcQAAAAENcQn/iDxHsAN+wl2kz9kIG6WuKhx3JqD+Ys/PbqAyiXkA2cAsdSD0ZsaRwNFwCiwA==", "38030129-ddfc-4f48-ad30-aa28e5829c76" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1441e48-9e22-47d6-a6de-981461285925",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e991e5a-e56d-4038-9b79-281177ee1e0f", "AQAAAAEAACcQAAAAEKFxN371Bxl0P8B3CzIpbIZdHhWMyGRQh79qs7izAuoWO8SsfdwrNJ2VbeEH5R054A==", "d6aa5116-ca38-4161-bc8d-7294d6be7a42" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfLines",
                table: "SubmittedCodes");

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
    }
}
