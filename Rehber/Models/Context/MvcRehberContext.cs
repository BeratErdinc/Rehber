using Rehber.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Rehber.Models.Context
{
    public class MvcRehberContext:DbContext
    {
        public MvcRehberContext():base("Server=.;Database=MvcRehberDb;Trusted_Connection=true")
        {

        }

        // enable-migrations
        // add-migrations veri tabanı adı
        // update-migrations verı tabanını tamamen oluşturur


        public DbSet<Kişi> Kisiler { get; set; }

        public DbSet<Sehir> Sehirler { get; set; }






    }

}