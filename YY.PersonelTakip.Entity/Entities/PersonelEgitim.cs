using YY.PersonelTakip.Entity.Abstract;

namespace YY.PersonelTakip.Entity.Entities
{
    public class PersonelEgitim : IEntity
    {
        public Personel Personel { get; set; }
        public int PersonelId { get; set; }
        public Egitim Egitim { get; set; }
        public int EgitimID { get; set; }
    }

}
