using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGA.BOL
{
    class Estatus
    {

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string IdModulo { get; set; }
        public Nullable<bool> Activo { get; set; }


    }
}
