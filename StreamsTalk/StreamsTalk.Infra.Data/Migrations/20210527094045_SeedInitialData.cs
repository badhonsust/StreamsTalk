using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StreamsTalk.Infra.Data.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employes",
                columns: new[] { "Id", "CreateTime", "FirstName", "IsDeleted", "LastModifiedTime", "LastName", "MiddleName" },
                values: new object[,]
                {
                    { "eae45a1b2684461f8ed1dd4fbee63743", new DateTime(2021, 5, 27, 15, 40, 45, 177, DateTimeKind.Local).AddTicks(3041), "Md", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AshfaQ", "Badhon" },
                    { "b00e553cfdd24091b207ed02dcb27374", new DateTime(2021, 5, 27, 15, 40, 45, 179, DateTimeKind.Local).AddTicks(950), "John", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Well", "Max" },
                    { "bc18004d54b34a819796de536a1d56f9", new DateTime(2021, 5, 27, 15, 40, 45, 179, DateTimeKind.Local).AddTicks(991), "Tom", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Goong", "Tang" },
                    { "e721b24fc73a4d82a4c881c75ed2d805", new DateTime(2021, 5, 27, 15, 40, 45, 179, DateTimeKind.Local).AddTicks(1001), "Tokio", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oscer", "Servei" },
                    { "27d82f92026a4445ba3001c3da646336", new DateTime(2021, 5, 27, 15, 40, 45, 179, DateTimeKind.Local).AddTicks(1008), "Mark", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Allen", "Tiger" },
                    { "33e386fc66a74029a86261e475f2a2ea", new DateTime(2021, 5, 27, 15, 40, 45, 179, DateTimeKind.Local).AddTicks(1029), "Alen", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pirer", "Max" },
                    { "297e20b8e110485eb9bfe911b2ca687d", new DateTime(2021, 5, 27, 15, 40, 45, 179, DateTimeKind.Local).AddTicks(1057), "Rasell", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Barnerd", "Shaw" },
                    { "9c4f545d78344a9690db4f6f95812015", new DateTime(2021, 5, 27, 15, 40, 45, 179, DateTimeKind.Local).AddTicks(1064), "Envy", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Goodwill" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employes",
                keyColumn: "Id",
                keyValue: "27d82f92026a4445ba3001c3da646336");

            migrationBuilder.DeleteData(
                table: "Employes",
                keyColumn: "Id",
                keyValue: "297e20b8e110485eb9bfe911b2ca687d");

            migrationBuilder.DeleteData(
                table: "Employes",
                keyColumn: "Id",
                keyValue: "33e386fc66a74029a86261e475f2a2ea");

            migrationBuilder.DeleteData(
                table: "Employes",
                keyColumn: "Id",
                keyValue: "9c4f545d78344a9690db4f6f95812015");

            migrationBuilder.DeleteData(
                table: "Employes",
                keyColumn: "Id",
                keyValue: "b00e553cfdd24091b207ed02dcb27374");

            migrationBuilder.DeleteData(
                table: "Employes",
                keyColumn: "Id",
                keyValue: "bc18004d54b34a819796de536a1d56f9");

            migrationBuilder.DeleteData(
                table: "Employes",
                keyColumn: "Id",
                keyValue: "e721b24fc73a4d82a4c881c75ed2d805");

            migrationBuilder.DeleteData(
                table: "Employes",
                keyColumn: "Id",
                keyValue: "eae45a1b2684461f8ed1dd4fbee63743");
        }
    }
}
