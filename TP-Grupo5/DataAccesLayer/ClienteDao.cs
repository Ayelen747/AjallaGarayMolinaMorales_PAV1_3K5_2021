using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TP_Grupo5.Entities;

namespace TP_Grupo5.DataAccesLayer
{
    class ClienteDao
    {
        
        public IList<Cliente> getAll()
        {
            List<Cliente> listaClientes = new List<Cliente>();

            string consulta = string.Concat(" SELECT ",
                                            "c.id_cliente, ",
                                            "c.razon_social, ",
                                            "c.cuit, ",
                                            "c.fecha_alta, ",
                                            "c.numero, ",
                                            "b.id_barrio, ",
                                            "b.nombre, ",
                                            "cont.id_contacto, ",
                                            "cont.nombre, ",
                                            "cont.apellido, ",
                                            "cont.email, ",
                                            "cont.telefono, ",
                                            " FROM Clientes c ",
                                            " INNER JOIN Barrios b ON (c.id_barrio=b.id_barrio) JOIN Contactos cont ON (cont.id_contacto=c.id_contacto) ",
                                            " WHERE C.borrado=0;");

            var resConsulta=DBHelper.GetDBHelper().ConsultaSQL(consulta);
            foreach (DataRow row in resConsulta.Rows)
            {
                listaClientes.Add(ObjectMapping(row));
            }
            return null;
        }

        private Cliente ObjectMapping(DataRow row)
        {
            Cliente oCLiente = new Cliente
            {
                Id_cliente = Convert.ToInt32(row["c.id_cliente"].ToString()),
                Razon_social = row["c.razon_social"].ToString(),
                Cuit = Convert.ToInt32(row["c.razon_social"].ToString()),
                Fecha_alta = row["c.fecha_alta"].ToString(),
                Numero = Convert.ToInt32(row["c.numero"].ToString()),
                Barrio = new Barrio
                {
                    Id_Barrio = Convert.ToInt32(row["b.id_barrio"].ToString()),
                    Nombre = row["b.nombre"].ToString(),
                },
                Contacto = new Contacto
                {
                    Id_Contacto = Convert.ToInt32(row["cont.id_contacto"].ToString()),
                    Nombre = row["cont.nombre"].ToString(),
                    Apellido=row["cont.apellido"].ToString(),
                    Email=row["cont.email"].ToString(),
                    Telefono=row["cont.telefono"].ToString(),
                }
            };
            return null;
        }
    }
}
