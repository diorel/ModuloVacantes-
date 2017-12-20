using System;

namespace SAGA.BOL
{
    public class PsicometriasCliente
    {
        public Guid Id { get; set; }
        public string Psicometria { get; set; }
        public string Descripcion { get; set; }
        public Guid DAMFO290Id { get; set; }

        public virtual DAMFO_290 DAMFO290 { get; set; }
    }
}