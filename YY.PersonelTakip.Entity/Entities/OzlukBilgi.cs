using YY.PersonelTakip.Entity.Abstract;

namespace YY.PersonelTakip.Entity.Entities
{
    public class OzlukBilgi : IEntity
    {
        public Personel Personel { get; set; }
        public int PersonelId { get; set; }
        public string Ikametgah { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public byte[] SaglikRaporu { get; set; }
        public byte[] AdliSicilBelgesi { get; set; }
        public byte[] Ehliyet { get; set; }
        public byte[] SirketSozlesmesi { get; set; }
        public byte[] Cv { get; set; }
        public byte[] IsBasvurusu { get; set; }
        public byte[] EvlilikCüzdanı { get; set; }
        public byte[] AskerlikBelgesi { get; set; }

    }

}
