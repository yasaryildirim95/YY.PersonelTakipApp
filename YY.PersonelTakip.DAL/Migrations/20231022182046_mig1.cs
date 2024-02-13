using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YY.PersonelTakip.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departmanlar",
                columns: table => new
                {
                    DepartmanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Maas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departmanlar", x => x.DepartmanId);
                });

            migrationBuilder.CreateTable(
                name: "Egitim",
                columns: table => new
                {
                    EgitimId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Acıklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Egitim", x => x.EgitimId);
                });

            migrationBuilder.CreateTable(
                name: "Kidemler",
                columns: table => new
                {
                    KidemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Maas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kidemler", x => x.KidemId);
                });

            migrationBuilder.CreateTable(
                name: "Sehirler",
                columns: table => new
                {
                    SehirId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SehirName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sehirler", x => x.SehirId);
                });

            migrationBuilder.CreateTable(
                name: "Personeller",
                columns: table => new
                {
                    PersonelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tc = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AnneAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BabaAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SehirId = table.Column<int>(type: "int", nullable: false),
                    MedeniDurum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Foto = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personeller", x => x.PersonelId);
                    table.ForeignKey(
                        name: "FK_Personeller_Sehirler_SehirId",
                        column: x => x.SehirId,
                        principalTable: "Sehirler",
                        principalColumn: "SehirId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EgitimBilgileri",
                columns: table => new
                {
                    PersonelId = table.Column<int>(type: "int", nullable: false),
                    Ilkokul = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lise = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uni = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UniBelge = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Yuksek = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YuksekBelge = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Doktora = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoktoraBelge = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EgitimBilgileri", x => x.PersonelId);
                    table.ForeignKey(
                        name: "FK_EgitimBilgileri_Personeller_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personeller",
                        principalColumn: "PersonelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IzinHaklari",
                columns: table => new
                {
                    PersonelId = table.Column<int>(type: "int", nullable: false),
                    KalanIzinGunu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IzinHaklari", x => x.PersonelId);
                    table.ForeignKey(
                        name: "FK_IzinHaklari_Personeller_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personeller",
                        principalColumn: "PersonelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KullanilanIzinler",
                columns: table => new
                {
                    PersonelId = table.Column<int>(type: "int", nullable: false),
                    BaslangicTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullanilanIzinler", x => new { x.PersonelId, x.BaslangicTarihi });
                    table.ForeignKey(
                        name: "FK_KullanilanIzinler_Personeller_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personeller",
                        principalColumn: "PersonelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OzlukBilgiler",
                columns: table => new
                {
                    PersonelId = table.Column<int>(type: "int", nullable: false),
                    Ikametgah = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BaslangicTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SaglikRaporu = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    AdliSicilBelgesi = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Ehliyet = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    SirketSozlesmesi = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Cv = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    IsBasvurusu = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    EvlilikCüzdanı = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    AskerlikBelgesi = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OzlukBilgiler", x => x.PersonelId);
                    table.ForeignKey(
                        name: "FK_OzlukBilgiler_Personeller_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personeller",
                        principalColumn: "PersonelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonelAyarlari",
                columns: table => new
                {
                    PersonelId = table.Column<int>(type: "int", nullable: false),
                    DepartmanID = table.Column<int>(type: "int", nullable: false),
                    KidemID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonelAyarlari", x => x.PersonelId);
                    table.ForeignKey(
                        name: "FK_PersonelAyarlari_Departmanlar_DepartmanID",
                        column: x => x.DepartmanID,
                        principalTable: "Departmanlar",
                        principalColumn: "DepartmanId");
                    table.ForeignKey(
                        name: "FK_PersonelAyarlari_Kidemler_KidemID",
                        column: x => x.KidemID,
                        principalTable: "Kidemler",
                        principalColumn: "KidemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonelAyarlari_Personeller_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personeller",
                        principalColumn: "PersonelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonelEgitimler",
                columns: table => new
                {
                    PersonelId = table.Column<int>(type: "int", nullable: false),
                    EgitimID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonelEgitimler", x => new { x.PersonelId, x.EgitimID });
                    table.ForeignKey(
                        name: "FK_PersonelEgitimler_Egitim_EgitimID",
                        column: x => x.EgitimID,
                        principalTable: "Egitim",
                        principalColumn: "EgitimId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonelEgitimler_Personeller_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personeller",
                        principalColumn: "PersonelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonelSertifika",
                columns: table => new
                {
                    SertifikaId = table.Column<int>(type: "int", nullable: false),
                    PersonelId = table.Column<int>(type: "int", nullable: false),
                    Dosya = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonelSertifika", x => new { x.PersonelId, x.SertifikaId });
                    table.ForeignKey(
                        name: "FK_PersonelSertifika_Personeller_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personeller",
                        principalColumn: "PersonelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departmanlar",
                columns: new[] { "DepartmanId", "Aciklama", "Maas" },
                values: new object[,]
                {
                    { 1, "İnsan Kaynakları", 5000 },
                    { 2, "Satış ve Pazarlama", 5500 },
                    { 3, "Hukuk", 6000 },
                    { 4, "Bilişim", 6500 }
                });

            migrationBuilder.InsertData(
                table: "Kidemler",
                columns: new[] { "KidemId", "Aciklama", "Maas" },
                values: new object[,]
                {
                    { 1, "Stajyer", 2500 },
                    { 2, "Düz Beyaz Yaka", 4000 },
                    { 3, "Uzman", 6000 },
                    { 4, "Yönetici", 8000 }
                });

            migrationBuilder.InsertData(
                table: "Sehirler",
                columns: new[] { "SehirId", "SehirName" },
                values: new object[,]
                {
                    { 1, "Ankara" },
                    { 2, "İstanbul" },
                    { 3, "İzmir" },
                    { 4, "Antalya" },
                    { 5, "Samsun" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonelAyarlari_DepartmanID",
                table: "PersonelAyarlari",
                column: "DepartmanID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonelAyarlari_KidemID",
                table: "PersonelAyarlari",
                column: "KidemID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonelEgitimler_EgitimID",
                table: "PersonelEgitimler",
                column: "EgitimID");

            migrationBuilder.CreateIndex(
                name: "IX_Personeller_SehirId",
                table: "Personeller",
                column: "SehirId");

            migrationBuilder.CreateIndex(
                name: "IX_Personeller_Tc",
                table: "Personeller",
                column: "Tc",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EgitimBilgileri");

            migrationBuilder.DropTable(
                name: "IzinHaklari");

            migrationBuilder.DropTable(
                name: "KullanilanIzinler");

            migrationBuilder.DropTable(
                name: "OzlukBilgiler");

            migrationBuilder.DropTable(
                name: "PersonelAyarlari");

            migrationBuilder.DropTable(
                name: "PersonelEgitimler");

            migrationBuilder.DropTable(
                name: "PersonelSertifika");

            migrationBuilder.DropTable(
                name: "Departmanlar");

            migrationBuilder.DropTable(
                name: "Kidemler");

            migrationBuilder.DropTable(
                name: "Egitim");

            migrationBuilder.DropTable(
                name: "Personeller");

            migrationBuilder.DropTable(
                name: "Sehirler");
        }
    }
}
