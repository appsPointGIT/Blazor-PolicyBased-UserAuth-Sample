﻿// <auto-generated />
using BlazorAuthApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorAuthApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BlazorAuthApp.Models.Entities.UserAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("user_account");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Password = "user1",
                            UserName = "user1"
                        },
                        new
                        {
                            Id = 2,
                            Password = "user2",
                            UserName = "user2"
                        },
                        new
                        {
                            Id = 3,
                            Password = "user3",
                            UserName = "user3"
                        },
                        new
                        {
                            Id = 4,
                            Password = "user4",
                            UserName = "user4"
                        },
                        new
                        {
                            Id = 5,
                            Password = "user5",
                            UserName = "user5"
                        });
                });

            modelBuilder.Entity("BlazorAuthApp.Models.Entities.UserAccountPolicy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("UserAccountId")
                        .HasColumnType("int");

                    b.Property<string>("UserPolicy")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("user_account_policy");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsEnabled = true,
                            UserAccountId = 1,
                            UserPolicy = "VIEW_PRODUCT"
                        },
                        new
                        {
                            Id = 2,
                            IsEnabled = true,
                            UserAccountId = 1,
                            UserPolicy = "ADD_PRODUCT"
                        },
                        new
                        {
                            Id = 3,
                            IsEnabled = true,
                            UserAccountId = 1,
                            UserPolicy = "EDIT_PRODUCT"
                        },
                        new
                        {
                            Id = 4,
                            IsEnabled = true,
                            UserAccountId = 1,
                            UserPolicy = "DELETE_PRODUCT"
                        },
                        new
                        {
                            Id = 5,
                            IsEnabled = true,
                            UserAccountId = 2,
                            UserPolicy = "VIEW_PRODUCT"
                        },
                        new
                        {
                            Id = 6,
                            IsEnabled = false,
                            UserAccountId = 2,
                            UserPolicy = "ADD_PRODUCT"
                        },
                        new
                        {
                            Id = 7,
                            IsEnabled = false,
                            UserAccountId = 2,
                            UserPolicy = "EDIT_PRODUCT"
                        },
                        new
                        {
                            Id = 8,
                            IsEnabled = false,
                            UserAccountId = 2,
                            UserPolicy = "DELETE_PRODUCT"
                        },
                        new
                        {
                            Id = 9,
                            IsEnabled = true,
                            UserAccountId = 3,
                            UserPolicy = "VIEW_PRODUCT"
                        },
                        new
                        {
                            Id = 10,
                            IsEnabled = true,
                            UserAccountId = 3,
                            UserPolicy = "ADD_PRODUCT"
                        },
                        new
                        {
                            Id = 11,
                            IsEnabled = false,
                            UserAccountId = 3,
                            UserPolicy = "EDIT_PRODUCT"
                        },
                        new
                        {
                            Id = 12,
                            IsEnabled = false,
                            UserAccountId = 3,
                            UserPolicy = "DELETE_PRODUCT"
                        },
                        new
                        {
                            Id = 13,
                            IsEnabled = true,
                            UserAccountId = 4,
                            UserPolicy = "VIEW_PRODUCT"
                        },
                        new
                        {
                            Id = 14,
                            IsEnabled = true,
                            UserAccountId = 4,
                            UserPolicy = "ADD_PRODUCT"
                        },
                        new
                        {
                            Id = 15,
                            IsEnabled = true,
                            UserAccountId = 4,
                            UserPolicy = "EDIT_PRODUCT"
                        },
                        new
                        {
                            Id = 16,
                            IsEnabled = false,
                            UserAccountId = 4,
                            UserPolicy = "DELETE_PRODUCT"
                        },
                        new
                        {
                            Id = 17,
                            IsEnabled = false,
                            UserAccountId = 5,
                            UserPolicy = "VIEW_PRODUCT"
                        },
                        new
                        {
                            Id = 18,
                            IsEnabled = false,
                            UserAccountId = 5,
                            UserPolicy = "ADD_PRODUCT"
                        },
                        new
                        {
                            Id = 19,
                            IsEnabled = false,
                            UserAccountId = 5,
                            UserPolicy = "EDIT_PRODUCT"
                        },
                        new
                        {
                            Id = 20,
                            IsEnabled = false,
                            UserAccountId = 5,
                            UserPolicy = "DELETE_PRODUCT"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
