using System;

namespace SAGA.BOL
{
    public class AptitudesPerfil
    {
        public Guid Id { get; set; }
        public string Aptitudes { get; set; }
        public Guid DAMFO290Id { get; set; }

        public virtual DAMFO_290 DAMFO290 { get; set; }
    }
}