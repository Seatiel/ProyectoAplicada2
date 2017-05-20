using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProyectoFarmacia.DAL
{
    public class WebFarmaciaDb : DbContext 
    {
        public WebFarmaciaDb() : base("ConStr")
        {

        }
        public DbSet<Models.Clientes> Cliente { get; set; }
    }
}