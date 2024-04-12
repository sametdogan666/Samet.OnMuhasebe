﻿using System.Data;
using Microsoft.EntityFrameworkCore;
using Samet.OnMuhasebe.BankAccounts;
using Samet.OnMuhasebe.BankBranches;
using Samet.OnMuhasebe.Banks;
using Samet.OnMuhasebe.Bills;
using Samet.OnMuhasebe.Consts;
using Samet.OnMuhasebe.Currents;
using Samet.OnMuhasebe.Parameters;
using Samet.OnMuhasebe.Safes;
using Samet.OnMuhasebe.Services;
using Samet.OnMuhasebe.Stores;
using Samet.OnMuhasebe.Terms;
using Samet.OnMuhasebe.Units;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Samet.OnMuhasebe.Configurations;

public static class OnMuhasebeDbContextModelBuilderExtensions
{
    public static void Configure(this ModelBuilder builder)
    {
        builder.Entity<Bank>(b =>
        {
            b.ToTable(OnMuhasebeConsts.DbTablePrefix + "Banks", OnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();

            //properties

            //indexes

            //relations
        });
    }


    public static void ConfigureBank(this ModelBuilder builder)
    {
        builder.Entity<Bank>(b =>
        {
            b.ToTable(OnMuhasebeConsts.DbTablePrefix + "Banks", OnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();

            //properties
            b.Property(x => x.Code)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntitiesConst.MaxCodeLength);

            b.Property(x => x.Name)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntitiesConst.MaxNameLength);

            b.Property(x => x.SpecialCode1Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.SpecialCode2Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.Description)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntitiesConst.MaxDescriptionLength);

            b.Property(x => x.Status)
                .HasColumnType(SqlDbType.Bit.ToString());

            //indexes
            b.HasIndex(x => x.Code);

            //relations
            b.HasOne(x => x.SpecialCode1)
                .WithMany(x => x.SpecialCode1Banks)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.SpecialCode2).WithMany(x => x.SpecialCode2Banks)
                .OnDelete(DeleteBehavior.NoAction);
        });
    }

    public static void ConfigureBankBranch(this ModelBuilder builder)
    {
        builder.Entity<BankBranch>(b =>
        {
            b.ToTable(OnMuhasebeConsts.DbTablePrefix + "BankBranches", OnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();

            //properties
            b.Property(x => x.Code)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntitiesConst.MaxCodeLength);

            b.Property(x => x.Name)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntitiesConst.MaxNameLength);

            b.Property(x => x.BankId)
                .IsRequired()
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.SpecialCode1Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.SpecialCode2Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.Description)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntitiesConst.MaxDescriptionLength);

            b.Property(x => x.Status)
                .HasColumnType(SqlDbType.Bit.ToString());


            //indexes
            b.HasKey(x => x.Code);

            //relations
            b.HasOne(x => x.Bank)
                .WithMany(x => x.BankBranches)
                .OnDelete(DeleteBehavior.Cascade);

            b.HasOne(x => x.SpecialCode1)
                .WithMany(x => x.SpecialCode1BankBranches)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.SpecialCode2).WithMany(x => x.SpecialCode2BankBranches)
                .OnDelete(DeleteBehavior.NoAction);
        });
    }

    public static void ConfigureBankAccount(this ModelBuilder builder)
    {
        builder.Entity<BankAccount>(b =>
        {
            b.ToTable(OnMuhasebeConsts.DbTablePrefix + "BankAccounts", OnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();

            //properties
            b.Property(x => x.Code)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntitiesConst.MaxCodeLength);

            b.Property(x => x.Name)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntitiesConst.MaxNameLength);

            b.Property(x => x.AccountType)
                .IsRequired()
                .HasColumnType(SqlDbType.TinyInt.ToString());

            b.Property(x => x.AccountNo)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(BankAccountsConst.MaxAccountNoLength);

            b.Property(x => x.IbanNo)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(BankAccountsConst.MaxIbanNoLength);

            b.Property(x => x.BankBranchId)
                .IsRequired()
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.SpecialCode1Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.SpecialCode2Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.BranchId)
                .IsRequired()
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.Description)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntitiesConst.MaxDescriptionLength);

            b.Property(x => x.Status)
                .HasColumnType(SqlDbType.Bit.ToString());

            //indexes
            b.HasKey(x => x.Code);

            //relations
            b.HasOne(x => x.BankBranch)
                .WithMany(x => x.BankAccounts)
                .OnDelete(DeleteBehavior.Cascade);

            b.HasOne(x => x.SpecialCode1)
                .WithMany(x => x.SpecialCode1BankAccounts)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.SpecialCode2).WithMany(x => x.SpecialCode2BankAccounts)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x=>x.Branch)
                .WithMany(x=>x.BankAccounts)
                .OnDelete(DeleteBehavior.Cascade);
        });
    }

    public static void ConfigureUnit(this ModelBuilder builder)
    {
        builder.Entity<Unit>(b =>
        {
            b.ToTable(OnMuhasebeConsts.DbTablePrefix + "Units", OnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();

            //properties
            b.Property(x => x.Code)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntitiesConst.MaxCodeLength);

            b.Property(x => x.Name)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntitiesConst.MaxNameLength);

            b.Property(x => x.SpecialCode1Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.SpecialCode2Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.Description)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntitiesConst.MaxDescriptionLength);

            b.Property(x => x.Status)
                .HasColumnType(SqlDbType.Bit.ToString());

            //indexes
            b.HasIndex(x => x.Code);

            //relations
            b.HasOne(x => x.SpecialCode1)
                .WithMany(x => x.SpecialCode1Units)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.SpecialCode2).WithMany(x => x.SpecialCode2Units)
                .OnDelete(DeleteBehavior.NoAction);
        });
    }

    public static void ConfigureCurrent(this ModelBuilder builder)
    {
        builder.Entity<Current>(b =>
        {
            b.ToTable(OnMuhasebeConsts.DbTablePrefix + "Currents", OnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();

            //properties
            b.Property(x => x.Code)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntitiesConst.MaxCodeLength);

            b.Property(x => x.Name)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntitiesConst.MaxNameLength);

            b.Property(x => x.TaxOffice)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(CurrentsConst.MaxTaxOfficeLength);

            b.Property(x => x.TaxNo)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(CurrentsConst.MaxTaxNoLength);

            b.Property(x => x.Phone)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntitiesConst.MaxPhoneLength);

            b.Property(x=>x.Address)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntitiesConst.MaxAddressLength);

            b.Property(x => x.SpecialCode1Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.SpecialCode2Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.Description)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntitiesConst.MaxDescriptionLength);

            b.Property(x => x.Status)
                .HasColumnType(SqlDbType.Bit.ToString());

            //indexes
            b.HasIndex(x => x.Code);

            //relations
            b.HasOne(x => x.SpecialCode1)
                .WithMany(x => x.SpecialCode1Currents)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.SpecialCode2).WithMany(x => x.SpecialCode2Currents)
                .OnDelete(DeleteBehavior.NoAction);
        });
    }

    public static void ConfigureStore(this ModelBuilder builder)
    {
        builder.Entity<Store>(b =>
        {
            b.ToTable(OnMuhasebeConsts.DbTablePrefix + "Stores", OnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();

            //properties
            b.Property(x => x.Code)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntitiesConst.MaxCodeLength);

            b.Property(x => x.Name)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntitiesConst.MaxNameLength);

            b.Property(x => x.SpecialCode1Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.SpecialCode2Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.BranchId)
                .IsRequired()
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.Description)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntitiesConst.MaxDescriptionLength);

            b.Property(x => x.Status)
                .HasColumnType(SqlDbType.Bit.ToString());

            //indexes
            b.HasIndex(x => x.Code);

            //relations
            b.HasOne(x => x.SpecialCode1)
                .WithMany(x => x.SpecialCode1Stores)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.SpecialCode2).WithMany(x => x.SpecialCode2Stores)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x=>x.Branch)
                .WithMany(x=>x.Stores)
                .OnDelete(DeleteBehavior.NoAction);
        });
    }

    public static void ConfigureTerm(this ModelBuilder builder)
    {
        builder.Entity<Term>(b =>
        {
            b.ToTable(OnMuhasebeConsts.DbTablePrefix + "Terms", OnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();

            //properties
            b.Property(x => x.Code)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntitiesConst.MaxCodeLength);

            b.Property(x => x.Name)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntitiesConst.MaxNameLength);

            b.Property(x => x.Description)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntitiesConst.MaxDescriptionLength);

            b.Property(x => x.Status)
                .HasColumnType(SqlDbType.Bit.ToString());

            //indexes
            b.HasIndex(x => x.Code);

            //relations
        });
    }

    public static void ConfigureInvoice(this ModelBuilder builder)
    {
        builder.Entity<Invoice>(b =>
        {
            b.ToTable(OnMuhasebeConsts.DbTablePrefix + "Invoices", OnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();

            //properties
            b.Property(x => x.InvoiceType)
                .IsRequired()
                .HasColumnType(SqlDbType.TinyInt.ToString());

            b.Property(x => x.InvoiceNo)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(InvoicesConst.MaxInvoiceNoLength);

            b.Property(x => x.Date)
                .IsRequired()
                .HasColumnType(SqlDbType.Date.ToString());

            b.Property(x => x.GrossAmount)
                .IsRequired()
                .HasColumnType(SqlDbType.Money.ToString());

            b.Property(x => x.DiscountAmount)
                .IsRequired()
                .HasColumnType(SqlDbType.Money.ToString());

            b.Property(x => x.ExcludesVat)
                .IsRequired()
                .HasColumnType(SqlDbType.Money.ToString());

            b.Property(x => x.VatAmount)
                .IsRequired()
                .HasColumnType(SqlDbType.Money.ToString());

            b.Property(x => x.NetAmount)
                .IsRequired()
                .HasColumnType(SqlDbType.Money.ToString());

            b.Property(x => x.NumberOfTransactions)
                .IsRequired()
                .HasColumnType(SqlDbType.Int.ToString());

            b.Property(x => x.CurrentId)
                .IsRequired()
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.SpecialCode1Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.SpecialCode2Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.BranchId)
                .IsRequired()
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.TermId)
                .IsRequired()
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.Description)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntitiesConst.MaxDescriptionLength);

            b.Property(x => x.Status)
                .HasColumnType(SqlDbType.Bit.ToString());

            //indexes
            b.HasIndex(x => x.InvoiceNo);

            //relations
            b.HasOne(x => x.Current)
                .WithMany(x => x.Invoices)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.SpecialCode1)
                .WithMany(x => x.SpecialCode1Invoices)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.SpecialCode2).WithMany(x => x.SpecialCode2Invoices)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x=>x.Branch)
                .WithMany(x=>x.Invoices)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.Term)
                .WithMany(x => x.Invoices)
                .OnDelete(DeleteBehavior.NoAction);
        });
    }

    public static void ConfigureInvoiceTransaction(this ModelBuilder builder)
    {
        builder.Entity<InvoiceTransaction>(b =>
        {
            b.ToTable(OnMuhasebeConsts.DbTablePrefix + "InvoiceTransactions", OnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();

            //properties
            b.Property(x => x.InvoiceId)
                .IsRequired()
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.TransactionType)
                .IsRequired()
                .HasColumnType(SqlDbType.TinyInt.ToString());

            b.Property(x => x.StockId)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.ServiceId)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.ExpenseId)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.StoreId)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.Amount)
                .IsRequired()
                .HasColumnType(SqlDbType.Money.ToString());

            b.Property(x => x.UnitPrice)
                .IsRequired()
                .HasColumnType(SqlDbType.Money.ToString());

            b.Property(x => x.GrossAmount)
                .IsRequired()
                .HasColumnType(SqlDbType.Money.ToString());

            b.Property(x => x.DiscountAmount)
                .IsRequired()
                .HasColumnType(SqlDbType.Money.ToString());

            b.Property(x => x.VatRate)
                .IsRequired()
                .HasColumnType(SqlDbType.Int.ToString());

            b.Property(x => x.ExcludesVat)
                .IsRequired()
                .HasColumnType(SqlDbType.Money.ToString());

            b.Property(x => x.VatAmount)
                .IsRequired()
                .HasColumnType(SqlDbType.Money.ToString());

            b.Property(x => x.NetAmount)
                .IsRequired()
                .HasColumnType(SqlDbType.Money.ToString());

            b.Property(x => x.Description)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntitiesConst.MaxDescriptionLength);

            //indexes

            //relations
            b.HasOne(x => x.Invoice)
                .WithMany(x => x.InvoiceTransactions)
                .OnDelete(DeleteBehavior.Cascade);

            b.HasOne(x => x.Stock)
                .WithMany(x => x.InvoiceTransactions)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.Service)
                .WithMany(x => x.InvoiceTransactions)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x=>x.Expense)
                .WithMany(x=>x.InvoiceTransactions)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x=>x.Store)
                .WithMany(x=>x.InvoiceTransactions)
                .OnDelete(DeleteBehavior.NoAction);
        });
    }

    public static void ConfigureCompanyParameter(this ModelBuilder builder)
    {
        builder.Entity<CompanyParameter>(b =>
        {
            b.ToTable(OnMuhasebeConsts.DbTablePrefix + "CompanyParameters", OnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();

            //properties
            b.Property(x => x.UserId)
                .IsRequired()
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.BranchId)
                .IsRequired()
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.TermId)
                .IsRequired()
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.StoreId)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            //indexes

            //relations
            b.HasOne(x => x.User)
                .WithOne()
                .HasForeignKey<CompanyParameter>(x => x.UserId);

            b.HasOne(x => x.Branch)
                .WithMany(x => x.CompanyParameters)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.Term)
                .WithMany(x => x.CompanyParameters)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.Store)
                .WithMany(x => x.CompanyParameters)
                .OnDelete(DeleteBehavior.NoAction);
        });
    }

    public static void ConfigureService(this ModelBuilder builder)
    {
        builder.Entity<Service>(b =>
        {
            b.ToTable(OnMuhasebeConsts.DbTablePrefix + "Services", OnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();

            //properties
            b.Property(x => x.Code)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntitiesConst.MaxCodeLength);

            b.Property(x => x.Name)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntitiesConst.MaxNameLength);

            b.Property(x => x.VatRate)
                .IsRequired()
                .HasColumnType(SqlDbType.Int.ToString());

            b.Property(x=>x.UnitPrice)
                .IsRequired()
                .HasColumnType(SqlDbType.Money.ToString());

            b.Property(x => x.Barcode)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntitiesConst.MaxBarcodeLength);

            b.Property(x => x.UnitId)
                .IsRequired()
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.SpecialCode1Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.SpecialCode2Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.Description)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntitiesConst.MaxDescriptionLength);

            b.Property(x => x.Status)
                .HasColumnType(SqlDbType.Bit.ToString());

            //indexes
            b.HasIndex(x => x.Code);

            //relations
            b.HasOne(x => x.Unit)
                .WithMany(x => x.Services)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.SpecialCode1)
                .WithMany(x => x.SpecialCode1Services)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.SpecialCode2).WithMany(x => x.SpecialCode2Services)
                .OnDelete(DeleteBehavior.NoAction);
        });
    }

    public static void ConfigureSafe(this ModelBuilder builder)
    {
        builder.Entity<Safe>(b =>
        {
            b.ToTable(OnMuhasebeConsts.DbTablePrefix + "Safes", OnMuhasebeConsts.DbSchema);
            b.ConfigureByConvention();

            //properties
            b.Property(x => x.Code)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntitiesConst.MaxCodeLength);

            b.Property(x => x.Name)
                .IsRequired()
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntitiesConst.MaxNameLength);

            b.Property(x => x.SpecialCode1Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.SpecialCode2Id)
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.BranchId)
                .IsRequired()
                .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

            b.Property(x => x.Description)
                .HasColumnType(SqlDbType.VarChar.ToString())
                .HasMaxLength(EntitiesConst.MaxDescriptionLength);

            b.Property(x => x.Status)
                .HasColumnType(SqlDbType.Bit.ToString());

            //indexes
            b.HasIndex(x => x.Code);

            //relations
            b.HasOne(x => x.SpecialCode1)
                .WithMany(x => x.SpecialCode1Safes)
                .OnDelete(DeleteBehavior.NoAction);

            b.HasOne(x => x.SpecialCode2).WithMany(x => x.SpecialCode2Safes)
                .OnDelete(DeleteBehavior.NoAction);
        });
    }
}