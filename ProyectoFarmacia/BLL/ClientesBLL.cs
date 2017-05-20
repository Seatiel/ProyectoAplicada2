using ProyectoFarmacia.DAL;
using ProyectoFarmacia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFarmacia.BLL
{
    public class ClientesBLL
    {
        public static bool Guardar(Clientes cliente)
        {
            bool retorno = false;
            using (var db = new WebFarmaciaDb())
            {
                try
                {
                    db.Cliente.Add(cliente);
                    db.SaveChanges();
                    retorno = true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return retorno;
        }
    }
}