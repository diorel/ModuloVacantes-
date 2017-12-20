using System;

namespace SAGA.BOL
{
    public class PrestacionesClientePerfil
    {
        public Guid Id { get; set; }
        public string Prestamo { get; set; }
        public Guid DAMFO290Id { get; set; }

        public virtual DAMFO_290 DAMFO290 { get; set; }
    }
}