using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIN_Ventures.Migrations
{
    public partial class addedscoreclass2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Scores",
                columns: table => new
                {
                    ScoreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScoreName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scores", x => x.ScoreId);
                });

            migrationBuilder.CreateTable(
                name: "FreelancerScore",
                columns: table => new
                {
                    FreelancersId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ScoreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreelancerScore", x => new { x.FreelancersId, x.ScoreId });
                    table.ForeignKey(
                        name: "FK_FreelancerScore_AspNetUsers_FreelancersId",
                        column: x => x.FreelancersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FreelancerScore_Scores_ScoreId",
                        column: x => x.ScoreId,
                        principalTable: "Scores",
                        principalColumn: "ScoreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e7a8add-af80-466b-878d-cdcbee2415ae",
                column: "ConcurrencyStamp",
                value: "6b70bb38-8590-40d9-93fa-dfa4e8bc07a0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                column: "ConcurrencyStamp",
                value: "a81ac4e3-9ff0-4515-9058-a5bc9481f737");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466b18cd-b94a-45cb-be05-aea6878443d8",
                column: "ConcurrencyStamp",
                value: "df073eb8-dd58-48d0-b62f-d5ac1ddc5d42");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                column: "ConcurrencyStamp",
                value: "fd822e50-7d40-4715-8765-1c82d7837c06");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d31e9f4e-4166-41bf-b226-67da21879725",
                column: "ConcurrencyStamp",
                value: "4cf7c590-39df-4e4d-ae3b-9fb86fc01b08");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e00c0ebc-dbc3-4bde-b738-6e925641cced", "AQAAAAEAACcQAAAAEAaoCYBAn4s/VQxcJUGAaHgQ/Tu64nf8mTxmaRX5yBx60CG+NGgIBu7ewFfrIH+gkQ==", "ea54636b-8648-48bb-81f1-b22f25707b35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84661890-95a0-42a4-a6a0-f9d7712a8f8f", "AQAAAAEAACcQAAAAEK+6Hu9bjYzOcuqF5Sr7mMMfRNzv9H12iKQ88gz8wCGKEB8pJGYEWUvCXEPT/qbGug==", "82d5b877-f056-4ac6-84bb-4a6b5ac7fe92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f52d3db-62aa-43d9-87ad-0fcd0ea03a45", "AQAAAAEAACcQAAAAEGbUE21d/QQqu+BCYHQSBuGTdu3M88Dn4v/aNr8WQ/xJW8b1zeVogene8ccIBLhBdA==", "a623b1a7-82ec-444e-ba75-78e786bc0818" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db001d8f-ee2f-4065-88ef-9732b8b5fc99",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0805da02-b05c-4136-9f1c-7be4a7f31f3e", "AQAAAAEAACcQAAAAEC7uBkleYGuICJYFZx1HInBaCKrm++55SbJnIewFhiP/mr9P2e80cBjYaeTMumzNow==", "4fc8c541-53bb-4265-8629-0c40d31502cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "163d57d7-8a53-46f0-8c37-90bc9fadddf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81408c9e-6a8e-4410-b309-a49c5bd0b8a7", "AQAAAAEAACcQAAAAEPYt7h5fFtwknoodxjmInZPDBb5Se8JhIE9a+UcXA2VasxkRbbbM9KpSAML1PpDvKA==", "37fa5a18-b30f-4a83-bafc-73f83e25f2d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86dc77f5-a7a5-4743-8a25-82b4c6d52525",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f74c9f94-a380-4f8d-9a2b-6e9134d9229b", "AQAAAAEAACcQAAAAELPWTlkDNJZknYi08Pp80US5xmR/PQYpLaXCmJooBDgi6L/IXiwtPuWdOjNKM0BRFQ==", "9313d0ab-ad39-43ec-823a-78215524dfd2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a06696c0-0976-4e0c-8f06-550fba6b624e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5db98772-e428-439f-a2eb-060c4df13463", "AQAAAAEAACcQAAAAEOsQIb+0xWqSBAtfU2KWmcr1oMa0pYry8bErW+YPyXp4w1gUFHgpyr84V6p+snnzwQ==", "5c54e0f0-6ab3-4ab2-b75b-3e0f14effd73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2d899fd-5b46-42f7-8a2d-3b042c159807",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6de4be9a-7728-4a02-b21f-70c8f5854acd", "AQAAAAEAACcQAAAAEHoCMOXrpGAQYAk62HjTH2aZZf4zGsCHBZ/ICsWGtUvI6OEn/eRJV3DDmmZk4H7ZiA==", "5e0897a4-a8bd-4cd3-b1ae-55b6ef821e55" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1441e48-9e22-47d6-a6de-981461285925",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "295e4770-39fe-4fb3-bf4e-ea1df1e39ef1", "AQAAAAEAACcQAAAAECaOszroTsTM7SxYYYAwB+wMcHMsmSXkFzwFcRg1mYjb88pjvbJqy9QrV8l7RU2MDA==", "f80872d8-d182-4ef0-aa23-34b561bd0963" });

            migrationBuilder.InsertData(
                table: "Scores",
                columns: new[] { "ScoreId", "ScoreName" },
                values: new object[,]
                {
                    { 1, "Dårlig" },
                    { 2, "Middels" },
                    { 3, "Bra" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FreelancerScore_ScoreId",
                table: "FreelancerScore",
                column: "ScoreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FreelancerScore");

            migrationBuilder.DropTable(
                name: "Scores");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e7a8add-af80-466b-878d-cdcbee2415ae",
                column: "ConcurrencyStamp",
                value: "82dff184-136e-4dc7-b552-e79d50b4a4ee");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e52d2ba-8811-452a-be8e-0b2cc408c510",
                column: "ConcurrencyStamp",
                value: "395e705c-d33b-4940-887e-dde4282e8e87");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466b18cd-b94a-45cb-be05-aea6878443d8",
                column: "ConcurrencyStamp",
                value: "52ef7394-8dd3-46f1-83db-f270a16a32a0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75a7f84d-7a47-40a7-ba4c-d249ab5dfed4",
                column: "ConcurrencyStamp",
                value: "858e4ce8-c0a9-428a-80ab-4e572bcb9559");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d31e9f4e-4166-41bf-b226-67da21879725",
                column: "ConcurrencyStamp",
                value: "938ffa4a-dffc-455f-bb17-a15aaf2eb9d0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "608f98cc-681c-42d0-8ee0-5d889584cb8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7fb852d5-c9c1-4117-929c-3992dec46639", "AQAAAAEAACcQAAAAEBsmr8RCYSIeQayHawvKCU97NXkn1rbTG66WwsNmtLRoIAaD53gFKv1wRjnichBPMw==", "fad41651-f9e1-4e2e-9731-9562d1764218" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3d0c038-508b-4c80-8fd7-7e56b0f74188",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d52b674a-f344-41e5-979f-cd9e024c91b2", "AQAAAAEAACcQAAAAEOOFqKhAUM9s3PcaMb2M7Uiny2c1w6HQ/lQm87Pp7vOQu0rsmoozZ0IumWjsm1rsew==", "b9ee5f21-c394-4dc1-9cd6-5120a32efc11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6fe3786-ba14-45b1-8bf7-f12d0ae1592c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3d4bee7-0156-4d4c-afea-c47fd527796e", "AQAAAAEAACcQAAAAEKmNLG5OF+I5w1VHkDrlwc6Nx+72lSUzj+L1NppQH2t0xou4HsaWQCYoCMM+3uafsQ==", "29ad8771-f4b8-40a9-9c3a-a9d41a9241b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db001d8f-ee2f-4065-88ef-9732b8b5fc99",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d30ad04b-5736-4d6a-be06-76151c776701", "AQAAAAEAACcQAAAAENXOGj45vk7c2/fVNyqbE5UitvFx/bkiMWy6dneXTy9POR/j6BmBVEGYzKeTD9egdQ==", "ebbc100b-2484-49b4-875f-04277dd87de0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "163d57d7-8a53-46f0-8c37-90bc9fadddf6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0a92692-790a-471e-9d45-865b4b7c545e", "AQAAAAEAACcQAAAAEEig44JMii3k6+r4RkC0ki54GoSmrUFmMmw70l0JMoLqyaE3APVUig2C+7gFR4+how==", "18fb79b9-ec23-4e0a-9c6c-f00688eb995c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86dc77f5-a7a5-4743-8a25-82b4c6d52525",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d5902a7-7292-4464-a792-2cc3ba8688e6", "AQAAAAEAACcQAAAAEJ1CR8eXq/PGTq7REJmXsACBJ7ut0gKgBkmO0k8Hn8f54u6M4ngQm3tcFDw+LOVktw==", "52b3e6b4-3492-4535-8138-e5d2230cb276" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a06696c0-0976-4e0c-8f06-550fba6b624e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2adb6681-f22d-400f-9387-5c32e06a2197", "AQAAAAEAACcQAAAAEHaG7dc0OUiFqMuRbtV63SYl/k3iL6t72hTbjPcP2kSaB/1qD8ZbTBgW8v04AztXvQ==", "e2e40913-760b-464e-b37f-9e3d6e5d7a2b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2d899fd-5b46-42f7-8a2d-3b042c159807",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ebac27ce-fef9-45b3-b88b-6ec31b3a3274", "AQAAAAEAACcQAAAAEMxOs2tYPRF/virE+20ZMTzbBwm/8yNOVVkxKjFwyRNyxBAe60r0TK92q/M5DfGNEg==", "ecf3a188-c963-4884-985a-ec1c651ac360" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1441e48-9e22-47d6-a6de-981461285925",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e3efc74-e98d-4fe5-83df-9df7fbd1fe27", "AQAAAAEAACcQAAAAEDMxa8CF6KoCc2pdStpYEFLK+oL8dXo2m8a5fN0ouMlzGMZYLAUOFFM0z0PK5/Pxcg==", "59b68aef-328b-4f18-82e7-ef1bb927a7f3" });
        }
    }
}
