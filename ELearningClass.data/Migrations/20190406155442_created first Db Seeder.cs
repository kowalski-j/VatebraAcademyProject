using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ELearningClass.data.Migrations
{
    public partial class createdfirstDbSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseCode", "CourseDescription", "CourseTitle", "DateCreated", "DateUpdated" },
                values: new object[,]
                {
                    { 1, "CSC 001", "This course teaches HTML", "Learning HTML", new DateTime(2019, 4, 6, 16, 54, 41, 917, DateTimeKind.Local), new DateTime(2019, 4, 6, 16, 54, 41, 919, DateTimeKind.Local) },
                    { 2, "CSC 002", "", "Learning Ef", new DateTime(2019, 4, 6, 16, 54, 41, 919, DateTimeKind.Local), new DateTime(2019, 4, 6, 16, 54, 41, 919, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "Id", "CourseId", "CourseId1", "DateCreated", "DateUpdated", "StudentId", "StudentId1" },
                values: new object[,]
                {
                    { 1, 1L, null, new DateTime(2019, 4, 6, 16, 54, 41, 920, DateTimeKind.Local), new DateTime(2019, 4, 6, 16, 54, 41, 920, DateTimeKind.Local), 1L, null },
                    { 2, 2L, null, new DateTime(2019, 4, 6, 16, 54, 41, 920, DateTimeKind.Local), new DateTime(2019, 4, 6, 16, 54, 41, 920, DateTimeKind.Local), 2L, null }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateCreated", "DateUpdated", "FirstName", "LastName", "MatricNumber" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 4, 6, 16, 54, 41, 920, DateTimeKind.Local), new DateTime(2019, 4, 6, 16, 54, 41, 920, DateTimeKind.Local), "Anthonia", "Ebhoaye", "1234567890" },
                    { 2, new DateTime(2019, 4, 6, 16, 54, 41, 920, DateTimeKind.Local), new DateTime(2019, 4, 6, 16, 54, 41, 920, DateTimeKind.Local), "Lucky", "Moye", "756449675" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
