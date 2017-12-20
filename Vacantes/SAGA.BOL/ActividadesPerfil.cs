using System;

namespace SAGA.BOL
{
    public class ActividadesPerfil
    {
        public Guid Id { get; set; }
        public string Actividades { get; set; }
        public Guid  DAMFO290Id { get; set; }

        public virtual DAMFO_290 DAMFO290 { get; set; }
    }
}