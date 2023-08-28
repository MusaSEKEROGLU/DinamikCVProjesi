using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectMyCV.Models
{
    public class Calismalarim
    {
        [Key]
        public int Id { get; set; }
        public string Adres { get; set; }
    }
}