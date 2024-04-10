using System.Data;
using Microsoft.EntityFrameworkCore;
using Samet.OnMuhasebe.BankAccounts;
using Samet.OnMuhasebe.BankBranches;
using Samet.OnMuhasebe.Banks;
using Samet.OnMuhasebe.Consts;
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
}