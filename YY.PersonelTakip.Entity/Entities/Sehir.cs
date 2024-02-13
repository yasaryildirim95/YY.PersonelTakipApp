using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YY.PersonelTakip.Entity.Abstract;

namespace YY.PersonelTakip.Entity.Entities
{
    public class Sehir : IEntity
    {
        public int SehirId { get; set; }
        public string SehirName { get; set; }
    }
}
