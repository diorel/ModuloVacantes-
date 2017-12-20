using System;

namespace SAGA.BOL
{
    public class DocumentosCliente
    {
        public Guid Id { get; set; }
        public string Documento { get; set; }
        public Guid DAMFO290Id { get; set; }

        public virtual DAMFO_290 DAMFO290 { get; set; }
    }
}