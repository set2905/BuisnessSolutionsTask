﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231120111341__init")]
    partial class _init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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
                            Name = "Волкова, Силина and Аксенов"
                        },
                        new
                        {
                            Id = 1,
                            Name = "Моисеев - Никитин"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Фролов - Филиппов"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Захарова, Белоусова and Тимофеева"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Богданов, Дьячкова and Суворова"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Фокина, Федорова and Рыбакова"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Игнатова Трейд"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Захарова, Виноградов and Потапова"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Афанасьев, Блинова and Иванова"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Дмитриева - Баранова"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Кузнецов Пром"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Дементьев, Орехов and Ершова"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Шарова Торг"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Агафонова Торг"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Дементьева, Иванова and Жданов"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Козлов Пром"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Бобров, Фролов and Максимова"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Константинова - Белова"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Калинина Сбыт"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Никонова, Ситников and Веселова"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Игнатьев, Рыбакова and Козлов"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Сидорова, Юдин and Лапина"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Силин, Александров and Васильева"
                        },
                        new
                        {
                            Id = 23,
                            Name = "Жуков Сбыт"
                        },
                        new
                        {
                            Id = 24,
                            Name = "Беспалов - Козлов"
                        },
                        new
                        {
                            Id = 25,
                            Name = "Новиков - Сорокина"
                        },
                        new
                        {
                            Id = 26,
                            Name = "Волкова, Фадеева and Казакова"
                        },
                        new
                        {
                            Id = 27,
                            Name = "Жукова, Шарова and Кириллова"
                        },
                        new
                        {
                            Id = 28,
                            Name = "Муравьева, Лебедева and Кудрявцева"
                        },
                        new
                        {
                            Id = 29,
                            Name = "Воронцова, Овчинникова and Петухов"
                        },
                        new
                        {
                            Id = 30,
                            Name = "Селиверстова Пром"
                        },
                        new
                        {
                            Id = 31,
                            Name = "Аксенов - Кулакова"
                        },
                        new
                        {
                            Id = 32,
                            Name = "Князев Пром"
                        },
                        new
                        {
                            Id = 33,
                            Name = "Сидоров - Ершова"
                        },
                        new
                        {
                            Id = 34,
                            Name = "Доронин - Савин"
                        },
                        new
                        {
                            Id = 35,
                            Name = "Жуков - Наумов"
                        },
                        new
                        {
                            Id = 36,
                            Name = "Гущина Торг"
                        },
                        new
                        {
                            Id = 37,
                            Name = "Некрасова - Ефремова"
                        },
                        new
                        {
                            Id = 38,
                            Name = "Богданов, Борисова and Павлова"
                        },
                        new
                        {
                            Id = 39,
                            Name = "Дементьева - Борисова"
                        },
                        new
                        {
                            Id = 40,
                            Name = "Панфилов - Игнатова"
                        },
                        new
                        {
                            Id = 41,
                            Name = "Терентьев - Чернова"
                        },
                        new
                        {
                            Id = 42,
                            Name = "Пахомова Пром"
                        },
                        new
                        {
                            Id = 43,
                            Name = "Корнилов Снаб"
                        },
                        new
                        {
                            Id = 44,
                            Name = "Ковалева - Михеев"
                        },
                        new
                        {
                            Id = 45,
                            Name = "Селезнев - Нестерова"
                        },
                        new
                        {
                            Id = 46,
                            Name = "Терентьева - Шашков"
                        },
                        new
                        {
                            Id = 47,
                            Name = "Ермакова, Денисова and Русаков"
                        },
                        new
                        {
                            Id = 48,
                            Name = "Александрова Снаб"
                        },
                        new
                        {
                            Id = 49,
                            Name = "Меркушев, Моисеева and Маслов"
                        },
                        new
                        {
                            Id = 50,
                            Name = "Кондратьева Трейд"
                        },
                        new
                        {
                            Id = 51,
                            Name = "Муравьева Сбыт"
                        },
                        new
                        {
                            Id = 52,
                            Name = "Морозов Снаб"
                        },
                        new
                        {
                            Id = 53,
                            Name = "Фролов - Мясникова"
                        },
                        new
                        {
                            Id = 54,
                            Name = "Носова, Воронцов and Новиков"
                        },
                        new
                        {
                            Id = 55,
                            Name = "Уваров - Никонов"
                        },
                        new
                        {
                            Id = 56,
                            Name = "Баранов Снаб"
                        },
                        new
                        {
                            Id = 57,
                            Name = "Иванов Торг"
                        },
                        new
                        {
                            Id = 58,
                            Name = "Ефимов - Афанасьева"
                        },
                        new
                        {
                            Id = 59,
                            Name = "Емельянов Пром"
                        },
                        new
                        {
                            Id = 60,
                            Name = "Морозов - Третьяков"
                        },
                        new
                        {
                            Id = 61,
                            Name = "Мартынова - Буров"
                        },
                        new
                        {
                            Id = 62,
                            Name = "Евсеева - Зуева"
                        },
                        new
                        {
                            Id = 63,
                            Name = "Колобов Торг"
                        },
                        new
                        {
                            Id = 64,
                            Name = "Меркушева - Тетерина"
                        },
                        new
                        {
                            Id = 65,
                            Name = "Данилов, Орлова and Ильин"
                        },
                        new
                        {
                            Id = 66,
                            Name = "Потапова Сбыт"
                        },
                        new
                        {
                            Id = 67,
                            Name = "Кулагина Торг"
                        },
                        new
                        {
                            Id = 68,
                            Name = "Михеев, Кулакова and Блинова"
                        },
                        new
                        {
                            Id = 69,
                            Name = "Титов, Гурьев and Гаврилова"
                        },
                        new
                        {
                            Id = 70,
                            Name = "Тарасов - Суворова"
                        },
                        new
                        {
                            Id = 71,
                            Name = "Кузнецов, Мартынова and Агафонова"
                        },
                        new
                        {
                            Id = 72,
                            Name = "Капустин Пром"
                        },
                        new
                        {
                            Id = 73,
                            Name = "Чернов, Григорьев and Власова"
                        },
                        new
                        {
                            Id = 74,
                            Name = "Зиновьев, Селезнева and Колобова"
                        },
                        new
                        {
                            Id = 75,
                            Name = "Вишняков - Боброва"
                        },
                        new
                        {
                            Id = 76,
                            Name = "Мамонтов - Исакова"
                        },
                        new
                        {
                            Id = 77,
                            Name = "Исаева - Белоусов"
                        },
                        new
                        {
                            Id = 78,
                            Name = "Носкова, Кабанов and Жданова"
                        },
                        new
                        {
                            Id = 79,
                            Name = "Молчанова - Логинова"
                        },
                        new
                        {
                            Id = 80,
                            Name = "Новиков Торг"
                        },
                        new
                        {
                            Id = 81,
                            Name = "Николаев - Савин"
                        },
                        new
                        {
                            Id = 82,
                            Name = "Герасимов Торг"
                        },
                        new
                        {
                            Id = 83,
                            Name = "Селезнева, Ермаков and Галкина"
                        },
                        new
                        {
                            Id = 84,
                            Name = "Лукин, Зуева and Селезнев"
                        },
                        new
                        {
                            Id = 85,
                            Name = "Гордеев, Шашков and Щукина"
                        },
                        new
                        {
                            Id = 86,
                            Name = "Лебедев - Ширяева"
                        },
                        new
                        {
                            Id = 87,
                            Name = "Яковлев Сбыт"
                        },
                        new
                        {
                            Id = 88,
                            Name = "Сорокина Торг"
                        },
                        new
                        {
                            Id = 89,
                            Name = "Сергеева - Сергеев"
                        },
                        new
                        {
                            Id = 90,
                            Name = "Коновалова Пром"
                        },
                        new
                        {
                            Id = 91,
                            Name = "Абрамов Снаб"
                        },
                        new
                        {
                            Id = 92,
                            Name = "Никитина Сбыт"
                        },
                        new
                        {
                            Id = 93,
                            Name = "Носков - Кузьмина"
                        },
                        new
                        {
                            Id = 94,
                            Name = "Копылова - Уваров"
                        },
                        new
                        {
                            Id = 95,
                            Name = "Егорова - Чернова"
                        },
                        new
                        {
                            Id = 96,
                            Name = "Ершов, Ефремова and Зиновьев"
                        },
                        new
                        {
                            Id = 97,
                            Name = "Федосеева Сбыт"
                        },
                        new
                        {
                            Id = 98,
                            Name = "Сорокин, Воробьева and Ларионова"
                        },
                        new
                        {
                            Id = 99,
                            Name = "Андреев - Лобанова"
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