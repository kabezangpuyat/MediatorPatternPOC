using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MNV.Database.Migrations
{
    public partial class AddGeneratedValueToKeyColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 2, 11, 18, 15, 45, 339, DateTimeKind.Unspecified).AddTicks(1846), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                schema: "dbo",
                table: "User",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 2, 11, 18, 43, 40, 341, DateTimeKind.Unspecified).AddTicks(6265), new TimeSpan(0, 8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 2, 11, 18, 15, 45, 335, DateTimeKind.Unspecified).AddTicks(6296), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                schema: "dbo",
                table: "Role",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 2, 11, 18, 43, 40, 322, DateTimeKind.Unspecified).AddTicks(4256), new TimeSpan(0, 8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 2, 11, 18, 15, 45, 314, DateTimeKind.Unspecified).AddTicks(7347), new TimeSpan(0, 8, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                schema: "dbo",
                table: "UserRole",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 2, 11, 18, 15, 45, 339, DateTimeKind.Unspecified).AddTicks(1846), new TimeSpan(0, 8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 2, 11, 18, 43, 40, 345, DateTimeKind.Unspecified).AddTicks(151), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                schema: "dbo",
                table: "User",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 2, 11, 18, 15, 45, 335, DateTimeKind.Unspecified).AddTicks(6296), new TimeSpan(0, 8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 2, 11, 18, 43, 40, 341, DateTimeKind.Unspecified).AddTicks(6265), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                schema: "dbo",
                table: "Role",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 2, 11, 18, 15, 45, 314, DateTimeKind.Unspecified).AddTicks(7347), new TimeSpan(0, 8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 2, 11, 18, 43, 40, 322, DateTimeKind.Unspecified).AddTicks(4256), new TimeSpan(0, 8, 0, 0, 0)));
        }
    }
}
