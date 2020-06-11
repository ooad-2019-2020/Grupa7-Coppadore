using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Projekat.Migrations
{
    public partial class novamigracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Placanje_Korisnik_KorisnikID",
                table: "Placanje");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Korisnik",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "komentar",
                table: "Komentar");

            migrationBuilder.RenameColumn(
                name: "KorisnikID",
                table: "Placanje",
                newName: "KorisnikId");

            migrationBuilder.RenameIndex(
                name: "IX_Placanje_KorisnikID",
                table: "Placanje",
                newName: "IX_Placanje_KorisnikId");

            migrationBuilder.AlterColumn<string>(
                name: "KorisnikId",
                table: "Placanje",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "KorisnikID",
                table: "Korisnik",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Korisnik",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Korisnik",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Korisnik",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Korisnik",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Korisnik",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Korisnik",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Korisnik",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Korisnik",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Korisnik",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Korisnik",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Korisnik",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Korisnik",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Korisnik",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Korisnik",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Korisnik",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "komentarTekst",
                table: "Komentar",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Korisnik",
                table: "Korisnik",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Placanje_Korisnik_KorisnikId",
                table: "Placanje",
                column: "KorisnikId",
                principalTable: "Korisnik",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Placanje_Korisnik_KorisnikId",
                table: "Placanje");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Korisnik",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "komentarTekst",
                table: "Komentar");

            migrationBuilder.RenameColumn(
                name: "KorisnikId",
                table: "Placanje",
                newName: "KorisnikID");

            migrationBuilder.RenameIndex(
                name: "IX_Placanje_KorisnikId",
                table: "Placanje",
                newName: "IX_Placanje_KorisnikID");

            migrationBuilder.AlterColumn<int>(
                name: "KorisnikID",
                table: "Placanje",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "KorisnikID",
                table: "Korisnik",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "komentar",
                table: "Komentar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Korisnik",
                table: "Korisnik",
                column: "KorisnikID");

            migrationBuilder.AddForeignKey(
                name: "FK_Placanje_Korisnik_KorisnikID",
                table: "Placanje",
                column: "KorisnikID",
                principalTable: "Korisnik",
                principalColumn: "KorisnikID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
