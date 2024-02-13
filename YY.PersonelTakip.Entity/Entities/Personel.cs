using System.Diagnostics.CodeAnalysis;
using YY.PersonelTakip.Entity.Abstract;

namespace YY.PersonelTakip.Entity.Entities
{
    public class Personel : IEntity
    {
        public int PersonelId { get; set; }
        public string Tc { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string AnneAdi { get; set; }
        public string BabaAdi { get; set; }
        public Sehir Sehir { get; set; }
        public int SehirId { get; set; }
        public string MedeniDurum { get; set; }
        [AllowNull]
        public byte[]? Foto { get; set; }

    }

}
