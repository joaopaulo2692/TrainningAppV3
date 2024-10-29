using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainningApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class alteracao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseMuscle_Exercise_ExercisesId",
                table: "ExerciseMuscle");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseMuscle_Muscle_MusclesId",
                table: "ExerciseMuscle");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainningDay_Trainnings_TrainningId",
                table: "TrainningDay");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainningExercise_Exercise_ExerciseId",
                table: "TrainningExercise");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainningExercise_TrainningDay_TrainningDayId",
                table: "TrainningExercise");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTrainnings_AspNetUsers_UsersId",
                table: "UserTrainnings");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTrainnings_Trainnings_TrainningsId",
                table: "UserTrainnings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTrainnings",
                table: "UserTrainnings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainningExercise",
                table: "TrainningExercise");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainningDay",
                table: "TrainningDay");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Muscle",
                table: "Muscle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Exercise",
                table: "Exercise");

            migrationBuilder.DropColumn(
                name: "TrainningId",
                table: "TrainningExercise");

            migrationBuilder.RenameTable(
                name: "UserTrainnings",
                newName: "ApplicationUserTrainning");

            migrationBuilder.RenameTable(
                name: "TrainningExercise",
                newName: "TrainningExercises");

            migrationBuilder.RenameTable(
                name: "TrainningDay",
                newName: "TrainningDays");

            migrationBuilder.RenameTable(
                name: "Muscle",
                newName: "Muscles");

            migrationBuilder.RenameTable(
                name: "Exercise",
                newName: "Exercises");

            migrationBuilder.RenameColumn(
                name: "TrainningsId",
                table: "ApplicationUserTrainning",
                newName: "TrainingsId");

            migrationBuilder.RenameIndex(
                name: "IX_UserTrainnings_UsersId",
                table: "ApplicationUserTrainning",
                newName: "IX_ApplicationUserTrainning_UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainningExercise_TrainningDayId",
                table: "TrainningExercises",
                newName: "IX_TrainningExercises_TrainningDayId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainningExercise_ExerciseId",
                table: "TrainningExercises",
                newName: "IX_TrainningExercises_ExerciseId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainningDay_TrainningId",
                table: "TrainningDays",
                newName: "IX_TrainningDays_TrainningId");

            migrationBuilder.AddColumn<int>(
                name: "GymId",
                table: "Trainnings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PersonalId",
                table: "Trainnings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "GymId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUserTrainning",
                table: "ApplicationUserTrainning",
                columns: new[] { "TrainingsId", "UsersId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainningExercises",
                table: "TrainningExercises",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainningDays",
                table: "TrainningDays",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Muscles",
                table: "Muscles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Exercises",
                table: "Exercises",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Gym",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    disabled_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gym", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Trainnings_GymId",
                table: "Trainnings",
                column: "GymId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_GymId",
                table: "AspNetUsers",
                column: "GymId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserTrainning_AspNetUsers_UsersId",
                table: "ApplicationUserTrainning",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserTrainning_Trainnings_TrainingsId",
                table: "ApplicationUserTrainning",
                column: "TrainingsId",
                principalTable: "Trainnings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Gym_GymId",
                table: "AspNetUsers",
                column: "GymId",
                principalTable: "Gym",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseMuscle_Exercises_ExercisesId",
                table: "ExerciseMuscle",
                column: "ExercisesId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseMuscle_Muscles_MusclesId",
                table: "ExerciseMuscle",
                column: "MusclesId",
                principalTable: "Muscles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainningDays_Trainnings_TrainningId",
                table: "TrainningDays",
                column: "TrainningId",
                principalTable: "Trainnings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainningExercises_Exercises_ExerciseId",
                table: "TrainningExercises",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainningExercises_TrainningDays_TrainningDayId",
                table: "TrainningExercises",
                column: "TrainningDayId",
                principalTable: "TrainningDays",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trainnings_Gym_GymId",
                table: "Trainnings",
                column: "GymId",
                principalTable: "Gym",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserTrainning_AspNetUsers_UsersId",
                table: "ApplicationUserTrainning");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserTrainning_Trainnings_TrainingsId",
                table: "ApplicationUserTrainning");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Gym_GymId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseMuscle_Exercises_ExercisesId",
                table: "ExerciseMuscle");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseMuscle_Muscles_MusclesId",
                table: "ExerciseMuscle");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainningDays_Trainnings_TrainningId",
                table: "TrainningDays");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainningExercises_Exercises_ExerciseId",
                table: "TrainningExercises");

            migrationBuilder.DropForeignKey(
                name: "FK_TrainningExercises_TrainningDays_TrainningDayId",
                table: "TrainningExercises");

            migrationBuilder.DropForeignKey(
                name: "FK_Trainnings_Gym_GymId",
                table: "Trainnings");

            migrationBuilder.DropTable(
                name: "Gym");

            migrationBuilder.DropIndex(
                name: "IX_Trainnings_GymId",
                table: "Trainnings");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_GymId",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainningExercises",
                table: "TrainningExercises");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainningDays",
                table: "TrainningDays");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Muscles",
                table: "Muscles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Exercises",
                table: "Exercises");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUserTrainning",
                table: "ApplicationUserTrainning");

            migrationBuilder.DropColumn(
                name: "GymId",
                table: "Trainnings");

            migrationBuilder.DropColumn(
                name: "PersonalId",
                table: "Trainnings");

            migrationBuilder.DropColumn(
                name: "GymId",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "TrainningExercises",
                newName: "TrainningExercise");

            migrationBuilder.RenameTable(
                name: "TrainningDays",
                newName: "TrainningDay");

            migrationBuilder.RenameTable(
                name: "Muscles",
                newName: "Muscle");

            migrationBuilder.RenameTable(
                name: "Exercises",
                newName: "Exercise");

            migrationBuilder.RenameTable(
                name: "ApplicationUserTrainning",
                newName: "UserTrainnings");

            migrationBuilder.RenameIndex(
                name: "IX_TrainningExercises_TrainningDayId",
                table: "TrainningExercise",
                newName: "IX_TrainningExercise_TrainningDayId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainningExercises_ExerciseId",
                table: "TrainningExercise",
                newName: "IX_TrainningExercise_ExerciseId");

            migrationBuilder.RenameIndex(
                name: "IX_TrainningDays_TrainningId",
                table: "TrainningDay",
                newName: "IX_TrainningDay_TrainningId");

            migrationBuilder.RenameColumn(
                name: "TrainingsId",
                table: "UserTrainnings",
                newName: "TrainningsId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationUserTrainning_UsersId",
                table: "UserTrainnings",
                newName: "IX_UserTrainnings_UsersId");

            migrationBuilder.AddColumn<int>(
                name: "TrainningId",
                table: "TrainningExercise",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainningExercise",
                table: "TrainningExercise",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainningDay",
                table: "TrainningDay",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Muscle",
                table: "Muscle",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Exercise",
                table: "Exercise",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTrainnings",
                table: "UserTrainnings",
                columns: new[] { "TrainningsId", "UsersId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseMuscle_Exercise_ExercisesId",
                table: "ExerciseMuscle",
                column: "ExercisesId",
                principalTable: "Exercise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseMuscle_Muscle_MusclesId",
                table: "ExerciseMuscle",
                column: "MusclesId",
                principalTable: "Muscle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainningDay_Trainnings_TrainningId",
                table: "TrainningDay",
                column: "TrainningId",
                principalTable: "Trainnings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainningExercise_Exercise_ExerciseId",
                table: "TrainningExercise",
                column: "ExerciseId",
                principalTable: "Exercise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainningExercise_TrainningDay_TrainningDayId",
                table: "TrainningExercise",
                column: "TrainningDayId",
                principalTable: "TrainningDay",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTrainnings_AspNetUsers_UsersId",
                table: "UserTrainnings",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTrainnings_Trainnings_TrainningsId",
                table: "UserTrainnings",
                column: "TrainningsId",
                principalTable: "Trainnings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
