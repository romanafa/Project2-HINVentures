using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIN_Ventures.Migrations
{
    public partial class addedaccountaddresstoapplicationuserandremovedfromcustomerandfreelancer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Freelancer_AccountAddress",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e7a8add-af80-466b-878d-cdcbee2415ae",
                column: "ConcurrencyStamp",
                value: "5efa30f5-8d51-4fa6-ae38-09c5d16d8d8c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                column: "ConcurrencyStamp",
                value: "cd0de189-44b3-4c85-ae70-e80da2ef0ed7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466b18cd-b94a-45cb-be05-aea6878443d8",
                column: "ConcurrencyStamp",
                value: "f6383a6a-4bc9-4f0f-ae65-4b6c8123b51d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                column: "ConcurrencyStamp",
                value: "659aa9be-fb36-4d30-a7b7-9621958a7267");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d31e9f4e-4166-41bf-b226-67da21879725",
                column: "ConcurrencyStamp",
                value: "0f81c9d7-4c2f-425c-84a6-6f463ef1719d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b437c8f-63cc-4263-9624-507db4bc0d47", "AQAAAAEAACcQAAAAEMn/yiTni6Wxu4rAWdzublHsGITOGEykal3fopJ7l3tETyNYzTFDYvUy6m0Y5uPF/w==", "b3e87729-0499-4801-aa01-969eea4804fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be27c53f-337c-4795-a4f7-2591fbed398c", "AQAAAAEAACcQAAAAEJxtdurFHioN73nFf+RCf2B8vaE64jS/seudFeA+FSAlGmS9c9JITl4mKAyPK+zUXA==", "4e2af387-0261-4407-b15b-85fc64222808" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c81f2fea-d85a-4246-a076-271b48ef4b1e", "AQAAAAEAACcQAAAAEEUiPQ9BE0sBUZbiaZmYazOcS87k+6mb/1Y91ZDwQbNhNaIq21WzeIHIGrLpGbby2w==", "5e1b408c-5664-4466-a39c-eda47e2eebc8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db001d8f-ee2f-4065-88ef-9732b8b5fc99",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25c0b4c2-668c-4189-b99f-660ded9d7341", "AQAAAAEAACcQAAAAEL9ihPorE7Jp7gaBhMx1bMWkLM3I3lFoXf0EFjuz7OsVNz301xlCM87VNhjiO9pZFg==", "8f4e9e92-edb1-42d2-8aa2-9fe65e93a7e8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "163d57d7-8a53-46f0-8c37-90bc9fadddf6",
                columns: new[] { "AccountAddress", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2MwEkhdf9hbh4RyqEqYARHZPZhJsT5w3Bpe", "16127348-4f42-4258-8d9c-6cb1d17066a8", "AQAAAAEAACcQAAAAEGxUiBsuFk8EBLpQ/f+LiqWxO5SKvHv2Ys2i3ifH2fx19psBAjfZl4kq8aHzTikaCA==", "87ba8c39-8326-406c-9918-7eefca948c11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86dc77f5-a7a5-4743-8a25-82b4c6d52525",
                columns: new[] { "AccountAddress", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2N8vgPdZu5KDbfcVvL38K2ZLJ5XFu8soMgG", "5cc4943b-6b11-4edf-a360-40ca07c66bb1", "AQAAAAEAACcQAAAAEMHEwdkMecG5AKvzKwACaY93WiSGIPb/B5YKFZjiBas2+k80/p9jk64GOJdyCv0uzw==", "1cf42f05-eab0-4acc-8026-96c978dfd2cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a06696c0-0976-4e0c-8f06-550fba6b624e",
                columns: new[] { "AccountAddress", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2MsFT3bnroCrEm2wVDxcwZs3NNZuxGoVjA5", "a3190dc5-ff0a-4508-baf7-6790f57560b1", "AQAAAAEAACcQAAAAEHIpgoXpwgfxm8HhNLuonH/76kVY2EahMSQ+eCK07Grxl3Ep/SNQYxtT4aQ1IbQoPA==", "14037489-77bc-48a2-9e85-f3cfb1f3d5a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2d899fd-5b46-42f7-8a2d-3b042c159807",
                columns: new[] { "AccountAddress", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2Mz5beBqoeFP2DSJt1fgxzPvnvDJAJtdAmB", "c381e953-1f32-46bb-aecc-5ae442bda9d9", "AQAAAAEAACcQAAAAEJDlPpQio6IVXEncj5hpal/blsE9y9Ne00csxYBVn4+B3hIynuscE40Tz+oEtbiQvg==", "2e3bd165-52b4-48bc-9727-e50f693b25d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1441e48-9e22-47d6-a6de-981461285925",
                columns: new[] { "AccountAddress", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2NFhZSZY2zpHCiAHGLbD9iVYfdZkg9yYkef", "92924690-a083-4774-8f69-12e989d71c0f", "AQAAAAEAACcQAAAAEHIz0MSgsF4bxBUSca2ANhheKmT2Qh43xKLvCJGii7f7JpJGUn7ptlWFdYyiGcFe4g==", "55ca62ed-ddb9-4c08-9392-e29fc3443564" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                value: "8bc50d3f-f21b-4494-aa24-ec5f04a2f89f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                column: "ConcurrencyStamp",
                value: "14f5f6f4-1b78-4fad-bec3-9ef1cad2724c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466b18cd-b94a-45cb-be05-aea6878443d8",
                column: "ConcurrencyStamp",
                value: "d1af217a-c6ac-4337-8160-c40408466d4d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                column: "ConcurrencyStamp",
                value: "8ed34d3a-f218-49ce-b534-a79d530de6b1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d31e9f4e-4166-41bf-b226-67da21879725",
                column: "ConcurrencyStamp",
                value: "4f9d68f1-b04b-4c2f-85db-d47b840d2bc8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34b13745-d50b-457a-af11-37ff7bcc711b", "AQAAAAEAACcQAAAAEOraKiMZBfkVmKLCJzSQ/Hoc7yhKDynY8HGq0F1zqYT8i71kHayJBXg6az1x5NPwUg==", "3f506fbb-d247-4877-a2b1-e44fb170b89e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2250527-26be-46df-a960-f9007f709550", "AQAAAAEAACcQAAAAEIPHfpmHHYP4UrGfELPyfrCReCerQYcOZmSyoUffWJEg7CRp/ptd599u+eGOiPgrcg==", "76965a24-46d0-4aca-9a24-dce0d93304ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fe63d50-7624-45e8-8a01-ef0abcf0a363", "AQAAAAEAACcQAAAAEEJ77ciYVoT4ZriXn5zV3SIsJYAnVTbCyksedJ2wrL6k3SZ32l77W0I83bO8D4LW5g==", "74b6a671-d1ff-4310-9fc6-af8d19727a6b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db001d8f-ee2f-4065-88ef-9732b8b5fc99",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7cfd7f1a-21fb-4edd-b7e6-287c4f7daa91", "AQAAAAEAACcQAAAAEN37bPblntC9vbyqykGyNOqB92Nbk1vYR+Amx3V2rvkTZMQyjFO880V3HoulSIKS5Q==", "4420ac7d-4e3a-4ec4-8471-8d4dbd0b4d05" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "163d57d7-8a53-46f0-8c37-90bc9fadddf6",
                columns: new[] { "Freelancer_AccountAddress", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2MwEkhdf9hbh4RyqEqYARHZPZhJsT5w3Bpe", "00e252b3-2191-4a1d-b576-4eea5dccb44a", "AQAAAAEAACcQAAAAEAPtD9QhFvgqD2mxEjf87EuQBFsPIHSZPydgHDKYKEq2xlDksAYSepQ8PfNQx6BJrQ==", "78c9c5e8-3737-4fed-a95d-284a3b272713" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86dc77f5-a7a5-4743-8a25-82b4c6d52525",
                columns: new[] { "Freelancer_AccountAddress", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2N8vgPdZu5KDbfcVvL38K2ZLJ5XFu8soMgG", "9d322b29-b30d-4133-9f5c-422aa9613fd5", "AQAAAAEAACcQAAAAEH7YezNr+XnBwScm0cyu0cP/CoMikbN1HP+KwOX1w1+b6h+7Res7WXVaHXKycK5wLg==", "21c92e75-f002-4ea0-8d2e-959158e76f76" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a06696c0-0976-4e0c-8f06-550fba6b624e",
                columns: new[] { "Freelancer_AccountAddress", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2MsFT3bnroCrEm2wVDxcwZs3NNZuxGoVjA5", "035570b3-d340-4c11-9e3c-9e8ef309ce0e", "AQAAAAEAACcQAAAAEJfORoVjL00MADYrrkJWMf0RnnCUeC/60zq8YuEQ991HUdfylI+2zEDoObICkXB0og==", "fe3b1262-b859-4a14-bcaf-e7b664e50d4a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2d899fd-5b46-42f7-8a2d-3b042c159807",
                columns: new[] { "Freelancer_AccountAddress", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2Mz5beBqoeFP2DSJt1fgxzPvnvDJAJtdAmB", "a0a937ef-62a0-48a1-bef4-113154e7ef3d", "AQAAAAEAACcQAAAAEOh/YYv1fEbLxvuuJ3qRY9Q3p9GeFSZZT5+ybESisbFHqhaA51Kf18HO1za66bnX/Q==", "3b059a1e-3f43-4a06-a8db-e2096191e819" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1441e48-9e22-47d6-a6de-981461285925",
                columns: new[] { "Freelancer_AccountAddress", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2NFhZSZY2zpHCiAHGLbD9iVYfdZkg9yYkef", "9e8f1143-d395-4b04-97d8-4030d13b69c0", "AQAAAAEAACcQAAAAEM2i/OuwVZnIoxWZyJM2UsboR0ODmg2Jd/HfnKlrXEW9bhC95roMRgQBiWrxCEKxuA==", "108660fc-f35a-46cf-a13d-fb5d3adbe5ba" });
        }
    }
}
