using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using TP_Grupo5.Entities;

namespace TP_Grupo5.DataAccesLayer
{
    public class ContactoDao
    {
        public IList<Contacto> getAll()
        {
            List<Contacto> listaCliente = new List<Contacto>();
            string consulta = string.Concat(" SELECT ",
                                            "c.id_contacto,",
                                            "c.apellido,",
                                            "c.email,",
                                            "c.nombre,",
                                            "c.telefono,",
                                            "c.borrado",
                                            " FROM Contactos c ",
                                            " WHERE c.borrado=0");
            var resConsulta=DBHelper.GetDBHelper().ConsultaSQL(consulta);
            foreach (DataRow row in resConsulta.Rows)
            {
                listaCliente.Add(ObjectMapping(row));
            }
            return listaCliente;
        }
        public IList<Contacto> consultWithFilter(string filtro)
        {
            List<Contacto> listaCliente = new List<Contacto>();
            string consulta = string.Concat(" SELECT ",
                                            "c.id_contacto,",
                                            "c.apellido,",
                                            "c.email,",
                                            "c.nombre,",
                                            "c.telefono,",
                                            "c.borrado",
                                            " FROM Contactos c ",
                                            " WHERE c.borrado=0");
            consulta = consulta + filtro + " ORDER BY c.id_contacto";
            var resConsulta = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            foreach (DataRow row in resConsulta.Rows)
            {
                listaCliente.Add(ObjectMapping(row));
            }
            return listaCliente;
        }

        public Contacto ObjectMapping(DataRow row)
        {
            Contacto oContacto = new Contacto
            {
                Id_Contacto = Convert.ToInt32(row["id_contacto"].ToString()),
                Apellido = row["apellido"].ToString(),
                Email = row["email"].ToString(),
                Nombre= row["nombre"].ToString(),
                Telefono=row["telefono"].ToString(),
            };
            return oContacto;
        }
        public bool Create(Contacto contacto)
        {

            string consulta = "INSERT INTO Contactos(nombre,apellido,email,telefono,borrado)" +
                            " VALUES (" +
                            "'" + contacto.Nombre + "'," +
                            "'" + contacto.Apellido + "'," +
                            "'" + contacto.Email + "'," +
                            "'" + contacto.Telefono + "'," +
                            "0)";

            return (DBHelper.GetDBHelper().EjecutarSQL(consulta) == 1);
        }

        public bool Update(Contacto contacto)
        {
            string consulta = "UPDATE Contactos" +
                                " SET " +
                                "nombre='" + contacto.Nombre + "'," +
                                "apellido='" + contacto.Apellido + "'," +
                                "email='" + contacto.Email + "'," +
                                "telefono='" + contacto.Telefono + "'" +
                               " WHERE id_contacto=" + contacto.Id_Contacto;
            return (DBHelper.GetDBHelper().EjecutarSQL(consulta) == 1);
        }

        public bool Delete(Contacto contacto)
        {
            string consulta = "UPDATE Contactos " +
                              "SET borrado=1" +
                              " WHERE id_contacto=" + contacto.Id_Contacto;
            return (DBHelper.GetDBHelper().EjecutarSQL(consulta) == 1);
        }


    }
}
