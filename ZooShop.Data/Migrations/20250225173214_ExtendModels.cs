using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZooShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class ExtendModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderState",
                newName: "State",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "PaymentState",
                table: "Orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<byte>(
                name: "Breed",
                table: "Animals",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);


            migrationBuilder.AddColumn<string>(
                name: "Functions",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "Height",
                table: "Animals",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "Weight",
                table: "Animals",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Functions",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Img",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Animals");

            migrationBuilder.AlterColumn<byte>(
                name: "PaymentState",
                table: "Orders",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<byte>(
                name: "Breed",
                table: "Animals",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.RenameColumn(
                name: "State",
                newName: "OrderState",
                table: "Orders");

        }
    }
}
