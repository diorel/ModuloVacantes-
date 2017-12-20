using System;
using System.ComponentModel;

namespace SAGA.BOL
{
    public class FormulariosIniciales
    {
        public Guid Id { get; set; }

        [DefaultValue(false)]
        public bool Paso1 { get; set; }
        [DefaultValue(false)]
        public bool Paso2 { get; set; }
        [DefaultValue(false)]
        public bool Paso3 { get; set; }

        public Guid CandidatoId { get; set; }
        public virtual Candidato Candidato { get; set; }

        public FormulariosIniciales()
        {
            this.Id = Guid.NewGuid();
        }
    }
}