using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGA.BOL
{
    class Usuarios
    {

        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Nombre { get; set; }
        public Nullable<bool> Activo { get; set; }

    }
}
