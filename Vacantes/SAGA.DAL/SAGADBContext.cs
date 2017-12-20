using SAGA.BOL;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace SAGA.DAL
{
    public class SAGADBContext : DbContext
    {
        public SAGADBContext() : base ("SAGADB")
        {
        }

        public DbSet<AboutMe> AcercaDeMi { get; set; }
        public DbSet<ActividadEmpresa> ActividadesEmpresas { get; set; }
        public DbSet<AreaExperiencia> AreasExperiencia { get; set; }
        public DbSet<AreaInteres> AreasInteres { get; set; }
        public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<Carrera> Carreras { get; set; }
        public DbSet<CandidatoConocimientoInformatico> CandidatoCI { get; set; }
        public DbSet<ConocimientoInformatico> ConocimientosInformaticos { get; set; }
        public DbSet<ConocimientoOHabilidad> Conocimientos { get; set; }
        public DbSet<Certificacion> Certificaciones { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<DocumentoValidador> DocumentosValidadores { get; set; }
        public DbSet<ExperienciaProfesional> ExperienciasProfesionales { get; set; }
        public DbSet<FormaContacto> FormasContacto { get; set; }
        public DbSet<FormulariosIniciales> FormulariosIniciales { get; set; }
        public DbSet<InstitucionEducativa> InstitucionesEducativas { get; set; }
        public DbSet<Nivel> Niveles { get; set; }
        public DbSet<PerfilCandidato> PerfilCandidato { get; set; }
        public DbSet<PerfilExperiencia> PerfilExperiencia { get; set; }
        public DbSet<Formacion> Formaciones { get; set; }
        public DbSet<Idioma> Idiomas { get; set; }
        public DbSet<Month> Months { get; set; }
        public DbSet<PerfilIdioma> PerfilesIdiomas { get; set; }
        public DbSet<PerfilProfesional> PerfilesProfesionales { get; set; }
        public DbSet<Porcentage> Porcentages { get; set; }
        public DbSet<TipoDiscapacidad> TiposDiscapacidades { get; set; }
        public DbSet<TipoLicencia> TiposLicencias { get; set; }
        public DbSet<Year> Years { get; set; }

        /*
         *      Reclutamiento
         */
        public DbSet<Agencia> Agencias { get; set; }
        public DbSet<Aptitud> Aptitudes { get; set; }
        public DbSet<BeneficiosPerfil> BeneficiosPerfil { get; set; }
        public DbSet<ClaseReclutamiento> ClasesReclutamientos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<CompetenciaArea> CompetenciasAreas { get; set; }
        public DbSet<CompetenciaCardinal> CompetenciasCardinales { get; set; }
        public DbSet<CompetenciaGarencial> CompetenciasGerenciales { get; set; }
        public DbSet<Contacto> Contactos { get; set; }
        public DbSet<DiaObligatorio> DiasOblicatorios { get; set; }
        public DbSet<DiaSemana> DiasSemanas { get; set; }
        public DbSet<DocumentosDamsa> DocumentosDamsa { get; set; }
        public DbSet<GiroEmpresa> GirosEmpresas { get; set; }
        public DbSet<HorarioPerfil> HorariosPerfiles { get; set; }
        public DbSet<PeriodoPago> PeriodosPagos { get; set; }
        public DbSet<PrestacionLey> PrestacionesLey { get; set; }
        public DbSet<RedSocial> RedesSociales { get; set; }
        public DbSet<Referenciado> Referenciados { get; set; }
        public DbSet<TamanoEmpresa> TamanoEmpresas { get; set; }
        public DbSet<TipoBase> TiposBases { get; set; }
        public DbSet<TipoBeneficio> TiposBeneficios { get; set; }
        public DbSet<TipoContrato> TiposContrato { get; set; }
        public DbSet<TipoEmpresa> TiposEmpresas { get; set; }
        public DbSet<TipodeNomina> TiposNominas { get; set; }
        public DbSet<TipoPsicometria> TiposPsicometrias { get; set; }
        public DbSet<TipoReclutamiento> TiposReclutamientos { get; set; }
        /*----------------------------------------------------------------*/
        public DbSet<ActividadesPerfil> ActividadesPerfil { get; set; }
        public DbSet<AptitudesPerfil> AptitudesPerfil { get; set; }
        public DbSet<CompetenciaAreaPerfil> CompetenciaAreaPerfil { get; set; }
        public DbSet<CompetenciaCardinalPerfil> CompetenciaCardinalPerfil { get; set; }
        public DbSet<CompetenciaGerencialPerfil> CompetenciaGerencialPerfil { get; set; }
        public DbSet<ContactoPerfil> ContactoPerfil { get; set; }
        public DbSet<EscolaridadesPerfil> EscolaridadesPerfil { get; set; }
        public DbSet<ObservacionesPerfil> ObservacionesPerfil { get; set; }
        public DbSet<PrestacionesClientePerfil> PrestacionesClientePerfil { get; set; }
        public DbSet<PsicometriasCliente> PsicometriasCliente { get; set; }
        public DbSet<PsicometriasDamsa> PsicometriasDamsa { get; set; }
        public DbSet<RutasPerfil> RutasPerfil { get; set; }
        public DbSet<TelefonoPerfil> TelefonoPerfil { get; set; }
        /*
         *      Relacionadas 
         */
        public DbSet<Area> Areas { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Colonia> Colonias { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<EstadoCivil> EstadosCiviles { get; set; }
        public DbSet<EstadoEstudio> EstadosEstudios { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<GradoEstudio> GradosEstudios { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Telefono> Telefonos { get; set; }
        public DbSet<TipoTelefono> TiposTelefonos { get; set; }
        public DbSet<TipoDireccion> TiposDirecciones { get; set; }
        public DbSet<TipoRedSocial> TiposRedesSociales { get; set; }
            
        


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<PersonasMap>().Property(p => p.Email).HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute() { IsUnique = true }));
            modelBuilder.HasDefaultSchema("sist");

            /*Bolsa de Trabajo*/
            modelBuilder.Entity<AboutMe>().ToTable("AcercaDeMi");
            modelBuilder.Entity<AreaExperiencia>().ToTable("AreasExperiencia");
            modelBuilder.Entity<AreaInteres>().ToTable("AreasInteres");
            modelBuilder.Entity<CandidatoConocimientoInformatico>().ToTable("CandidatoConocimientoInformatico");
            modelBuilder.Entity<Cargo>().ToTable("Cargos");
            modelBuilder.Entity<Carrera>().ToTable("Carreras");
            modelBuilder.Entity<Certificacion>().ToTable("Certificaciones");
            modelBuilder.Entity<ConocimientoInformatico>().ToTable("ConocimientosInformaticos");
            modelBuilder.Entity<ConocimientoOHabilidad>().ToTable("ConocimientosHabilidades");
            modelBuilder.Entity<Curso>().ToTable("Cursos");
            modelBuilder.Entity<DocumentoValidador>().ToTable("DocumentosValidadores");
            modelBuilder.Entity<FormulariosIniciales>().ToTable("FormulariosIniciales");
            modelBuilder.Entity<Formacion>().ToTable("Formaciones");
            modelBuilder.Entity<FormaContacto>().ToTable("FormasContacto");
            modelBuilder.Entity<ExperienciaProfesional>().ToTable("ExperienciasProfesionales");
            modelBuilder.Entity<InstitucionEducativa>().ToTable("InstitucionesEducativas");
            modelBuilder.Entity<PerfilCandidato>().ToTable("PerfilCandidato");
            modelBuilder.Entity<PerfilExperiencia>().ToTable("PerfilExperiencia");
            modelBuilder.Entity<PerfilProfesional>().ToTable("PerfilesProfesionales");
            modelBuilder.Entity<GradoEstudio>().ToTable("GradosEstudio");
            modelBuilder.Entity<TipoDiscapacidad>().ToTable("TiposDiscapacidades");
            modelBuilder.Entity<TipoLicencia>().ToTable("TiposLicencias");
            modelBuilder.Entity<TipoRedSocial>().ToTable("TiposRedesSociales");

            modelBuilder.Configurations.Add(new AptitudMap().ToTable("Aptitudes"));
            modelBuilder.Configurations.Add(new AreaMap().ToTable("Areas"));
            modelBuilder.Configurations.Add(new ColoniasMap().ToTable("Colonias"));
            modelBuilder.Configurations.Add(new EstadoMap().ToTable("Estados"));
            modelBuilder.Configurations.Add(new DiaSemanaMap().ToTable("DiasSemana"));
            modelBuilder.Configurations.Add(new DireccionMap().ToTable("Direcciones"));
            modelBuilder.Configurations.Add(new EmailMap().ToTable("Emails"));
            modelBuilder.Configurations.Add(new EstadoCivilMap().ToTable("EstadosCiviles"));
            modelBuilder.Configurations.Add(new EstadoEstudioMap().ToTable("EstadosEstudios"));
            modelBuilder.Configurations.Add(new GeneroMap().ToTable("Generos"));
            modelBuilder.Configurations.Add(new GiroEmpresaMap().ToTable("GiroEmpresas"));
            modelBuilder.Configurations.Add(new GradoEstudioMap().ToTable("GradosEstudios"));
            modelBuilder.Configurations.Add(new MunicipioMap().ToTable("Municipios"));
            modelBuilder.Configurations.Add(new PaisMap().ToTable("Paises"));
            modelBuilder.Configurations.Add(new TamanoEmpresaMap().ToTable("TamanosEmpresas"));
            modelBuilder.Configurations.Add(new TelefonoMap().ToTable("Telefonos"));
            modelBuilder.Configurations.Add(new TipoDireccionMap().ToTable("TiposDirecciones"));
            modelBuilder.Configurations.Add(new TipoEmpresaMap().ToTable("TiposEmpresas"));
            modelBuilder.Configurations.Add(new TipoReclutamientoMap().ToTable("TiposReclutamientos"));
            modelBuilder.Configurations.Add(new TipoTelefonoMap().ToTable("TiposTelefonos"));
            modelBuilder.Configurations.Add(new TipoBaseMap().ToTable("TiposBases"));



            

            modelBuilder.Configurations.Add(new ActividadEmpMap().ToTable("ActividadEmpresas"));
            modelBuilder.Configurations.Add(new ActividadesPerfilMap().ToTable("ActividadesPerfil"));
            modelBuilder.Configurations.Add(new AgenciaMap().ToTable("Agencias"));
            modelBuilder.Configurations.Add(new AptitudesPerfilMap().ToTable("AptitudesPerfil"));
            modelBuilder.Configurations.Add(new CompeteciasAreasMap().ToTable("CompetenciasAreas"));
            modelBuilder.Configurations.Add(new CompetenciaAreaPerfilMap().ToTable("CompetenciaAreaPerfil"));
            modelBuilder.Configurations.Add(new CompetenciasCardinalesMap().ToTable("CompetenciasCardinales"));
            modelBuilder.Configurations.Add(new CompetenciaCardinalPerfilMap().ToTable("CompetenciaCardinalPerfil"));
            modelBuilder.Configurations.Add(new CompetenciaGerencialPerfilMap().ToTable("CompetenciaGerencialPerfil"));
            modelBuilder.Configurations.Add(new CompeteciasGerencialesMap().ToTable("CompetenciasGerenciales"));
            modelBuilder.Configurations.Add(new ContactoPerfilMap().ToTable("ContactoPerfil"));
            modelBuilder.Configurations.Add(new ClaseReclutamientoMap().ToTable("ClasesReclutamientos"));
            modelBuilder.Configurations.Add(new DAMFO_290Map().ToTable("DAMFO_290"));
            modelBuilder.Configurations.Add(new DiaObligatorioMap().ToTable("DiasObligatorios"));
            modelBuilder.Configurations.Add(new DocumentosDamsaMap().ToTable("DocumentosDamsa"));
            modelBuilder.Configurations.Add(new EscolaridadesPerfilMap().ToTable("EscolaridadesPerfil"));
            modelBuilder.Configurations.Add(new HorarioPerfilMap().ToTable("HorariosPerfiles"));
            modelBuilder.Configurations.Add(new NivelMap().ToTable("Niveles"));
            modelBuilder.Configurations.Add(new ObservacionesPerfilMap().ToTable("ObservacionesPerfil"));
            modelBuilder.Configurations.Add(new PeriodoPagoMap().ToTable("PeriodosPagos"));
            modelBuilder.Configurations.Add(new PrestacionesLeyMap().ToTable("PrestacionesLey"));
            modelBuilder.Configurations.Add(new PrestacionesClientePerfilMap().ToTable("PrestacionesClientePerfil"));
            modelBuilder.Configurations.Add(new PsicometriasDamsaMap().ToTable("PsicometriasDamsa"));
            modelBuilder.Configurations.Add(new PsicometriasClienteMap().ToTable("PsicometriasCliente"));
            modelBuilder.Configurations.Add(new RedSocialMap().ToTable("RedesSociales"));
            modelBuilder.Configurations.Add(new RutasPerfilMap().ToTable("RutasPerfil"));
            modelBuilder.Configurations.Add(new TelefonoPerfilMap().ToTable("TelefonoPerfil"));
            modelBuilder.Configurations.Add(new TipoBeneficioMap().ToTable("TiposBeneficios"));
            modelBuilder.Configurations.Add(new TipoContratoMap().ToTable("TiposContratos"));
            modelBuilder.Configurations.Add(new TipodeNominaMap().ToTable("TiposNominas"));
            modelBuilder.Configurations.Add(new TipoPsicometriaMap().ToTable("TiposPsicometrias"));


            /*Heredan de persona*/
            modelBuilder.Configurations.Add(new PersonaMap());
            modelBuilder.Configurations.Add(new CandidatoMap());
            modelBuilder.Configurations.Add(new ContactoMap());
            modelBuilder.Configurations.Add(new ReferenciadoMap());
            modelBuilder.Configurations.Add(new ClienteMap());



            base.OnModelCreating(modelBuilder);
        }
        
        public class AgenciaMap : EntityTypeConfiguration<Agencia>
        {
            public AgenciaMap()
            {
                HasKey(x => x.Id);
                Property(x => x.agencia).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
                Property(x => x.DesdeCuendo).HasColumnType("date");
                Property(x => x.Empleado).HasPrecision(5,2).IsRequired();
                Property(x => x.Cobro).HasPrecision(5,2).IsRequired();
            }
        }
        public class PersonaMap : EntityTypeConfiguration<Persona>
        {
            public PersonaMap()
            {
                HasKey(x => x.Id);
                Property(x => x.Nombre).HasColumnType("nvarchar").HasMaxLength(50);
                Property(x => x.ApellidoMaterno).HasColumnType("nvarchar").HasMaxLength(50);
                Property(x => x.ApellidoPaterno).HasColumnType("nvarchar").HasMaxLength(50);
                Property(x => x.FechaNacimiento).HasColumnType("date").IsOptional();
            }
        }
        public class ClienteMap : EntityTypeConfiguration<Cliente>
        {
            public ClienteMap()
            {
                ToTable("Clientes");
                Property(x => x.RazonSocial).HasColumnType("nvarchar").HasMaxLength(100);
                Property(x => x.Nombrecomercial).HasColumnType("nvarchar").HasMaxLength(500);
                Property(x => x.RFC).HasColumnType("nvarchar").HasMaxLength(15);
                Property(x => x.Clasificacion).HasColumnType("nvarchar").HasMaxLength(10).IsRequired();
                Property(x => x.NumeroEmpleados).IsRequired();
            }
        }
        public class CandidatoMap : EntityTypeConfiguration<Candidato>
        {
            public CandidatoMap()
            {
                ToTable("Candidatos");
                Property(x => x.PaisNacimientoId);
                Property(x => x.EstadoNacimientoId);
                Property(x => x.MunicipioNacimientoId);

            }
        }
        public class ReferenciadoMap : EntityTypeConfiguration<Referenciado>
        {
            public ReferenciadoMap()
            {
                ToTable("Referenciados");
                Property(x => x.Puesto).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                Property(x => x.Clave).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            }
        }
        public class ContactoMap : EntityTypeConfiguration<Contacto>
        {
            public ContactoMap()
            {
                ToTable("Contactos");
                Property(x => x.Puesto).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            }
        }
        public class PaisMap : EntityTypeConfiguration<Pais>
        {
            public PaisMap()
            {
                HasKey(x => x.Id);
                Property(x => x.pais).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
                
            }
        }
        public class EstadoMap : EntityTypeConfiguration<Estado>
        {
            public EstadoMap()
            {
                HasKey(x => x.Id);
                Property(x => x.estado).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                Property(x => x.PaisId).IsRequired();
            }
        }
        public class MunicipioMap : EntityTypeConfiguration<Municipio>
        {
            public MunicipioMap()
            {
                HasKey(x => x.Id);
                Property(x => x.municipio).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                Property(x => x.EstadoId).IsRequired();
            }
        }
        public class ColoniasMap : EntityTypeConfiguration<Colonia>
        {
            public ColoniasMap()
            {
                HasKey(x => x.Id);
                Property(x => x.colonia).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                Property(x => x.CP).HasColumnType("nvarchar").HasMaxLength(13).IsRequired();
                Property(x => x.TipoColonia).HasColumnType("nvarchar").HasMaxLength(50);
                Property(x => x.MunicipioId).IsRequired();
            }
        }
        public class ActividadEmpMap : EntityTypeConfiguration<ActividadEmpresa>
        {
            public ActividadEmpMap()
            {
                HasKey(x => x.Id);
                Property(x => x.actividadEmpresa).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            }
        }
        public class AptitudMap : EntityTypeConfiguration<Aptitud>
        {
            public AptitudMap()
            {
                HasKey(x => x.Id);
                Property(x=>x.aptitud).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            }
        }
        public class AreaMap : EntityTypeConfiguration<Area>
        {
            public AreaMap()
            {
                HasKey(x => x.Id);
                Property(x => x.Nombre).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            }
        }
        public class ClaseReclutamientoMap : EntityTypeConfiguration<ClaseReclutamiento>
        {
            public ClaseReclutamientoMap()
            {
                HasKey(x => x.Id);
                Property(x => x.clasesReclutamiento).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            }
        }
        public class DiaSemanaMap : EntityTypeConfiguration<DiaSemana>
        {
            public DiaSemanaMap()
            {
                HasKey(x => x.Id);
                Property(x => x.diaSemana).HasColumnType("nvarchar").HasMaxLength(15).IsRequired();
            }
        }
        public class DireccionMap : EntityTypeConfiguration<Direccion>
        {
            public DireccionMap()
            {
                HasKey(x => x.Id);
                Property(x => x.TipoDireccionId).IsRequired();
                Property(x => x.Calle).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                Property(x => x.Referencia).HasColumnType("nvarchar").HasMaxLength(500);
                Property(x => x.NumeroExterior).HasColumnType("nvarchar").HasMaxLength(10);
                Property(x => x.NumeroInterior).HasColumnType("nvarchar").HasMaxLength(10);
                Property(x => x.PaisId).IsRequired();
                Property(x => x.EstadoId);
                Property(x => x.MunicipioId);
                Property(x => x.ColoniaId);
                Property(x => x.CodigoPostal).HasColumnType("nvarchar").HasMaxLength(15).IsRequired();
            }
        }
        public class EmailMap : EntityTypeConfiguration<Email>
        {
            public EmailMap()
            {
                HasKey(x => x.Id);
                Property(x => x.email).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            }
        }
        public class RedSocialMap : EntityTypeConfiguration<RedSocial>
        {
            public RedSocialMap()
            {
                HasKey(x => x.Id);
                Property(x => x.redSocial).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            }
        }
        public class EstadoCivilMap : EntityTypeConfiguration<EstadoCivil>
        {
            public EstadoCivilMap()
            {
                HasKey(x => x.Id);
                Property(x => x.estadoCivil).HasColumnType("nvarchar").HasMaxLength(20).IsRequired();
            }
        }
        public class EstadoEstudioMap : EntityTypeConfiguration<EstadoEstudio>
        {
            public EstadoEstudioMap()
            {
                HasKey(x => x.Id);
                Property(x => x.estadoEstudio).HasColumnType("nvarchar").HasMaxLength(15).IsRequired();
            }
        }
        public class GeneroMap : EntityTypeConfiguration<Genero>
        {
            public GeneroMap()
            {
                HasKey(x => x.Id);
                Property(x => x.genero).HasColumnType("nvarchar").HasMaxLength(15).IsRequired();
            }
        }
        public class GiroEmpresaMap : EntityTypeConfiguration<GiroEmpresa>
        {
            public GiroEmpresaMap()
            {
                HasKey(x => x.Id);
                Property(x => x.giroEmpresa).HasColumnType("nvarchar").HasMaxLength(15).IsRequired();
            }
        }
        public class GradoEstudioMap : EntityTypeConfiguration<GradoEstudio>
        {
            public GradoEstudioMap()
            {
                HasKey(x => x.Id);
                Property(x => x.gradoEstudio).HasColumnType("nvarchar").HasMaxLength(15).IsRequired();
            }
        }
        public class HorarioPerfilMap : EntityTypeConfiguration<HorarioPerfil>
        {
            public HorarioPerfilMap()
            {
                HasKey(x => x.Id);
                Property(x => x.Nombre).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
                Property(x => x.deDia).HasColumnType("nvarchar").HasMaxLength(15).IsRequired();
                Property(x => x.aDia).HasColumnType("nvarchar").HasMaxLength(15).IsRequired();
                Property(x => x.deHora).HasColumnType("nvarchar").HasMaxLength(15).IsRequired();
                Property(x => x.aHora).HasColumnType("nvarchar").HasMaxLength(15).IsRequired();
                Property(x => x.numeroVacantes).HasColumnType("tinyint").IsRequired();
                Property(x => x.Especificaciones).HasColumnType("varchar").HasMaxLength(500).IsRequired();
            }
        }

        public class TamanoEmpresaMap : EntityTypeConfiguration<TamanoEmpresa>
        {
            public TamanoEmpresaMap()
            {
                HasKey(x => x.Id);
                Property(x => x.tamanoEmpresa).HasColumnType("nvarchar").HasMaxLength(30).IsRequired();
            }
        }
        public class TelefonoMap : EntityTypeConfiguration<Telefono>
        {
            public TelefonoMap()
            {
                HasKey(x => x.Id);
                Property(x => x.ClavePais).HasColumnType("nvarchar").HasMaxLength(5).IsRequired();
                Property(x => x.ClaveLada).HasColumnType("nvarchar").HasMaxLength(5);
                Property(x => x.telefono).HasColumnType("nvarchar").HasMaxLength(15).IsRequired();
                Property(x => x.Extension).HasColumnType("nvarchar").HasMaxLength(10);
                Property(x => x.esPrincipal).IsRequired();
                Property(x => x.TipoTelefonoId).IsRequired();
            }
        }
        public class TipoDireccionMap : EntityTypeConfiguration<TipoDireccion>
        {
            public TipoDireccionMap()
            {
                HasKey(x => x.Id);
                Property(x => x.tipoDireccion).HasColumnType("nvarchar").HasMaxLength(50).IsRequired().IsUnicode();
            }
        }
        public class TipoEmpresaMap : EntityTypeConfiguration<TipoEmpresa>
        {
            public TipoEmpresaMap()
            {
                HasKey(x => x.Id);
                Property(x => x.tipoEmpresa).HasColumnType("nvarchar").HasMaxLength(20).IsRequired();
            }
        }
        public class TipoReclutamientoMap : EntityTypeConfiguration<TipoReclutamiento>
        {
            public TipoReclutamientoMap()
            {
                HasKey(x => x.Id);
                Property(x => x.tipoReclutamiento).HasColumnType("nvarchar").HasMaxLength(20).IsRequired();
            }
        }
        public class TipoTelefonoMap : EntityTypeConfiguration<TipoTelefono>
        {
            public TipoTelefonoMap()
            {
                HasKey(x => x.Id);
                Property(x => x.Tipo).HasColumnType("nvarchar").HasMaxLength(15).IsRequired();
            }
        }
        public class TipoBaseMap : EntityTypeConfiguration<TipoBase>
        {
            public TipoBaseMap()
            {
                HasKey(x => x.Id);
                Property(x => x.tipoBase).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            }
        }
        public class NivelMap : EntityTypeConfiguration<Nivel>
        {
            public NivelMap()
            {
                HasKey(x => x.Id);
                Property(x => x.nivel).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            }
        }

        public class TipoPsicometriaMap : EntityTypeConfiguration<TipoPsicometria>
        {
            public TipoPsicometriaMap()
            {
                HasKey(x => x.Id);
                Property(x => x.tipoPsicometria).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
                Property(x => x.descripcion).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            }
        }

        public class TipodeNominaMap : EntityTypeConfiguration<TipodeNomina>
        {
            public TipodeNominaMap()
            {
                HasKey(x => x.Id);
                Property(x => x.tipoDeNomina).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            }
        }

        public class PeriodoPagoMap : EntityTypeConfiguration<PeriodoPago>
        {
            public PeriodoPagoMap()
            {
                HasKey(x => x.Id);
                Property(x => x.periodoPago).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            }
        }

        public class TipoBeneficioMap : EntityTypeConfiguration<TipoBeneficio>
        {
            public TipoBeneficioMap()
            {
                HasKey(x => x.Id);
                Property(x => x.tipoBeneficio).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            }
        }

        public class TipoContratoMap : EntityTypeConfiguration<TipoContrato>
        {
            public TipoContratoMap()
            {
                HasKey(x => x.Id);
                Property(x => x.tipoContrato).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            }
        }

        public class DocumentosDamsaMap : EntityTypeConfiguration<DocumentosDamsa>
        {
            public DocumentosDamsaMap()
            {
                HasKey(x => x.Id);
                Property(x => x.documentoDamsa).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            }
        }

        public class PrestacionesLeyMap : EntityTypeConfiguration<PrestacionLey>
        {
            public PrestacionesLeyMap()
            {
                HasKey(x => x.id);
                Property(x => x.prestacionLey).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            }
        }

        public class DiaObligatorioMap : EntityTypeConfiguration<DiaObligatorio>
        {
            public DiaObligatorioMap()
            {
                HasKey(x => x.id);
                Property(x => x.diaObligatorio).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            }
        }

        public class CompetenciasCardinalesMap : EntityTypeConfiguration<CompetenciaCardinal>
        {
            public CompetenciasCardinalesMap()
            {
                HasKey(x => x.id);
                Property(x => x.competenciaCardinal).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            }
        }

        public class CompeteciasAreasMap : EntityTypeConfiguration<CompetenciaArea>
        {
            public CompeteciasAreasMap()
            {
                HasKey(x => x.id);
                Property(x => x.competenciaArea).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            }
        }

        public class CompeteciasGerencialesMap : EntityTypeConfiguration<CompetenciaGarencial>
        {
            public CompeteciasGerencialesMap()
            {
                HasKey(x => x.id);
                Property(x => x.competenciaGerencial).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            }
        } 

        public class ActividadesPerfilMap : EntityTypeConfiguration<ActividadesPerfil>
        {
            public ActividadesPerfilMap()
            {
                HasKey(x => x.Id);
                Property(x => x.Actividades).HasColumnType("varchar").HasMaxLength(200).IsRequired();
            }
        }
        public class AptitudesPerfilMap : EntityTypeConfiguration<AptitudesPerfil>
        {
            public AptitudesPerfilMap()
            {
                HasKey(x => x.Id);
                Property(x => x.Aptitudes).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            }
        }

        public class CompetenciaAreaPerfilMap : EntityTypeConfiguration<CompetenciaAreaPerfil>
        {
            public CompetenciaAreaPerfilMap()
            {
                HasKey(x => x.Id);
                Property(x => x.CompetenciaId).IsRequired();
                Property(x => x.Nivel).HasColumnType("nvarchar").HasMaxLength(5).IsRequired();
            }
        }

        public class CompetenciaCardinalPerfilMap : EntityTypeConfiguration<CompetenciaCardinalPerfil>
        {
            public CompetenciaCardinalPerfilMap()
            {
                HasKey(x => x.Id);
                Property(x => x.CompetenciaId).IsRequired();
                Property(x => x.Nivel).HasColumnType("nvarchar").HasMaxLength(5).IsRequired();
            }
        
        }
        public class CompetenciaGerencialPerfilMap : EntityTypeConfiguration<CompetenciaGerencialPerfil>
        {
            public CompetenciaGerencialPerfilMap()
            {
                HasKey(x => x.Id);
                Property(x => x.CompetenciaId).IsRequired();
                Property(x => x.Nivel).HasColumnType("nvarchar").HasMaxLength(5).IsRequired();
            }
        }
        public class ContactoPerfilMap : EntityTypeConfiguration<ContactoPerfil>
        {
            public ContactoPerfilMap()
            {
                HasKey(x => x.Id);
                Property(x => x.ContactoId).IsRequired();
                Property(x => x.DAMFO290Id).IsRequired();
            }
        }
        public class DAMFO_290Map : EntityTypeConfiguration<DAMFO_290>
        {
            public DAMFO_290Map()
            {
                HasKey(x => x.Id);
                Property(x => x.ClienteId).IsRequired();
                Property(x => x.DireccionId).IsRequired();
                Property(x => x.TipoNominaId).IsRequired();
                Property(x => x.ClaseReclutamientoId).IsRequired();
                Property(x => x.NombrePerfil).HasColumnType("varchar").HasMaxLength(100);
                Property(x => x.SexoId).IsRequired();
                Property(x => x.EdadMaxima).IsRequired();
                Property(x => x.EstadoCivilId).IsRequired();
                Property(x => x.NivelId).IsRequired();
                Property(x => x.Experiencia).HasColumnType("varchar").HasMaxLength(500).IsRequired();
                Property(x => x.SueldoMinimo).HasPrecision(18,2).IsRequired();
                Property(x => x.SueldoMaximo).HasPrecision(18,3).IsRequired();
                Property(x => x.DiaCorteId).IsRequired();
                Property(x => x.TipoNominaId).IsRequired();
                Property(x => x.DiaPagoId).IsRequired();
                Property(x => x.PeriodoPagoId).IsRequired();
                Property(x => x.ContratoInicialId).IsRequired();
                Property(x => x.ContratoFinalId).IsRequired();
            }
        }
        public class EscolaridadesPerfilMap : EntityTypeConfiguration<EscolaridadesPerfil>
        {
            public EscolaridadesPerfilMap()
            {
                HasKey(x => x.Id);
                Property(x => x.Escolaridad).HasColumnType("varchar").HasMaxLength(100).IsRequired();
                Property(x => x.DAMFO290Id).IsRequired();
            }

        }
        public class ObservacionesPerfilMap : EntityTypeConfiguration<ObservacionesPerfil>
        {
            public ObservacionesPerfilMap()
            {
                HasKey(x => x.Id);
                Property(x => x.Observaciones).HasColumnType("varchar").HasMaxLength(100).IsRequired();
                Property(x => x.DAMFO290Id).IsRequired();
            }
        }
        public class PrestacionesClientePerfilMap : EntityTypeConfiguration<PrestacionesClientePerfil>
        {
            public PrestacionesClientePerfilMap()
            {
                HasKey(x => x.Id);
                Property(x => x.Prestamo).HasColumnType("varchar").HasMaxLength(100).IsRequired();
                Property(x => x.DAMFO290Id).IsRequired();
            }
        }
        public class RutasPerfilMap : EntityTypeConfiguration<RutasPerfil>
        {
            public RutasPerfilMap()
            {
                HasKey(x => x.Id);
                Property(x => x.DireccionId).IsRequired();
                Property(x => x.Ruta).HasColumnType("varchar").HasMaxLength(100).IsRequired();
                Property(x => x.Via).HasColumnType("varchar").HasMaxLength(100);
            }
        }
        public class TelefonoPerfilMap : EntityTypeConfiguration<TelefonoPerfil>
        {
            public TelefonoPerfilMap()
            {
                HasKey(x => x.Id);
                Property(x => x.telefonoId).IsRequired();
                Property(x => x.DAMFO290Id).IsRequired();
            }
        }
        public class PsicometriasClienteMap : EntityTypeConfiguration<PsicometriasCliente>
        {
            public PsicometriasClienteMap()
            {
                HasKey(x => x.Id);
                Property(x => x.Psicometria).HasColumnType("nvarchar").HasMaxLength(50);
                Property(x => x.Descripcion).HasColumnType("nvarchar").HasMaxLength(200);
                Property(x => x.DAMFO290Id).IsRequired();
            }
        }
        public class PsicometriasDamsaMap : EntityTypeConfiguration<PsicometriasDamsa>
        {
            public PsicometriasDamsaMap()
            {
                HasKey(x => x.Id);
                Property(x => x.PsicometriaId).IsRequired();
                Property(x => x.DAMFO290Id).IsRequired();
            }
        }
    }
}
