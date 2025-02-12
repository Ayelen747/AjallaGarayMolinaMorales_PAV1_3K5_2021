﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Grupo5.Entities
{
    class Cliente
    {
        public int Id_cliente { get; set;}
        public int Cuit { get; set; }
        public String Razon_social { get; set; }
        public String Fecha_alta { get; set; }
        public int Borrado { get; set; }
        public String Calle { get; set; }
        public int Numero { get; set; }
        public Barrio Barrio { get; set; }
        public Contacto Contacto { get; set; }

        public override string ToString()
        {
            return Razon_social;
        }
    }

    
}
