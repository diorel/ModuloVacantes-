using System;

namespace SAGA.BOL
{
    public class CompetenciaCardinalPerfil
    {
        public Guid Id { get; set; }
        public int CompetenciaId { get; set; }
        public string Nivel { get; set; }
        public Guid DAMFO290Id { get; set; }

        public virtual DAMFO_290 DAMFO290 { get; set; }
        public virtual CompetenciaCardinal Competencia { get; set; }
    }
}