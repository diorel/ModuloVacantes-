using System;

namespace SAGA.BOL
{
    public class PsicometriasDamsa
    {
        public Guid Id { get; set; }
        public Guid PsicometriaId { get; set; }
        public Guid DAMFO290Id { get; set; }

        public virtual DAMFO_290 DAMFO290 { get; set; }
    }
}