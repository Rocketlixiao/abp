﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyCompanyName.MyProjectName.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs;

namespace MyCompanyName.MyProjectName.Migrations
{
    [DbContext(typeof(MyProjectNameDbContext))]
    [Migration("20180917104042_Initial_Modules")]
    partial class Initial_Modules
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Volo.Abp.AuditLogging.AuditLog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BrowserInfo")
                        .HasColumnName("BrowserInfo")
                        .HasMaxLength(512);

                    b.Property<string>("ClientIpAddress")
                        .HasColumnName("ClientIpAddress")
                        .HasMaxLength(64);

                    b.Property<string>("ClientName")
                        .HasColumnName("ClientName")
                        .HasMaxLength(128);

                    b.Property<string>("Comments")
                        .HasColumnName("Comments")
                        .HasMaxLength(256);

                    b.Property<string>("Exceptions")
                        .HasColumnName("Exceptions")
                        .HasMaxLength(4000);

                    b.Property<int>("ExecutionDuration")
                        .HasColumnName("ExecutionDuration");

                    b.Property<DateTime>("ExecutionTime");

                    b.Property<string>("ExtraProperties")
                        .HasColumnName("ExtraProperties");

                    b.Property<string>("HttpMethod")
                        .HasColumnName("HttpMethod")
                        .HasMaxLength(16);

                    b.Property<int?>("HttpStatusCode")
                        .HasColumnName("HttpStatusCode");

                    b.Property<Guid?>("ImpersonatorTenantId")
                        .HasColumnName("ImpersonatorTenantId");

                    b.Property<Guid?>("ImpersonatorUserId")
                        .HasColumnName("ImpersonatorUserId");

                    b.Property<Guid?>("TenantId")
                        .HasColumnName("TenantId");

                    b.Property<string>("Url")
                        .HasColumnName("Url")
                        .HasMaxLength(256);

                    b.Property<Guid?>("UserId")
                        .HasColumnName("UserId");

