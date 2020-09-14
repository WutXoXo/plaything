using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClosedXML.Report.Sample.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "m_product",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    isActive = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false),
                    createdBy = table.Column<long>(nullable: false),
                    updatedAt = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<long>(nullable: false),
                    name = table.Column<string>(nullable: false),
                    code = table.Column<string>(nullable: true),
                    barcode = table.Column<string>(nullable: true),
                    price = table.Column<double>(nullable: false),
                    description = table.Column<string>(nullable: true),
                    quantity = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_product", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "m_product",
                columns: new[] { "id", "barcode", "code", "createdAt", "createdBy", "description", "isActive", "name", "price", "quantity", "updatedAt", "updatedBy" },
                values: new object[] { 1L, "8850125082311", "8850125082311", new DateTime(2020, 9, 9, 18, 40, 32, 523, DateTimeKind.Local).AddTicks(5236), 1L, null, true, "ไมโล เครื่องดื่มช็อกโกแลตมอลต์ปรุงสำเร็จชนิดผง สูตรน้ำตาลน้อย 25 กรัม แพ็ค 15", 98.0, 100.0, new DateTime(2020, 9, 9, 18, 40, 32, 524, DateTimeKind.Local).AddTicks(5098), 1L });

            migrationBuilder.InsertData(
                table: "m_product",
                columns: new[] { "id", "barcode", "code", "createdAt", "createdBy", "description", "isActive", "name", "price", "quantity", "updatedAt", "updatedBy" },
                values: new object[] { 2L, "8851959632185", "8851959632185", new DateTime(2020, 9, 9, 18, 40, 32, 524, DateTimeKind.Local).AddTicks(5814), 1L, null, true, "แฟนต้า น้ำอัดลม น้ำเขียว 325 มล. 6 กระป๋อง", 72.0, 200.0, new DateTime(2020, 9, 9, 18, 40, 32, 524, DateTimeKind.Local).AddTicks(5843), 1L });

            migrationBuilder.InsertData(
                table: "m_product",
                columns: new[] { "id", "barcode", "code", "createdAt", "createdBy", "description", "isActive", "name", "price", "quantity", "updatedAt", "updatedBy" },
                values: new object[] { 3L, "8850250004943", "8850250004943", new DateTime(2020, 9, 9, 18, 40, 32, 524, DateTimeKind.Local).AddTicks(5858), 1L, null, true, "ยำยำ บะหมี่กึ่งสำเร็จรูป รสต้มยำกุ้ง 67 ก. แพ็ค", 48.0, 300.0, new DateTime(2020, 9, 9, 18, 40, 32, 524, DateTimeKind.Local).AddTicks(5859), 1L });

            migrationBuilder.InsertData(
                table: "m_product",
                columns: new[] { "id", "barcode", "code", "createdAt", "createdBy", "description", "isActive", "name", "price", "quantity", "updatedAt", "updatedBy" },
                values: new object[] { 4L, "8850006322499", "8850006322499", new DateTime(2020, 9, 9, 18, 40, 32, 524, DateTimeKind.Local).AddTicks(5862), 1L, null, true, "คอลเกต ยาสีฟัน สูตรเกลือสมุนไพร 150 กรัม แพ็ค 2", 99.0, 400.0, new DateTime(2020, 9, 9, 18, 40, 32, 524, DateTimeKind.Local).AddTicks(5863), 1L });

            migrationBuilder.InsertData(
                table: "m_product",
                columns: new[] { "id", "barcode", "code", "createdAt", "createdBy", "description", "isActive", "name", "price", "quantity", "updatedAt", "updatedBy" },
                values: new object[] { 5L, "8888336032917", "8888336032917", new DateTime(2020, 9, 9, 18, 40, 32, 524, DateTimeKind.Local).AddTicks(5865), 1L, null, true, "ฮักกี้ส์ โกลด์ ซอฟท์แอนด์สลิม แพ้นท์ กางเกงผ้าอ้อมเด็ก ขนาด XL แพ็ค 38 ชิ้น", 449.0, 500.0, new DateTime(2020, 9, 9, 18, 40, 32, 524, DateTimeKind.Local).AddTicks(5867), 1L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "m_product");
        }
    }
}
