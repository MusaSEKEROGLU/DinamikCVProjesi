using ProjectMyCV.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectMyCV.Contexts
{
    public class CVContext : DbContext
    {
        public DbSet<Adres> Adres { get; set; }
        public DbSet<Calismalarim> Calismalarim { get; set; }
        public DbSet<Hakkimda> Hakkimda { get; set; }
        public DbSet<İletisim> İletisim { get; set; }
        public DbSet<Yetenekler> Yetenekler  { get; set; }
        public DbSet<KayıtOl> KayıtOl  { get; set; }
    }
}