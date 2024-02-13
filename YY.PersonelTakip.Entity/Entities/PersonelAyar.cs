using YY.PersonelTakip.Entity.Abstract;

namespace YY.PersonelTakip.Entity.Entities
{
    public class PersonelAyar : IEntity
    {
        public Personel Personel { get; set; }
        public int PersonelId { get; set; }
        public Departman Departman { get; set; }
        public int DepartmanID { get; set; }
        public Kidem Kidem { get; set; }
        public int KidemID { get; set; }
    }

}
