using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.DAL;
using SistemasVentas.Modelos;

namespace SistemasVentas.BSS
{
    public class examen2Bss
    {
        public examen2Bss() { }
        Examen2Dal dal = new Examen2Dal();
        public DataTable UsurioDatosBss()
        {
            return dal.DatosClientesDal();
        }
        public DataTable TotalPorProveedorBss()
        {
            return dal.TotalPorProveedorDal();
        }
        public DataTable MarcaMasVendidaBss()
        {
            return dal.MarcaMasVendidaDal() ;
        }

        public DataTable CantidadProductosBss()
        {
            return dal.CantidadProductosDal();
        }

        public DataTable orden5Bss()
        {
            return dal.orden5Dal();
        }

        public DataTable orden6Bss()
        {
            return dal.orden6Dal();
        }

        public DataTable orden7Bss()
        {
            return dal.orden7Dal();
        }

        public DataTable orden8Bss()
        {
            return dal.orden8Dal();
        }

        public DataTable orden9Bss()
        {
            return dal.orden9Dal();
        }

        public DataTable orden10Bss()
        {
            return dal.orden10Dal();
        }
    }
}
