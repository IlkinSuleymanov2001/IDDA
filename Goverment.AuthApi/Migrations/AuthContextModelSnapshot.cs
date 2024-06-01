﻿// <auto-generated />
using System;
using Goverment.AuthApi.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Goverment.AuthApi.Migrations
{
    [DbContext(typeof(AuthContext))]
    partial class AuthContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            PasswordHash = new byte[] { 191, 126, 0, 45, 97, 165, 63, 143, 195, 186, 111, 61, 218, 164, 60, 1, 42, 168, 188, 96, 70, 74, 7, 159, 119, 9, 192, 59, 3, 64, 202, 222, 242, 178, 161, 6, 36, 242, 112, 53, 38, 5, 226, 5, 192, 130, 142, 183, 196, 104, 30, 172, 203, 99, 149, 95, 241, 217, 82, 80, 35, 211, 245, 166 },
                            PasswordSalt = new byte[] { 114, 166, 90, 210, 234, 126, 222, 67, 120, 234, 198, 42, 15, 13, 218, 55, 98, 231, 226, 133, 59, 217, 78, 139, 101, 182, 172, 82, 86, 173, 42, 103, 182, 69, 247, 28, 181, 62, 60, 95, 25, 70, 225, 19, 191, 137, 86, 148, 74, 240, 159, 65, 93, 224, 45, 119, 245, 251, 60, 203, 95, 56, 75, 20, 195, 81, 224, 15, 146, 176, 102, 209, 131, 134, 4, 212, 159, 16, 103, 151, 92, 241, 190, 36, 179, 1, 219, 90, 182, 96, 237, 224, 255, 240, 95, 110, 10, 37, 133, 84, 177, 221, 51, 237, 118, 150, 173, 24, 35, 54, 169, 68, 2, 124, 146, 95, 210, 131, 184, 177, 52, 144, 36, 224, 126, 53, 212, 231 },
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

                    b.Property<bool>("IsAccountBlock")
                        .HasMaxLength(5)
                        .HasColumnType("bit")
                        .HasColumnName("isBlock");

                    b.Property<int>("LoginRetryCount")
                        .HasMaxLength(2)
                        .HasColumnType("int")
                        .HasColumnName("LoginRetryCount");

                    b.HasKey("UserId");

                    b.ToTable("UserLoginSecurities", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            IsAccountBlock = false,
                            LoginRetryCount = 0
                        });
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
