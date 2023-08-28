using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectMyCV.Models
{
    public class Adres
    {
        [Key]
        public int Id { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Adres1 { get; set; }
        public string Konum { get; set; }
    }
}