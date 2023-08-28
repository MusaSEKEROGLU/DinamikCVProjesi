using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectMyCV.Models
{
    public class KayıtOl
    {
        [Key]
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Şifre { get; set; }
        public DateTime KayıtTarihi { get; set; }
    }
}