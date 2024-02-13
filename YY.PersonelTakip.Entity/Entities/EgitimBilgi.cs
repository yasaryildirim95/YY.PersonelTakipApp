using System.Diagnostics.CodeAnalysis;
using YY.PersonelTakip.Entity.Abstract;

namespace YY.PersonelTakip.Entity.Entities
{
    public class EgitimBilgi : IEntity
    {
        public Personel Personel { get; set; }
        public int PersonelId { get; set; }
        public string Ilkokul { get; set; }
        public string Lise { get; set; }
        public string Uni { get; set; }
        [AllowNull]
        public byte[]? UniBelge { get; set; }
        public string Yuksek { get; set; }
        [AllowNull]
        public byte[]? YuksekBelge { get; set; }
        public string Doktora { get; set; }
        [AllowNull]
        public byte[]? DoktoraBelge { get; set; }


    }

}
