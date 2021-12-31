using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rehber.Models.Entities
{
    public class Sehir
    {
        public int Id { get; set; }
        public string SehirAdi { get; set; }

        public int PlakaKodu { get; set; }
    }
}