using System;
using System.Collections.Generic;
using System.Text;
using TP_Grupo5.Entities;
using System.Data;
namespace TP_Grupo5.DataAccesLayer
{
    class BarrioDao
    {
        public IList<Barrio> getAll()
        {
            List<Barrio> listaBarrio = new List<Barrio>();

            string consulta = string.Concat("SELECT ",
                                            "b.id_barrio,",
                                            "b.nombre as barrio",
                                            " FROM Barrios b",
                                            " WHERE b.borrado = 0");
            var resConsulta = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            foreach (DataRow row in resConsulta.Rows)
            {
                listaBarrio.Add(ObjectMapping(row));
            }
            return listaBarrio;
        }

        private Barrio ObjectMapping(DataRow row)
        {
            Barrio oBarrio = new Barrio
            {
                Id_Barrio = Convert.ToInt32(row["id_barrio"].ToString()),
                Nombre = row["barrio"].ToString()
            };
            return oBarrio;
        }

        public IList<Barrio> consultWithFilter(string filtro)
        {
            List<Barrio> listaBarrios = new List<Barrio>();

            string consulta = string.Concat("SELECT ",
                                            "b.id_barrio,",
                                            "b.nombre as barrio",
                                            " FROM Barrios b",
                                            " WHERE b.borrado = 0");

            consulta = consulta + filtro;
            var resConsulta = DBHelper.GetDBHelper().ConsultaSQL(consulta);
            foreach (DataRow row in resConsulta.Rows)
            {
                listaBarrios.Add(ObjectMapping(row));
            }
            return listaBarrios;
        }
    }
}
