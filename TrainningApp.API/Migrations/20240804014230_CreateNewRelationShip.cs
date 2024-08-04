using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainningApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreateNewRelationShip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainningExercise_Trainnings_TrainningId",
                table: "TrainningExercise");

            migrationBuilder.DropIndex(
                name: "IX_TrainningExercise_TrainningId",
                table: "TrainningExercise");

            migrationBuilder.AddColumn<int>(
                name: "Ordenation",
                table: "TrainningExercise",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TrainningDayId",
                table: "TrainningExercise",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TrainningDay",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrainningId = table.Column<int>(type: "int", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    disabled_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainningDay", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainningDay_Trainnings_TrainningId",
                        column: x => x.TrainningId,
                        principalTable: "Trainnings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrainningExercise_TrainningDayId",
                table: "TrainningExercise",
                column: "TrainningDayId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainningDay_TrainningId",
                table: "TrainningDay",
                column: "TrainningId");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainningExercise_TrainningDay_TrainningDayId",
                table: "TrainningExercise",
                column: "TrainningDayId",
                principalTable: "TrainningDay",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainningExercise_TrainningDay_TrainningDayId",
                table: "TrainningExercise");

            migrationBuilder.DropTable(
                name: "TrainningDay");

            migrationBuilder.DropIndex(
                name: "IX_TrainningExercise_TrainningDayId",
                table: "TrainningExercise");

            migrationBuilder.DropColumn(
                name: "Ordenation",
                table: "TrainningExercise");

            migrationBuilder.DropColumn(
                name: "TrainningDayId",
                table: "TrainningExercise");

            migrationBuilder.CreateIndex(
                name: "IX_TrainningExercise_TrainningId",
                table: "TrainningExercise",
                column: "TrainningId");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainningExercise_Trainnings_TrainningId",
                table: "TrainningExercise",
                column: "TrainningId",
                principalTable: "Trainnings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
