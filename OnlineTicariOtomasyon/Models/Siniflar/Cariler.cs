﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineTicariOtomasyon.Models.Siniflar
{
    public class Cariler
    {
        [Key]
        public int Cariid { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CariAd { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30, ErrorMessage = "En Fazla 30 Karakter Yazabilirsiniz!")]
        public string CariSoyad { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(13)]
        [Required(ErrorMessage ="Bu Alanı Boş Geçemezsiniz!")]
        public string CariSehir { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string CariMail { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string CariSifre { get; set; }
        public bool Durum { get; set; }
        public ICollection<SatisHareket> SatisHarekets { get; set; }
    }
}