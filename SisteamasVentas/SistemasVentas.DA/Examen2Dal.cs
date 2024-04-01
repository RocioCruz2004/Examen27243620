using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class Examen2Dal
    {
        public DataTable DatosClientesDal()
        {
            string consulta = "SELECT C.IDCLIENTE, P.NOMBRE, P.APELLIDO " +
                              "FROM  PERSONA P INNER JOIN " +
                         "CLIENTE C ON P.IDPERSONA = C.IDPERSONA ";
            return conexion.EjecutarDataTabla(consulta, "fsdf");
        }
        public DataTable TotalPorProveedorDal()
        {
            string consulta = "SELECT IDPROVEEDOR, SUM(TOTAL) AS Total " +
                              "FROM INGRESO " +
                              "GROUP BY IDPROVEEDOR";
            return conexion.EjecutarDataTabla(consulta, "x");
        }

        public DataTable MarcaMasVendidaDal()
        {
            string consulta = "SELECT m.Nombre, COUNT(*) AS CantidadVentas " +
                              " FROM Marca m " +
                              " INNER JOIN Producto p ON m.IdMarca = p.IdMarca " +
                              " INNER JOIN DetalleVenta dv ON p.IdProducto = dv.IdProducto " +
                              "GROUP BY m.Nombre " +
                              "HAVING COUNT(*) = (SELECT TOP 1 COUNT(*) AS CantidadVentas " +
                                                  "FROM Marca m" +
                                                  "     INNER JOIN Producto p ON m.IdMarca = p.IdMarca " +
                                                  "     INNER JOIN DetalleVenta dv ON p.IdProducto = dv.IdProducto " +
                                                  "GROUP BY m.Nombre "+
                                                  "ORDER BY COUNT(*) DESC)";
            return conexion.EjecutarDataTabla(consulta, "x");
        }

        public DataTable CantidadProductosDal()
        {
            string consulta = "SELECT SUM(UNIDAD) " +
                                "FROM PRODUCTO";
            return conexion.EjecutarDataTabla(consulta, "x");
        }

        public DataTable orden5Dal()
        {
            string consulta = "SELECT DI.IDPRODUCTO, P.NOMBRE, DI.FECHAVENC\r\nFROM DETALLEING DI\r\n\tINNER JOIN PRODUCTO P ON DI.IDPRODUCTO = P.IDPRODUCTO\r\nWHERE DI.FECHAVENC <= DATEADD(MONTH, 1, GETDATE()) AND\r\n      DI.FECHAVENC >= GETDATE();";
            return conexion.EjecutarDataTabla(consulta, "x");
        }

        public DataTable orden6Dal()
        {
            string consulta = "SELECT P.NOMBRE + P.APELLIDO AS VENDEDOR, PR.NOMBRE, SUM(DV.CANTIDAD) AS [CANTIDAD PRODCUTO]\r\nFROM DETALLEVENTA DV\r\n\tINNER JOIN VENTA V ON DV.IDVENTA = V.IDVENTA\r\n\tINNER JOIN USUARIO U ON V.IDVENDEDOR = U.IDUSUARIO\r\n\tINNER JOIN PERSONA P ON U.IDPERSONA = P.IDPERSONA\r\n\tINNER JOIN PRODUCTO PR ON DV.IDPRODUCTO = PR.IDPRODUCTO\r\nGROUP BY P.NOMBRE, P.APELLIDO, PR.NOMBRE, DV.CANTIDAD";
            return conexion.EjecutarDataTabla(consulta, "x");
        }

        public DataTable orden7Dal()
        {
            string consulta = "SELECT V.IDCLIENTE, NOMBRE + ' ' + APELLIDO AS NOMBRES, SUM(TOTAL) [INGRESO GENERADO]\r\nFROM VENTA V\r\n\tINNER JOIN CLIENTE C ON V.IDCLIENTE=C.IDCLIENTE\r\n\tINNER JOIN PERSONA P ON C.IDPERSONA=P.IDPERSONA\r\nGROUP BY V.IDCLIENTE, NOMBRE, APELLIDO";
            return conexion.EjecutarDataTabla(consulta, "x");
        }

        public DataTable orden8Dal()
        {
            string consulta = "SELECT TOP 1 PR.NOMBRE, COUNT(*) AS [CANTIDAD PRODUCTOS]\r\nFROM PROVEE P\r\n\tINNER JOIN PROVEEDOR PR ON P.IDPROVEEDOR = PR.IDPROVEEDOR\r\nGROUP BY PR.NOMBRE\r\nORDER BY COUNT(*) DESC;";
            return conexion.EjecutarDataTabla(consulta, "x");
        }

        public DataTable orden9Dal()
        {
            string consulta = "SELECT TP.NOMBRE, SUM(DV.CANTIDAD) AS CANTIDAD\r\nFROM DETALLEVENTA DV\r\n\tINNER JOIN PRODUCTO P ON DV.IDPRODUCTO = P.IDPRODUCTO\r\n\tINNER JOIN TIPOPROD TP ON P.IDTIPOPROD = TP.IDTIPOPROD\r\nGROUP BY TP.NOMBRE;";
            return conexion.EjecutarDataTabla(consulta, "x");
        }

        public DataTable orden10Dal()
        {
            string consulta = "SELECT C.IDCLIENTE, P.NOMBRE AS NombreCliente, SUM(DV.SUBTOTAL) AS TotalCompras \r\nFROM CLIENTE C\r\nINNER JOIN VENTA V ON C.IDCLIENTE = V.IDCLIENTE\r\nINNER JOIN DETALLEVENTA DV ON V.IDVENTA = DV.IDVENTA\r\nINNER JOIN PERSONA P ON C.IDPERSONA= P.IDPERSONA\r\nGROUP BY C.IDCLIENTE, P.NOMBRE\r\nHAVING SUM(DV.SUBTOTAL) > 30;";
            return conexion.EjecutarDataTabla(consulta, "x");
        }
    }
}

