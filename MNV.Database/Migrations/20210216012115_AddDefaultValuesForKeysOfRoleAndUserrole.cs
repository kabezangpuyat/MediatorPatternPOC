using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MNV.Database.Migrations
{
    public partial class AddDefaultValuesForKeysOfRoleAndUserrole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "Key",
                schema: "dbo",
                table: "UserRole",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("586d4ef8-7e56-4077-b7a4-c84f448f272c"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                schema: "dbo",
                table: "UserRole",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 2, 16, 9, 21, 15, 43, DateTimeKind.Unspecified).AddTicks(7909), new TimeSpan(0, 8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 2, 16, 8, 26, 5, 566, DateTimeKind.Unspecified).AddTicks(937), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "Key",
                schema: "dbo",
                table: "User",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("1efb2b3a-7841-4916-abab-371ceff55fd4"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("e56e48a8-c4ef-4fa6-a933-2b447f2de406"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                schema: "dbo",
                table: "User",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 2, 16, 9, 21, 15, 40, DateTimeKind.Unspecified).AddTicks(8779), new TimeSpan(0, 8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 2, 16, 8, 26, 5, 563, DateTimeKind.Unspecified).AddTicks(1271), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "Key",
                schema: "dbo",
                table: "Role",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("b0b4cb1e-4f00-4902-acc6-a636710fea65"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                schema: "dbo",
                table: "Role",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 2, 16, 9, 21, 15, 26, DateTimeKind.Unspecified).AddTicks(8640), new TimeSpan(0, 8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 2, 16, 8, 26, 5, 545, DateTimeKind.Unspecified).AddTicks(151), new TimeSpan(0, 8, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "Key",
                schema: "dbo",
                table: "UserRole",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("586d4ef8-7e56-4077-b7a4-c84f448f272c"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                schema: "dbo",
                table: "UserRole",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 2, 16, 8, 26, 5, 566, DateTimeKind.Unspecified).AddTicks(937), new TimeSpan(0, 8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 2, 16, 9, 21, 15, 43, DateTimeKind.Unspecified).AddTicks(7909), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "Key",
                schema: "dbo",
                table: "User",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("e56e48a8-c4ef-4fa6-a933-2b447f2de406"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("1efb2b3a-7841-4916-abab-371ceff55fd4"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                schema: "dbo",
                table: "User",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 2, 16, 8, 26, 5, 563, DateTimeKind.Unspecified).AddTicks(1271), new TimeSpan(0, 8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 2, 16, 9, 21, 15, 40, DateTimeKind.Unspecified).AddTicks(8779), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.AlterColumn<Guid>(
                name: "Key",
                schema: "dbo",
                table: "Role",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("b0b4cb1e-4f00-4902-acc6-a636710fea65"));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DateCreated",
                schema: "dbo",
                table: "Role",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 2, 16, 8, 26, 5, 545, DateTimeKind.Unspecified).AddTicks(151), new TimeSpan(0, 8, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 2, 16, 9, 21, 15, 26, DateTimeKind.Unspecified).AddTicks(8640), new TimeSpan(0, 8, 0, 0, 0)));
        }
    }
}
