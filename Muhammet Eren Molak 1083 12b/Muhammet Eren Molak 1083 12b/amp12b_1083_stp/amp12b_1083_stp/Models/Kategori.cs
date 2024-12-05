using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amp12b_1083_stp.Models
{
     public class Kategori
    {
        [Key]
        public int Id { get; set; }

        public int KategoriAdi { get; set; }

        //bir kategorinin birden fazla ürünü olabilir   

        public virtual ICollection<Urun> Urunler { get; set; }=new HashSet<Urun>();
    }
}
