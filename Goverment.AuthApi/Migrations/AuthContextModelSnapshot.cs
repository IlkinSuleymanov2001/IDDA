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
                            PasswordHash = new byte[] { 157, 15, 250, 172, 26, 4, 34, 171, 163, 18, 10, 115, 179, 238, 186, 0, 127, 188, 145, 35, 67, 88, 155, 183, 126, 215, 233, 174, 164, 110, 41, 24, 156, 71, 4, 110, 0, 29, 75, 191, 62, 129, 18, 65, 166, 184, 6, 176, 92, 5, 0, 51, 75, 47, 237, 2, 143, 49, 74, 197, 76, 200, 115, 232 },
                            PasswordSalt = new byte[] { 61, 1, 227, 172, 100, 125, 89, 13, 76, 92, 21, 247, 144, 49, 163, 244, 63, 84, 167, 236, 217, 172, 154, 74, 75, 60, 85, 221, 12, 229, 233, 146, 197, 147, 28, 179, 73, 113, 73, 218, 185, 65, 102, 71, 134, 224, 194, 131, 91, 184, 193, 91, 122, 221, 26, 96, 55, 170, 246, 124, 99, 253, 11, 87, 31, 197, 210, 27, 214, 87, 113, 81, 203, 52, 238, 186, 214, 84, 41, 183, 100, 88, 76, 162, 106, 94, 204, 212, 4, 31, 90, 181, 149, 61, 231, 69, 245, 18, 7, 34, 18, 126, 55, 21, 3, 245, 57, 229, 62, 71, 97, 206, 48, 12, 238, 79, 14, 120, 161, 222, 65, 39, 254, 106, 69, 55, 172, 63 },
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