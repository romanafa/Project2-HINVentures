using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIN_Ventures.Migrations
{
    public partial class addedpropertiesfreelancernameandcustomername2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FreelancerName",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e7a8add-af80-466b-878d-cdcbee2415ae",
                column: "ConcurrencyStamp",
                value: "d2ef8ff3-2543-402c-b3ad-f477c82f0505");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                column: "ConcurrencyStamp",
                value: "7d62cd33-5fd4-4aff-a417-356c67e47e54");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466b18cd-b94a-45cb-be05-aea6878443d8",
                column: "ConcurrencyStamp",
                value: "2f47d0f3-2d94-458b-b0a0-d61f1c780c36");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                column: "ConcurrencyStamp",
                value: "cd02e9e0-ba96-4dd4-b294-2d6ffb7b9c71");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d31e9f4e-4166-41bf-b226-67da21879725",
                column: "ConcurrencyStamp",
                value: "e2ba4756-819f-4a16-bc63-5c4032143318");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca561bf3-7a5e-4088-8ac4-23fc92fa0cd3", "AQAAAAEAACcQAAAAEGJcOO3B31KHyEsoBOfrJnEdnfJfoBoOhPl02IQHKAa7oy7N02xCFMgxovwJQHBmMA==", "16375b0d-27e5-4995-8f52-2215b17288d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89fd9879-8f65-484b-b2a4-34012ff588d4", "AQAAAAEAACcQAAAAEDUlyAlU4IK3ez9RMfNK7Daq/tywaS3zAVoDXUqixgRPQqit1wwRENcnco2v16A61w==", "21a70554-26fe-43f1-8dd3-b860d0ccd3cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfadce8e-2ff9-40e2-a2bc-a355ca3af908", "AQAAAAEAACcQAAAAEBMoH+moJnuOVM2EZSYHbHym4NwCqsV6TiQL8G4VM5Tt+4cmkxYB0w2gWRQdUepIEw==", "4d867a97-edb0-4924-b999-beba34bc152a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db001d8f-ee2f-4065-88ef-9732b8b5fc99",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffceb5f5-e441-4648-8100-361ac5f27cc8", "AQAAAAEAACcQAAAAEIaAqavbtdTWSsIgiv7eHGNcIWV2bxrpx1EAv64++wbyJrdz2zgh/vgkGlZ0icHTwA==", "e23ab344-8e47-4462-8e80-d1da6949f328" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "163d57d7-8a53-46f0-8c37-90bc9fadddf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1669ea12-876b-4198-94bb-594a2109ca95", "AQAAAAEAACcQAAAAEJx8p3Uq8p62yJCEFUbUTOsyWyY62Cj1JnZye+OVszdB78RyyZojmVSHoXKBer+qNw==", "5c5cddd0-c5e4-47fa-b173-3bc013356999" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86dc77f5-a7a5-4743-8a25-82b4c6d52525",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34241b7d-c5e7-4faa-8d18-bf183b431dd4", "AQAAAAEAACcQAAAAEOeB1E2B5V5vDS6UaVS8r1IpaVN0p5oYuXZ/xd/eWH1PjozRy2rfNUM9y1xppzenyg==", "94a25a0f-5466-4021-919c-d268e8bae25a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a06696c0-0976-4e0c-8f06-550fba6b624e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65f8871f-e1fa-4a82-9019-aaef01b6f1a7", "AQAAAAEAACcQAAAAEPuJq9Dyjl9bQsn4BOo9cgDWdmkHwvcvZNR7EMdYtDTHdl8uPFV+T4pJol9azhJV7A==", "f8558eec-fbba-4bda-b5f5-e69e148dcc72" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2d899fd-5b46-42f7-8a2d-3b042c159807",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59d8dd11-f2d1-4882-aba3-958b49088fec", "AQAAAAEAACcQAAAAEAMSRvb66D4s/MSg+7CfkbEi4AmY/9qV5bKICEO/+zl4RlozWbp9p61UEsxdh6QmDQ==", "7519a1fb-af8e-4920-9264-6b6ac92fef6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1441e48-9e22-47d6-a6de-981461285925",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "362e6713-be1f-4984-a0bb-6d1fe4553d2b", "AQAAAAEAACcQAAAAEAY7zOaEJvt9HLcsRxSXabijFbMAYd3uJHJg0zTFfYRvrVaNE+ZJL025isdW4ZlHVg==", "4f4025c8-729c-4ee7-b50d-0341ea3a3f78" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "FreelancerName",
                table: "Payments");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e7a8add-af80-466b-878d-cdcbee2415ae",
                column: "ConcurrencyStamp",
                value: "0a855e54-8f61-4235-bcfb-6d5ba05d8ca0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                column: "ConcurrencyStamp",
                value: "b15c6751-4144-4379-9587-4c62569bd72d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466b18cd-b94a-45cb-be05-aea6878443d8",
                column: "ConcurrencyStamp",
                value: "5e89e855-42c1-4276-808b-fa0d70a6b2ae");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                column: "ConcurrencyStamp",
                value: "9820685a-9dae-46f5-a86e-c75c977c4d73");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d31e9f4e-4166-41bf-b226-67da21879725",
                column: "ConcurrencyStamp",
                value: "12641ef2-c547-4f39-8755-0a0a7dd2c4d7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0cb50c64-37d5-49ac-85f8-3c4263664cd7", "AQAAAAEAACcQAAAAEMVtltarA5I4xioE7knql+VzvhZfCvWDj68u9nlQlnoPKP8ydHf3Ue4wQSPs5hf5lg==", "4667e5eb-3b19-4e1e-9a8f-83509b7f0dd9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "785312d7-e55f-4520-a6cb-e4fcce8d3e10", "AQAAAAEAACcQAAAAEHd1+RrNizn0Mr9xnSX7Mp8dgeVi5edpdS+4pryoUuagWoJlS+JoBdek8Jus56G8QA==", "ef3e8964-bf02-4377-b735-0c08a4a04d76" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2832e17a-200f-47dd-9d65-c0edfdce456b", "AQAAAAEAACcQAAAAEHndCtKhxepNY7ZUaRtiCpZSWEtVD/Ihp5MgZZtBx6Zo/EdZwkMuMBYdcQ30oyMVdw==", "f5970d5b-121a-47fd-b8b4-1df7ddf54ff0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db001d8f-ee2f-4065-88ef-9732b8b5fc99",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e6a656f-0d37-42ca-ad77-9eca9e4ed812", "AQAAAAEAACcQAAAAEDBjHMKvt3I4I3oXl38auiR6fi3JrlTaG+sGm+nMI2i4wFglKpQGuppiRO5MTIjUuQ==", "82fb983f-1b6b-478a-b0e5-7229ef365648" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "163d57d7-8a53-46f0-8c37-90bc9fadddf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18d67b94-5f48-4770-a705-dd8cea6b448a", "AQAAAAEAACcQAAAAEMS16GLkDOuFtoiefZvYXFUJ6ajO65w3j61AiZUajkZj/obTB1XiDjU4btezjA7dyA==", "4da3c00f-9274-4c2e-8b6b-08ccf68850f2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86dc77f5-a7a5-4743-8a25-82b4c6d52525",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3dce0a89-42fe-49d8-9ac2-0b365c8ce8ed", "AQAAAAEAACcQAAAAEGUG7rNCEA1cgmDNxuplBLF25Aw3dM0YeP1sFJALsP3WZ5xDsq5JxZ4ctxfjA0aUQg==", "da0a7ccb-a8f4-43f4-aa04-6a0c0bbefad7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a06696c0-0976-4e0c-8f06-550fba6b624e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "324a3925-af3c-4104-a349-ae4bf32944eb", "AQAAAAEAACcQAAAAEAhpqwNAd/KX7heU77elS5zaUhT5VqRvn7hMZFKv72xxCysMICYiutW95kwRJkA7JA==", "ca9b4247-8276-4056-b609-a2e93246e99b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2d899fd-5b46-42f7-8a2d-3b042c159807",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9e7f039-01b5-43ee-bc5e-53c85818aa82", "AQAAAAEAACcQAAAAEKcGhdTdW6C8RNYrv3r2N7lv+HZQS4PcE6GbDAFqE5KtpTUOd+pMrtU1etYeg9l+wA==", "c680f441-ffa0-48c7-bb0d-1ae463434972" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1441e48-9e22-47d6-a6de-981461285925",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77a21dd6-69bb-4f9f-bdeb-044a6e1c574c", "AQAAAAEAACcQAAAAEBGoyKrGCwRIBgJcoqxOtPKDbYsmZH63N18NKve8CBIvZI3Rfqe1wnOBM0lKPPhiww==", "8e36f119-9bf0-4d09-b6e8-40fdd94be3e9" });
        }
    }
}
