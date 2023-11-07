using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankManagment_Migration.Migrations
{
    public partial class RefactorModelToMatchBankTransactionANDRemoveTotalBalanceFromDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("7027972d-4e89-4feb-8d4e-56b24dce32e2"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("e6cc0556-98fb-460e-a11d-0ec930fa5835"));

            migrationBuilder.DeleteData(
                table: "BankTransactions",
                keyColumn: "Id",
                keyValue: new Guid("3918570a-fd49-42e7-a754-426de2a76afc"));

            migrationBuilder.DeleteData(
                table: "BankTransactions",
                keyColumn: "Id",
                keyValue: new Guid("43606249-3139-45d0-b3d0-3f48dc0cb514"));

            migrationBuilder.DeleteData(
                table: "BankTransactions",
                keyColumn: "Id",
                keyValue: new Guid("7a1d7970-2cb4-4e41-81fe-d359df2b4c02"));

            migrationBuilder.DeleteData(
                table: "BankTransactions",
                keyColumn: "Id",
                keyValue: new Guid("9482873a-02ee-4407-b3e6-e71e916c712a"));

            migrationBuilder.DeleteData(
                table: "BankTransactions",
                keyColumn: "Id",
                keyValue: new Guid("b3283467-4c39-4b6c-af4f-f0aacbfef3d6"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("933e1a20-e086-4c4b-910f-a8fc17f6751b"));

            migrationBuilder.DeleteData(
                table: "AccountTypes",
                keyColumn: "Id",
                keyValue: new Guid("507cbf03-829b-488b-97b1-f237ea31a43f"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("010315fd-a567-4abd-a4b0-f73431454f4f"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("1d94c74c-9794-40ca-8a43-6a465c6c16ff"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("5d096aa8-d3f8-40a0-9fdf-9bfc0be93d5f"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("0bf38f97-3634-424a-ada8-5e94acbb27bc"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("480ee408-ddcb-4c46-87a3-be057376723e"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("cf9b49e9-6372-4989-a732-bfa6ac5a3c03"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("f4cffe7d-869c-44c9-86c5-0aec1ad30ef1"));

            migrationBuilder.DeleteData(
                table: "AccountTypes",
                keyColumn: "Id",
                keyValue: new Guid("79605657-382b-4be2-9d70-687d9ab23123"));

            migrationBuilder.DropColumn(
                name: "TotalBalance",
                table: "BankAccounts");

            migrationBuilder.InsertData(
                table: "AccountTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("24368cc0-0daf-40e6-8bb7-f11df234da5b"), "Liability" },
                    { new Guid("b44fc92a-c2e3-4a10-8f89-df9664784d2e"), "Asset" }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1aa80f7c-98a7-4c63-acb2-f86a62e74b34"), "Cheque" },
                    { new Guid("4b4f240e-4298-44f9-9fba-3a6d0459ac26"), "NEFT" },
                    { new Guid("6d3fab18-e05d-4902-9aab-dc1714c6fc32"), "RTGS" },
                    { new Guid("d2dbcb54-1ab7-4baf-bb80-fc86aab809b2"), "Cash" },
                    { new Guid("fd65ea46-bfd2-4b58-ad05-83303ad1d71a"), "Other" }
                });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "AccountNumber", "AccountTypeId", "ClosingDate", "FirstName", "LastName", "MiddleName", "OpeningDate" },
                values: new object[,]
                {
                    { new Guid("276fbd82-5369-43e3-b5cf-26eefabebbee"), "92606112", new Guid("24368cc0-0daf-40e6-8bb7-f11df234da5b"), null, "Akash", "Rana", null, new DateTime(2023, 11, 6, 19, 54, 17, 737, DateTimeKind.Local).AddTicks(3667) },
                    { new Guid("4cd608bf-c842-4bdd-b2a3-aac994b939c9"), "62533098", new Guid("24368cc0-0daf-40e6-8bb7-f11df234da5b"), null, "Akash", "Rana", null, new DateTime(2023, 11, 3, 19, 54, 17, 737, DateTimeKind.Local).AddTicks(3685) },
                    { new Guid("50ac678c-6afd-4ab9-9e11-a3afde713b36"), "76226526", new Guid("24368cc0-0daf-40e6-8bb7-f11df234da5b"), null, "Akash", "Rana", null, new DateTime(2023, 11, 4, 19, 54, 17, 737, DateTimeKind.Local).AddTicks(3678) },
                    { new Guid("6ed5447c-4778-4a43-8d8e-deeed84acb93"), "76734846", new Guid("24368cc0-0daf-40e6-8bb7-f11df234da5b"), null, "Akash", "Rana", null, new DateTime(2023, 11, 7, 19, 54, 17, 737, DateTimeKind.Local).AddTicks(3645) },
                    { new Guid("dfea66a1-d998-4c06-b1b2-aeca7b5dc97b"), "83929158", new Guid("b44fc92a-c2e3-4a10-8f89-df9664784d2e"), null, "Akash", "Rana", null, new DateTime(2023, 11, 5, 19, 54, 17, 737, DateTimeKind.Local).AddTicks(3675) }
                });

            migrationBuilder.InsertData(
                table: "BankTransactions",
                columns: new[] { "Id", "Amount", "BankAccountID", "Category", "PaymentMethodID", "TransactionDate", "TransactionPersonFirstName", "TransactionPersonLastName", "TransactionPersonMiddleName", "TransactionType" },
                values: new object[,]
                {
                    { new Guid("46f2cf68-512b-45d2-831a-fb014e05190c"), 923.769672392775000m, new Guid("276fbd82-5369-43e3-b5cf-26eefabebbee"), "Normal Transactions", new Guid("1aa80f7c-98a7-4c63-acb2-f86a62e74b34"), new DateTime(2023, 11, 7, 19, 54, 17, 737, DateTimeKind.Local).AddTicks(3853), "Akash", "Rana", null, "Credit" },
                    { new Guid("77813e47-7c0a-49c8-92a9-35186cd62c77"), 810.383424071375000m, new Guid("4cd608bf-c842-4bdd-b2a3-aac994b939c9"), "Bank Charges", new Guid("6d3fab18-e05d-4902-9aab-dc1714c6fc32"), new DateTime(2023, 11, 6, 19, 54, 17, 737, DateTimeKind.Local).AddTicks(3921), "Akash", "Rana", null, "Debit" },
                    { new Guid("9411638d-c313-476d-af6a-bffe066386ba"), 342.930677230827000m, new Guid("276fbd82-5369-43e3-b5cf-26eefabebbee"), "Bank Interest", new Guid("6d3fab18-e05d-4902-9aab-dc1714c6fc32"), new DateTime(2023, 11, 5, 19, 54, 17, 737, DateTimeKind.Local).AddTicks(3926), "Akash", "Rana", null, "Credit" },
                    { new Guid("bd637b21-62fc-4c4f-8052-032e860ed3f9"), 678.691591321751000m, new Guid("6ed5447c-4778-4a43-8d8e-deeed84acb93"), "Bank Charges", new Guid("d2dbcb54-1ab7-4baf-bb80-fc86aab809b2"), new DateTime(2023, 11, 3, 19, 54, 17, 737, DateTimeKind.Local).AddTicks(3933), "Akash", "Rana", null, "Credit" },
                    { new Guid("cefe1b5a-fcc7-43da-92cd-bf60594954a6"), 449.552452320298000m, new Guid("276fbd82-5369-43e3-b5cf-26eefabebbee"), "Opening Balance", new Guid("6d3fab18-e05d-4902-9aab-dc1714c6fc32"), new DateTime(2023, 11, 4, 19, 54, 17, 737, DateTimeKind.Local).AddTicks(3930), "Akash", "Rana", null, "Debit" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("50ac678c-6afd-4ab9-9e11-a3afde713b36"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("dfea66a1-d998-4c06-b1b2-aeca7b5dc97b"));

            migrationBuilder.DeleteData(
                table: "BankTransactions",
                keyColumn: "Id",
                keyValue: new Guid("46f2cf68-512b-45d2-831a-fb014e05190c"));

            migrationBuilder.DeleteData(
                table: "BankTransactions",
                keyColumn: "Id",
                keyValue: new Guid("77813e47-7c0a-49c8-92a9-35186cd62c77"));

            migrationBuilder.DeleteData(
                table: "BankTransactions",
                keyColumn: "Id",
                keyValue: new Guid("9411638d-c313-476d-af6a-bffe066386ba"));

            migrationBuilder.DeleteData(
                table: "BankTransactions",
                keyColumn: "Id",
                keyValue: new Guid("bd637b21-62fc-4c4f-8052-032e860ed3f9"));

            migrationBuilder.DeleteData(
                table: "BankTransactions",
                keyColumn: "Id",
                keyValue: new Guid("cefe1b5a-fcc7-43da-92cd-bf60594954a6"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("4b4f240e-4298-44f9-9fba-3a6d0459ac26"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("fd65ea46-bfd2-4b58-ad05-83303ad1d71a"));

            migrationBuilder.DeleteData(
                table: "AccountTypes",
                keyColumn: "Id",
                keyValue: new Guid("b44fc92a-c2e3-4a10-8f89-df9664784d2e"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("276fbd82-5369-43e3-b5cf-26eefabebbee"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("4cd608bf-c842-4bdd-b2a3-aac994b939c9"));

            migrationBuilder.DeleteData(
                table: "BankAccounts",
                keyColumn: "Id",
                keyValue: new Guid("6ed5447c-4778-4a43-8d8e-deeed84acb93"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("1aa80f7c-98a7-4c63-acb2-f86a62e74b34"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("6d3fab18-e05d-4902-9aab-dc1714c6fc32"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("d2dbcb54-1ab7-4baf-bb80-fc86aab809b2"));

            migrationBuilder.DeleteData(
                table: "AccountTypes",
                keyColumn: "Id",
                keyValue: new Guid("24368cc0-0daf-40e6-8bb7-f11df234da5b"));

            migrationBuilder.AddColumn<decimal>(
                name: "TotalBalance",
                table: "BankAccounts",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "AccountTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("507cbf03-829b-488b-97b1-f237ea31a43f"), "Liability" },
                    { new Guid("79605657-382b-4be2-9d70-687d9ab23123"), "Asset" }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0bf38f97-3634-424a-ada8-5e94acbb27bc"), "Cheque" },
                    { new Guid("480ee408-ddcb-4c46-87a3-be057376723e"), "Cash" },
                    { new Guid("933e1a20-e086-4c4b-910f-a8fc17f6751b"), "RTGS" },
                    { new Guid("cf9b49e9-6372-4989-a732-bfa6ac5a3c03"), "NEFT" },
                    { new Guid("f4cffe7d-869c-44c9-86c5-0aec1ad30ef1"), "Other" }
                });

            migrationBuilder.InsertData(
                table: "BankAccounts",
                columns: new[] { "Id", "AccountNumber", "AccountTypeId", "ClosingDate", "FirstName", "LastName", "MiddleName", "OpeningDate", "TotalBalance" },
                values: new object[,]
                {
                    { new Guid("010315fd-a567-4abd-a4b0-f73431454f4f"), "93300357", new Guid("79605657-382b-4be2-9d70-687d9ab23123"), null, "Akash", "Rana", null, new DateTime(2023, 10, 31, 11, 26, 17, 605, DateTimeKind.Local).AddTicks(6481), 1000m },
                    { new Guid("1d94c74c-9794-40ca-8a43-6a465c6c16ff"), "98151379", new Guid("79605657-382b-4be2-9d70-687d9ab23123"), null, "Akash", "Rana", null, new DateTime(2023, 11, 3, 11, 26, 17, 605, DateTimeKind.Local).AddTicks(6445), 1000m },
                    { new Guid("5d096aa8-d3f8-40a0-9fdf-9bfc0be93d5f"), "51863866", new Guid("79605657-382b-4be2-9d70-687d9ab23123"), null, "Akash", "Rana", null, new DateTime(2023, 10, 30, 11, 26, 17, 605, DateTimeKind.Local).AddTicks(6488), 1000m },
                    { new Guid("7027972d-4e89-4feb-8d4e-56b24dce32e2"), "20011388", new Guid("507cbf03-829b-488b-97b1-f237ea31a43f"), null, "Akash", "Rana", null, new DateTime(2023, 11, 2, 11, 26, 17, 605, DateTimeKind.Local).AddTicks(6473), 1000m },
                    { new Guid("e6cc0556-98fb-460e-a11d-0ec930fa5835"), "81906010", new Guid("507cbf03-829b-488b-97b1-f237ea31a43f"), null, "Akash", "Rana", null, new DateTime(2023, 11, 1, 11, 26, 17, 605, DateTimeKind.Local).AddTicks(6477), 1000m }
                });

            migrationBuilder.InsertData(
                table: "BankTransactions",
                columns: new[] { "Id", "Amount", "BankAccountID", "Category", "PaymentMethodID", "TransactionDate", "TransactionPersonFirstName", "TransactionPersonLastName", "TransactionPersonMiddleName", "TransactionType" },
                values: new object[,]
                {
                    { new Guid("3918570a-fd49-42e7-a754-426de2a76afc"), 843.717140581565000m, new Guid("1d94c74c-9794-40ca-8a43-6a465c6c16ff"), "Bank Charges", new Guid("480ee408-ddcb-4c46-87a3-be057376723e"), new DateTime(2023, 11, 3, 11, 26, 17, 605, DateTimeKind.Local).AddTicks(6665), "Akash", "Rana", null, "Credit" },
                    { new Guid("43606249-3139-45d0-b3d0-3f48dc0cb514"), 921.384731920803000m, new Guid("1d94c74c-9794-40ca-8a43-6a465c6c16ff"), "Bank Interest", new Guid("f4cffe7d-869c-44c9-86c5-0aec1ad30ef1"), new DateTime(2023, 10, 30, 11, 26, 17, 605, DateTimeKind.Local).AddTicks(6684), "Akash", "Rana", null, "Credit" },
                    { new Guid("7a1d7970-2cb4-4e41-81fe-d359df2b4c02"), 34.8647367220243000m, new Guid("1d94c74c-9794-40ca-8a43-6a465c6c16ff"), "Bank Interest", new Guid("cf9b49e9-6372-4989-a732-bfa6ac5a3c03"), new DateTime(2023, 11, 1, 11, 26, 17, 605, DateTimeKind.Local).AddTicks(6674), "Akash", "Rana", null, "Credit" },
                    { new Guid("9482873a-02ee-4407-b3e6-e71e916c712a"), 433.23440167249000m, new Guid("5d096aa8-d3f8-40a0-9fdf-9bfc0be93d5f"), "Opening Balance", new Guid("0bf38f97-3634-424a-ada8-5e94acbb27bc"), new DateTime(2023, 11, 2, 11, 26, 17, 605, DateTimeKind.Local).AddTicks(6671), "Akash", "Rana", null, "Debit" },
                    { new Guid("b3283467-4c39-4b6c-af4f-f0aacbfef3d6"), 841.705131144781000m, new Guid("010315fd-a567-4abd-a4b0-f73431454f4f"), "Normal Transactions", new Guid("f4cffe7d-869c-44c9-86c5-0aec1ad30ef1"), new DateTime(2023, 10, 31, 11, 26, 17, 605, DateTimeKind.Local).AddTicks(6681), "Akash", "Rana", null, "Debit" }
                });
        }
    }
}
