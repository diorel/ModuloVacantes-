using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGA.BOL
{
    class Requisicion
    {

        public Guid Id { get; set; }
        public string VBtra { get; set; }
        public int EscolaridadId { get; set; }
        public string Experiencia { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaAprobacion { get; set; }
        public DateTime FechaCumplimiento { get; set; }
        public int ZonaId { get; set; }
        public int CategoriaId { get; set; }
        public int ClienteId { get; set; }
        public decimal Salario { get; set; }
        public int NivelId { get; set; }
        public int AptitudesId { get; set; }
        public int HorariosId { get; set; }
        public string Actividades { get; set; }
        public int BeneficiosId { get; set; }
        public int ContratoId { get; set; }
        public int PrestacionesId { get; set; }
        public string Folio { get; set; }
        public int SolicitanteId { get; set; }
        public  Boolean Confidencial { get; set; }
        public Boolean Aprobada { get; set; }
        public int AprobadorId { get; set; }
        public Boolean Asignada { get; set; }
        public int PrioridadId { get; set; }
        public int OfcReclutamientoId { get; set; }
        public int EstatusId { get; set; }
        public int IDDAMFO290 { get; set; }
        public int SexoId { get; set; }
        public int EstadoCivilId { get; set; }
        public int DireccionId { get; set; }
        public int FechaMod { get; set; }
        public int UsuarioMod { get; set; }


        public virtual EstadoEstudio Escolaridad { get; set; }
        public virtual TipoDireccion Zona { get; set; }
        public virtual Area Categoria { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Nivel Nivel { get; set; }
        public virtual Aptitud Aptitudes { get; set; }
        public virtual HorarioPerfil Horario { get; set; }
        public virtual BeneficiosPerfil Beneficios { get; set; }
        public virtual TipoContrato Contrato { get; set; }
        public virtual PrestacionLey Prestraciones { get; set; }
        public virtual Usuarios Solicitante { get; set; }
        public virtual Usuarios Aprobador { get; set; }
        public virtual Prioridad Prioridad { get; set; }
        public virtual OfcReclutamiento ofcReclutamiento { get; set; }
        public virtual Estatus Estatus { get; set; }
        public virtual DAMFO_290 DAMFO290 { get; set; }
        public virtual Genero Sexo { get; set; }
        public virtual EstadoCivil EstadoCivil { get; set; }
        public virtual Direccion Direccion { get; set; }
    }
}
