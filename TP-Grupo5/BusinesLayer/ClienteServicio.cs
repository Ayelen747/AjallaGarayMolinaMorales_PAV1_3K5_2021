using System;
using System.Collections.Generic;
using System.Text;
using TP_Grupo5.DataAccesLayer;
using TP_Grupo5.Entities;

namespace TP_Grupo5.BusinesLayer
{
    class ClienteServicio
    {
        private ClienteDao oClienteDao = new ClienteDao();

        public IList<Cliente> dameTodo()
        {
            return oClienteDao.getAll();
        }

        public IList<Cliente> consultaConFiltros(string filtro)
        {
            return oClienteDao.consultWithFilter(filtro);
        }

        public bool InsertarCliente(Cliente cliente)
        {
            return oClienteDao.Create(cliente);
        }

    }
}
