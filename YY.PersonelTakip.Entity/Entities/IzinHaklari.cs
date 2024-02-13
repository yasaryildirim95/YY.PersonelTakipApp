using YY.PersonelTakip.Entity.Abstract;

namespace YY.PersonelTakip.Entity.Entities
{
    public class IzinHaklari : IEntity
    {
        public Personel Personel { get; set; }
        public int PersonelId { get; set; }
        public int KalanIzinGunu { get; set; }


    }

}
