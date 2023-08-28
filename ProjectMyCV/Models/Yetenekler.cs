using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectMyCV.Models
{
    public class Yetenekler
    {
        [Key]
        public int Id { get; set; }
        public string Yetenek { get; set; }
        public int Derece { get; set; }
    }
}