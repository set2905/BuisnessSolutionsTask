using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class _seedProviders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Provider",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 0, "Константинова Пром" },
                    { 1, "Артемьева, Богданова and Мартынов" },
                    { 2, "Кондратьев Торг" },
                    { 3, "Брагина Снаб" },
                    { 4, "Артемьева Трейд" },
                    { 5, "Юдина Трейд" },
                    { 6, "Веселов - Суханов" },
                    { 7, "Ильина, Попов and Фокина" },
                    { 8, "Пестова - Игнатова" },
                    { 9, "Ситникова - Бобров" },
                    { 10, "Шарова, Поляков and Тетерина" },
                    { 11, "Суворова Пром" },
                    { 12, "Ефремова Снаб" },
                    { 13, "Зимина, Лыткина and Тарасов" },
                    { 14, "Хохлов - Петухова" },
                    { 15, "Громова, Богданова and Корнилов" },
                    { 16, "Копылов - Богданов" },
                    { 17, "Кулагина - Петухов" },
                    { 18, "Кудряшов Торг" },
                    { 19, "Дементьева Трейд" },
                    { 20, "Доронина, Кошелева and Елисеев" },
                    { 21, "Афанасьев Торг" },
                    { 22, "Новиков Трейд" },
                    { 23, "Королев - Сорокин" },
                    { 24, "Беляева Снаб" },
                    { 25, "Маслов Пром" },
                    { 26, "Гуляев Снаб" },
                    { 27, "Гаврилова, Нестерова and Белоусов" },
                    { 28, "Максимов, Красильникова and Быкова" },
                    { 29, "Кудряшов Торг" },
                    { 30, "Некрасов, Яковлев and Котов" },
                    { 31, "Красильникова - Силин" },
                    { 32, "Веселов - Брагина" },
                    { 33, "Копылов, Кононова and Фадеева" },
                    { 34, "Фокина - Максимов" },
                    { 35, "Казакова - Калашникова" },
                    { 36, "Лаврентьев Трейд" },
                    { 37, "Баранов Трейд" },
                    { 38, "Жданова, Архипова and Блинова" },
                    { 39, "Данилов, Ларионов and Шилов" },
                    { 40, "Фокина Снаб" },
                    { 41, "Андреева, Медведев and Никифорова" },
                    { 42, "Петрова, Кудрявцев and Юдин" },
                    { 43, "Иванов Торг" },
                    { 44, "Суворова, Владимиров and Панов" },
                    { 45, "Попова, Суханов and Шилов" },
                    { 46, "Лаврентьева Трейд" },
                    { 47, "Павлова, Дьячков and Федотов" },
                    { 48, "Сысоева - Родионова" },
                    { 49, "Елисеева, Евсеев and Медведева" },
                    { 50, "Белякова, Кириллова and Степанов" },
                    { 51, "Белова Торг" },
                    { 52, "Большакова, Горшкова and Игнатьев" },
                    { 53, "Козлова Снаб" },
                    { 54, "Алексеев, Михеев and Родионова" },
                    { 55, "Доронин - Нестерова" },
                    { 56, "Коновалов, Молчанов and Поляков" },
                    { 57, "Князев - Кузьмин" },
                    { 58, "Меркушев Пром" },
                    { 59, "Федотов Трейд" },
                    { 60, "Матвеев Торг" },
                    { 61, "Федотова, Гордеева and Зиновьева" },
                    { 62, "Меркушев - Осипова" },
                    { 63, "Дорофеев, Киселев and Цветков" },
                    { 64, "Дьячков - Баранова" },
                    { 65, "Гусева - Трофимова" },
                    { 66, "Белоусова, Егоров and Никитина" },
                    { 67, "Волков - Шестаков" },
                    { 68, "Мясникова, Новикова and Быкова" },
                    { 69, "Елисеев, Красильников and Бобылев" },
                    { 70, "Белозеров Торг" },
                    { 71, "Жданов Сбыт" },
                    { 72, "Суворов Снаб" },
                    { 73, "Гурьев, Рогов and Дьячкова" },
                    { 74, "Антонов, Симонов and Костин" },
                    { 75, "Сорокин Торг" },
                    { 76, "Рожков Сбыт" },
                    { 77, "Калинин, Кононова and Панов" },
                    { 78, "Лыткин - Фомин" },
                    { 79, "Рожкова - Воронова" },
                    { 80, "Орлов - Петухов" },
                    { 81, "Шилов, Блохин and Филатова" },
                    { 82, "Лебедев, Наумова and Макарова" },
                    { 83, "Симонова - Родионов" },
                    { 84, "Юдина - Шарова" },
                    { 85, "Горбунова, Новикова and Титова" },
                    { 86, "Мартынов Торг" },
                    { 87, "Шарапова, Яковлев and Лобанова" },
                    { 88, "Федосеев, Нестерова and Тетерина" },
                    { 89, "Евдокимова Трейд" },
                    { 90, "Тетерин Трейд" },
                    { 91, "Кононова Торг" },
                    { 92, "Евсеев - Боброва" },
                    { 93, "Федорова Пром" },
                    { 94, "Никонов Трейд" },
                    { 95, "Елисеева, Буров and Виноградова" },
                    { 96, "Ситников Снаб" },
                    { 97, "Костина, Котова and Соколова" },
                    { 98, "Ефимова, Ларионов and Денисов" },
                    { 99, "Савельева - Волкова" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 0);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Provider",
                keyColumn: "Id",
                keyValue: 99);
        }
    }
}
