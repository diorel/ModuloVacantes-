using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGA.BOL
{
    public class DAMFO_290
    {
        public Guid Id { get; set; }
        public Guid ClienteId { get; set; }
        public Guid DireccionId { get; set; }
        public int TipoReclutamientoId { get; set; }
        public int ClaseReclutamientoId { get; set; }
        public string NombrePerfil { get; set; }
        public int SexoId { get; set; }
        public int EdadMinima { get; set; }
        public int EdadMaxima { get; set; }
        public byte EstadoCivilId { get; set; }
        public int NivelId { get; set; }
        public int AreaId { get; set; }
        public string Experiencia { get; set; }
        public decimal SueldoMinimo { get; set; }
        public decimal SueldoMaximo { get; set; }
        public byte DiaCorteId { get; set; }
        public int TipoNominaId { get; set; }
        public byte DiaPagoId { get; set; }
        public int PeriodoPagoId { get; set; }
        public int ContratoInicialId { get; set; }
        public int ContratoFinalId { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Direccion Direccion { get; set; }
        public virtual DiaSemana DiaCorte { get; set; }
        public virtual DiaSemana DiaPago { get; set; }
        public virtual TipoContrato ContratoInicial { get; set; }
        public virtual TipoContrato ContratoFinal{ get; set; }
        public virtual TipoReclutamiento TipoReclutamiento { get; set; }
        public virtual ClaseReclutamiento CalseReclutamiento { get; set; }
        public virtual EstadoCivil EstadoCivil { get; set; }
        public virtual Area Area { get; set; }
        public virtual TipodeNomina TipoNomina { get; set; }
        public virtual PeriodoPago PeriodoPego { get; set; }
        
        public virtual ICollection<EscolaridadesPerfil> escolardadesPerfil { get; set; }
        public virtual ICollection<AptitudesPerfil> Perfil { get; set; }
        public virtual ICollection<TelefonoPerfil> telefonoPerfil { get; set; }
        public virtual ICollection<ContactoPerfil> contactoPerfil { get; set; }
        public virtual ICollection<HorarioPerfil> horariosPErfil { get; set; }
        public virtual ICollection<ActividadesPerfil> actividadesPerfil { get; set; } 
        public virtual ICollection<ObservacionesPerfil> observacionesPerfil { get; set; }
        public virtual ICollection<PsicometriasDamsa> psicometriasDamsa { get; set; }
        public virtual ICollection<PsicometriasCliente> psicometriasCliente { get; set; }
        public virtual ICollection<BeneficiosPerfil> beneficiosPerfil { get; set; }
        public virtual ICollection<DocumentosCliente> documentosCliente { get; set; }
        public virtual ICollection<ProcesoPerfil> procesoPerfil { get; set; }
        public virtual ICollection<PrestacionesClientePerfil> prestacionesCliente { get; set; }
        public virtual ICollection<CompetenciaAreaPerfil> comptenciasAreaPerfil { get; set; }
        public virtual ICollection<CompetenciaCardinalPerfil> competenciasCardinalPerfil { get; set; }
        public virtual ICollection<CompetenciaGerencialPerfil> comptetenciasGerencialPerfil { get; set; }

    }
}
