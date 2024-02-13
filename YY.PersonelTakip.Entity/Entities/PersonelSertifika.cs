using System.Diagnostics.CodeAnalysis;
using YY.PersonelTakip.Entity.Abstract;

namespace YY.PersonelTakip.Entity.Entities
{
    public class PersonelSertifika : IEntity
    {
        public int SertifikaId { get; set; }
        public Personel Personel { get; set; }
        public int PersonelId { get; set; }
        [AllowNull]
        public byte[] Dosya { get; set; }


    }

}
