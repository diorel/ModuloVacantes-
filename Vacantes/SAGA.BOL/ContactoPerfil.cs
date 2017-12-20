using System;

namespace SAGA.BOL
{
    public class ContactoPerfil
    {
        public Guid Id { get; set; }
        public Guid ContactoId { get; set; }
        public Guid DAMFO290Id { get; set; }

        public virtual Contacto Contactos { get; set; }
        public virtual DAMFO_290 DAMFO290 { get; set; }

    }
}