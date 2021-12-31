using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rehber.Models.Entities
{
    public class Kişi

    {
        public int Id { get; set; }
        public string KisiAdi { get; set; }
        public string Soyad { get; set; }
        public string EvTelefon{ get; set; }
        public string CepTelefon { get; set; }
        public string IsTelefon { get; set; }
        public string EmailAdres { get; set; }
        public string Adres { get; set; }
        public int SehirId { get; set; }

        public Sehir Sehir { get; set; }

    }
}