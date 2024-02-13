using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YY.PersonelTakip.Entity.Entities;

namespace YY.PersonelTakip.DAL.Context
{
    public class PersonelAppContext : DbContext
    {
        DbSet<Personel> Personeller { get; set; }
        DbSet<PersonelAyar> PersonelAyarlari { get; set; }
        DbSet<PersonelEgitim> PersonelEgitimler { get; set; }
        DbSet<KullanilanIzin> KullanilanIzinler { get; set; }
        DbSet<OzlukBilgi> OzlukBilgiler { get; set; }
        DbSet<EgitimBilgi> EgitimBilgileri { get; set; }
        DbSet<IzinHaklari> IzinHaklari {  get; set; }
        DbSet<Departman> Departmanlar {  get; set; }
        DbSet<Kidem> Kidemler {  get; set; }
        DbSet<Sehir> Sehirler { get; set; }





        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=Gaming-PC\SQLEXPRESS;Initial Catalog=PersonelTakipApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personel>()
                .HasKey(a => a.PersonelId);
            modelBuilder.Entity<Personel>()
                .HasIndex(a => a.Tc)
                .IsUnique();

            modelBuilder.Entity<OzlukBilgi>()
                .HasKey(a => a.PersonelId);

            modelBuilder.Entity<EgitimBilgi>()
                .HasKey(a => a.PersonelId);

            modelBuilder.Entity<PersonelEgitim>()
                .HasKey(a => new { a.PersonelId, a.EgitimID });

            modelBuilder.Entity<PersonelSertifika>()
                .HasKey(a => new { a.PersonelId, a.SertifikaId });

            modelBuilder.Entity<IzinHaklari>()
                .HasKey(a => a.PersonelId);

            modelBuilder.Entity<KullanilanIzin>()
                .HasKey(a => new { a.PersonelId, a.BaslangicTarihi });

            modelBuilder.Entity<PersonelAyar>()
                .HasKey(a => a.PersonelId);

            modelBuilder.Entity<EgitimBilgi>()
                .HasOne(e => e.Personel)
                .WithMany()
                .HasForeignKey(e => e.PersonelId)
                .IsRequired(); 

            modelBuilder.Entity<IzinHaklari>()
                .HasOne(i => i.Personel)
                .WithMany()
                .HasForeignKey(i => i.PersonelId)
                .IsRequired(); 

            modelBuilder.Entity<OzlukBilgi>()
                .HasOne(o => o.Personel)
                .WithMany()
                .HasForeignKey(o => o.PersonelId)
                .IsRequired();

            modelBuilder.Entity<PersonelAyar>()
                .HasOne(a => a.Personel)
                .WithMany()
                .HasForeignKey(a => a.PersonelId)
                .IsRequired();


            modelBuilder.Entity<PersonelAyar>()
                .HasOne(a => a.Departman)
                .WithMany()
                .HasForeignKey(a => a.DepartmanID)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Sehir>()
                .HasKey(a => a.SehirId);

            modelBuilder.Entity<Sehir>().HasData(
                new Sehir { SehirId = 1,SehirName = "Ankara" },
                new Sehir { SehirId = 2, SehirName = "İstanbul" },
                new Sehir { SehirId = 3, SehirName = "İzmir" },
                new Sehir { SehirId = 4, SehirName = "Antalya" },
                new Sehir { SehirId = 5, SehirName = "Samsun" });

            modelBuilder.Entity<Departman>().HasData(
        new Departman { DepartmanId = 1, Aciklama = "İnsan Kaynakları", Maas = 5000 },
        new Departman { DepartmanId = 2, Aciklama = "Satış ve Pazarlama", Maas = 5500 },
        new Departman { DepartmanId = 3, Aciklama = "Hukuk", Maas = 6000 },
        new Departman { DepartmanId = 4, Aciklama = "Bilişim", Maas = 6500 });

            modelBuilder.Entity<Kidem>().HasData(
                new Kidem { KidemId = 1, Aciklama = "Stajyer", Maas = 2500 },
                new Kidem { KidemId = 2, Aciklama = "Düz Beyaz Yaka", Maas = 4000 },
                new Kidem { KidemId = 3, Aciklama = "Uzman", Maas = 6000 },
                new Kidem { KidemId = 4, Aciklama = "Yönetici", Maas = 8000 });



            base.OnModelCreating(modelBuilder);
        }

    }


}
