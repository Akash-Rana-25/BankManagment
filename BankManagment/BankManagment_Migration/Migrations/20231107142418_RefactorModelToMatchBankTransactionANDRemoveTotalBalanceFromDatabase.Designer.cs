﻿// <auto-generated />
using System;
using BankManagment_Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BankManagment_Migration.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231107142418_RefactorModelToMatchBankTransactionANDRemoveTotalBalanceFromDatabase")]
    partial class RefactorModelToMatchBankTransactionANDRemoveTotalBalanceFromDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("24368cc0-0daf-40e6-8bb7-f11df234da5b"),
                            Name = "Liability"
                        },
                        new
                        {
                            Id = new Guid("b44fc92a-c2e3-4a10-8f89-df9664784d2e"),
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

                    b.HasKey("Id");

                    b.HasIndex("AccountTypeId");

                    b.ToTable("BankAccounts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6ed5447c-4778-4a43-8d8e-deeed84acb93"),
                            AccountNumber = "76734846",
                            AccountTypeId = new Guid("24368cc0-0daf-40e6-8bb7-f11df234da5b"),
                            FirstName = "Akash",
                            LastName = "Rana",
                            OpeningDate = new DateTime(2023, 11, 7, 19, 54, 17, 737, DateTimeKind.Local).AddTicks(3645)
                        },
                        new
                        {
                            Id = new Guid("276fbd82-5369-43e3-b5cf-26eefabebbee"),
                            AccountNumber = "92606112",
                            AccountTypeId = new Guid("24368cc0-0daf-40e6-8bb7-f11df234da5b"),
                            FirstName = "Akash",
                            LastName = "Rana",
                            OpeningDate = new DateTime(2023, 11, 6, 19, 54, 17, 737, DateTimeKind.Local).AddTicks(3667)
                        },
                        new
                        {
                            Id = new Guid("dfea66a1-d998-4c06-b1b2-aeca7b5dc97b"),
                            AccountNumber = "83929158",
                            AccountTypeId = new Guid("b44fc92a-c2e3-4a10-8f89-df9664784d2e"),
                            FirstName = "Akash",
                            LastName = "Rana",
                            OpeningDate = new DateTime(2023, 11, 5, 19, 54, 17, 737, DateTimeKind.Local).AddTicks(3675)
                        },
                        new
                        {
                            Id = new Guid("50ac678c-6afd-4ab9-9e11-a3afde713b36"),
                            AccountNumber = "76226526",
                            AccountTypeId = new Guid("24368cc0-0daf-40e6-8bb7-f11df234da5b"),
                            FirstName = "Akash",
                            LastName = "Rana",
                            OpeningDate = new DateTime(2023, 11, 4, 19, 54, 17, 737, DateTimeKind.Local).AddTicks(3678)
                        },
                        new
                        {
                            Id = new Guid("4cd608bf-c842-4bdd-b2a3-aac994b939c9"),
                            AccountNumber = "62533098",
                            AccountTypeId = new Guid("24368cc0-0daf-40e6-8bb7-f11df234da5b"),
                            FirstName = "Akash",
                            LastName = "Rana",
                            OpeningDate = new DateTime(2023, 11, 3, 19, 54, 17, 737, DateTimeKind.Local).AddTicks(3685)
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
                            Id = new Guid("46f2cf68-512b-45d2-831a-fb014e05190c"),
                            Amount = 923.769672392775000m,
                            BankAccountID = new Guid("276fbd82-5369-43e3-b5cf-26eefabebbee"),
                            Category = "Normal Transactions",
                            PaymentMethodID = new Guid("1aa80f7c-98a7-4c63-acb2-f86a62e74b34"),
                            TransactionDate = new DateTime(2023, 11, 7, 19, 54, 17, 737, DateTimeKind.Local).AddTicks(3853),
                            TransactionPersonFirstName = "Akash",
                            TransactionPersonLastName = "Rana",
                            TransactionType = "Credit"
                        },
                        new
                        {
                            Id = new Guid("77813e47-7c0a-49c8-92a9-35186cd62c77"),
                            Amount = 810.383424071375000m,
                            BankAccountID = new Guid("4cd608bf-c842-4bdd-b2a3-aac994b939c9"),
                            Category = "Bank Charges",
                            PaymentMethodID = new Guid("6d3fab18-e05d-4902-9aab-dc1714c6fc32"),
                            TransactionDate = new DateTime(2023, 11, 6, 19, 54, 17, 737, DateTimeKind.Local).AddTicks(3921),
                            TransactionPersonFirstName = "Akash",
                            TransactionPersonLastName = "Rana",
                            TransactionType = "Debit"
                        },
                        new
                        {
                            Id = new Guid("9411638d-c313-476d-af6a-bffe066386ba"),
                            Amount = 342.930677230827000m,
                            BankAccountID = new Guid("276fbd82-5369-43e3-b5cf-26eefabebbee"),
                            Category = "Bank Interest",
                            PaymentMethodID = new Guid("6d3fab18-e05d-4902-9aab-dc1714c6fc32"),
                            TransactionDate = new DateTime(2023, 11, 5, 19, 54, 17, 737, DateTimeKind.Local).AddTicks(3926),
                            TransactionPersonFirstName = "Akash",
                            TransactionPersonLastName = "Rana",
                            TransactionType = "Credit"
                        },
                        new
                        {
                            Id = new Guid("cefe1b5a-fcc7-43da-92cd-bf60594954a6"),
                            Amount = 449.552452320298000m,
                            BankAccountID = new Guid("276fbd82-5369-43e3-b5cf-26eefabebbee"),
                            Category = "Opening Balance",
                            PaymentMethodID = new Guid("6d3fab18-e05d-4902-9aab-dc1714c6fc32"),
                            TransactionDate = new DateTime(2023, 11, 4, 19, 54, 17, 737, DateTimeKind.Local).AddTicks(3930),
                            TransactionPersonFirstName = "Akash",
                            TransactionPersonLastName = "Rana",
                            TransactionType = "Debit"
                        },
                        new
                        {
                            Id = new Guid("bd637b21-62fc-4c4f-8052-032e860ed3f9"),
                            Amount = 678.691591321751000m,
                            BankAccountID = new Guid("6ed5447c-4778-4a43-8d8e-deeed84acb93"),
                            Category = "Bank Charges",
                            PaymentMethodID = new Guid("d2dbcb54-1ab7-4baf-bb80-fc86aab809b2"),
                            TransactionDate = new DateTime(2023, 11, 3, 19, 54, 17, 737, DateTimeKind.Local).AddTicks(3933),
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
                            Id = new Guid("d2dbcb54-1ab7-4baf-bb80-fc86aab809b2"),
                            Name = "Cash"
                        },
                        new
                        {
                            Id = new Guid("1aa80f7c-98a7-4c63-acb2-f86a62e74b34"),
                            Name = "Cheque"
                        },
                        new
                        {
                            Id = new Guid("4b4f240e-4298-44f9-9fba-3a6d0459ac26"),
                            Name = "NEFT"
                        },
                        new
                        {
                            Id = new Guid("6d3fab18-e05d-4902-9aab-dc1714c6fc32"),
                            Name = "RTGS"
                        },
                        new
                        {
                            Id = new Guid("fd65ea46-bfd2-4b58-ad05-83303ad1d71a"),
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
