﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProviderId");

                    b.HasIndex("Number", "ProviderId")
                        .IsUnique();

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Domain.Entities.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("Domain.Entities.Provider", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Provider");

                    b.HasData(
                        new
                        {
                            Id = 0,
                            Name = "Константинова Пром"
                        },
                        new
                        {
                            Id = 1,
                            Name = "Артемьева, Богданова and Мартынов"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Кондратьев Торг"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Брагина Снаб"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Артемьева Трейд"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Юдина Трейд"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Веселов - Суханов"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Ильина, Попов and Фокина"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Пестова - Игнатова"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Ситникова - Бобров"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Шарова, Поляков and Тетерина"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Суворова Пром"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Ефремова Снаб"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Зимина, Лыткина and Тарасов"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Хохлов - Петухова"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Громова, Богданова and Корнилов"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Копылов - Богданов"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Кулагина - Петухов"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Кудряшов Торг"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Дементьева Трейд"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Доронина, Кошелева and Елисеев"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Афанасьев Торг"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Новиков Трейд"
                        },
                        new
                        {
                            Id = 23,
                            Name = "Королев - Сорокин"
                        },
                        new
                        {
                            Id = 24,
                            Name = "Беляева Снаб"
                        },
                        new
                        {
                            Id = 25,
                            Name = "Маслов Пром"
                        },
                        new
                        {
                            Id = 26,
                            Name = "Гуляев Снаб"
                        },
                        new
                        {
                            Id = 27,
                            Name = "Гаврилова, Нестерова and Белоусов"
                        },
                        new
                        {
                            Id = 28,
                            Name = "Максимов, Красильникова and Быкова"
                        },
                        new
                        {
                            Id = 29,
                            Name = "Кудряшов Торг"
                        },
                        new
                        {
                            Id = 30,
                            Name = "Некрасов, Яковлев and Котов"
                        },
                        new
                        {
                            Id = 31,
                            Name = "Красильникова - Силин"
                        },
                        new
                        {
                            Id = 32,
                            Name = "Веселов - Брагина"
                        },
                        new
                        {
                            Id = 33,
                            Name = "Копылов, Кононова and Фадеева"
                        },
                        new
                        {
                            Id = 34,
                            Name = "Фокина - Максимов"
                        },
                        new
                        {
                            Id = 35,
                            Name = "Казакова - Калашникова"
                        },
                        new
                        {
                            Id = 36,
                            Name = "Лаврентьев Трейд"
                        },
                        new
                        {
                            Id = 37,
                            Name = "Баранов Трейд"
                        },
                        new
                        {
                            Id = 38,
                            Name = "Жданова, Архипова and Блинова"
                        },
                        new
                        {
                            Id = 39,
                            Name = "Данилов, Ларионов and Шилов"
                        },
                        new
                        {
                            Id = 40,
                            Name = "Фокина Снаб"
                        },
                        new
                        {
                            Id = 41,
                            Name = "Андреева, Медведев and Никифорова"
                        },
                        new
                        {
                            Id = 42,
                            Name = "Петрова, Кудрявцев and Юдин"
                        },
                        new
                        {
                            Id = 43,
                            Name = "Иванов Торг"
                        },
                        new
                        {
                            Id = 44,
                            Name = "Суворова, Владимиров and Панов"
                        },
                        new
                        {
                            Id = 45,
                            Name = "Попова, Суханов and Шилов"
                        },
                        new
                        {
                            Id = 46,
                            Name = "Лаврентьева Трейд"
                        },
                        new
                        {
                            Id = 47,
                            Name = "Павлова, Дьячков and Федотов"
                        },
                        new
                        {
                            Id = 48,
                            Name = "Сысоева - Родионова"
                        },
                        new
                        {
                            Id = 49,
                            Name = "Елисеева, Евсеев and Медведева"
                        },
                        new
                        {
                            Id = 50,
                            Name = "Белякова, Кириллова and Степанов"
                        },
                        new
                        {
                            Id = 51,
                            Name = "Белова Торг"
                        },
                        new
                        {
                            Id = 52,
                            Name = "Большакова, Горшкова and Игнатьев"
                        },
                        new
                        {
                            Id = 53,
                            Name = "Козлова Снаб"
                        },
                        new
                        {
                            Id = 54,
                            Name = "Алексеев, Михеев and Родионова"
                        },
                        new
                        {
                            Id = 55,
                            Name = "Доронин - Нестерова"
                        },
                        new
                        {
                            Id = 56,
                            Name = "Коновалов, Молчанов and Поляков"
                        },
                        new
                        {
                            Id = 57,
                            Name = "Князев - Кузьмин"
                        },
                        new
                        {
                            Id = 58,
                            Name = "Меркушев Пром"
                        },
                        new
                        {
                            Id = 59,
                            Name = "Федотов Трейд"
                        },
                        new
                        {
                            Id = 60,
                            Name = "Матвеев Торг"
                        },
                        new
                        {
                            Id = 61,
                            Name = "Федотова, Гордеева and Зиновьева"
                        },
                        new
                        {
                            Id = 62,
                            Name = "Меркушев - Осипова"
                        },
                        new
                        {
                            Id = 63,
                            Name = "Дорофеев, Киселев and Цветков"
                        },
                        new
                        {
                            Id = 64,
                            Name = "Дьячков - Баранова"
                        },
                        new
                        {
                            Id = 65,
                            Name = "Гусева - Трофимова"
                        },
                        new
                        {
                            Id = 66,
                            Name = "Белоусова, Егоров and Никитина"
                        },
                        new
                        {
                            Id = 67,
                            Name = "Волков - Шестаков"
                        },
                        new
                        {
                            Id = 68,
                            Name = "Мясникова, Новикова and Быкова"
                        },
                        new
                        {
                            Id = 69,
                            Name = "Елисеев, Красильников and Бобылев"
                        },
                        new
                        {
                            Id = 70,
                            Name = "Белозеров Торг"
                        },
                        new
                        {
                            Id = 71,
                            Name = "Жданов Сбыт"
                        },
                        new
                        {
                            Id = 72,
                            Name = "Суворов Снаб"
                        },
                        new
                        {
                            Id = 73,
                            Name = "Гурьев, Рогов and Дьячкова"
                        },
                        new
                        {
                            Id = 74,
                            Name = "Антонов, Симонов and Костин"
                        },
                        new
                        {
                            Id = 75,
                            Name = "Сорокин Торг"
                        },
                        new
                        {
                            Id = 76,
                            Name = "Рожков Сбыт"
                        },
                        new
                        {
                            Id = 77,
                            Name = "Калинин, Кононова and Панов"
                        },
                        new
                        {
                            Id = 78,
                            Name = "Лыткин - Фомин"
                        },
                        new
                        {
                            Id = 79,
                            Name = "Рожкова - Воронова"
                        },
                        new
                        {
                            Id = 80,
                            Name = "Орлов - Петухов"
                        },
                        new
                        {
                            Id = 81,
                            Name = "Шилов, Блохин and Филатова"
                        },
                        new
                        {
                            Id = 82,
                            Name = "Лебедев, Наумова and Макарова"
                        },
                        new
                        {
                            Id = 83,
                            Name = "Симонова - Родионов"
                        },
                        new
                        {
                            Id = 84,
                            Name = "Юдина - Шарова"
                        },
                        new
                        {
                            Id = 85,
                            Name = "Горбунова, Новикова and Титова"
                        },
                        new
                        {
                            Id = 86,
                            Name = "Мартынов Торг"
                        },
                        new
                        {
                            Id = 87,
                            Name = "Шарапова, Яковлев and Лобанова"
                        },
                        new
                        {
                            Id = 88,
                            Name = "Федосеев, Нестерова and Тетерина"
                        },
                        new
                        {
                            Id = 89,
                            Name = "Евдокимова Трейд"
                        },
                        new
                        {
                            Id = 90,
                            Name = "Тетерин Трейд"
                        },
                        new
                        {
                            Id = 91,
                            Name = "Кононова Торг"
                        },
                        new
                        {
                            Id = 92,
                            Name = "Евсеев - Боброва"
                        },
                        new
                        {
                            Id = 93,
                            Name = "Федорова Пром"
                        },
                        new
                        {
                            Id = 94,
                            Name = "Никонов Трейд"
                        },
                        new
                        {
                            Id = 95,
                            Name = "Елисеева, Буров and Виноградова"
                        },
                        new
                        {
                            Id = 96,
                            Name = "Ситников Снаб"
                        },
                        new
                        {
                            Id = 97,
                            Name = "Костина, Котова and Соколова"
                        },
                        new
                        {
                            Id = 98,
                            Name = "Ефимова, Ларионов and Денисов"
                        },
                        new
                        {
                            Id = 99,
                            Name = "Савельева - Волкова"
                        });
                });

            modelBuilder.Entity("Domain.Entities.Order", b =>
                {
                    b.HasOne("Domain.Entities.Provider", "Provider")
                        .WithMany()
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Provider");
                });

            modelBuilder.Entity("Domain.Entities.OrderItem", b =>
                {
                    b.HasOne("Domain.Entities.Order", null)
                        .WithMany("Items")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Order", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
