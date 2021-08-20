using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Grupo5.Entities
{
    class Barrio
    {
        public int Id_Barrio { get; set; }
        public String Nombre { get; set; }
        public int Borrado { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
