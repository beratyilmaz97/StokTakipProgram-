using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMP12A_1425_StokTakipProgramı.Model
{
    public class Kategori
    {
        [Key]
        public int Id { get; set; }
        public string KategoriAdi { get; set; }

        // İlişki : Bir kategoride birden fazla ürüne sahip olabilir

        public virtual ICollection<Urun> Urunler {  get; set; }=new HashSet<Urun>();
    }
}
