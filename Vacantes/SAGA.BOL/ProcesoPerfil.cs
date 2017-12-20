using System;

namespace SAGA.BOL
{
    public class ProcesoPerfil
    {
        public Guid Id { get; set; }
        public string Proceso { get; set; }
        public Guid DAMFO290Id { get; set; }

        public virtual DAMFO_290 DAMFO290 { get; set; }
    }
}