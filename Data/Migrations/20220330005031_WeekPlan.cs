using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipeApp.Data.Migrations
{
    public partial class WeekPlan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WeekPlanId",
                table: "Recipes",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WeekPlanId1",
                table: "Recipes",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WeekPlanId2",
                table: "Recipes",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WeekPlanId3",
                table: "Recipes",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WeekPlanId4",
                table: "Recipes",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WeekPlanId5",
                table: "Recipes",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WeekPlanId6",
                table: "Recipes",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "WeekPlans",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    WeekPlanId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeekPlans", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_WeekPlanId",
                table: "Recipes",
                column: "WeekPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_WeekPlanId1",
                table: "Recipes",
                column: "WeekPlanId1");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_WeekPlanId2",
                table: "Recipes",
                column: "WeekPlanId2");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_WeekPlanId3",
                table: "Recipes",
                column: "WeekPlanId3");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_WeekPlanId4",
                table: "Recipes",
                column: "WeekPlanId4");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_WeekPlanId5",
                table: "Recipes",
                column: "WeekPlanId5");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_WeekPlanId6",
                table: "Recipes",
                column: "WeekPlanId6");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_WeekPlans_WeekPlanId",
                table: "Recipes",
                column: "WeekPlanId",
                principalTable: "WeekPlans",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_WeekPlans_WeekPlanId1",
                table: "Recipes",
                column: "WeekPlanId1",
                principalTable: "WeekPlans",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_WeekPlans_WeekPlanId2",
                table: "Recipes",
                column: "WeekPlanId2",
                principalTable: "WeekPlans",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_WeekPlans_WeekPlanId3",
                table: "Recipes",
                column: "WeekPlanId3",
                principalTable: "WeekPlans",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_WeekPlans_WeekPlanId4",
                table: "Recipes",
                column: "WeekPlanId4",
                principalTable: "WeekPlans",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_WeekPlans_WeekPlanId5",
                table: "Recipes",
                column: "WeekPlanId5",
                principalTable: "WeekPlans",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_WeekPlans_WeekPlanId6",
                table: "Recipes",
                column: "WeekPlanId6",
                principalTable: "WeekPlans",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_WeekPlans_WeekPlanId",
                table: "Recipes");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_WeekPlans_WeekPlanId1",
                table: "Recipes");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_WeekPlans_WeekPlanId2",
                table: "Recipes");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_WeekPlans_WeekPlanId3",
                table: "Recipes");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_WeekPlans_WeekPlanId4",
                table: "Recipes");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_WeekPlans_WeekPlanId5",
                table: "Recipes");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_WeekPlans_WeekPlanId6",
                table: "Recipes");

            migrationBuilder.DropTable(
                name: "WeekPlans");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_WeekPlanId",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_WeekPlanId1",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_WeekPlanId2",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_WeekPlanId3",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_WeekPlanId4",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_WeekPlanId5",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_WeekPlanId6",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "WeekPlanId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "WeekPlanId1",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "WeekPlanId2",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "WeekPlanId3",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "WeekPlanId4",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "WeekPlanId5",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "WeekPlanId6",
                table: "Recipes");
        }
    }
}
