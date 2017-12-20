using System;

namespace SAGA.BOL
{
    public class ObservacionesPerfil
    {
        public Guid Id { get; set; }
        public string Observaciones { get; set; }
        public Guid DAMFO290Id { get; set; }

        public virtual DAMFO_290 DAMFO290 { get; set; }
    }
}