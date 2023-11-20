using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class _init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Provider",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provider", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProviderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Provider_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "Provider",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Provider",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 0, "Волкова, Силина and Аксенов" },
                    { 1, "Моисеев - Никитин" },
                    { 2, "Фролов - Филиппов" },
                    { 3, "Захарова, Белоусова and Тимофеева" },
                    { 4, "Богданов, Дьячкова and Суворова" },
                    { 5, "Фокина, Федорова and Рыбакова" },
                    { 6, "Игнатова Трейд" },
                    { 7, "Захарова, Виноградов and Потапова" },
                    { 8, "Афанасьев, Блинова and Иванова" },
                    { 9, "Дмитриева - Баранова" },
                    { 10, "Кузнецов Пром" },
                    { 11, "Дементьев, Орехов and Ершова" },
                    { 12, "Шарова Торг" },
                    { 13, "Агафонова Торг" },
                    { 14, "Дементьева, Иванова and Жданов" },
                    { 15, "Козлов Пром" },
                    { 16, "Бобров, Фролов and Максимова" },
                    { 17, "Константинова - Белова" },
                    { 18, "Калинина Сбыт" },
                    { 19, "Никонова, Ситников and Веселова" },
                    { 20, "Игнатьев, Рыбакова and Козлов" },
                    { 21, "Сидорова, Юдин and Лапина" },
                    { 22, "Силин, Александров and Васильева" },
                    { 23, "Жуков Сбыт" },
                    { 24, "Беспалов - Козлов" },
                    { 25, "Новиков - Сорокина" },
                    { 26, "Волкова, Фадеева and Казакова" },
                    { 27, "Жукова, Шарова and Кириллова" },
                    { 28, "Муравьева, Лебедева and Кудрявцева" },
                    { 29, "Воронцова, Овчинникова and Петухов" },
                    { 30, "Селиверстова Пром" },
                    { 31, "Аксенов - Кулакова" },
                    { 32, "Князев Пром" },
                    { 33, "Сидоров - Ершова" },
                    { 34, "Доронин - Савин" },
                    { 35, "Жуков - Наумов" },
                    { 36, "Гущина Торг" },
                    { 37, "Некрасова - Ефремова" },
                    { 38, "Богданов, Борисова and Павлова" },
                    { 39, "Дементьева - Борисова" },
                    { 40, "Панфилов - Игнатова" },
                    { 41, "Терентьев - Чернова" },
                    { 42, "Пахомова Пром" },
                    { 43, "Корнилов Снаб" },
                    { 44, "Ковалева - Михеев" },
                    { 45, "Селезнев - Нестерова" },
                    { 46, "Терентьева - Шашков" },
                    { 47, "Ермакова, Денисова and Русаков" },
                    { 48, "Александрова Снаб" },
                    { 49, "Меркушев, Моисеева and Маслов" },
                    { 50, "Кондратьева Трейд" },
                    { 51, "Муравьева Сбыт" },
                    { 52, "Морозов Снаб" },
                    { 53, "Фролов - Мясникова" },
                    { 54, "Носова, Воронцов and Новиков" },
                    { 55, "Уваров - Никонов" },
                    { 56, "Баранов Снаб" },
                    { 57, "Иванов Торг" },
                    { 58, "Ефимов - Афанасьева" },
                    { 59, "Емельянов Пром" },
                    { 60, "Морозов - Третьяков" },
                    { 61, "Мартынова - Буров" },
                    { 62, "Евсеева - Зуева" },
                    { 63, "Колобов Торг" },
                    { 64, "Меркушева - Тетерина" },
                    { 65, "Данилов, Орлова and Ильин" },
                    { 66, "Потапова Сбыт" },
                    { 67, "Кулагина Торг" },
                    { 68, "Михеев, Кулакова and Блинова" },
                    { 69, "Титов, Гурьев and Гаврилова" },
                    { 70, "Тарасов - Суворова" },
                    { 71, "Кузнецов, Мартынова and Агафонова" },
                    { 72, "Капустин Пром" },
                    { 73, "Чернов, Григорьев and Власова" },
                    { 74, "Зиновьев, Селезнева and Колобова" },
                    { 75, "Вишняков - Боброва" },
                    { 76, "Мамонтов - Исакова" },
                    { 77, "Исаева - Белоусов" },
                    { 78, "Носкова, Кабанов and Жданова" },
                    { 79, "Молчанова - Логинова" },
                    { 80, "Новиков Торг" },
                    { 81, "Николаев - Савин" },
                    { 82, "Герасимов Торг" },
                    { 83, "Селезнева, Ермаков and Галкина" },
                    { 84, "Лукин, Зуева and Селезнев" },
                    { 85, "Гордеев, Шашков and Щукина" },
                    { 86, "Лебедев - Ширяева" },
                    { 87, "Яковлев Сбыт" },
                    { 88, "Сорокина Торг" },
                    { 89, "Сергеева - Сергеев" },
                    { 90, "Коновалова Пром" },
                    { 91, "Абрамов Снаб" },
                    { 92, "Никитина Сбыт" },
                    { 93, "Носков - Кузьмина" },
                    { 94, "Копылова - Уваров" },
                    { 95, "Егорова - Чернова" },
                    { 96, "Ершов, Ефремова and Зиновьев" },
                    { 97, "Федосеева Сбыт" },
                    { 98, "Сорокин, Воробьева and Ларионова" },
                    { 99, "Андреев - Лобанова" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_Number_ProviderId",
                table: "Order",
                columns: new[] { "Number", "ProviderId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Order_ProviderId",
                table: "Order",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Provider");
        }
    }
}
