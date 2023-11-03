﻿// <auto-generated />
using System;
using BankManagment_Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BankManagment_Migration.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BankManagment_Domain.Entity.AccountType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AccountTypes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("507cbf03-829b-488b-97b1-f237ea31a43f"),
                            Name = "Liability"
                        },
                        new
                        {
                            Id = new Guid("79605657-382b-4be2-9d70-687d9ab23123"),
                            Name = "Asset"
                        });
                });

            modelBuilder.Entity("BankManagment_Domain.Entity.BankAccount", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("AccountTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ClosingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OpeningDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalBalance")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("AccountTypeId");

                    b.ToTable("BankAccounts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1d94c74c-9794-40ca-8a43-6a465c6c16ff"),
                            AccountNumber = "98151379",
                            AccountTypeId = new Guid("79605657-382b-4be2-9d70-687d9ab23123"),
                            FirstName = "Akash",
                            LastName = "Rana",
                            OpeningDate = new DateTime(2023, 11, 3, 11, 26, 17, 605, DateTimeKind.Local).AddTicks(6445),
                            TotalBalance = 1000m
                        },
                        new
                        {
                            Id = new Guid("7027972d-4e89-4feb-8d4e-56b24dce32e2"),
                            AccountNumber = "20011388",
                            AccountTypeId = new Guid("507cbf03-829b-488b-97b1-f237ea31a43f"),
                            FirstName = "Akash",
                            LastName = "Rana",
                            OpeningDate = new DateTime(2023, 11, 2, 11, 26, 17, 605, DateTimeKind.Local).AddTicks(6473),
                            TotalBalance = 1000m
                        },
                        new
                        {
                            Id = new Guid("e6cc0556-98fb-460e-a11d-0ec930fa5835"),
                            AccountNumber = "81906010",
                            AccountTypeId = new Guid("507cbf03-829b-488b-97b1-f237ea31a43f"),
                            FirstName = "Akash",
                            LastName = "Rana",
                            OpeningDate = new DateTime(2023, 11, 1, 11, 26, 17, 605, DateTimeKind.Local).AddTicks(6477),
                            TotalBalance = 1000m
                        },
                        new
                        {
                            Id = new Guid("010315fd-a567-4abd-a4b0-f73431454f4f"),
                            AccountNumber = "93300357",
                            AccountTypeId = new Guid("79605657-382b-4be2-9d70-687d9ab23123"),
                            FirstName = "Akash",
                            LastName = "Rana",
                            OpeningDate = new DateTime(2023, 10, 31, 11, 26, 17, 605, DateTimeKind.Local).AddTicks(6481),
                            TotalBalance = 1000m
                        },
                        new
                        {
                            Id = new Guid("5d096aa8-d3f8-40a0-9fdf-9bfc0be93d5f"),
                            AccountNumber = "51863866",
                            AccountTypeId = new Guid("79605657-382b-4be2-9d70-687d9ab23123"),
                            FirstName = "Akash",
                            LastName = "Rana",
                            OpeningDate = new DateTime(2023, 10, 30, 11, 26, 17, 605, DateTimeKind.Local).AddTicks(6488),
                            TotalBalance = 1000m
                        });
                });

            modelBuilder.Entity("BankManagment_Domain.Entity.BankTransaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("BankAccountID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PaymentMethodID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TransactionPersonFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransactionPersonLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransactionPersonMiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransactionType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BankAccountID");

                    b.HasIndex("PaymentMethodID");

                    b.ToTable("BankTransactions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3918570a-fd49-42e7-a754-426de2a76afc"),
                            Amount = 843.717140581565000m,
                            BankAccountID = new Guid("1d94c74c-9794-40ca-8a43-6a465c6c16ff"),
                            Category = "Bank Charges",
                            PaymentMethodID = new Guid("480ee408-ddcb-4c46-87a3-be057376723e"),
                            TransactionDate = new DateTime(2023, 11, 3, 11, 26, 17, 605, DateTimeKind.Local).AddTicks(6665),
                            TransactionPersonFirstName = "Akash",
                            TransactionPersonLastName = "Rana",
                            TransactionType = "Credit"
                        },
                        new
                        {
                            Id = new Guid("9482873a-02ee-4407-b3e6-e71e916c712a"),
                            Amount = 433.23440167249000m,
                            BankAccountID = new Guid("5d096aa8-d3f8-40a0-9fdf-9bfc0be93d5f"),
                            Category = "Opening Balance",
                            PaymentMethodID = new Guid("0bf38f97-3634-424a-ada8-5e94acbb27bc"),
                            TransactionDate = new DateTime(2023, 11, 2, 11, 26, 17, 605, DateTimeKind.Local).AddTicks(6671),
                            TransactionPersonFirstName = "Akash",
                            TransactionPersonLastName = "Rana",
                            TransactionType = "Debit"
                        },
                        new
                        {
                            Id = new Guid("7a1d7970-2cb4-4e41-81fe-d359df2b4c02"),
                            Amount = 34.8647367220243000m,
                            BankAccountID = new Guid("1d94c74c-9794-40ca-8a43-6a465c6c16ff"),
                            Category = "Bank Interest",
                            PaymentMethodID = new Guid("cf9b49e9-6372-4989-a732-bfa6ac5a3c03"),
                            TransactionDate = new DateTime(2023, 11, 1, 11, 26, 17, 605, DateTimeKind.Local).AddTicks(6674),
                            TransactionPersonFirstName = "Akash",
                            TransactionPersonLastName = "Rana",
                            TransactionType = "Credit"
                        },
                        new
                        {
                            Id = new Guid("b3283467-4c39-4b6c-af4f-f0aacbfef3d6"),
                            Amount = 841.705131144781000m,
                            BankAccountID = new Guid("010315fd-a567-4abd-a4b0-f73431454f4f"),
                            Category = "Normal Transactions",
                            PaymentMethodID = new Guid("f4cffe7d-869c-44c9-86c5-0aec1ad30ef1"),
                            TransactionDate = new DateTime(2023, 10, 31, 11, 26, 17, 605, DateTimeKind.Local).AddTicks(6681),
                            TransactionPersonFirstName = "Akash",
                            TransactionPersonLastName = "Rana",
                            TransactionType = "Debit"
                        },
                        new
                        {
                            Id = new Guid("43606249-3139-45d0-b3d0-3f48dc0cb514"),
                            Amount = 921.384731920803000m,
                            BankAccountID = new Guid("1d94c74c-9794-40ca-8a43-6a465c6c16ff"),
                            Category = "Bank Interest",
                            PaymentMethodID = new Guid("f4cffe7d-869c-44c9-86c5-0aec1ad30ef1"),
                            TransactionDate = new DateTime(2023, 10, 30, 11, 26, 17, 605, DateTimeKind.Local).AddTicks(6684),
                            TransactionPersonFirstName = "Akash",
                            TransactionPersonLastName = "Rana",
                            TransactionType = "Credit"
                        });
                });

            modelBuilder.Entity("BankManagment_Domain.Entity.PaymentMethod", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PaymentMethods");

                    b.HasData(
                        new
                        {
                            Id = new Guid("480ee408-ddcb-4c46-87a3-be057376723e"),
                            Name = "Cash"
                        },
                        new
                        {
                            Id = new Guid("0bf38f97-3634-424a-ada8-5e94acbb27bc"),
                            Name = "Cheque"
                        },
                        new
                        {
                            Id = new Guid("cf9b49e9-6372-4989-a732-bfa6ac5a3c03"),
                            Name = "NEFT"
                        },
                        new
                        {
                            Id = new Guid("933e1a20-e086-4c4b-910f-a8fc17f6751b"),
                            Name = "RTGS"
                        },
                        new
                        {
                            Id = new Guid("f4cffe7d-869c-44c9-86c5-0aec1ad30ef1"),
                            Name = "Other"
                        });
                });

            modelBuilder.Entity("BankManagment_Domain.Entity.BankAccount", b =>
                {
                    b.HasOne("BankManagment_Domain.Entity.AccountType", "AccountType")
                        .WithMany()
                        .HasForeignKey("AccountTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountType");
                });

            modelBuilder.Entity("BankManagment_Domain.Entity.BankTransaction", b =>
                {
                    b.HasOne("BankManagment_Domain.Entity.BankAccount", "BankAccount")
                        .WithMany()
                        .HasForeignKey("BankAccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BankManagment_Domain.Entity.PaymentMethod", "PaymentMethod")
                        .WithMany()
                        .HasForeignKey("PaymentMethodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BankAccount");

                    b.Navigation("PaymentMethod");
                });
#pragma warning restore 612, 618
        }
    }
}
