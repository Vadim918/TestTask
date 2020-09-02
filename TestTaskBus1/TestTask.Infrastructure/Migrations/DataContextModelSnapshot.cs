﻿// <auto-generated />

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace TestTask.Infrastructure.Migrations
{
    [DbContext(typeof(DataContext))]
    internal class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TestTask.Core.Entities.Main", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("char(36)");

                b.Property<int>("Count")
                    .HasColumnType("int");

                b.Property<DateTime>("Date")
                    .HasColumnType("date");

                b.Property<string>("EditableUrl")
                    .IsRequired()
                    .HasColumnType("varchar(500) CHARACTER SET utf8mb4")
                    .HasMaxLength(500);

                b.Property<string>("LongUrl")
                    .IsRequired()
                    .HasColumnType("varchar(1024) CHARACTER SET utf8mb4")
                    .HasMaxLength(1024);

                b.HasKey("Id");

                b.ToTable("Main");

                b.HasData(
                    new
                    {
                        Id = new Guid("716c2e99-6f6c-4472-81a5-43c56e11637c"),
                        Count = 0,
                        Date = new DateTime(2020, 9, 2, 0, 0, 0, 0, DateTimeKind.Local),
                        EditableUrl = "https://bit.ly/3b2lFle",
                        LongUrl = "https://www.instagram.com/zab.91/"
                    },
                    new
                    {
                        Id = new Guid("bfcbbec9-0023-4a6f-b466-a099f11f3b09"),
                        Count = 0,
                        Date = new DateTime(2020, 9, 2, 0, 0, 0, 0, DateTimeKind.Local),
                        EditableUrl = "https://cutt.ly/dfzomFL",
                        LongUrl = "https://github.com/Vadim918"
                    },
                    new
                    {
                        Id = new Guid("f7e42b20-9f4f-44ff-a7e3-c65c4772b308"),
                        Count = 0,
                        Date = new DateTime(2020, 9, 2, 0, 0, 0, 0, DateTimeKind.Local),
                        EditableUrl = "https://cutt.ly/7fzoZjB",
                        LongUrl = "https://metanit.com/sharp/aspnet5/1.1.php"
                    });
            });
#pragma warning restore 612, 618
        }
    }
}