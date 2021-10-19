using System;
using System.Collections.Generic;
using System.Text;
using TP_Grupo5.DataAccesLayer;
using TP_Grupo5.Entities;

namespace TP_Grupo5.BusinesLayer
{
    public class ContactoServicio
    {
        private ContactoDao oContactoDao = new ContactoDao();
        public IList<Contacto> dameTodo()
        {
            return oContactoDao.getAll();
        }
    }
}
