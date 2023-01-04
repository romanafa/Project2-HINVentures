using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIN_Ventures.Migrations
{
    public partial class fiksetforholdmellomsubscriptionogkunde : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_AspNetUsers_CustomerId",
                table: "Subscriptions");

            migrationBuilder.DropIndex(
                name: "IX_Subscriptions_CustomerId",
                table: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Subscriptions");

            migrationBuilder.AddColumn<int>(
                name: "SubscriptionId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e7a8add-af80-466b-878d-cdcbee2415ae",
                column: "ConcurrencyStamp",
                value: "926c1f6f-0b93-48c8-93b2-33dc045e89dc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                column: "ConcurrencyStamp",
                value: "a934f225-4102-4f57-87ff-c4aa31213c2d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466b18cd-b94a-45cb-be05-aea6878443d8",
                column: "ConcurrencyStamp",
                value: "1b2921b5-5b87-4811-a0d4-cccf5e8126ae");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                column: "ConcurrencyStamp",
                value: "f85d6b15-cd7d-484c-a75f-14cdbfb51d2e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d31e9f4e-4166-41bf-b226-67da21879725",
                column: "ConcurrencyStamp",
                value: "1c26be3a-c645-4f5b-84b0-121402a73573");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4df0ea9-4b7e-43d7-a7a6-ecaafcb497ab", "AQAAAAEAACcQAAAAEH7VwoB3ERqvfEp3ogOqJNuxmYtkmffQJLf5B0hEYCjiR0i/7DySdjEN+NP19NvnFQ==", "fa7f089c-748b-454e-be93-8f228cf0273d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa0f5fa6-dbb6-48e7-868c-6cd84f23a4d2", "AQAAAAEAACcQAAAAEJy0igwbhfBX/FpzU5gWa0u5WUdJ4fOptOST+LKG6+Tk+HKn0ItggasRfAL9x/rWJQ==", "c1be6b15-1b20-4982-9b52-0e9c09e0bfa8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23da7f6d-7b21-466a-8c44-d99dc0c356df", "AQAAAAEAACcQAAAAENz1q2TpC7Hc6uzobsg24YOlAPRQY62IbDukIqinWqW55aj+Y/LmmGKBsOej+2Lv3w==", "5ff54e50-4e37-46f6-9ce4-a7f4800aadef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db001d8f-ee2f-4065-88ef-9732b8b5fc99",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44238cf0-0d51-4386-acc3-82d1e12781be", "AQAAAAEAACcQAAAAEIbx/0ThAMr/cA3v9KjktKPbn0x///amnuOLsuW8E4lhL6vs/Bs4+wSd/n6Vd2aSDg==", "d249f2d4-d0ca-45cd-803c-ff5f0aa3bc75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "163d57d7-8a53-46f0-8c37-90bc9fadddf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "224dfe04-d00c-4e3e-a5c6-94697038bb51", "AQAAAAEAACcQAAAAEJEVICdQtg/8iVmEiGNyS8g2uXDyJoXyMEsuehP9R001+ZQu09aM0JAgqK/PULT+xA==", "7358cf17-07a7-4ce0-963f-1c4aa7914942" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86dc77f5-a7a5-4743-8a25-82b4c6d52525",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47dc1a8c-dc13-46cc-a342-711b83d5e48c", "AQAAAAEAACcQAAAAEIu4YNBQXHEwgLnZavkYfyx+B3Z+vg/ds8oPXnoXr6wwQaj2/6+VZP5nv05Tr1tGAA==", "234f4366-fb50-419b-b03c-02fe7f2a4535" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a06696c0-0976-4e0c-8f06-550fba6b624e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bec277ea-779b-44ba-9a15-340f003e116f", "AQAAAAEAACcQAAAAEPV4kiAGaUHYv101YsK3qSrDdXEKoT8SmZFhtxjql3Djty+qZFYQiPcTQxDKP3Ho8Q==", "43c96f84-e967-4332-968b-cfe5eb79b851" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2d899fd-5b46-42f7-8a2d-3b042c159807",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "407d4cb9-d084-4479-bac8-d65a4ae08c8f", "AQAAAAEAACcQAAAAEI3FKlPEJA6mqoliUi+2GTsZWwkHfbfnaSskMinIFpM5LZHbeIJYykrsvRzsni8sKw==", "f3de5936-cb66-4e1e-80ef-2b52076d8ff8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1441e48-9e22-47d6-a6de-981461285925",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9adc741a-af80-4ac6-99f7-4ae9440c18bc", "AQAAAAEAACcQAAAAECFM8jBpBl2orEl/u8g8MUUP/XF5Da3iQUB7hGQ65koeWc9PwLc122cqqT6SMXd1Dw==", "cad33818-ce58-45bd-8a99-a59d903a8dc5" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SubscriptionId",
                table: "AspNetUsers",
                column: "SubscriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Subscriptions_SubscriptionId",
                table: "AspNetUsers",
                column: "SubscriptionId",
                principalTable: "Subscriptions",
                principalColumn: "SubscriptionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Subscriptions_SubscriptionId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_SubscriptionId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SubscriptionId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "CustomerId",
                table: "Subscriptions",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e7a8add-af80-466b-878d-cdcbee2415ae",
                column: "ConcurrencyStamp",
                value: "efe552b5-f5e9-498d-a250-0b24d19a5798");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                column: "ConcurrencyStamp",
                value: "cf99db44-478c-400a-9b9e-ad682cbbd684");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466b18cd-b94a-45cb-be05-aea6878443d8",
                column: "ConcurrencyStamp",
                value: "8d282000-628e-4585-9da7-dde12f43a3bc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                column: "ConcurrencyStamp",
                value: "eb6962f0-08b1-4a6a-8a52-0576f2c23bf1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d31e9f4e-4166-41bf-b226-67da21879725",
                column: "ConcurrencyStamp",
                value: "98f67c00-e1e7-42d0-b4b9-b90302051635");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56622564-29ec-413b-8f18-51dab4cbc840", "AQAAAAEAACcQAAAAEIegRxS1JuFwXCpKIf8hQzopSbbimsi0DPeMDVXRxNpQ5XiJeVINh/RX72gAxsFdNw==", "89e2136e-1ea6-4732-987c-e18c8b9fd81d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76efc948-b7f2-46e1-8325-41388bdcb1b3", "AQAAAAEAACcQAAAAEJ4sf2dtVF2Ut38sa2FPCMKSpqk2vpi8N4AeCMIk/YuHXUPPt9gybCgM4uF1OJLPxQ==", "00b26765-1790-4287-9706-20e770755bc5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8934fbe9-5b71-4334-bd87-77275fce0243", "AQAAAAEAACcQAAAAEJLDrfHz+T4yqHZGrBRuK5SKPHYuz4no6tQq1C1MC77xXKB7Lj3jn0TOmcK2MpcyQg==", "8cb68578-4323-436b-a99f-4a91f1d28ae2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db001d8f-ee2f-4065-88ef-9732b8b5fc99",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba90f283-283c-40be-ae3b-1965ac847b73", "AQAAAAEAACcQAAAAEBbFZvTDkoxcuj3Xt4XiGHt4AeRTn1e/JurC8nbzQYy8eVQNfo5aF6rWkhstW//unQ==", "b17655b5-02b9-40cb-bb26-3b6621560f31" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "163d57d7-8a53-46f0-8c37-90bc9fadddf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92378dae-5f58-4924-bc67-c005b7736968", "AQAAAAEAACcQAAAAEA1FW5WUATxqnEkqWg5seVqQnDdQJUzYWNNLdnxM1svcOaUq1wcLRc7RUMbC+93hmQ==", "9131b848-3a40-4ad0-9d6c-2207b0f49e6a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86dc77f5-a7a5-4743-8a25-82b4c6d52525",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f26c31f7-076a-4fb1-953b-47af73dcfd28", "AQAAAAEAACcQAAAAEClTJ2TOYm6wwvPwHmJ/egwzzUSxBZIagXDVP0AQkbS1m7i535axmAUj3ARXVbCxMQ==", "a6abe28c-fb72-4197-b2c9-6efe2840310e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a06696c0-0976-4e0c-8f06-550fba6b624e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "388f959b-87d0-42bb-9fa9-7da9354fbc5b", "AQAAAAEAACcQAAAAELHXpyDPkf/rIGHzCxJeqgFoc6Yf1bKXhhCLOcJiWnDp/7acpLm2/AZavklJWAGLSQ==", "1cd4fb20-5296-4374-9dce-76434e58fc1d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2d899fd-5b46-42f7-8a2d-3b042c159807",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fd48294-1337-4557-b57a-93f15586e47e", "AQAAAAEAACcQAAAAEGUoT8baHYUL9W+zlQt/y2m1WgsTGH5Zz0DTZCOudTQh6pXl4ci+wrUJ1SbW/LtVfQ==", "8b2e2610-2337-4e05-b425-75cce26a5394" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1441e48-9e22-47d6-a6de-981461285925",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e4f8aee-b2c1-42d0-9adb-82ec47575a3c", "AQAAAAEAACcQAAAAECexJCHmmb/c6aV+K2fWifYQW7r/DZpaaWyTwFYrU0b7uGdPeH7/6Y3olRbkY3u4WA==", "a3c4d924-afdf-43e8-a31b-30d31b2e368d" });

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_CustomerId",
                table: "Subscriptions",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_AspNetUsers_CustomerId",
                table: "Subscriptions",
                column: "CustomerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
