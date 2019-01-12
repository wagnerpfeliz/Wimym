﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using System;

namespace Wimym.DatabaseContext.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Wimym.Model.Domain.Shop", b =>
                {
                    b.Property<int>("ShopId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime?>("CreationDate");

                    b.Property<bool>("Deleted");

                    b.Property<DateTime?>("DeletedAt");

                    b.Property<string>("DeletedBy");

                    b.Property<string>("Email")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("OwnerId");

                    b.Property<string>("Tel")
                        .HasMaxLength(15);

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<string>("UpdatedBy");

                    b.Property<string>("WebAddress")
                        .HasMaxLength(50);

                    b.HasKey("ShopId");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.HasIndex("OwnerId");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("Shops");
                });

            modelBuilder.Entity("Wimym.Model.Domain._Control.AccountType", b =>
                {
                    b.Property<int>("AccountTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Description")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("OriginId");

                    b.Property<bool>("State");

                    b.HasKey("AccountTypeId");

                    b.HasIndex("OriginId");

                    b.ToTable("AccountTypes");
                });

            modelBuilder.Entity("Wimym.Model.Domain._Control.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AboutMe")
                        .HasMaxLength(500);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<bool>("Deleted");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("Image")
                        .HasMaxLength(100);

                    b.Property<string>("Lastname")
                        .HasMaxLength(50);

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("SeoUrl")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("ShopId");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<int>("UserTypeId");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("ShopId");

                    b.HasIndex("UserTypeId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Wimym.Model.Domain._Control.Currency", b =>
                {
                    b.Property<int>("CurrencyId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("CurrencyId");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("Wimym.Model.Domain._Control.Origin", b =>
                {
                    b.Property<int>("OriginId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.Property<string>("Description")
                        .HasMaxLength(30);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("Simbol")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.HasKey("OriginId");

                    b.ToTable("Origins");
                });

            modelBuilder.Entity("Wimym.Model.Domain._Control.Owner", b =>
                {
                    b.Property<int>("OwnerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<bool>("Deleted");

                    b.Property<DateTime?>("DeletedAt");

                    b.Property<string>("DeletedBy");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("NcfEnds")
                        .HasMaxLength(25);

                    b.Property<string>("PrefixFact")
                        .HasMaxLength(15);

                    b.Property<string>("PrefixFinalFact")
                        .HasMaxLength(15);

                    b.Property<string>("PrefixNcf")
                        .HasMaxLength(15);

                    b.Property<string>("PrefixOrder")
                        .HasMaxLength(10);

                    b.Property<int>("SeqFact");

                    b.Property<int>("SeqNcf");

                    b.Property<string>("Tel");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("OwnerId");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("Wimym.Model.Domain._Control.Periodicity", b =>
                {
                    b.Property<int>("PeriodicityId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("PeriodicityId");

                    b.ToTable("Periodicities");
                });

            modelBuilder.Entity("Wimym.Model.Domain._Control.UserType", b =>
                {
                    b.Property<int>("UserTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("UserTypeId");

                    b.ToTable("UserTypes");
                });

            modelBuilder.Entity("Wimym.Model.Domain._General.AccountingAccount", b =>
                {
                    b.Property<int>("AccountingAccountId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountTypeId");

                    b.Property<decimal>("Amount");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<int>("CurrencyId");

                    b.Property<bool>("Deleted");

                    b.Property<DateTime?>("DeletedAt");

                    b.Property<string>("DeletedBy");

                    b.Property<string>("Description")
                        .HasMaxLength(100);

                    b.Property<bool>("State");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<string>("UpdatedBy");

                    b.Property<int>("WalletId");

                    b.HasKey("AccountingAccountId");

                    b.HasIndex("AccountTypeId");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("DeletedBy");

                    b.HasIndex("UpdatedBy");

                    b.HasIndex("WalletId");

                    b.ToTable("AccountingAccounts");
                });

            modelBuilder.Entity("Wimym.Model.Domain._General.Operation", b =>
                {
                    b.Property<long>("OperationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId");

                    b.Property<decimal>("Amount");

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("Date");

                    b.Property<bool>("Deleted");

                    b.Property<DateTime?>("DeletedAt");

                    b.Property<string>("DeletedBy");

                    b.Property<string>("Observations")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<int>("OriginId");

                    b.Property<int>("PeriodicityId");

                    b.Property<bool>("Recurrent");

                    b.Property<int>("TagId");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("OperationId");

                    b.HasIndex("AccountId");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.HasIndex("OriginId");

                    b.HasIndex("PeriodicityId");

                    b.HasIndex("TagId");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("Operations");
                });

            modelBuilder.Entity("Wimym.Model.Domain._General.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount");

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<bool>("Deleted");

                    b.Property<DateTime?>("DeletedAt");

                    b.Property<string>("DeletedBy");

                    b.Property<string>("Description")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("OwnerId");

                    b.Property<bool>("State");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("TagId");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.HasIndex("OwnerId");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Wimym.Model.Domain._General.Wallet", b =>
                {
                    b.Property<int>("WalletId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<DateTime?>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<bool>("Deleted");

                    b.Property<DateTime?>("DeletedAt");

                    b.Property<string>("DeletedBy");

                    b.Property<string>("Description")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("OwnerId");

                    b.Property<bool>("State");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("WalletId");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeletedBy");

                    b.HasIndex("OwnerId");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("Wallets");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Wimym.Model.Domain._Control.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Wimym.Model.Domain._Control.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Wimym.Model.Domain._Control.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Wimym.Model.Domain._Control.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Wimym.Model.Domain.Shop", b =>
                {
                    b.HasOne("Wimym.Model.Domain._Control.ApplicationUser", "CreatedUser")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("Wimym.Model.Domain._Control.ApplicationUser", "DeletedUser")
                        .WithMany()
                        .HasForeignKey("DeletedBy");

                    b.HasOne("Wimym.Model.Domain._Control.Owner", "Owner")
                        .WithMany("Shops")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Wimym.Model.Domain._Control.ApplicationUser", "UpdatedUser")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");
                });

            modelBuilder.Entity("Wimym.Model.Domain._Control.AccountType", b =>
                {
                    b.HasOne("Wimym.Model.Domain._Control.Origin", "Origin")
                        .WithMany("AccountTypes")
                        .HasForeignKey("OriginId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Wimym.Model.Domain._Control.ApplicationUser", b =>
                {
                    b.HasOne("Wimym.Model.Domain.Shop", "Shop")
                        .WithMany("ApplicationUsers")
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Wimym.Model.Domain._Control.UserType", "UserType")
                        .WithMany("ApplicationUsers")
                        .HasForeignKey("UserTypeId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Wimym.Model.Domain._Control.Owner", b =>
                {
                    b.HasOne("Wimym.Model.Domain._Control.ApplicationUser", "CreatedUser")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("Wimym.Model.Domain._Control.ApplicationUser", "DeletedUser")
                        .WithMany()
                        .HasForeignKey("DeletedBy");

                    b.HasOne("Wimym.Model.Domain._Control.ApplicationUser", "UpdatedUser")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");
                });

            modelBuilder.Entity("Wimym.Model.Domain._General.AccountingAccount", b =>
                {
                    b.HasOne("Wimym.Model.Domain._Control.AccountType", "AccountType")
                        .WithMany("AccountingAccounts")
                        .HasForeignKey("AccountTypeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Wimym.Model.Domain._Control.ApplicationUser", "CreatedUser")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("Wimym.Model.Domain._Control.Currency", "Currency")
                        .WithMany("AccountingAccounts")
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Wimym.Model.Domain._Control.ApplicationUser", "DeletedUser")
                        .WithMany()
                        .HasForeignKey("DeletedBy");

                    b.HasOne("Wimym.Model.Domain._Control.ApplicationUser", "UpdatedUser")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");

                    b.HasOne("Wimym.Model.Domain._General.Wallet", "Wallet")
                        .WithMany("AccountingAccounts")
                        .HasForeignKey("WalletId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Wimym.Model.Domain._General.Operation", b =>
                {
                    b.HasOne("Wimym.Model.Domain._General.AccountingAccount", "Account")
                        .WithMany("Operations")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Wimym.Model.Domain._Control.ApplicationUser", "CreatedUser")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("Wimym.Model.Domain._Control.ApplicationUser", "DeletedUser")
                        .WithMany()
                        .HasForeignKey("DeletedBy");

                    b.HasOne("Wimym.Model.Domain._Control.Origin", "Origin")
                        .WithMany("Operations")
                        .HasForeignKey("OriginId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Wimym.Model.Domain._Control.Periodicity", "Periodicity")
                        .WithMany("Operations")
                        .HasForeignKey("PeriodicityId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Wimym.Model.Domain._General.Tag", "Tag")
                        .WithMany("Operations")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Wimym.Model.Domain._Control.ApplicationUser", "UpdatedUser")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");
                });

            modelBuilder.Entity("Wimym.Model.Domain._General.Tag", b =>
                {
                    b.HasOne("Wimym.Model.Domain._Control.ApplicationUser", "CreatedUser")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("Wimym.Model.Domain._Control.ApplicationUser", "DeletedUser")
                        .WithMany()
                        .HasForeignKey("DeletedBy");

                    b.HasOne("Wimym.Model.Domain._Control.Owner", "Owner")
                        .WithMany("Tags")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Wimym.Model.Domain._Control.ApplicationUser", "UpdatedUser")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");
                });

            modelBuilder.Entity("Wimym.Model.Domain._General.Wallet", b =>
                {
                    b.HasOne("Wimym.Model.Domain._Control.ApplicationUser", "CreatedUser")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("Wimym.Model.Domain._Control.ApplicationUser", "DeletedUser")
                        .WithMany()
                        .HasForeignKey("DeletedBy");

                    b.HasOne("Wimym.Model.Domain._Control.Owner", "Owner")
                        .WithMany("Wallets")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Wimym.Model.Domain._Control.ApplicationUser", "UpdatedUser")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");
                });
#pragma warning restore 612, 618
        }
    }
}
