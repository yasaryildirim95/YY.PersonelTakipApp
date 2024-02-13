using YY.PersonelTakip.Entity.Abstract;

namespace YY.PersonelTakip.Entity.Entities
{
    public class KullanilanIzin : IEntity
    {
        public Personel Personel { get; set; }
        public int PersonelId { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }

    }

}
