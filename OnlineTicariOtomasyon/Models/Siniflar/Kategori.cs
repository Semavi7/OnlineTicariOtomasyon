using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineTicariOtomasyon.Models.Siniflar
{
    public class Kategori
    {
        [Key]
        [Display(Name = "Kategori")]
        public int Kategoriid { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string KategorAd { get; set; }
        public ICollection<Urun>Uruns { get; set; }
    }
}