﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Adi { get; set; }
        [Required]
        public string Soyadi { get; set; }
        public string Gorevi { get; set; }
        [Required, StringLength(20)]
        public string KullaniciAdi { get; set; }
        [Required, StringLength(20)]
        public string Sifre { get; set; }
        [Required]
        public bool AktifMi { get; set; }

        // İlişkiler

        public Theater Salon { get; set; }
    }
}
