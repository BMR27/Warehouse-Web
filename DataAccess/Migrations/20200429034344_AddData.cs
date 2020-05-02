using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { "ASH", "Aseo Hogar" },
                    { "ASP", "Aseo Personal" },
                    { "HGR", "Hogar" },
                    { "PRF", "Perfumes" },
                    { "SLD", "Salud" },
                    { "VDJ", "Video Juegos" }
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[,]
                {
                    { "3251333e-7288-47cc-94e6-e4bd93b9837c", "Calle los delfines con 23", "Bodega Central" },
                    { "d6c35568-6adb-4447-a0a1-d3e4b5f57132", "Calle 8 con 23", "Bodega Norte" },
                    { "ccc53afe-2c5f-4adb-9a61-477439f9c3ce", "Calle 5 con 10", "Bodega Sur" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "ASH");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "ASP");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "HGR");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "PRF");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "SLD");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "VDJ");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "3251333e-7288-47cc-94e6-e4bd93b9837c");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "ccc53afe-2c5f-4adb-9a61-477439f9c3ce");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "d6c35568-6adb-4447-a0a1-d3e4b5f57132");
        }
    }
}
