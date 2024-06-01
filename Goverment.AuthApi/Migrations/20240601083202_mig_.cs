﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Goverment.AuthApi.Migrations
{
    /// <inheritdoc />
    public partial class mig_ : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "passwordhash", "passwordsalt" },
                values: new object[] { new byte[] { 219, 167, 25, 20, 189, 15, 117, 86, 66, 239, 189, 173, 17, 106, 177, 13, 43, 193, 52, 114, 187, 31, 149, 195, 158, 249, 206, 16, 200, 113, 168, 31, 50, 106, 218, 19, 86, 198, 10, 27, 71, 37, 86, 219, 84, 53, 194, 67, 95, 111, 46, 179, 129, 150, 32, 222, 70, 4, 69, 202, 225, 228, 22, 123 }, new byte[] { 98, 117, 71, 127, 192, 22, 244, 204, 196, 220, 140, 103, 229, 161, 57, 84, 68, 171, 44, 51, 219, 135, 66, 107, 203, 108, 211, 101, 227, 154, 82, 57, 32, 247, 143, 164, 120, 72, 195, 57, 206, 206, 100, 48, 135, 91, 91, 97, 155, 24, 204, 165, 248, 245, 112, 67, 161, 99, 71, 23, 54, 239, 67, 205, 36, 55, 209, 119, 124, 45, 8, 141, 240, 0, 77, 57, 7, 180, 33, 8, 115, 28, 110, 1, 222, 98, 42, 108, 58, 28, 105, 249, 236, 182, 231, 214, 169, 50, 124, 52, 64, 235, 89, 115, 216, 28, 251, 5, 62, 97, 74, 135, 60, 190, 250, 47, 142, 71, 192, 113, 48, 4, 6, 102, 85, 241, 157, 135 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "passwordhash", "passwordsalt" },
                values: new object[] { new byte[] { 24, 253, 177, 2, 31, 194, 239, 230, 181, 184, 93, 55, 184, 147, 23, 171, 235, 250, 19, 249, 72, 74, 38, 85, 193, 238, 99, 31, 99, 145, 115, 172, 254, 236, 1, 118, 217, 35, 173, 130, 25, 4, 141, 121, 123, 88, 89, 159, 244, 242, 207, 172, 29, 95, 237, 1, 251, 55, 9, 37, 125, 214, 197, 108 }, new byte[] { 93, 9, 174, 8, 240, 55, 209, 29, 245, 209, 68, 143, 0, 19, 175, 198, 0, 90, 227, 166, 254, 172, 179, 165, 44, 37, 245, 55, 118, 70, 16, 176, 144, 52, 114, 160, 80, 190, 11, 252, 162, 61, 8, 28, 194, 151, 15, 134, 126, 119, 47, 253, 96, 220, 182, 208, 154, 172, 6, 204, 240, 243, 220, 218, 40, 182, 216, 186, 26, 105, 78, 71, 121, 71, 24, 31, 179, 199, 195, 212, 42, 35, 207, 44, 243, 122, 252, 194, 110, 198, 66, 28, 158, 125, 31, 232, 186, 24, 158, 200, 171, 109, 53, 136, 185, 30, 195, 53, 133, 160, 101, 139, 48, 191, 189, 252, 106, 135, 108, 75, 177, 35, 93, 141, 35, 108, 121, 235 } });
        }
    }
}
