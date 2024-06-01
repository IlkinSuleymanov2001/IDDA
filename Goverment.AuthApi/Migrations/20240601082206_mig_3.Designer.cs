﻿// <auto-generated />
using System;
using Goverment.AuthApi.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Goverment.AuthApi.Migrations
{
    [DbContext(typeof(AuthContext))]
    [Migration("20240601082206_mig_3")]
    partial class mig_3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Core.Security.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("roles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Name = "USER"
                        },
                        new
                        {
                            Id = 1,
                            Name = "ADMIN"
                        });
                });

            modelBuilder.Entity("Core.Security.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConfirmToken")
                        .HasMaxLength(400)
                        .HasColumnType("text")
                        .HasColumnName("confirmtoken");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("firstname");

                    b.Property<bool>("IsResetPassword")
                        .HasMaxLength(20)
                        .HasColumnType("bit")
                        .HasColumnName("isresetpassword");

                    b.Property<bool>("IsVerify")
                        .HasMaxLength(20)
                        .HasColumnType("bit")
                        .HasColumnName("isverify");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("lastname");

                    b.Property<DateTime?>("OptCreatedDate")
                        .HasMaxLength(50)
                        .HasColumnType("datetime2")
                        .HasColumnName("otpcreateddate");

                    b.Property<string>("OtpCode")
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)")
                        .HasColumnName("otpcode");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("passwordhash");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("passwordsalt");

                    b.Property<bool>("Status")
                        .HasColumnType("bit")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.ToTable("users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "ilkinsuleymanov200@gmail.com",
                            FirstName = "Ilkin",
                            IsResetPassword = false,
                            IsVerify = true,
                            LastName = "Suleymanov",
                            PasswordHash = new byte[] { 203, 149, 56, 184, 51, 20, 91, 247, 215, 120, 17, 45, 236, 76, 92, 5, 103, 162, 27, 63, 50, 67, 200, 146, 57, 104, 31, 237, 54, 146, 58, 136, 1, 35, 14, 180, 83, 169, 211, 25, 224, 247, 228, 233, 59, 247, 24, 253, 108, 32, 47, 61, 58, 17, 161, 234, 235, 80, 119, 172, 60, 50, 158, 171 },
                            PasswordSalt = new byte[] { 50, 83, 181, 104, 165, 26, 123, 131, 35, 22, 117, 16, 186, 232, 99, 62, 152, 223, 5, 121, 36, 18, 179, 72, 207, 148, 33, 54, 204, 113, 30, 37, 138, 47, 14, 110, 106, 43, 78, 89, 236, 85, 189, 211, 62, 223, 26, 53, 2, 45, 165, 146, 255, 222, 48, 77, 98, 121, 30, 194, 74, 25, 37, 105, 200, 185, 151, 35, 86, 175, 34, 22, 204, 104, 160, 155, 10, 85, 236, 117, 123, 113, 47, 133, 229, 245, 162, 101, 148, 225, 82, 252, 109, 173, 141, 115, 161, 188, 60, 96, 67, 223, 183, 87, 212, 188, 61, 231, 19, 80, 15, 123, 26, 56, 152, 85, 133, 87, 245, 71, 251, 108, 158, 178, 25, 95, 56, 218 },
                            Status = false
                        });
                });

            modelBuilder.Entity("Core.Security.Entities.UserLoginSecurity", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("userid");

                    b.Property<DateTime?>("AccountBlockedTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("AccountBlockedTime");

                    b.Property<DateTime?>("AccountUnblockedTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("AccountUnBlockedTime");

                    b.Property<bool?>("IsAccountBlock")
                        .HasMaxLength(5)
                        .HasColumnType("bit")
                        .HasColumnName("isBlock");

                    b.Property<int>("LoginRetryCount")
                        .HasMaxLength(2)
                        .HasColumnType("int")
                        .HasColumnName("LoginRetryCount");

                    b.HasKey("UserId");

                    b.ToTable("UserLoginSecurities", (string)null);
                });

            modelBuilder.Entity("Core.Security.Entities.UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("userid");

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("roleid");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("userroles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoleId = 1
                        });
                });

            modelBuilder.Entity("Core.Security.Entities.UserLoginSecurity", b =>
                {
                    b.HasOne("Core.Security.Entities.User", "User")
                        .WithOne("UserLoginSecurity")
                        .HasForeignKey("Core.Security.Entities.UserLoginSecurity", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Core.Security.Entities.UserRole", b =>
                {
                    b.HasOne("Core.Security.Entities.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Security.Entities.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Core.Security.Entities.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("Core.Security.Entities.User", b =>
                {
                    b.Navigation("UserLoginSecurity")
                        .IsRequired();

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
