using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectMyCV.Models
{
    public class Hakkimda
    {
        [Key]
        public int Id { get; set; }
        public string Bilgiler { get; set; }
        public string Egitim { get; set; }
        public string IsDeneyimleri { get; set; }
    }
}