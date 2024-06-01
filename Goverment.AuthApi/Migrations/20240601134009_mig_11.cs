﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Goverment.AuthApi.Migrations
{
    /// <inheritdoc />
    public partial class mig_11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "passwordhash", "passwordsalt" },
                values: new object[] { new byte[] { 191, 126, 0, 45, 97, 165, 63, 143, 195, 186, 111, 61, 218, 164, 60, 1, 42, 168, 188, 96, 70, 74, 7, 159, 119, 9, 192, 59, 3, 64, 202, 222, 242, 178, 161, 6, 36, 242, 112, 53, 38, 5, 226, 5, 192, 130, 142, 183, 196, 104, 30, 172, 203, 99, 149, 95, 241, 217, 82, 80, 35, 211, 245, 166 }, new byte[] { 114, 166, 90, 210, 234, 126, 222, 67, 120, 234, 198, 42, 15, 13, 218, 55, 98, 231, 226, 133, 59, 217, 78, 139, 101, 182, 172, 82, 86, 173, 42, 103, 182, 69, 247, 28, 181, 62, 60, 95, 25, 70, 225, 19, 191, 137, 86, 148, 74, 240, 159, 65, 93, 224, 45, 119, 245, 251, 60, 203, 95, 56, 75, 20, 195, 81, 224, 15, 146, 176, 102, 209, 131, 134, 4, 212, 159, 16, 103, 151, 92, 241, 190, 36, 179, 1, 219, 90, 182, 96, 237, 224, 255, 240, 95, 110, 10, 37, 133, 84, 177, 221, 51, 237, 118, 150, 173, 24, 35, 54, 169, 68, 2, 124, 146, 95, 210, 131, 184, 177, 52, 144, 36, 224, 126, 53, 212, 231 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "passwordhash", "passwordsalt" },
                values: new object[] { new byte[] { 156, 28, 92, 160, 57, 101, 96, 151, 104, 115, 84, 255, 181, 107, 203, 100, 78, 137, 35, 70, 39, 50, 0, 24, 82, 246, 78, 254, 98, 151, 121, 123, 24, 131, 77, 165, 166, 19, 187, 94, 31, 13, 132, 71, 138, 196, 3, 49, 41, 94, 2, 2, 37, 231, 173, 35, 41, 57, 175, 33, 224, 57, 137, 193 }, new byte[] { 244, 219, 254, 209, 138, 120, 237, 147, 114, 74, 136, 100, 159, 12, 32, 196, 19, 78, 167, 21, 180, 192, 100, 163, 92, 217, 117, 253, 149, 36, 196, 204, 49, 51, 105, 135, 0, 167, 186, 210, 152, 113, 179, 65, 180, 110, 122, 34, 238, 87, 204, 90, 3, 54, 7, 232, 81, 169, 208, 141, 148, 205, 44, 22, 157, 143, 106, 44, 113, 181, 198, 58, 174, 9, 144, 121, 26, 40, 132, 176, 43, 205, 13, 121, 230, 135, 223, 229, 15, 136, 118, 147, 220, 55, 142, 181, 57, 1, 117, 109, 1, 27, 188, 43, 218, 106, 96, 53, 32, 141, 243, 44, 66, 183, 164, 113, 40, 44, 88, 91, 94, 166, 1, 206, 205, 13, 83, 128 } });
        }
    }
}
