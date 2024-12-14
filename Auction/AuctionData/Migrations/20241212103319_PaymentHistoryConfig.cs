using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuctionDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class PaymentHistoryConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClientSecret",
                table: "PaymentHistories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StripePaymentIntentId",
                table: "PaymentHistories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 29, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3638), new DateTime(2024, 12, 12, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3623) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 5, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3647), new DateTime(2024, 12, 12, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3646) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 22, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3650), new DateTime(2024, 12, 12, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3649) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 29, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3653), new DateTime(2024, 12, 12, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3652) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 22, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3655), new DateTime(2024, 12, 12, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3655) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 29, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3659), new DateTime(2024, 12, 12, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3658) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 22, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3663), new DateTime(2024, 12, 12, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3662) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 29, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3666), new DateTime(2024, 12, 12, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3665) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 22, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3668), new DateTime(2024, 12, 12, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3668) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 29, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3671), new DateTime(2024, 12, 12, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3670) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 22, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3674), new DateTime(2024, 12, 12, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3673) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 29, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3676), new DateTime(2024, 12, 12, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3676) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 22, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3680), new DateTime(2024, 12, 12, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3680) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 29, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3683), new DateTime(2024, 12, 12, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3682) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 22, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3685), new DateTime(2024, 12, 12, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3685) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 22, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3688), new DateTime(2024, 12, 12, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3688) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 29, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3691), new DateTime(2024, 12, 12, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3690) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 18,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 22, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3693), new DateTime(2024, 12, 12, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3693) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 29, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3696), new DateTime(2024, 12, 12, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3696) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 20,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 22, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3700), new DateTime(2024, 12, 12, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3699) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 21,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 29, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3702), new DateTime(2024, 12, 12, 13, 33, 18, 441, DateTimeKind.Local).AddTicks(3702) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientSecret",
                table: "PaymentHistories");

            migrationBuilder.DropColumn(
                name: "StripePaymentIntentId",
                table: "PaymentHistories");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 27, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7759), new DateTime(2024, 12, 10, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7744) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 3, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7774), new DateTime(2024, 12, 10, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7773) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7779), new DateTime(2024, 12, 10, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 27, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7783), new DateTime(2024, 12, 10, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7783) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7787), new DateTime(2024, 12, 10, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7787) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 27, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7791), new DateTime(2024, 12, 10, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7795), new DateTime(2024, 12, 10, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7794) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 27, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7799), new DateTime(2024, 12, 10, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7802), new DateTime(2024, 12, 10, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7802) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 27, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7807), new DateTime(2024, 12, 10, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7811), new DateTime(2024, 12, 10, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7810) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 27, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7815), new DateTime(2024, 12, 10, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7814) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7819), new DateTime(2024, 12, 10, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7818) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 27, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7823), new DateTime(2024, 12, 10, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7827), new DateTime(2024, 12, 10, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7826) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7832), new DateTime(2024, 12, 10, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7831) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 27, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7836), new DateTime(2024, 12, 10, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7835) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 18,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7839), new DateTime(2024, 12, 10, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7839) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 27, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7843), new DateTime(2024, 12, 10, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7842) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 20,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7847), new DateTime(2024, 12, 10, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7847) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 21,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 27, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7851), new DateTime(2024, 12, 10, 20, 10, 53, 614, DateTimeKind.Local).AddTicks(7850) });
        }
    }
}
