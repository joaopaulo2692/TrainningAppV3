using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainningApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Alt_relationShip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Activate",
                table: "Trainnings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "FrequencyWeekly",
                table: "Trainnings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Trainnings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Level",
                table: "Trainnings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ManagementId",
                table: "Trainnings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Observation",
                table: "Trainnings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Reps",
                table: "TrainningExercises",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Interval",
                table: "TrainningExercises",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Weight",
                table: "TrainningExercises",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Level",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Trainnings_ManagementId",
                table: "Trainnings",
                column: "ManagementId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trainnings_Managements_ManagementId",
                table: "Trainnings",
                column: "ManagementId",
                principalTable: "Managements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trainnings_Managements_ManagementId",
                table: "Trainnings");

            migrationBuilder.DropIndex(
                name: "IX_Trainnings_ManagementId",
                table: "Trainnings");

            migrationBuilder.DropColumn(
                name: "Activate",
                table: "Trainnings");

            migrationBuilder.DropColumn(
                name: "FrequencyWeekly",
                table: "Trainnings");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Trainnings");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "Trainnings");

            migrationBuilder.DropColumn(
                name: "ManagementId",
                table: "Trainnings");

            migrationBuilder.DropColumn(
                name: "Observation",
                table: "Trainnings");

            migrationBuilder.DropColumn(
                name: "Interval",
                table: "TrainningExercises");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "TrainningExercises");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "Exercises");

            migrationBuilder.AlterColumn<int>(
                name: "Reps",
                table: "TrainningExercises",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
