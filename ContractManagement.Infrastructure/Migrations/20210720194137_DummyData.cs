using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContractManagement.Infrastructure.Migrations
{
    public partial class DummyData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ID", "Age", "CreatedDate", "Email", "Name", "PersonalIdentificationNumber", "Phone", "Surname" },
                values: new object[,]
                {
                    { 1, 30, new DateTime(2021, 7, 20, 21, 41, 37, 425, DateTimeKind.Local).AddTicks(9518), "novak@seznam.cz", "Jan", "870928/1234", "+420777888001", "Novák" },
                    { 20, 18, new DateTime(2021, 7, 20, 21, 41, 37, 425, DateTimeKind.Local).AddTicks(9706), "vyoral@seznam.cz", "Petr", "910708/9899", "+420777888020", "Vyoral" },
                    { 19, 20, new DateTime(2021, 7, 20, 21, 41, 37, 425, DateTimeKind.Local).AddTicks(9703), "narocny@seznam.cz", "Pavel", "901212/4829", "+420777888019", "Náročný" },
                    { 18, 78, new DateTime(2021, 7, 20, 21, 41, 37, 425, DateTimeKind.Local).AddTicks(9699), "vsetecny@seznam.cz", "Roman", "870102/9902", "+420777888018", "Všetečný" },
                    { 17, 45, new DateTime(2021, 7, 20, 21, 41, 37, 425, DateTimeKind.Local).AddTicks(9695), "dockal@seznam.cz", "Filip", "760506/7878", "+420777888017", "Dočkal" },
                    { 16, 35, new DateTime(2021, 7, 20, 21, 41, 37, 425, DateTimeKind.Local).AddTicks(9692), "slima@seznam.cz", "Jan", "880906/8880", "+420777888016", "Slimák" },
                    { 14, 34, new DateTime(2021, 7, 20, 21, 41, 37, 425, DateTimeKind.Local).AddTicks(9683), "osma@seznam.cz", "Martina", "890605/7558", "+420777888014", "Osmá" },
                    { 13, 47, new DateTime(2021, 7, 20, 21, 41, 37, 425, DateTimeKind.Local).AddTicks(9679), "schic@seznam.cz", "Michal", "900909/8009", "+420777888013", "Schick" },
                    { 12, 66, new DateTime(2021, 7, 20, 21, 41, 37, 425, DateTimeKind.Local).AddTicks(9676), "rychly@centrum.cz", "Petr", "031516/5667", "+420777888012", "Rychlý" },
                    { 11, 45, new DateTime(2021, 7, 20, 21, 41, 37, 425, DateTimeKind.Local).AddTicks(9672), "sysel@gmail.com", "Tomáš", "021809/7899", "+420777888011", "Sysel" },
                    { 15, 47, new DateTime(2021, 7, 20, 21, 41, 37, 425, DateTimeKind.Local).AddTicks(9688), "semerad@gmail.com", "Martin", "990907/7899", "+420777888015", "Semerád" },
                    { 9, 38, new DateTime(2021, 7, 20, 21, 41, 37, 425, DateTimeKind.Local).AddTicks(9665), "polna@seznam.cz", "Věra", "670309/6707", "+420777888009", "Polná" },
                    { 8, 23, new DateTime(2021, 7, 20, 21, 41, 37, 425, DateTimeKind.Local).AddTicks(9660), "nadherna@seznam.cz", "Diana", "900709/5677", "+420777888008", "Nádherná" },
                    { 7, 36, new DateTime(2021, 7, 20, 21, 41, 37, 425, DateTimeKind.Local).AddTicks(9657), "usmevava@seznam.cz", "Dana", "891313/6789", "+420777888007", "Usměvavá" },
                    { 6, 39, new DateTime(2021, 7, 20, 21, 41, 37, 425, DateTimeKind.Local).AddTicks(9653), "povedomy@outlook.cz", "Michal", "670608/7890", "+420777888006", "Povědomý" },
                    { 5, 50, new DateTime(2021, 7, 20, 21, 41, 37, 425, DateTimeKind.Local).AddTicks(9650), "vetrova@email.cz", "Jana", "890920/4456", "+420777888005", "Větrová" },
                    { 4, 33, new DateTime(2021, 7, 20, 21, 41, 37, 425, DateTimeKind.Local).AddTicks(9646), "doloman@seznam.cz", "Lukáš", "781304/1234", "+420777888004", "Doloman" },
                    { 3, 23, new DateTime(2021, 7, 20, 21, 41, 37, 425, DateTimeKind.Local).AddTicks(9642), "pospisil@gmail.com", "Pavel", "971020/8907", "+420777888003", "Pospíšil" },
                    { 2, 20, new DateTime(2021, 7, 20, 21, 41, 37, 425, DateTimeKind.Local).AddTicks(9636), "pekny@seznam.cz", "Petr", "990728/4567", "+420777888002", "Pěkný" },
                    { 10, 36, new DateTime(2021, 7, 20, 21, 41, 37, 425, DateTimeKind.Local).AddTicks(9668), "tmava@seznam.cz", "Kristýna", "980909/9090", "+420777888010", "Tmavá" }
                });

            migrationBuilder.InsertData(
                table: "Consultants",
                columns: new[] { "ID", "Age", "CreatedDate", "Email", "Name", "PersonalIdentificationNumber", "Phone", "Surname" },
                values: new object[,]
                {
                    { 7, 20, new DateTime(2021, 7, 20, 21, 41, 37, 426, DateTimeKind.Local).AddTicks(265), "narocny@seznam.cz", "Pavel", "901212/4829", "+420777888019", "Náročný" },
                    { 6, 78, new DateTime(2021, 7, 20, 21, 41, 37, 426, DateTimeKind.Local).AddTicks(261), "vsetecny@seznam.cz", "Roman", "870102/9902", "+420777888018", "Všetečný" },
                    { 5, 45, new DateTime(2021, 7, 20, 21, 41, 37, 426, DateTimeKind.Local).AddTicks(258), "dockal@seznam.cz", "Filip", "760506/7878", "+420777888017", "Dočkal" },
                    { 1, 30, new DateTime(2021, 7, 20, 21, 41, 37, 426, DateTimeKind.Local).AddTicks(215), "novak@seznam.cz", "Jan", "870928/1234", "+420777888001", "Novák" },
                    { 3, 23, new DateTime(2021, 7, 20, 21, 41, 37, 426, DateTimeKind.Local).AddTicks(250), "pospisil@gmail.com", "Pavel", "971020/8907", "+420777888003", "Pospíšil" },
                    { 2, 20, new DateTime(2021, 7, 20, 21, 41, 37, 426, DateTimeKind.Local).AddTicks(246), "pekny@seznam.cz", "Petr", "990728/4567", "+420777888002", "Pěkný" },
                    { 4, 35, new DateTime(2021, 7, 20, 21, 41, 37, 426, DateTimeKind.Local).AddTicks(254), "slima@seznam.cz", "Jan", "880906/8880", "+420777888016", "Slimák" }
                });

            migrationBuilder.InsertData(
                table: "Institutions",
                columns: new[] { "ID", "CreatedDate", "Name" },
                values: new object[,]
                {
                    { 2, new DateTime(2021, 7, 20, 21, 41, 37, 424, DateTimeKind.Local).AddTicks(7107), "Axa" },
                    { 1, new DateTime(2021, 7, 20, 21, 41, 37, 421, DateTimeKind.Local).AddTicks(9079), "AEGON" },
                    { 3, new DateTime(2021, 7, 20, 21, 41, 37, 424, DateTimeKind.Local).AddTicks(7150), "ČSOB" }
                });

            migrationBuilder.InsertData(
                table: "Contracts",
                columns: new[] { "ID", "AdministratorID", "ClientID", "ConclusionDate", "CreatedDate", "InstitutionID", "RegistrationNumber", "TerminationDate", "ValidFromDate" },
                values: new object[,]
                {
                    { 1, 7, 1, new DateTime(2021, 7, 20, 21, 41, 37, 426, DateTimeKind.Local).AddTicks(1602), new DateTime(2021, 7, 20, 21, 41, 37, 426, DateTimeKind.Local).AddTicks(2430), 1, "68768768", new DateTime(2021, 7, 20, 21, 41, 37, 426, DateTimeKind.Local).AddTicks(2170), new DateTime(2021, 7, 20, 21, 41, 37, 426, DateTimeKind.Local).AddTicks(1902) },
                    { 4, 4, 4, new DateTime(2021, 7, 20, 21, 41, 37, 426, DateTimeKind.Local).AddTicks(2543), new DateTime(2021, 7, 20, 21, 41, 37, 426, DateTimeKind.Local).AddTicks(2552), 1, "98908054", new DateTime(2021, 7, 20, 21, 41, 37, 426, DateTimeKind.Local).AddTicks(2549), new DateTime(2021, 7, 20, 21, 41, 37, 426, DateTimeKind.Local).AddTicks(2546) },
                    { 6, 2, 6, new DateTime(2021, 7, 20, 21, 41, 37, 426, DateTimeKind.Local).AddTicks(2567), new DateTime(2021, 7, 20, 21, 41, 37, 426, DateTimeKind.Local).AddTicks(2576), 1, "68986545", new DateTime(2021, 7, 20, 21, 41, 37, 426, DateTimeKind.Local).AddTicks(2573), new DateTime(2021, 7, 20, 21, 41, 37, 426, DateTimeKind.Local).AddTicks(2570) },
                    { 2, 6, 2, new DateTime(2021, 7, 20, 21, 41, 37, 426, DateTimeKind.Local).AddTicks(2486), new DateTime(2021, 7, 20, 21, 41, 37, 426, DateTimeKind.Local).AddTicks(2526), 2, "34567899", new DateTime(2021, 7, 20, 21, 41, 37, 426, DateTimeKind.Local).AddTicks(2516), new DateTime(2021, 7, 20, 21, 41, 37, 426, DateTimeKind.Local).AddTicks(2496) },
                    { 3, 5, 3, new DateTime(2021, 7, 20, 21, 41, 37, 426, DateTimeKind.Local).AddTicks(2530), new DateTime(2021, 7, 20, 21, 41, 37, 426, DateTimeKind.Local).AddTicks(2539), 2, "87964775", new DateTime(2021, 7, 20, 21, 41, 37, 426, DateTimeKind.Local).AddTicks(2536), new DateTime(2021, 7, 20, 21, 41, 37, 426, DateTimeKind.Local).AddTicks(2533) },
                    { 5, 3, 5, new DateTime(2021, 7, 20, 21, 41, 37, 426, DateTimeKind.Local).AddTicks(2555), new DateTime(2021, 7, 20, 21, 41, 37, 426, DateTimeKind.Local).AddTicks(2564), 3, "45786436", new DateTime(2021, 7, 20, 21, 41, 37, 426, DateTimeKind.Local).AddTicks(2561), new DateTime(2021, 7, 20, 21, 41, 37, 426, DateTimeKind.Local).AddTicks(2558) }
                });

            migrationBuilder.InsertData(
                table: "ContractConsultants",
                columns: new[] { "ConsultantID", "ContractID" },
                values: new object[,]
                {
                    { 7, 1 },
                    { 6, 1 },
                    { 5, 1 },
                    { 4, 4 },
                    { 3, 4 },
                    { 2, 4 },
                    { 1, 4 },
                    { 2, 6 },
                    { 1, 6 },
                    { 6, 6 },
                    { 6, 2 },
                    { 3, 2 },
                    { 5, 3 },
                    { 3, 5 },
                    { 7, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ContractConsultants",
                keyColumns: new[] { "ConsultantID", "ContractID" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "ContractConsultants",
                keyColumns: new[] { "ConsultantID", "ContractID" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "ContractConsultants",
                keyColumns: new[] { "ConsultantID", "ContractID" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "ContractConsultants",
                keyColumns: new[] { "ConsultantID", "ContractID" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "ContractConsultants",
                keyColumns: new[] { "ConsultantID", "ContractID" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "ContractConsultants",
                keyColumns: new[] { "ConsultantID", "ContractID" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "ContractConsultants",
                keyColumns: new[] { "ConsultantID", "ContractID" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "ContractConsultants",
                keyColumns: new[] { "ConsultantID", "ContractID" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "ContractConsultants",
                keyColumns: new[] { "ConsultantID", "ContractID" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "ContractConsultants",
                keyColumns: new[] { "ConsultantID", "ContractID" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "ContractConsultants",
                keyColumns: new[] { "ConsultantID", "ContractID" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "ContractConsultants",
                keyColumns: new[] { "ConsultantID", "ContractID" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "ContractConsultants",
                keyColumns: new[] { "ConsultantID", "ContractID" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "ContractConsultants",
                keyColumns: new[] { "ConsultantID", "ContractID" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "ContractConsultants",
                keyColumns: new[] { "ConsultantID", "ContractID" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "Consultants",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Consultants",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Consultants",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Consultants",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Consultants",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Consultants",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Consultants",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Institutions",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Institutions",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Institutions",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
