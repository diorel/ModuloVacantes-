using System;

namespace SAGA.BOL
{
    public class RutasPerfil
    {
        public Guid Id { get; set; }
        public Guid DireccionId { get; set; }
        public string Ruta { get; set; }
        public string Via { get; set; }

        public virtual Direccion Direccion { get; set; }
    }
}