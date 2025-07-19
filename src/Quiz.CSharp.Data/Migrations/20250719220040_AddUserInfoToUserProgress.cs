﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quiz.CSharp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUserInfoToUserProgress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "user_progress",
                type: "character varying(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "telegram_username",
                table: "user_progress",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "username",
                table: "user_progress",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "name",
                table: "user_progress");

            migrationBuilder.DropColumn(
                name: "telegram_username",
                table: "user_progress");

            migrationBuilder.DropColumn(
                name: "username",
                table: "user_progress");
        }
    }
}
