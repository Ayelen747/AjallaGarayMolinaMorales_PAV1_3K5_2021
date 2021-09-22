﻿using System;
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
                                            "c.calle, ",
                                            "c.numero, ",
                                            "b.id_barrio, ",
                                            "b.nombre AS barrio, ",
                                            "cont.id_contacto, ",
                                            "cont.nombre, ",
                                            "cont.apellido, ",
                                            "cont.email, ",
                                            "cont.telefono ",
                                            " FROM Clientes c ",
                                            " INNER JOIN Barrios b ON (c.id_barrio=b.id_barrio) JOIN Contactos cont ON (cont.id_contacto=c.id_contacto) ",
                                            " WHERE C.borrado=0");

            var resConsulta=DBHelper.GetDBHelper().ConsultaSQL(consulta);
            foreach (DataRow row in resConsulta.Rows)
            {
                listaClientes.Add(ObjectMapping(row));
            }
            return listaClientes;
        }

        public IList<Cliente> consultWithFilter(string filtro)
        {
            List<Cliente> listaClientes = new List<Cliente>();

            string consulta = string.Concat(" SELECT ",
                                            "c.id_cliente, ",
                                            "c.razon_social, ",
                                            "c.cuit, ",
                                            "c.fecha_alta, ",
                                            "c.calle, ",
                                            "c.numero, ",
                                            "b.id_barrio, ",
                                            "b.nombre AS barrio, ",
                                            "cont.id_contacto, ",
                                            "cont.nombre, ",
                                            "cont.apellido, ",
                                            "cont.email, ",
                                            "cont.telefono ",
                                            " FROM Clientes c ",
                                            " INNER JOIN Barrios b ON (c.id_barrio=b.id_barrio) JOIN Contactos cont ON (cont.id_contacto=c.id_contacto) ",
                                            " WHERE C.borrado=0");
            consulta = consulta + filtro;
            var resConsulta = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            foreach (DataRow row in resConsulta.Rows)
            {
                listaClientes.Add(ObjectMapping(row));
            }
            return listaClientes;
        }

        private Cliente ObjectMapping(DataRow row)
        {
            Cliente oCliente = new Cliente
            {
                Id_cliente = Convert.ToInt32(row["id_cliente"].ToString()),
                Razon_social = row["razon_social"].ToString(),
                Cuit = Convert.ToInt32(row["cuit"].ToString()),
                Fecha_alta = Convert.ToDateTime(row["fecha_alta"].ToString()),
                Numero = Convert.ToInt32(row["numero"].ToString()),
                Barrio = new Barrio
                {
                    Id_Barrio = Convert.ToInt32(row["id_barrio"].ToString()),
                    Nombre = row["barrio"].ToString(),
                },
                Contacto = new Contacto
                {
                    Id_Contacto = Convert.ToInt32(row["id_contacto"].ToString()),
                    Nombre = row["nombre"].ToString(),
                    Apellido=row["apellido"].ToString(),
                    Email=row["email"].ToString(),
                    Telefono=row["telefono"].ToString(),
                }
            };
            return oCliente;
        }
    }
}
