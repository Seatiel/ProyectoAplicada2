using ProyectoFarmacia.DAL;
using ProyectoFarmacia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFarmacia.BLL
{
    public class MedicinasBLL
    {
        public static bool Guardar(Medicinas medicina)
        {
            bool retorno = false;
            using (var conexion = new WebFarmaciaDb())
            {
                conexion.Medicina.Add(medicina);

                conexion.SaveChanges();

                retorno = true;
            }
            return retorno;
        }
    }
}