using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGA.BOL
{
    public partial class HorarioPerfil
    {
        public  HorarioPerfil()
        {

        }
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string deDia { get; set; }
        public string aDia { get; set; }
        public string deHora { get; set; }
        public string aHora { get; set; }
        public byte numeroVacantes { get; set; }
        public string Especificaciones { get; set; }
        public Guid DAMFO290Id { get; set; }
        public bool Activo { get; set; }

        public virtual DAMFO_290 DAMFO290 { get; set; }
    }
}
