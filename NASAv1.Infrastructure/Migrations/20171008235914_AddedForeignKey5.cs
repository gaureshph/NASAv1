using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace NASAv1.Infrastructure.Migrations
{
    public partial class AddedForeignKey5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Satellite_RocketID",
                table: "Satellite",
                column: "RocketID");

            migrationBuilder.AddForeignKey(
                name: "FK_Satellite_Rockets_RocketID",
                table: "Satellite",
                column: "RocketID",
                principalTable: "Rockets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Satellite_Rockets_RocketID",
                table: "Satellite");

            migrationBuilder.DropIndex(
                name: "IX_Satellite_RocketID",
                table: "Satellite");
        }
    }
}
