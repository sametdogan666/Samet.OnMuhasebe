using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Samet.OnMuhasebe.Migrations
{
    /// <inheritdoc />
    public partial class migAllEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppBranchs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppBranchs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppSpecialCodes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    SpecialCodeType = table.Column<byte>(type: "TinyInt", nullable: false),
                    CardType = table.Column<byte>(type: "TinyInt", nullable: false),
                    Description = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSpecialCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppTerms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppTerms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppBanks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    SpecialCode1Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    SpecialCode2Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    Description = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppBanks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppBanks_AppSpecialCodes_SpecialCode1Id",
                        column: x => x.SpecialCode1Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppBanks_AppSpecialCodes_SpecialCode2Id",
                        column: x => x.SpecialCode2Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppCurrents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    TaxOffice = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: true),
                    TaxNo = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: true),
                    Phone = table.Column<string>(type: "VarChar(15)", maxLength: 15, nullable: true),
                    Address = table.Column<string>(type: "VarChar(150)", maxLength: 150, nullable: true),
                    SpecialCode1Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    SpecialCode2Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    Description = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCurrents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppCurrents_AppSpecialCodes_SpecialCode1Id",
                        column: x => x.SpecialCode1Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppCurrents_AppSpecialCodes_SpecialCode2Id",
                        column: x => x.SpecialCode2Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppSafes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    SpecialCode1Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    SpecialCode2Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    BranchId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    Description = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSafes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppSafes_AppBranchs_BranchId",
                        column: x => x.BranchId,
                        principalTable: "AppBranchs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppSafes_AppSpecialCodes_SpecialCode1Id",
                        column: x => x.SpecialCode1Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppSafes_AppSpecialCodes_SpecialCode2Id",
                        column: x => x.SpecialCode2Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppStores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    SpecialCode1Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    SpecialCode2Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    BranchId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    Description = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppStores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppStores_AppBranchs_BranchId",
                        column: x => x.BranchId,
                        principalTable: "AppBranchs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStores_AppSpecialCodes_SpecialCode1Id",
                        column: x => x.SpecialCode1Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStores_AppSpecialCodes_SpecialCode2Id",
                        column: x => x.SpecialCode2Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppUnits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    SpecialCode1Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    SpecialCode2Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    Description = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUnits_AppSpecialCodes_SpecialCode1Id",
                        column: x => x.SpecialCode1Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppUnits_AppSpecialCodes_SpecialCode2Id",
                        column: x => x.SpecialCode2Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppBankBranches",
                columns: table => new
                {
                    Code = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    BankId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    SpecialCode1Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    SpecialCode2Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    Description = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<bool>(type: "Bit", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppBankBranches", x => x.Code);
                    table.ForeignKey(
                        name: "FK_AppBankBranches_AppBanks_BankId",
                        column: x => x.BankId,
                        principalTable: "AppBanks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppBankBranches_AppSpecialCodes_SpecialCode1Id",
                        column: x => x.SpecialCode1Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppBankBranches_AppSpecialCodes_SpecialCode2Id",
                        column: x => x.SpecialCode2Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppInvoices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InvoiceType = table.Column<byte>(type: "TinyInt", nullable: false),
                    InvoiceNo = table.Column<string>(type: "VarChar(16)", maxLength: 16, nullable: false),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    GrossAmount = table.Column<decimal>(type: "Money", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "Money", nullable: false),
                    ExcludesVat = table.Column<decimal>(type: "Money", nullable: false),
                    VatAmount = table.Column<decimal>(type: "Money", nullable: false),
                    NetAmount = table.Column<decimal>(type: "Money", nullable: false),
                    NumberOfTransactions = table.Column<int>(type: "Int", nullable: false),
                    CurrentId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    SpecialCode1Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    SpecialCode2Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    BranchId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    TermId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    Description = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppInvoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppInvoices_AppBranchs_BranchId",
                        column: x => x.BranchId,
                        principalTable: "AppBranchs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppInvoices_AppCurrents_CurrentId",
                        column: x => x.CurrentId,
                        principalTable: "AppCurrents",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppInvoices_AppSpecialCodes_SpecialCode1Id",
                        column: x => x.SpecialCode1Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppInvoices_AppSpecialCodes_SpecialCode2Id",
                        column: x => x.SpecialCode2Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppInvoices_AppTerms_TermId",
                        column: x => x.TermId,
                        principalTable: "AppTerms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppCompanyParameters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    BranchId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    TermId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    StoreId = table.Column<Guid>(type: "UniqueIdentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCompanyParameters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppCompanyParameters_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppCompanyParameters_AppBranchs_BranchId",
                        column: x => x.BranchId,
                        principalTable: "AppBranchs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppCompanyParameters_AppStores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "AppStores",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppCompanyParameters_AppTerms_TermId",
                        column: x => x.TermId,
                        principalTable: "AppTerms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppExpenses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    VatAmount = table.Column<int>(type: "Int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "Money", nullable: false),
                    Barcode = table.Column<string>(type: "VarChar(128)", maxLength: 128, nullable: true),
                    UnitId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    SpecialCode1Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    SpecialCode2Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    Description = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppExpenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppExpenses_AppSpecialCodes_SpecialCode1Id",
                        column: x => x.SpecialCode1Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppExpenses_AppSpecialCodes_SpecialCode2Id",
                        column: x => x.SpecialCode2Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppExpenses_AppUnits_UnitId",
                        column: x => x.UnitId,
                        principalTable: "AppUnits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppServices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    VatRate = table.Column<int>(type: "Int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "Money", nullable: false),
                    Barcode = table.Column<string>(type: "VarChar(128)", maxLength: 128, nullable: true),
                    UnitId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    SpecialCode1Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    SpecialCode2Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    Description = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppServices_AppSpecialCodes_SpecialCode1Id",
                        column: x => x.SpecialCode1Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppServices_AppSpecialCodes_SpecialCode2Id",
                        column: x => x.SpecialCode2Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppServices_AppUnits_UnitId",
                        column: x => x.UnitId,
                        principalTable: "AppUnits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppStocks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    VatRate = table.Column<int>(type: "Int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "Money", nullable: false),
                    Barcode = table.Column<string>(type: "VarChar(128)", maxLength: 128, nullable: true),
                    UnitId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    SpecialCode1Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    SpecialCode2Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    Description = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<bool>(type: "Bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppStocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppStocks_AppSpecialCodes_SpecialCode1Id",
                        column: x => x.SpecialCode1Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStocks_AppSpecialCodes_SpecialCode2Id",
                        column: x => x.SpecialCode2Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppStocks_AppUnits_UnitId",
                        column: x => x.UnitId,
                        principalTable: "AppUnits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppBankAccounts",
                columns: table => new
                {
                    Code = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "VarChar(50)", maxLength: 50, nullable: false),
                    AccountType = table.Column<byte>(type: "TinyInt", nullable: false),
                    AccountNo = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: false),
                    IbanNo = table.Column<string>(type: "VarChar(26)", maxLength: 26, nullable: true),
                    BankBranchId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    SpecialCode1Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    SpecialCode2Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    BranchId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    Description = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<bool>(type: "Bit", nullable: false),
                    BankBranchCode = table.Column<string>(type: "VarChar(20)", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppBankAccounts", x => x.Code);
                    table.ForeignKey(
                        name: "FK_AppBankAccounts_AppBankBranches_BankBranchCode",
                        column: x => x.BankBranchCode,
                        principalTable: "AppBankBranches",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppBankAccounts_AppBranchs_BranchId",
                        column: x => x.BranchId,
                        principalTable: "AppBranchs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppBankAccounts_AppSpecialCodes_SpecialCode1Id",
                        column: x => x.SpecialCode1Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppBankAccounts_AppSpecialCodes_SpecialCode2Id",
                        column: x => x.SpecialCode2Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppInvoiceTransactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InvoiceId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    TransactionType = table.Column<byte>(type: "TinyInt", nullable: false),
                    StockId = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    ServiceId = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    ExpenseId = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    StoreId = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    Amount = table.Column<decimal>(type: "Money", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "Money", nullable: false),
                    GrossAmount = table.Column<decimal>(type: "Money", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "Money", nullable: false),
                    VatRate = table.Column<int>(type: "Int", nullable: false),
                    ExcludesVat = table.Column<decimal>(type: "Money", nullable: false),
                    VatAmount = table.Column<decimal>(type: "Money", nullable: false),
                    NetAmount = table.Column<decimal>(type: "Money", nullable: false),
                    Description = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppInvoiceTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppInvoiceTransactions_AppExpenses_ExpenseId",
                        column: x => x.ExpenseId,
                        principalTable: "AppExpenses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppInvoiceTransactions_AppInvoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "AppInvoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppInvoiceTransactions_AppServices_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "AppServices",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppInvoiceTransactions_AppStocks_StockId",
                        column: x => x.StockId,
                        principalTable: "AppStocks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppInvoiceTransactions_AppStores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "AppStores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppReceipts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceiptType = table.Column<byte>(type: "TinyInt", nullable: false),
                    ReceiptNo = table.Column<string>(type: "VarChar(16)", maxLength: 16, nullable: false),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    CurrentId = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    SafeId = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    BankAccountId = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    NumberOfTransactions = table.Column<int>(type: "Int", nullable: false),
                    CheckTotal = table.Column<decimal>(type: "Money", nullable: false),
                    BillTotal = table.Column<decimal>(type: "Money", nullable: false),
                    PosTotal = table.Column<decimal>(type: "Money", nullable: false),
                    CashTotal = table.Column<decimal>(type: "Money", nullable: false),
                    BankTotal = table.Column<decimal>(type: "Money", nullable: false),
                    SpecialCode1Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    SpecialCode2Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    BranchId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    TermId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    Description = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: false),
                    Status = table.Column<bool>(type: "Bit", nullable: false),
                    BankAccountCode = table.Column<string>(type: "VarChar(20)", nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppReceipts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppReceipts_AppBankAccounts_BankAccountCode",
                        column: x => x.BankAccountCode,
                        principalTable: "AppBankAccounts",
                        principalColumn: "Code");
                    table.ForeignKey(
                        name: "FK_AppReceipts_AppBranchs_BranchId",
                        column: x => x.BranchId,
                        principalTable: "AppBranchs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppReceipts_AppCurrents_CurrentId",
                        column: x => x.CurrentId,
                        principalTable: "AppCurrents",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppReceipts_AppSafes_SafeId",
                        column: x => x.SafeId,
                        principalTable: "AppSafes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppReceipts_AppSpecialCodes_SpecialCode1Id",
                        column: x => x.SpecialCode1Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppReceipts_AppSpecialCodes_SpecialCode2Id",
                        column: x => x.SpecialCode2Id,
                        principalTable: "AppSpecialCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppReceipts_AppTerms_TermId",
                        column: x => x.TermId,
                        principalTable: "AppTerms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppReceiptTransactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReceiptId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    PaymentType = table.Column<byte>(type: "TinyInt", nullable: false),
                    TrackingNo = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: true),
                    CheckBankId = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    CheckBankBranchId = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    CheckAccountNo = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: true),
                    DocumentNo = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: true),
                    Maturity = table.Column<DateTime>(type: "Date", nullable: false),
                    PrincipalDebtor = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: true),
                    Endorser = table.Column<string>(type: "VarChar(20)", maxLength: 20, nullable: true),
                    SafeId = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    BankAccountId = table.Column<Guid>(type: "UniqueIdentifier", nullable: true),
                    Sum = table.Column<decimal>(type: "Money", nullable: false),
                    DocumentStatus = table.Column<byte>(type: "TinyInt", nullable: false),
                    OurOwnDocument = table.Column<bool>(type: "Bit", nullable: false),
                    Description = table.Column<string>(type: "VarChar(200)", maxLength: 200, nullable: true),
                    CheckBankBranchCode = table.Column<string>(type: "VarChar(20)", nullable: true),
                    BankAccountCode = table.Column<string>(type: "VarChar(20)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppReceiptTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppReceiptTransactions_AppBankAccounts_BankAccountCode",
                        column: x => x.BankAccountCode,
                        principalTable: "AppBankAccounts",
                        principalColumn: "Code");
                    table.ForeignKey(
                        name: "FK_AppReceiptTransactions_AppBankBranches_CheckBankBranchCode",
                        column: x => x.CheckBankBranchCode,
                        principalTable: "AppBankBranches",
                        principalColumn: "Code");
                    table.ForeignKey(
                        name: "FK_AppReceiptTransactions_AppBanks_CheckBankId",
                        column: x => x.CheckBankId,
                        principalTable: "AppBanks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppReceiptTransactions_AppReceipts_ReceiptId",
                        column: x => x.ReceiptId,
                        principalTable: "AppReceipts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppReceiptTransactions_AppSafes_SafeId",
                        column: x => x.SafeId,
                        principalTable: "AppSafes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppBankAccounts_BankBranchCode",
                table: "AppBankAccounts",
                column: "BankBranchCode");

            migrationBuilder.CreateIndex(
                name: "IX_AppBankAccounts_BranchId",
                table: "AppBankAccounts",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AppBankAccounts_SpecialCode1Id",
                table: "AppBankAccounts",
                column: "SpecialCode1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppBankAccounts_SpecialCode2Id",
                table: "AppBankAccounts",
                column: "SpecialCode2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppBankBranches_BankId",
                table: "AppBankBranches",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_AppBankBranches_SpecialCode1Id",
                table: "AppBankBranches",
                column: "SpecialCode1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppBankBranches_SpecialCode2Id",
                table: "AppBankBranches",
                column: "SpecialCode2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppBanks_Code",
                table: "AppBanks",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AppBanks_SpecialCode1Id",
                table: "AppBanks",
                column: "SpecialCode1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppBanks_SpecialCode2Id",
                table: "AppBanks",
                column: "SpecialCode2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppBranchs_Code",
                table: "AppBranchs",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AppCompanyParameters_BranchId",
                table: "AppCompanyParameters",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AppCompanyParameters_StoreId",
                table: "AppCompanyParameters",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_AppCompanyParameters_TermId",
                table: "AppCompanyParameters",
                column: "TermId");

            migrationBuilder.CreateIndex(
                name: "IX_AppCompanyParameters_UserId",
                table: "AppCompanyParameters",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppCurrents_Code",
                table: "AppCurrents",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AppCurrents_SpecialCode1Id",
                table: "AppCurrents",
                column: "SpecialCode1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppCurrents_SpecialCode2Id",
                table: "AppCurrents",
                column: "SpecialCode2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppExpenses_Code",
                table: "AppExpenses",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AppExpenses_SpecialCode1Id",
                table: "AppExpenses",
                column: "SpecialCode1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppExpenses_SpecialCode2Id",
                table: "AppExpenses",
                column: "SpecialCode2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppExpenses_UnitId",
                table: "AppExpenses",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_AppInvoices_BranchId",
                table: "AppInvoices",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AppInvoices_CurrentId",
                table: "AppInvoices",
                column: "CurrentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppInvoices_InvoiceNo",
                table: "AppInvoices",
                column: "InvoiceNo");

            migrationBuilder.CreateIndex(
                name: "IX_AppInvoices_SpecialCode1Id",
                table: "AppInvoices",
                column: "SpecialCode1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppInvoices_SpecialCode2Id",
                table: "AppInvoices",
                column: "SpecialCode2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppInvoices_TermId",
                table: "AppInvoices",
                column: "TermId");

            migrationBuilder.CreateIndex(
                name: "IX_AppInvoiceTransactions_ExpenseId",
                table: "AppInvoiceTransactions",
                column: "ExpenseId");

            migrationBuilder.CreateIndex(
                name: "IX_AppInvoiceTransactions_InvoiceId",
                table: "AppInvoiceTransactions",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_AppInvoiceTransactions_ServiceId",
                table: "AppInvoiceTransactions",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_AppInvoiceTransactions_StockId",
                table: "AppInvoiceTransactions",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_AppInvoiceTransactions_StoreId",
                table: "AppInvoiceTransactions",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceipts_BankAccountCode",
                table: "AppReceipts",
                column: "BankAccountCode");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceipts_BranchId",
                table: "AppReceipts",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceipts_CurrentId",
                table: "AppReceipts",
                column: "CurrentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceipts_ReceiptNo",
                table: "AppReceipts",
                column: "ReceiptNo");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceipts_SafeId",
                table: "AppReceipts",
                column: "SafeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceipts_SpecialCode1Id",
                table: "AppReceipts",
                column: "SpecialCode1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceipts_SpecialCode2Id",
                table: "AppReceipts",
                column: "SpecialCode2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceipts_TermId",
                table: "AppReceipts",
                column: "TermId");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceiptTransactions_BankAccountCode",
                table: "AppReceiptTransactions",
                column: "BankAccountCode");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceiptTransactions_CheckBankBranchCode",
                table: "AppReceiptTransactions",
                column: "CheckBankBranchCode");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceiptTransactions_CheckBankId",
                table: "AppReceiptTransactions",
                column: "CheckBankId");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceiptTransactions_ReceiptId",
                table: "AppReceiptTransactions",
                column: "ReceiptId");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceiptTransactions_SafeId",
                table: "AppReceiptTransactions",
                column: "SafeId");

            migrationBuilder.CreateIndex(
                name: "IX_AppReceiptTransactions_TrackingNo",
                table: "AppReceiptTransactions",
                column: "TrackingNo");

            migrationBuilder.CreateIndex(
                name: "IX_AppSafes_BranchId",
                table: "AppSafes",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AppSafes_Code",
                table: "AppSafes",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AppSafes_SpecialCode1Id",
                table: "AppSafes",
                column: "SpecialCode1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppSafes_SpecialCode2Id",
                table: "AppSafes",
                column: "SpecialCode2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppServices_Code",
                table: "AppServices",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AppServices_SpecialCode1Id",
                table: "AppServices",
                column: "SpecialCode1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppServices_SpecialCode2Id",
                table: "AppServices",
                column: "SpecialCode2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppServices_UnitId",
                table: "AppServices",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_AppSpecialCodes_Code",
                table: "AppSpecialCodes",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AppStocks_Code",
                table: "AppStocks",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AppStocks_SpecialCode1Id",
                table: "AppStocks",
                column: "SpecialCode1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppStocks_SpecialCode2Id",
                table: "AppStocks",
                column: "SpecialCode2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppStocks_UnitId",
                table: "AppStocks",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStores_BranchId",
                table: "AppStores",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AppStores_Code",
                table: "AppStores",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AppStores_SpecialCode1Id",
                table: "AppStores",
                column: "SpecialCode1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppStores_SpecialCode2Id",
                table: "AppStores",
                column: "SpecialCode2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppTerms_Code",
                table: "AppTerms",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AppUnits_Code",
                table: "AppUnits",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AppUnits_SpecialCode1Id",
                table: "AppUnits",
                column: "SpecialCode1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AppUnits_SpecialCode2Id",
                table: "AppUnits",
                column: "SpecialCode2Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppCompanyParameters");

            migrationBuilder.DropTable(
                name: "AppInvoiceTransactions");

            migrationBuilder.DropTable(
                name: "AppReceiptTransactions");

            migrationBuilder.DropTable(
                name: "AppExpenses");

            migrationBuilder.DropTable(
                name: "AppInvoices");

            migrationBuilder.DropTable(
                name: "AppServices");

            migrationBuilder.DropTable(
                name: "AppStocks");

            migrationBuilder.DropTable(
                name: "AppStores");

            migrationBuilder.DropTable(
                name: "AppReceipts");

            migrationBuilder.DropTable(
                name: "AppUnits");

            migrationBuilder.DropTable(
                name: "AppBankAccounts");

            migrationBuilder.DropTable(
                name: "AppCurrents");

            migrationBuilder.DropTable(
                name: "AppSafes");

            migrationBuilder.DropTable(
                name: "AppTerms");

            migrationBuilder.DropTable(
                name: "AppBankBranches");

            migrationBuilder.DropTable(
                name: "AppBranchs");

            migrationBuilder.DropTable(
                name: "AppBanks");

            migrationBuilder.DropTable(
                name: "AppSpecialCodes");
        }
    }
}
