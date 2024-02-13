using YY.PersonelTakip.Entity.Abstract;

namespace YY.PersonelTakip.Entity.Entities
{
    public class Kidem :IEntity
    {
        public int KidemId { get; set; }
        public string Aciklama { get; set; }

        public int Maas { get; set; }
    }

}
