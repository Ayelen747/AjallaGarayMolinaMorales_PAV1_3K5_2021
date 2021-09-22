using System;
using System.Collections.Generic;
using System.Text;
using TP_Grupo5.DataAccesLayer;
using TP_Grupo5.Entities;
namespace TP_Grupo5.BusinesLayer
{
    class BarrioServicio
    {
        private BarrioDao oBarrioDao = new BarrioDao();

        public IList<Barrio> dameTodo()
        {
            return oBarrioDao.getAll();
        }
    }
}
