﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Bank.Data.Migrations
{
    public partial class InitalMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(250)", nullable: false),
                    Email = table.Column<string>(type: "varchar(200)", nullable: false),
                    Endereco = table.Column<string>(type: "varchar(250)", nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    Documento = table.Column<string>(type: "varchar(11)", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
