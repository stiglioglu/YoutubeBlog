using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YoutubeBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("6e05702c-c500-4649-955e-b1264d3c7bb4"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("8fea3f28-8048-482c-8f1e-b1e38d198d24"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("791d4d0a-729c-4980-b435-0b4675b59496"), new Guid("c0e72f21-6b53-440b-8470-f001794ef1e5"), "Content2", "Admin test2", new DateTime(2024, 5, 19, 15, 41, 35, 938, DateTimeKind.Local).AddTicks(9674), null, null, new Guid("76756daa-e0ef-4ed8-97cd-a9cbc0a9a50a"), false, null, null, "Title2", new Guid("a00edfc0-6709-4167-8990-7e48b2f8ca9e"), 3 },
                    { new Guid("cf60aba5-49d0-4683-b197-12d4f66592f5"), new Guid("f66e52f9-0a94-430b-a949-07a7be45662a"), "Content", "Admin test", new DateTime(2024, 5, 19, 15, 41, 35, 938, DateTimeKind.Local).AddTicks(9666), null, null, new Guid("fc736561-06d2-473e-b4c7-fea7884a488e"), false, null, null, "Title", new Guid("93005e5f-433a-4d09-9f3e-5702df10f77b"), 1 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1a830408-fb65-4ef9-94d2-f73d64fced13"),
                column: "ConcurrencyStamp",
                value: "09b2c6e6-7499-454d-a3c6-8b2171041780");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ac59af34-7f0b-425d-a431-c934d16cc6d2"),
                column: "ConcurrencyStamp",
                value: "9c4e6486-a990-4f4e-8cc6-bd74edf8b6a0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c211c590-3551-4b84-b91c-049f9ca423ed"),
                column: "ConcurrencyStamp",
                value: "443b789f-890b-4f77-99fa-2a07e4f3a5fc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("93005e5f-433a-4d09-9f3e-5702df10f77b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2fbdb51a-2dfa-429b-a45d-b021e2804dd0", "AQAAAAIAAYagAAAAEPVQzZytbdtgnGdxiKhufMeIuIk8ylyzZcj3NpTqgbYpfVBVWK57+jEPruDTrKzPTA==", "4c4f0074-ac35-4ce6-8b0a-274ad2f93651" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a00edfc0-6709-4167-8990-7e48b2f8ca9e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f658b195-4649-4176-90f6-46538144deb6", "AQAAAAIAAYagAAAAEDNwh3NElddDcBFXtMVQ4V2I4vAOz64rZHUEkH+Ig5zqGpzf9GRevG1x+ihc1q6olg==", "a6757e5e-0b8d-42c0-869c-5d7f69d74259" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c0e72f21-6b53-440b-8470-f001794ef1e5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 15, 41, 35, 939, DateTimeKind.Local).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f66e52f9-0a94-430b-a949-07a7be45662a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 15, 41, 35, 939, DateTimeKind.Local).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("76756daa-e0ef-4ed8-97cd-a9cbc0a9a50a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 15, 41, 35, 939, DateTimeKind.Local).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("fc736561-06d2-473e-b4c7-fea7884a488e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 19, 15, 41, 35, 939, DateTimeKind.Local).AddTicks(3364));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("791d4d0a-729c-4980-b435-0b4675b59496"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("cf60aba5-49d0-4683-b197-12d4f66592f5"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("6e05702c-c500-4649-955e-b1264d3c7bb4"), new Guid("c0e72f21-6b53-440b-8470-f001794ef1e5"), "Content2", "Admin test2", new DateTime(2024, 5, 15, 19, 11, 2, 702, DateTimeKind.Local).AddTicks(1309), null, null, new Guid("76756daa-e0ef-4ed8-97cd-a9cbc0a9a50a"), false, null, null, "Title2", new Guid("a00edfc0-6709-4167-8990-7e48b2f8ca9e"), 3 },
                    { new Guid("8fea3f28-8048-482c-8f1e-b1e38d198d24"), new Guid("f66e52f9-0a94-430b-a949-07a7be45662a"), "Content", "Admin test", new DateTime(2024, 5, 15, 19, 11, 2, 702, DateTimeKind.Local).AddTicks(1303), null, null, new Guid("fc736561-06d2-473e-b4c7-fea7884a488e"), false, null, null, "Title", new Guid("93005e5f-433a-4d09-9f3e-5702df10f77b"), 1 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1a830408-fb65-4ef9-94d2-f73d64fced13"),
                column: "ConcurrencyStamp",
                value: "3c790d39-f08a-4700-9938-aee5c5ec3695");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("ac59af34-7f0b-425d-a431-c934d16cc6d2"),
                column: "ConcurrencyStamp",
                value: "e21ce558-49ba-417f-afad-347f1c79271e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c211c590-3551-4b84-b91c-049f9ca423ed"),
                column: "ConcurrencyStamp",
                value: "aa1f2b07-a5c2-4544-beab-59d07bd44807");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("93005e5f-433a-4d09-9f3e-5702df10f77b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ad861fb-d82a-4243-badd-376a03df84ac", "AQAAAAIAAYagAAAAECOZmjRCNkd7bpgJqm+Dvg1tNvEpK5DgNb6mht8KNHxsthr3MOI0YgJncu/NXb3FUA==", "5509b072-affa-46ec-8f47-fdb1e317931a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a00edfc0-6709-4167-8990-7e48b2f8ca9e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d5df07a-1542-4761-9a60-f543cdf591d9", "AQAAAAIAAYagAAAAEE37h7Kt/EUZYYYexbHl+OHRX9ea8qUJ25C15zscDJi/73mim8PRx8OV/cjUgQ5Bdg==", "0c10ab11-878e-4253-a325-9ef2ca613f29" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c0e72f21-6b53-440b-8470-f001794ef1e5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 15, 19, 11, 2, 702, DateTimeKind.Local).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f66e52f9-0a94-430b-a949-07a7be45662a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 15, 19, 11, 2, 702, DateTimeKind.Local).AddTicks(3108));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("76756daa-e0ef-4ed8-97cd-a9cbc0a9a50a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 15, 19, 11, 2, 702, DateTimeKind.Local).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("fc736561-06d2-473e-b4c7-fea7884a488e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 15, 19, 11, 2, 702, DateTimeKind.Local).AddTicks(4440));
        }
    }
}
