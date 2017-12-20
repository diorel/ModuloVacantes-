using System;

namespace SAGA.BOL
{
    public class EscolaridadesPerfil
    {
        public Guid Id { get; set; }
        public string Escolaridad { get; set; }
        public Guid DAMFO290Id { get; set; }

        public DAMFO_290 DAMFO290 { get; set; }
    }
}