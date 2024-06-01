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
    [Migration("20240601070311_mig_2")]
    partial class mig_2
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
                            PasswordHash = new byte[] { 132, 170, 50, 121, 54, 131, 120, 98, 129, 112, 96, 126, 73, 21, 212, 245, 15, 78, 80, 22, 58, 225, 11, 122, 6, 166, 58, 136, 202, 30, 106, 141, 239, 184, 177, 199, 18, 99, 83, 163, 123, 150, 24, 78, 232, 101, 191, 93, 136, 172, 11, 62, 230, 186, 223, 108, 14, 176, 60, 229, 96, 100, 227, 129 },
                            PasswordSalt = new byte[] { 32, 60, 125, 255, 137, 41, 202, 82, 108, 82, 89, 107, 48, 196, 5, 151, 223, 193, 168, 253, 172, 150, 73, 91, 123, 214, 193, 44, 247, 97, 16, 81, 242, 170, 148, 160, 50, 251, 113, 51, 14, 152, 167, 98, 8, 30, 11, 109, 56, 156, 154, 195, 197, 31, 51, 83, 109, 22, 188, 219, 41, 53, 242, 92, 0, 234, 63, 122, 44, 201, 19, 6, 146, 120, 119, 231, 104, 107, 154, 193, 176, 203, 178, 161, 89, 150, 107, 20, 51, 161, 147, 48, 27, 238, 114, 136, 156, 132, 54, 15, 247, 77, 7, 206, 145, 189, 36, 10, 102, 12, 54, 235, 143, 131, 173, 27, 187, 21, 105, 166, 203, 103, 67, 60, 20, 106, 149, 225 },
                            Status = false
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
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
