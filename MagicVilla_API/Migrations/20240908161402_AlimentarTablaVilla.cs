﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetroCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Detalle de la villa...", new DateTime(2024, 9, 8, 18, 14, 2, 186, DateTimeKind.Local).AddTicks(4311), new DateTime(2024, 9, 8, 18, 14, 2, 186, DateTimeKind.Local).AddTicks(4255), "", 50, "Villa Real", 5, 200.0 },
                    { 2, "", "Detalle de la villa premium...", new DateTime(2024, 9, 8, 18, 14, 2, 186, DateTimeKind.Local).AddTicks(4316), new DateTime(2024, 9, 8, 18, 14, 2, 186, DateTimeKind.Local).AddTicks(4315), "", 40, "Preimium Villa Real", 4, 150.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
