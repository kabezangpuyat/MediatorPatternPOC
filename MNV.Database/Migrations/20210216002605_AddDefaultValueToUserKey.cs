using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MNV.Database.Migrations
{
    public partial class AddDefaultValueToUserKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                schema: "dbo",
                table: "UserRole",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 2, 16, 8, 26, 5, 566, DateTimeKind.Unspecified).AddTicks(937), new TimeSpan(0, 8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 2, 11, 18, 43, 40, 345, DateTimeKind.Unspecified).AddTicks(151), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "Key",
                schema: "dbo",
                table: "User",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("e56e48a8-c4ef-4fa6-a933-2b447f2de406"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                schema: "dbo",
                table: "User",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 2, 16, 8, 26, 5, 563, DateTimeKind.Unspecified).AddTicks(1271), new TimeSpan(0, 8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 2, 11, 18, 43, 40, 341, DateTimeKind.Unspecified).AddTicks(6265), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                schema: "dbo",
                table: "Role",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 2, 16, 8, 26, 5, 545, DateTimeKind.Unspecified).AddTicks(151), new TimeSpan(0, 8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 2, 11, 18, 43, 40, 322, DateTimeKind.Unspecified).AddTicks(4256), new TimeSpan(0, 8, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                schema: "dbo",
                table: "UserRole",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 2, 11, 18, 43, 40, 345, DateTimeKind.Unspecified).AddTicks(151), new TimeSpan(0, 8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 2, 16, 8, 26, 5, 566, DateTimeKind.Unspecified).AddTicks(937), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "Key",
                schema: "dbo",
                table: "User",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("e56e48a8-c4ef-4fa6-a933-2b447f2de406"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                schema: "dbo",
                table: "User",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 2, 11, 18, 43, 40, 341, DateTimeKind.Unspecified).AddTicks(6265), new TimeSpan(0, 8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 2, 16, 8, 26, 5, 563, DateTimeKind.Unspecified).AddTicks(1271), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                schema: "dbo",
                table: "Role",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 2, 11, 18, 43, 40, 322, DateTimeKind.Unspecified).AddTicks(4256), new TimeSpan(0, 8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 2, 16, 8, 26, 5, 545, DateTimeKind.Unspecified).AddTicks(151), new TimeSpan(0, 8, 0, 0, 0)));
        }
    }
}
