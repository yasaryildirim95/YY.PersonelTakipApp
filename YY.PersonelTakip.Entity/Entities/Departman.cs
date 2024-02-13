using YY.PersonelTakip.Entity.Abstract;

namespace YY.PersonelTakip.Entity.Entities
{
    public class Departman :IEntity
    {
        public int DepartmanId { get; set; }
        public string Aciklama { get; set; }
        public int Maas { get; set; }
    }

}