                    b.Property<string>("UserName")
                        .HasColumnName("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("TenantId", "ExecutionTime");

                    b.HasIndex("TenantId", "UserId", "ExecutionTime");

                    b.ToTable("AbpAuditLogs");
                });

            modelBuilder.Entity("Volo.Abp.AuditLogging.AuditLogAction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AuditLogId")
                        .HasColumnName("AuditLogId");

                    b.Property<Guid?>("AuditLogId1");

                    b.Property<int>("ExecutionDuration")
                        .HasColumnName("ExecutionDuration");

                    b.Property<DateTime>("ExecutionTime")
                        .HasColumnName("ExecutionTime");

                    b.Property<string>("ExtraProperties")
                        .HasColumnName("ExtraProperties");

                    b.Property<string>("MethodName")
                        .HasColumnName("MethodName")
                        .HasMaxLength(128);

                    b.Property<string>("Parameters")
                        .HasColumnName("Parameters")
                        .HasMaxLength(2000);

                    b.Property<string>("ServiceName")
                        .HasColumnName("ServiceName")
                        .HasMaxLength(256);

                    b.Property<Guid?>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("AuditLogId");

                    b.HasIndex("AuditLogId1");

                    b.HasIndex("TenantId", "ServiceName", "MethodName", "ExecutionTime");

                    b.ToTable("AbpAuditLogActions");
                });

            modelBuilder.Entity("Volo.Abp.AuditLogging.EntityChange", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AuditLogId")
                        .HasColumnName("AuditLogId");

                    b.Property<Guid?>("AuditLogId1");

                    b.Property<DateTime>("ChangeTime")
                        .HasColumnName("ChangeTime");

                    b.Property<byte>("ChangeType")
                        .HasColumnName("ChangeType");

                    b.Property<string>("EntityId")
                        .IsRequired()
                        .HasColumnName("EntityId")
                        .HasMaxLength(128);

                    b.Property<string>("EntityTypeFullName")
                        .IsRequired()
                        .HasColumnName("EntityTypeFullName")
                        .HasMaxLength(128);

                    b.Property<string>("ExtraProperties")
                        .HasColumnName("ExtraProperties");

                    b.Property<Guid?>("TenantId")
                        .HasColumnName("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("AuditLogId");

                    b.HasIndex("AuditLogId1");

                    b.HasIndex("TenantId", "EntityTypeFullName", "EntityId");

                    b.ToTable("AbpEntityChanges");
                });

            modelBuilder.Entity("Volo.Abp.AuditLogging.EntityPropertyChange", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("EntityChangeId");

                    b.Property<Guid?>("EntityChangeId1");

                    b.Property<string>("NewValue")
                        .HasColumnName("NewValue")
                        .HasMaxLength(512);

                    b.Property<string>("OriginalValue")
                        .HasColumnName("OriginalValue")
                        .HasMaxLength(512);

                    b.Property<string>("PropertyName")
                        .IsRequired()
                        .HasColumnName("PropertyName")
                        .HasMaxLength(128);

                    b.Property<string>("PropertyTypeFullName")
                        .IsRequired()
                        .HasColumnName("PropertyTypeFullName")
                        .HasMaxLength(64);

                    b.Property<Guid?>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("EntityChangeId");

                    b.HasIndex("EntityChangeId1");

                    b.ToTable("AbpEntityPropertyChanges");
                });

            modelBuilder.Entity("Volo.Abp.BackgroundJobs.BackgroundJobRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime");

                    b.Property<bool>("IsAbandoned")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("JobArgs")
                        .IsRequired()
                        .HasMaxLength(1048576);

                    b.Property<string>("JobName")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTime?>("LastTryTime");

                    b.Property<DateTime>("NextTryTime");

                    b.Property<byte>("Priority")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue((byte)15);

                    b.Property<short>("TryCount")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue((short)0);

                    b.HasKey("Id");

                    b.HasIndex("IsAbandoned", "NextTryTime");

                    b.ToTable("AbpBackgroundJobs");
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<Guid?>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName");

                    b.ToTable("AbpRoles");
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityRoleClaim", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("ClaimValue")
                        .HasMaxLength(1024);

                    b.Property<Guid>("RoleId");

                    b.Property<Guid?>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AbpRoleClaims");
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AccessFailedCount")
                        .HasDefaultValue(0);

                    b.Property<string>("ConcurrencyStamp")
                        .IsRequired()
                        .HasColumnName("ConcurrencyStamp")
                        .HasMaxLength(256);

                    b.Property<string>("Email")
                        .HasColumnName("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("EmailConfirmed")
                        .HasDefaultValue(false);

                    b.Property<string>("ExtraProperties")
                        .HasColumnName("ExtraProperties");

                    b.Property<bool>("LockoutEnabled")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("LockoutEnabled")
                        .HasDefaultValue(false);

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnName("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .IsRequired()
                        .HasColumnName("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnName("PasswordHash")
                        .HasMaxLength(256);

                    b.Property<string>("PhoneNumber")
                        .HasColumnName("PhoneNumber")
                        .HasMaxLength(16);

                    b.Property<bool>("PhoneNumberConfirmed")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PhoneNumberConfirmed")
                        .HasDefaultValue(false);

                    b.Property<string>("SecurityStamp")
                        .IsRequired()
                        .HasColumnName("SecurityStamp")
                        .HasMaxLength(256);

                    b.Property<Guid?>("TenantId")
                        .HasColumnName("TenantId");

                    b.Property<bool>("TwoFactorEnabled")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("TwoFactorEnabled")
                        .HasDefaultValue(false);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnName("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("Email");

                    b.HasIndex("NormalizedEmail");

                    b.HasIndex("NormalizedUserName");

                    b.HasIndex("UserName");

                    b.ToTable("AbpUsers");
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityUserClaim", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("ClaimValue")
                        .HasMaxLength(1024);

                    b.Property<Guid?>("TenantId");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AbpUserClaims");
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityUserLogin", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(64);

                    b.Property<string>("ProviderDisplayName")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .IsRequired()
                        .HasMaxLength(196);

                    b.Property<Guid?>("TenantId");

                    b.HasKey("UserId", "LoginProvider");

                    b.HasIndex("LoginProvider", "ProviderKey");

                    b.ToTable("AbpUserLogins");
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityUserRole", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("RoleId");

                    b.Property<Guid?>("TenantId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId", "UserId");

                    b.ToTable("AbpUserRoles");
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityUserToken", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name");

                    b.Property<Guid?>("TenantId");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AbpUserTokens");
                });

            modelBuilder.Entity("Volo.Abp.PermissionManagement.PermissionGrant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("ProviderName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<Guid?>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("Name", "ProviderName", "ProviderKey");

                    b.ToTable("AbpPermissionGrants");
                });

            modelBuilder.Entity("Volo.Abp.SettingManagement.Setting", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(64);

                    b.Property<string>("ProviderName")
                        .HasMaxLength(64);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(2048);

                    b.HasKey("Id");

                    b.HasIndex("Name", "ProviderName", "ProviderKey");

                    b.ToTable("AbpSettings");
                });

            modelBuilder.Entity("Volo.Abp.AuditLogging.AuditLogAction", b =>
                {
                    b.HasOne("Volo.Abp.AuditLogging.AuditLog")
                        .WithMany()
                        .HasForeignKey("AuditLogId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Volo.Abp.AuditLogging.AuditLog")
                        .WithMany("Actions")
                        .HasForeignKey("AuditLogId1");
                });

            modelBuilder.Entity("Volo.Abp.AuditLogging.EntityChange", b =>
                {
                    b.HasOne("Volo.Abp.AuditLogging.AuditLog")
                        .WithMany()
                        .HasForeignKey("AuditLogId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Volo.Abp.AuditLogging.AuditLog")
                        .WithMany("EntityChanges")
                        .HasForeignKey("AuditLogId1");
                });

            modelBuilder.Entity("Volo.Abp.AuditLogging.EntityPropertyChange", b =>
                {
                    b.HasOne("Volo.Abp.AuditLogging.EntityChange")
                        .WithMany()
                        .HasForeignKey("EntityChangeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Volo.Abp.AuditLogging.EntityChange")
                        .WithMany("PropertyChanges")
                        .HasForeignKey("EntityChangeId1");
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityRoleClaim", b =>
                {
                    b.HasOne("Volo.Abp.Identity.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityUserClaim", b =>
                {
                    b.HasOne("Volo.Abp.Identity.IdentityUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityUserLogin", b =>
                {
                    b.HasOne("Volo.Abp.Identity.IdentityUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityUserRole", b =>
                {
                    b.HasOne("Volo.Abp.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Volo.Abp.Identity.IdentityUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Volo.Abp.Identity.IdentityUserToken", b =>
                {
                    b.HasOne("Volo.Abp.Identity.IdentityUser")
                        .WithMany("Tokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}