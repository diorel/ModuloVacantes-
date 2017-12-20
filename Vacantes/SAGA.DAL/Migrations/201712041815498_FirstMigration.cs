namespace SAGA.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "sist.AcercaDeMi",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        AcercaDeMi = c.String(),
                        PuestoDeseado = c.String(),
                        SalarioAceptable = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SalarioDeseado = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AreaExperienciaId = c.Int(nullable: false),
                        AreaInteresId = c.Int(),
                        PerfilExperienciaId = c.Int(),
                        PerfilCandidatoId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.AreasExperiencia", t => t.AreaExperienciaId, cascadeDelete: true)
                .ForeignKey("sist.AreasInteres", t => t.AreaInteresId)
                .ForeignKey("sist.PerfilCandidato", t => t.PerfilCandidatoId, cascadeDelete: true)
                .ForeignKey("sist.PerfilExperiencia", t => t.PerfilExperienciaId)
                .Index(t => t.AreaExperienciaId)
                .Index(t => t.AreaInteresId)
                .Index(t => t.PerfilExperienciaId)
                .Index(t => t.PerfilCandidatoId);
            
            CreateTable(
                "sist.AreasExperiencia",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        areaExperiencia = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.AreasInteres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        areaInteres = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.PerfilCandidato",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        CandidatoId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.Candidatos", t => t.CandidatoId)
                .Index(t => t.CandidatoId);
            
            CreateTable(
                "sist.Personas",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        ApellidoPaterno = c.String(nullable: false, maxLength: 50),
                        ApellidoMaterno = c.String(nullable: false, maxLength: 50),
                        FechaNacimiento = c.DateTime(storeType: "date"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.Direcciones",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        TipoDireccionId = c.Int(nullable: false),
                        esMoral = c.Boolean(nullable: false),
                        Calle = c.String(nullable: false, maxLength: 100),
                        NumeroInterior = c.String(maxLength: 10),
                        NumeroExterior = c.String(maxLength: 10),
                        PaisId = c.Int(nullable: false),
                        EstadoId = c.Int(),
                        MunicipioId = c.Int(),
                        ColoniaId = c.Int(),
                        CodigoPostal = c.String(nullable: false, maxLength: 15),
                        esPrincipal = c.Boolean(nullable: false),
                        Activo = c.Boolean(nullable: false),
                        Referencia = c.String(maxLength: 500),
                        PersonaId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.Colonias", t => t.ColoniaId, cascadeDelete: false)
                .ForeignKey("sist.Estados", t => t.EstadoId, cascadeDelete: false)
                .ForeignKey("sist.Municipios", t => t.MunicipioId, cascadeDelete: false)
                .ForeignKey("sist.Paises", t => t.PaisId, cascadeDelete: false)
                .ForeignKey("sist.Personas", t => t.PersonaId, cascadeDelete: false)
                .ForeignKey("sist.TiposDirecciones", t => t.TipoDireccionId, cascadeDelete: false)
                .Index(t => t.TipoDireccionId)
                .Index(t => t.PaisId)
                .Index(t => t.EstadoId)
                .Index(t => t.MunicipioId)
                .Index(t => t.ColoniaId)
                .Index(t => t.PersonaId);
            
            CreateTable(
                "sist.Colonias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        colonia = c.String(nullable: false, maxLength: 100),
                        CP = c.String(nullable: false, maxLength: 13),
                        TipoColonia = c.String(maxLength: 50),
                        MunicipioId = c.Int(nullable: false),
                        EstadoId = c.Int(nullable: false),
                        PaisId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.Estados", t => t.EstadoId, cascadeDelete: false)
                .ForeignKey("sist.Municipios", t => t.MunicipioId, cascadeDelete: false)
                .ForeignKey("sist.Paises", t => t.PaisId, cascadeDelete: false)
                .Index(t => t.MunicipioId)
                .Index(t => t.EstadoId)
                .Index(t => t.PaisId);
            
            CreateTable(
                "sist.Estados",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        estado = c.String(nullable: false, maxLength: 100),
                        PaisId = c.Int(nullable: false),
                        Clave = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.Paises", t => t.PaisId, cascadeDelete: true)
                .Index(t => t.PaisId);
            
            CreateTable(
                "sist.Paises",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        pais = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.Municipios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        municipio = c.String(nullable: false, maxLength: 100),
                        EstadoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.Estados", t => t.EstadoId, cascadeDelete: false)
                .Index(t => t.EstadoId);
            
            CreateTable(
                "sist.Emails",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        email = c.String(nullable: false, maxLength: 100),
                        esPrincipal = c.Boolean(nullable: false),
                        PersonaId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.Personas", t => t.PersonaId, cascadeDelete: true)
                .Index(t => t.PersonaId);
            
            CreateTable(
                "sist.Telefonos",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        ClavePais = c.String(nullable: false, maxLength: 5),
                        ClaveLada = c.String(maxLength: 5),
                        Extension = c.String(maxLength: 10),
                        telefono = c.String(nullable: false, maxLength: 15),
                        TipoTelefonoId = c.Byte(nullable: false),
                        Activo = c.Boolean(nullable: false),
                        esPrincipal = c.Boolean(nullable: false),
                        PersonaId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.Personas", t => t.PersonaId, cascadeDelete: true)
                .ForeignKey("sist.TiposTelefonos", t => t.TipoTelefonoId, cascadeDelete: false)
                .Index(t => t.TipoTelefonoId)
                .Index(t => t.PersonaId);
            
            CreateTable(
                "sist.TiposTelefonos",
                c => new
                    {
                        Id = c.Byte(nullable: false, identity: true),
                        Tipo = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.ActividadEmpresas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GiroEmpresaId = c.Int(nullable: false),
                        actividadEmpresa = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.GiroEmpresas", t => t.GiroEmpresaId, cascadeDelete: true)
                .Index(t => t.GiroEmpresaId);
            
            CreateTable(
                "sist.GiroEmpresas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        giroEmpresa = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.TamanosEmpresas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        tamanoEmpresa = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.TiposBases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        tipoBase = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.TiposEmpresas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        tipoEmpresa = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.TiposDirecciones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        tipoDireccion = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.EstadosCiviles",
                c => new
                    {
                        Id = c.Byte(nullable: false, identity: true),
                        estadoCivil = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.Generos",
                c => new
                    {
                        Id = c.Byte(nullable: false, identity: true),
                        genero = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.TiposDiscapacidades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        tipoDiscapacidad = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.TiposLicencias",
                c => new
                    {
                        Id = c.Byte(nullable: false, identity: true),
                        tipoLicencia = c.String(),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.Certificaciones",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        certificacion = c.String(),
                        AutoridadEmisora = c.String(),
                        Licencia = c.String(),
                        UrlCertificacion = c.String(),
                        noVence = c.Boolean(nullable: false),
                        YearInicioId = c.Int(nullable: false),
                        MonthInicioId = c.Int(nullable: false),
                        YearTerminoId = c.Int(nullable: false),
                        MonthTerminoId = c.Int(nullable: false),
                        PerfilCandidatoId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.Months", t => t.MonthInicioId, cascadeDelete: false)
                .ForeignKey("sist.Months", t => t.MonthTerminoId, cascadeDelete: false)
                .ForeignKey("sist.PerfilCandidato", t => t.PerfilCandidatoId, cascadeDelete: true)
                .ForeignKey("sist.Years", t => t.YearInicioId, cascadeDelete: false)
                .ForeignKey("sist.Years", t => t.YearTerminoId, cascadeDelete: false)
                .Index(t => t.YearInicioId)
                .Index(t => t.MonthInicioId)
                .Index(t => t.YearTerminoId)
                .Index(t => t.MonthTerminoId)
                .Index(t => t.PerfilCandidatoId);
            
            CreateTable(
                "sist.Months",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        month = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.Years",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        year = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.ConocimientosHabilidades",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Conocimiento = c.String(),
                        Herramienta = c.String(),
                        InstitucionEducativaId = c.Guid(),
                        NivelId = c.Byte(),
                        PerfilCandidatoId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.InstitucionesEducativas", t => t.InstitucionEducativaId)
                .ForeignKey("sist.Niveles", t => t.NivelId)
                .ForeignKey("sist.PerfilCandidato", t => t.PerfilCandidatoId, cascadeDelete: true)
                .Index(t => t.InstitucionEducativaId)
                .Index(t => t.NivelId)
                .Index(t => t.PerfilCandidatoId);
            
            CreateTable(
                "sist.InstitucionesEducativas",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        institucionEducativa = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.Niveles",
                c => new
                    {
                        Id = c.Byte(nullable: false, identity: true),
                        nivel = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.Cursos",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        curso = c.String(),
                        InstitucionEducativaId = c.Guid(nullable: false),
                        YearInicioId = c.Int(),
                        MonthInicioId = c.Int(),
                        YearTerminoId = c.Int(),
                        MonthTerminoId = c.Int(),
                        PerfilCandidatoId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.InstitucionesEducativas", t => t.InstitucionEducativaId, cascadeDelete: true)
                .ForeignKey("sist.Months", t => t.MonthInicioId)
                .ForeignKey("sist.Months", t => t.MonthTerminoId)
                .ForeignKey("sist.PerfilCandidato", t => t.PerfilCandidatoId, cascadeDelete: true)
                .ForeignKey("sist.Years", t => t.YearInicioId)
                .ForeignKey("sist.Years", t => t.YearTerminoId)
                .Index(t => t.InstitucionEducativaId)
                .Index(t => t.YearInicioId)
                .Index(t => t.MonthInicioId)
                .Index(t => t.YearTerminoId)
                .Index(t => t.MonthTerminoId)
                .Index(t => t.PerfilCandidatoId);
            
            CreateTable(
                "sist.ExperienciasProfesionales",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Empresa = c.String(),
                        GiroEmpresaId = c.Int(nullable: false),
                        CargoAsignado = c.String(),
                        AreaId = c.Int(nullable: false),
                        YearInicioId = c.Int(nullable: false),
                        MonthInicioId = c.Int(nullable: false),
                        YearTerminoId = c.Int(nullable: false),
                        MonthTerminoId = c.Int(nullable: false),
                        Salario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TrabajoActual = c.Boolean(nullable: false),
                        Descripcion = c.String(),
                        PerfilCandidatoId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.Areas", t => t.AreaId, cascadeDelete: false)
                .ForeignKey("sist.GiroEmpresas", t => t.GiroEmpresaId, cascadeDelete: false)
                .ForeignKey("sist.Months", t => t.MonthInicioId, cascadeDelete: false)
                .ForeignKey("sist.Months", t => t.MonthTerminoId, cascadeDelete: false)
                .ForeignKey("sist.PerfilCandidato", t => t.PerfilCandidatoId, cascadeDelete: true)
                .ForeignKey("sist.Years", t => t.YearInicioId, cascadeDelete: false)
                .ForeignKey("sist.Years", t => t.YearTerminoId, cascadeDelete: false)
                .Index(t => t.GiroEmpresaId)
                .Index(t => t.AreaId)
                .Index(t => t.YearInicioId)
                .Index(t => t.MonthInicioId)
                .Index(t => t.YearTerminoId)
                .Index(t => t.MonthTerminoId)
                .Index(t => t.PerfilCandidatoId);
            
            CreateTable(
                "sist.Areas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.Formaciones",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        InstitucionEducativaId = c.Guid(nullable: false),
                        GradoEstudioId = c.Int(nullable: false),
                        EstadoEstudioId = c.Int(nullable: false),
                        DocumentoValidadorId = c.Int(nullable: false),
                        CarreraId = c.Guid(nullable: false),
                        YearInicioId = c.Int(nullable: false),
                        MonthInicioId = c.Int(nullable: false),
                        YearTerminoId = c.Int(nullable: false),
                        MonthTerminoId = c.Int(nullable: false),
                        PerfilCandidatoId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.Carreras", t => t.CarreraId, cascadeDelete: false)
                .ForeignKey("sist.DocumentosValidadores", t => t.DocumentoValidadorId, cascadeDelete: false)
                .ForeignKey("sist.EstadosEstudios", t => t.EstadoEstudioId, cascadeDelete: false)
                .ForeignKey("sist.GradosEstudios", t => t.GradoEstudioId, cascadeDelete: false)
                .ForeignKey("sist.InstitucionesEducativas", t => t.InstitucionEducativaId, cascadeDelete: false)
                .ForeignKey("sist.Months", t => t.MonthInicioId, cascadeDelete: false)
                .ForeignKey("sist.Months", t => t.MonthTerminoId, cascadeDelete: false)
                .ForeignKey("sist.PerfilCandidato", t => t.PerfilCandidatoId, cascadeDelete: true)
                .ForeignKey("sist.Years", t => t.YearInicioId, cascadeDelete: false)
                .ForeignKey("sist.Years", t => t.YearTerminoId, cascadeDelete: false)
                .Index(t => t.InstitucionEducativaId)
                .Index(t => t.GradoEstudioId)
                .Index(t => t.EstadoEstudioId)
                .Index(t => t.DocumentoValidadorId)
                .Index(t => t.CarreraId)
                .Index(t => t.YearInicioId)
                .Index(t => t.MonthInicioId)
                .Index(t => t.YearTerminoId)
                .Index(t => t.MonthTerminoId)
                .Index(t => t.PerfilCandidatoId);
            
            CreateTable(
                "sist.Carreras",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        carrera = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.DocumentosValidadores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        documentoValidador = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.EstadosEstudios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        estadoEstudio = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.GradosEstudios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        gradoEstudio = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.PerfilIdiomas",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        IdiomaId = c.Int(nullable: false),
                        NivelId = c.Byte(nullable: false),
                        PerfilCandidatoId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.Idiomas", t => t.IdiomaId, cascadeDelete: false)
                .ForeignKey("sist.Niveles", t => t.NivelId, cascadeDelete: false)
                .ForeignKey("sist.PerfilCandidato", t => t.PerfilCandidatoId, cascadeDelete: true)
                .Index(t => t.IdiomaId)
                .Index(t => t.NivelId)
                .Index(t => t.PerfilCandidatoId);
            
            CreateTable(
                "sist.Idiomas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        idioma = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.PerfilExperiencia",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        perfilExperiencia = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.ActividadesPerfil",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Actividades = c.String(nullable: false, maxLength: 200, unicode: false),
                        DAMFO290Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.DAMFO_290", t => t.DAMFO290Id, cascadeDelete: true)
                .Index(t => t.DAMFO290Id);
            
            CreateTable(
                "sist.DAMFO_290",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        ClienteId = c.Guid(nullable: false),
                        DireccionId = c.Guid(nullable: false),
                        TipoReclutamientoId = c.Int(nullable: false),
                        ClaseReclutamientoId = c.Int(nullable: false),
                        NombrePerfil = c.String(maxLength: 100, unicode: false),
                        SexoId = c.Int(nullable: false),
                        EdadMinima = c.Int(nullable: false),
                        EdadMaxima = c.Int(nullable: false),
                        EstadoCivilId = c.Byte(nullable: false),
                        NivelId = c.Int(nullable: false),
                        AreaId = c.Int(nullable: false),
                        Experiencia = c.String(nullable: false, maxLength: 500, unicode: false),
                        SueldoMinimo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SueldoMaximo = c.Decimal(nullable: false, precision: 18, scale: 3),
                        DiaCorteId = c.Byte(nullable: false),
                        TipoNominaId = c.Int(nullable: false),
                        DiaPagoId = c.Byte(nullable: false),
                        PeriodoPagoId = c.Int(nullable: false),
                        ContratoInicialId = c.Int(nullable: false),
                        ContratoFinalId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.Areas", t => t.AreaId, cascadeDelete: false)
                .ForeignKey("sist.ClasesReclutamientos", t => t.ClaseReclutamientoId, cascadeDelete: false)
                .ForeignKey("sist.Clientes", t => t.ClienteId, cascadeDelete: false)
                .ForeignKey("sist.TiposContratos", t => t.ContratoFinalId, cascadeDelete: false)
                .ForeignKey("sist.TiposContratos", t => t.ContratoInicialId, cascadeDelete: false)
                .ForeignKey("sist.DiasSemana", t => t.DiaCorteId, cascadeDelete: false)
                .ForeignKey("sist.DiasSemana", t => t.DiaPagoId, cascadeDelete: false)
                .ForeignKey("sist.Direcciones", t => t.DireccionId, cascadeDelete: false)
                .ForeignKey("sist.EstadosCiviles", t => t.EstadoCivilId, cascadeDelete: false)
                .ForeignKey("sist.PeriodosPagos", t => t.PeriodoPagoId, cascadeDelete: false)
                .ForeignKey("sist.TiposNominas", t => t.TipoNominaId, cascadeDelete: false)
                .ForeignKey("sist.TiposReclutamientos", t => t.TipoReclutamientoId, cascadeDelete: false)
                .Index(t => t.ClienteId)
                .Index(t => t.DireccionId)
                .Index(t => t.TipoReclutamientoId)
                .Index(t => t.ClaseReclutamientoId)
                .Index(t => t.EstadoCivilId)
                .Index(t => t.AreaId)
                .Index(t => t.DiaCorteId)
                .Index(t => t.TipoNominaId)
                .Index(t => t.DiaPagoId)
                .Index(t => t.PeriodoPagoId)
                .Index(t => t.ContratoInicialId)
                .Index(t => t.ContratoFinalId);
            
            CreateTable(
                "sist.BeneficiosPerfils",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        TipoBeneficioId = c.Int(nullable: false),
                        Cantidad = c.Single(nullable: false),
                        Observaciones = c.String(),
                        DAMFO290Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.DAMFO_290", t => t.DAMFO290Id, cascadeDelete: true)
                .ForeignKey("sist.TiposBeneficios", t => t.TipoBeneficioId, cascadeDelete: true)
                .Index(t => t.TipoBeneficioId)
                .Index(t => t.DAMFO290Id);
            
            CreateTable(
                "sist.TiposBeneficios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        tipoBeneficio = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.ClasesReclutamientos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        clasesReclutamiento = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.CompetenciaCardinalPerfil",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        CompetenciaId = c.Int(nullable: false),
                        Nivel = c.String(nullable: false, maxLength: 5),
                        DAMFO290Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.CompetenciasCardinales", t => t.CompetenciaId, cascadeDelete: false)
                .ForeignKey("sist.DAMFO_290", t => t.DAMFO290Id, cascadeDelete: false)
                .Index(t => t.CompetenciaId)
                .Index(t => t.DAMFO290Id);
            
            CreateTable(
                "sist.CompetenciasCardinales",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        competenciaCardinal = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "sist.CompetenciaAreaPerfil",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        CompetenciaId = c.Int(nullable: false),
                        Nivel = c.String(nullable: false, maxLength: 5),
                        DAMFO290Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.CompetenciasAreas", t => t.CompetenciaId, cascadeDelete: false)
                .ForeignKey("sist.DAMFO_290", t => t.DAMFO290Id, cascadeDelete: false)
                .Index(t => t.CompetenciaId)
                .Index(t => t.DAMFO290Id);
            
            CreateTable(
                "sist.CompetenciasAreas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        competenciaArea = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "sist.CompetenciaGerencialPerfil",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        CompetenciaId = c.Int(nullable: false),
                        Nivel = c.String(nullable: false, maxLength: 5),
                        DAMFO290Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.CompetenciasGerenciales", t => t.CompetenciaId, cascadeDelete: false)
                .ForeignKey("sist.DAMFO_290", t => t.DAMFO290Id, cascadeDelete: false)
                .Index(t => t.CompetenciaId)
                .Index(t => t.DAMFO290Id);
            
            CreateTable(
                "sist.CompetenciasGerenciales",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        competenciaGerencial = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "sist.ContactoPerfil",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        ContactoId = c.Guid(nullable: false),
                        DAMFO290Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.Contactos", t => t.ContactoId)
                .ForeignKey("sist.DAMFO_290", t => t.DAMFO290Id, cascadeDelete: true)
                .Index(t => t.ContactoId)
                .Index(t => t.DAMFO290Id);
            
            CreateTable(
                "sist.TiposContratos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        tipoContrato = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.DiasSemana",
                c => new
                    {
                        Id = c.Byte(nullable: false, identity: true),
                        diaSemana = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.DocumentosClientes",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Documento = c.String(),
                        DAMFO290Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.DAMFO_290", t => t.DAMFO290Id, cascadeDelete: true)
                .Index(t => t.DAMFO290Id);
            
            CreateTable(
                "sist.EscolaridadesPerfil",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Escolaridad = c.String(nullable: false, maxLength: 100, unicode: false),
                        DAMFO290Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.DAMFO_290", t => t.DAMFO290Id, cascadeDelete: true)
                .Index(t => t.DAMFO290Id);
            
            CreateTable(
                "sist.HorariosPerfiles",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        deDia = c.String(nullable: false, maxLength: 15),
                        aDia = c.String(nullable: false, maxLength: 15),
                        deHora = c.String(nullable: false, maxLength: 15),
                        aHora = c.String(nullable: false, maxLength: 15),
                        numeroVacantes = c.Byte(nullable: false),
                        Especificaciones = c.String(nullable: false, maxLength: 500, unicode: false),
                        DAMFO290Id = c.Guid(nullable: false),
                        Activo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.DAMFO_290", t => t.DAMFO290Id, cascadeDelete: true)
                .Index(t => t.DAMFO290Id);
            
            CreateTable(
                "sist.ObservacionesPerfil",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Observaciones = c.String(nullable: false, maxLength: 100, unicode: false),
                        DAMFO290Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.DAMFO_290", t => t.DAMFO290Id, cascadeDelete: true)
                .Index(t => t.DAMFO290Id);
            
            CreateTable(
                "sist.AptitudesPerfil",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Aptitudes = c.String(nullable: false, maxLength: 50),
                        DAMFO290Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.DAMFO_290", t => t.DAMFO290Id, cascadeDelete: true)
                .Index(t => t.DAMFO290Id);
            
            CreateTable(
                "sist.PeriodosPagos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        periodoPago = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.PrestacionesClientePerfil",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Prestamo = c.String(nullable: false, maxLength: 100, unicode: false),
                        DAMFO290Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.DAMFO_290", t => t.DAMFO290Id, cascadeDelete: true)
                .Index(t => t.DAMFO290Id);
            
            CreateTable(
                "sist.ProcesoPerfils",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Proceso = c.String(),
                        DAMFO290Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.DAMFO_290", t => t.DAMFO290Id, cascadeDelete: true)
                .Index(t => t.DAMFO290Id);
            
            CreateTable(
                "sist.PsicometriasClientes",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Psicometria = c.String(),
                        Descripcion = c.String(),
                        DAMFO290Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.DAMFO_290", t => t.DAMFO290Id, cascadeDelete: true)
                .Index(t => t.DAMFO290Id);
            
            CreateTable(
                "sist.PsicometriasDamsas",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        PsicometriaId = c.Guid(nullable: false),
                        DAMFO290Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.DAMFO_290", t => t.DAMFO290Id, cascadeDelete: true)
                .Index(t => t.DAMFO290Id);
            
            CreateTable(
                "sist.RutasPerfil",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        DireccionId = c.Guid(nullable: false),
                        Ruta = c.String(nullable: false, maxLength: 100, unicode: false),
                        Via = c.String(maxLength: 100, unicode: false),
                        DAMFO290Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.DAMFO_290", t => t.DAMFO290Id, cascadeDelete: true)
                .ForeignKey("sist.Direcciones", t => t.DireccionId, cascadeDelete: true)
                .Index(t => t.DireccionId)
                .Index(t => t.DAMFO290Id);
            
            CreateTable(
                "sist.TelefonoPerfil",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        telefonoId = c.Guid(nullable: false),
                        DAMFO290Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.DAMFO_290", t => t.DAMFO290Id, cascadeDelete: true)
                .ForeignKey("sist.Telefonos", t => t.telefonoId, cascadeDelete: true)
                .Index(t => t.telefonoId)
                .Index(t => t.DAMFO290Id);
            
            CreateTable(
                "sist.TiposNominas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        tipoDeNomina = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.TiposReclutamientos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        tipoReclutamiento = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.Agencias",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        PersonaId = c.Guid(nullable: false),
                        agencia = c.String(nullable: false, maxLength: 50),
                        DesdeCuendo = c.DateTime(nullable: false, storeType: "date"),
                        Empleado = c.Decimal(nullable: false, precision: 5, scale: 2),
                        Cobro = c.Decimal(nullable: false, precision: 5, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.Personas", t => t.PersonaId, cascadeDelete: true)
                .Index(t => t.PersonaId);
            
            CreateTable(
                "sist.Aptitudes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        aptitud = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.CandidatoConocimientoInformatico",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        ConocimientoInformaticoId = c.Guid(nullable: false),
                        PorcentageId = c.Int(nullable: false),
                        CandidatoId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.ConocimientosInformaticos", t => t.ConocimientoInformaticoId, cascadeDelete: true)
                .ForeignKey("sist.Porcentages", t => t.PorcentageId, cascadeDelete: true)
                .Index(t => t.ConocimientoInformaticoId)
                .Index(t => t.PorcentageId);
            
            CreateTable(
                "sist.ConocimientosInformaticos",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.Porcentages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        porcentage = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.Cargos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.DiasObligatorios",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        diaObligatorio = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "sist.DocumentosDamsa",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        documentoDamsa = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.FormasContacto",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        CandidatoId = c.Guid(nullable: false),
                        CorreoElectronico = c.Boolean(nullable: false),
                        Celular = c.Boolean(nullable: false),
                        WhatsApp = c.Boolean(nullable: false),
                        TelLocal = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.Candidatos", t => t.CandidatoId)
                .Index(t => t.CandidatoId);
            
            CreateTable(
                "sist.FormulariosIniciales",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Paso1 = c.Boolean(nullable: false),
                        Paso2 = c.Boolean(nullable: false),
                        Paso3 = c.Boolean(nullable: false),
                        CandidatoId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.Candidatos", t => t.CandidatoId)
                .Index(t => t.CandidatoId);
            
            CreateTable(
                "sist.PerfilesProfesionales",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        CargoId = c.Int(nullable: false),
                        AreaId = c.Int(nullable: false),
                        Descripcion = c.String(),
                        PuestoDeseado = c.String(),
                        Salario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CandidatoId = c.Guid(nullable: false),
                        SitioWeb = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.Areas", t => t.AreaId, cascadeDelete: true)
                .ForeignKey("sist.Cargos", t => t.CargoId, cascadeDelete: true)
                .Index(t => t.CargoId)
                .Index(t => t.AreaId);
            
            CreateTable(
                "sist.PrestacionesLey",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        prestacionLey = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "sist.RedesSociales",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        TipoRedSocialId = c.Byte(nullable: false),
                        redSocial = c.String(nullable: false, maxLength: 100),
                        PersonaId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.Personas", t => t.PersonaId)
                .ForeignKey("sist.TiposRedesSociales", t => t.TipoRedSocialId, cascadeDelete: true)
                .Index(t => t.TipoRedSocialId)
                .Index(t => t.PersonaId);
            
            CreateTable(
                "sist.TiposRedesSociales",
                c => new
                    {
                        Id = c.Byte(nullable: false, identity: true),
                        tipoRedSocial = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.TiposPsicometrias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        tipoPsicometria = c.String(nullable: false, maxLength: 50),
                        descripcion = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "sist.Candidatos",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        PaisNacimientoId = c.Int(nullable: false),
                        EstadoNacimientoId = c.Int(),
                        MunicipioNacimientoId = c.Int(),
                        CodigoPostal = c.String(),
                        GeneroId = c.Byte(nullable: false),
                        EstadoCivilId = c.Byte(),
                        esDiscapacitado = c.Boolean(nullable: false),
                        TipoDiscapacidadId = c.Int(),
                        tieneLicenciaConducir = c.Boolean(nullable: false),
                        TipoLicenciaId = c.Byte(),
                        tieneVehiculoPropio = c.Boolean(nullable: false),
                        puedeViajar = c.Boolean(nullable: false),
                        puedeRehubicarse = c.Boolean(nullable: false),
                        CURP = c.String(),
                        RFC = c.String(),
                        NSS = c.String(),
                        ImgProfileUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.Personas", t => t.Id)
                .ForeignKey("sist.Paises", t => t.PaisNacimientoId, cascadeDelete: false)
                .ForeignKey("sist.Estados", t => t.EstadoNacimientoId)
                .ForeignKey("sist.Municipios", t => t.MunicipioNacimientoId)
                .ForeignKey("sist.Generos", t => t.GeneroId, cascadeDelete: false)
                .ForeignKey("sist.EstadosCiviles", t => t.EstadoCivilId)
                .ForeignKey("sist.TiposDiscapacidades", t => t.TipoDiscapacidadId)
                .ForeignKey("sist.TiposLicencias", t => t.TipoLicenciaId)
                .Index(t => t.Id)
                .Index(t => t.PaisNacimientoId)
                .Index(t => t.EstadoNacimientoId)
                .Index(t => t.MunicipioNacimientoId)
                .Index(t => t.GeneroId)
                .Index(t => t.EstadoCivilId)
                .Index(t => t.TipoDiscapacidadId)
                .Index(t => t.TipoLicenciaId);
            
            CreateTable(
                "sist.Clientes",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        RazonSocial = c.String(maxLength: 100),
                        Nombrecomercial = c.String(maxLength: 500),
                        RFC = c.String(maxLength: 15),
                        GiroEmpresaId = c.Int(nullable: false),
                        ActividadEmpresaId = c.Int(nullable: false),
                        TamanoEmpresaId = c.Int(nullable: false),
                        TipoEmpresaId = c.Int(nullable: false),
                        TipoBaseId = c.Int(nullable: false),
                        otraAgencia = c.Boolean(nullable: false),
                        esCliente = c.Boolean(nullable: false),
                        Clasificacion = c.String(nullable: false, maxLength: 10),
                        NumeroEmpleados = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.Personas", t => t.Id)
                .ForeignKey("sist.GiroEmpresas", t => t.GiroEmpresaId, cascadeDelete: false)
                .ForeignKey("sist.ActividadEmpresas", t => t.ActividadEmpresaId, cascadeDelete: false)
                .ForeignKey("sist.TamanosEmpresas", t => t.TamanoEmpresaId, cascadeDelete: false)
                .ForeignKey("sist.TiposEmpresas", t => t.TipoEmpresaId, cascadeDelete: false)
                .ForeignKey("sist.TiposBases", t => t.TipoBaseId, cascadeDelete: false)
                .Index(t => t.Id)
                .Index(t => t.GiroEmpresaId)
                .Index(t => t.ActividadEmpresaId)
                .Index(t => t.TamanoEmpresaId)
                .Index(t => t.TipoEmpresaId)
                .Index(t => t.TipoBaseId);
            
            CreateTable(
                "sist.Contactos",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Puesto = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.Personas", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "sist.Referenciados",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Puesto = c.String(nullable: false, maxLength: 100),
                        DAL = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("sist.Personas", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("sist.Referenciados", "Id", "sist.Personas");
            DropForeignKey("sist.Contactos", "Id", "sist.Personas");
            DropForeignKey("sist.Clientes", "TipoBaseId", "sist.TiposBases");
            DropForeignKey("sist.Clientes", "TipoEmpresaId", "sist.TiposEmpresas");
            DropForeignKey("sist.Clientes", "TamanoEmpresaId", "sist.TamanosEmpresas");
            DropForeignKey("sist.Clientes", "ActividadEmpresaId", "sist.ActividadEmpresas");
            DropForeignKey("sist.Clientes", "GiroEmpresaId", "sist.GiroEmpresas");
            DropForeignKey("sist.Clientes", "Id", "sist.Personas");
            DropForeignKey("sist.Candidatos", "TipoLicenciaId", "sist.TiposLicencias");
            DropForeignKey("sist.Candidatos", "TipoDiscapacidadId", "sist.TiposDiscapacidades");
            DropForeignKey("sist.Candidatos", "EstadoCivilId", "sist.EstadosCiviles");
            DropForeignKey("sist.Candidatos", "GeneroId", "sist.Generos");
            DropForeignKey("sist.Candidatos", "MunicipioNacimientoId", "sist.Municipios");
            DropForeignKey("sist.Candidatos", "EstadoNacimientoId", "sist.Estados");
            DropForeignKey("sist.Candidatos", "PaisNacimientoId", "sist.Paises");
            DropForeignKey("sist.Candidatos", "Id", "sist.Personas");
            DropForeignKey("sist.RedesSociales", "TipoRedSocialId", "sist.TiposRedesSociales");
            DropForeignKey("sist.RedesSociales", "PersonaId", "sist.Personas");
            DropForeignKey("sist.PerfilesProfesionales", "CargoId", "sist.Cargos");
            DropForeignKey("sist.PerfilesProfesionales", "AreaId", "sist.Areas");
            DropForeignKey("sist.FormulariosIniciales", "CandidatoId", "sist.Candidatos");
            DropForeignKey("sist.FormasContacto", "CandidatoId", "sist.Candidatos");
            DropForeignKey("sist.CandidatoConocimientoInformatico", "PorcentageId", "sist.Porcentages");
            DropForeignKey("sist.CandidatoConocimientoInformatico", "ConocimientoInformaticoId", "sist.ConocimientosInformaticos");
            DropForeignKey("sist.Agencias", "PersonaId", "sist.Personas");
            DropForeignKey("sist.DAMFO_290", "TipoReclutamientoId", "sist.TiposReclutamientos");
            DropForeignKey("sist.DAMFO_290", "TipoNominaId", "sist.TiposNominas");
            DropForeignKey("sist.TelefonoPerfil", "telefonoId", "sist.Telefonos");
            DropForeignKey("sist.TelefonoPerfil", "DAMFO290Id", "sist.DAMFO_290");
            DropForeignKey("sist.RutasPerfil", "DireccionId", "sist.Direcciones");
            DropForeignKey("sist.RutasPerfil", "DAMFO290Id", "sist.DAMFO_290");
            DropForeignKey("sist.PsicometriasDamsas", "DAMFO290Id", "sist.DAMFO_290");
            DropForeignKey("sist.PsicometriasClientes", "DAMFO290Id", "sist.DAMFO_290");
            DropForeignKey("sist.ProcesoPerfils", "DAMFO290Id", "sist.DAMFO_290");
            DropForeignKey("sist.PrestacionesClientePerfil", "DAMFO290Id", "sist.DAMFO_290");
            DropForeignKey("sist.DAMFO_290", "PeriodoPagoId", "sist.PeriodosPagos");
            DropForeignKey("sist.AptitudesPerfil", "DAMFO290Id", "sist.DAMFO_290");
            DropForeignKey("sist.ObservacionesPerfil", "DAMFO290Id", "sist.DAMFO_290");
            DropForeignKey("sist.HorariosPerfiles", "DAMFO290Id", "sist.DAMFO_290");
            DropForeignKey("sist.DAMFO_290", "EstadoCivilId", "sist.EstadosCiviles");
            DropForeignKey("sist.EscolaridadesPerfil", "DAMFO290Id", "sist.DAMFO_290");
            DropForeignKey("sist.DocumentosClientes", "DAMFO290Id", "sist.DAMFO_290");
            DropForeignKey("sist.DAMFO_290", "DireccionId", "sist.Direcciones");
            DropForeignKey("sist.DAMFO_290", "DiaPagoId", "sist.DiasSemana");
            DropForeignKey("sist.DAMFO_290", "DiaCorteId", "sist.DiasSemana");
            DropForeignKey("sist.DAMFO_290", "ContratoInicialId", "sist.TiposContratos");
            DropForeignKey("sist.DAMFO_290", "ContratoFinalId", "sist.TiposContratos");
            DropForeignKey("sist.ContactoPerfil", "DAMFO290Id", "sist.DAMFO_290");
            DropForeignKey("sist.ContactoPerfil", "ContactoId", "sist.Contactos");
            DropForeignKey("sist.CompetenciaGerencialPerfil", "DAMFO290Id", "sist.DAMFO_290");
            DropForeignKey("sist.CompetenciaGerencialPerfil", "CompetenciaId", "sist.CompetenciasGerenciales");
            DropForeignKey("sist.CompetenciaAreaPerfil", "DAMFO290Id", "sist.DAMFO_290");
            DropForeignKey("sist.CompetenciaAreaPerfil", "CompetenciaId", "sist.CompetenciasAreas");
            DropForeignKey("sist.CompetenciaCardinalPerfil", "DAMFO290Id", "sist.DAMFO_290");
            DropForeignKey("sist.CompetenciaCardinalPerfil", "CompetenciaId", "sist.CompetenciasCardinales");
            DropForeignKey("sist.DAMFO_290", "ClienteId", "sist.Clientes");
            DropForeignKey("sist.DAMFO_290", "ClaseReclutamientoId", "sist.ClasesReclutamientos");
            DropForeignKey("sist.BeneficiosPerfils", "TipoBeneficioId", "sist.TiposBeneficios");
            DropForeignKey("sist.BeneficiosPerfils", "DAMFO290Id", "sist.DAMFO_290");
            DropForeignKey("sist.DAMFO_290", "AreaId", "sist.Areas");
            DropForeignKey("sist.ActividadesPerfil", "DAMFO290Id", "sist.DAMFO_290");
            DropForeignKey("sist.AcercaDeMi", "PerfilExperienciaId", "sist.PerfilExperiencia");
            DropForeignKey("sist.PerfilIdiomas", "PerfilCandidatoId", "sist.PerfilCandidato");
            DropForeignKey("sist.PerfilIdiomas", "NivelId", "sist.Niveles");
            DropForeignKey("sist.PerfilIdiomas", "IdiomaId", "sist.Idiomas");
            DropForeignKey("sist.Formaciones", "YearTerminoId", "sist.Years");
            DropForeignKey("sist.Formaciones", "YearInicioId", "sist.Years");
            DropForeignKey("sist.Formaciones", "PerfilCandidatoId", "sist.PerfilCandidato");
            DropForeignKey("sist.Formaciones", "MonthTerminoId", "sist.Months");
            DropForeignKey("sist.Formaciones", "MonthInicioId", "sist.Months");
            DropForeignKey("sist.Formaciones", "InstitucionEducativaId", "sist.InstitucionesEducativas");
            DropForeignKey("sist.Formaciones", "GradoEstudioId", "sist.GradosEstudios");
            DropForeignKey("sist.Formaciones", "EstadoEstudioId", "sist.EstadosEstudios");
            DropForeignKey("sist.Formaciones", "DocumentoValidadorId", "sist.DocumentosValidadores");
            DropForeignKey("sist.Formaciones", "CarreraId", "sist.Carreras");
            DropForeignKey("sist.ExperienciasProfesionales", "YearTerminoId", "sist.Years");
            DropForeignKey("sist.ExperienciasProfesionales", "YearInicioId", "sist.Years");
            DropForeignKey("sist.ExperienciasProfesionales", "PerfilCandidatoId", "sist.PerfilCandidato");
            DropForeignKey("sist.ExperienciasProfesionales", "MonthTerminoId", "sist.Months");
            DropForeignKey("sist.ExperienciasProfesionales", "MonthInicioId", "sist.Months");
            DropForeignKey("sist.ExperienciasProfesionales", "GiroEmpresaId", "sist.GiroEmpresas");
            DropForeignKey("sist.ExperienciasProfesionales", "AreaId", "sist.Areas");
            DropForeignKey("sist.Cursos", "YearTerminoId", "sist.Years");
            DropForeignKey("sist.Cursos", "YearInicioId", "sist.Years");
            DropForeignKey("sist.Cursos", "PerfilCandidatoId", "sist.PerfilCandidato");
            DropForeignKey("sist.Cursos", "MonthTerminoId", "sist.Months");
            DropForeignKey("sist.Cursos", "MonthInicioId", "sist.Months");
            DropForeignKey("sist.Cursos", "InstitucionEducativaId", "sist.InstitucionesEducativas");
            DropForeignKey("sist.ConocimientosHabilidades", "PerfilCandidatoId", "sist.PerfilCandidato");
            DropForeignKey("sist.ConocimientosHabilidades", "NivelId", "sist.Niveles");
            DropForeignKey("sist.ConocimientosHabilidades", "InstitucionEducativaId", "sist.InstitucionesEducativas");
            DropForeignKey("sist.Certificaciones", "YearTerminoId", "sist.Years");
            DropForeignKey("sist.Certificaciones", "YearInicioId", "sist.Years");
            DropForeignKey("sist.Certificaciones", "PerfilCandidatoId", "sist.PerfilCandidato");
            DropForeignKey("sist.Certificaciones", "MonthTerminoId", "sist.Months");
            DropForeignKey("sist.Certificaciones", "MonthInicioId", "sist.Months");
            DropForeignKey("sist.PerfilCandidato", "CandidatoId", "sist.Candidatos");
            DropForeignKey("sist.Direcciones", "TipoDireccionId", "sist.TiposDirecciones");
            DropForeignKey("sist.ActividadEmpresas", "GiroEmpresaId", "sist.GiroEmpresas");
            DropForeignKey("sist.Telefonos", "TipoTelefonoId", "sist.TiposTelefonos");
            DropForeignKey("sist.Telefonos", "PersonaId", "sist.Personas");
            DropForeignKey("sist.Emails", "PersonaId", "sist.Personas");
            DropForeignKey("sist.Direcciones", "PersonaId", "sist.Personas");
            DropForeignKey("sist.Direcciones", "PaisId", "sist.Paises");
            DropForeignKey("sist.Direcciones", "MunicipioId", "sist.Municipios");
            DropForeignKey("sist.Direcciones", "EstadoId", "sist.Estados");
            DropForeignKey("sist.Direcciones", "ColoniaId", "sist.Colonias");
            DropForeignKey("sist.Colonias", "PaisId", "sist.Paises");
            DropForeignKey("sist.Colonias", "MunicipioId", "sist.Municipios");
            DropForeignKey("sist.Municipios", "EstadoId", "sist.Estados");
            DropForeignKey("sist.Colonias", "EstadoId", "sist.Estados");
            DropForeignKey("sist.Estados", "PaisId", "sist.Paises");
            DropForeignKey("sist.AcercaDeMi", "PerfilCandidatoId", "sist.PerfilCandidato");
            DropForeignKey("sist.AcercaDeMi", "AreaInteresId", "sist.AreasInteres");
            DropForeignKey("sist.AcercaDeMi", "AreaExperienciaId", "sist.AreasExperiencia");
            DropIndex("sist.Referenciados", new[] { "Id" });
            DropIndex("sist.Contactos", new[] { "Id" });
            DropIndex("sist.Clientes", new[] { "TipoBaseId" });
            DropIndex("sist.Clientes", new[] { "TipoEmpresaId" });
            DropIndex("sist.Clientes", new[] { "TamanoEmpresaId" });
            DropIndex("sist.Clientes", new[] { "ActividadEmpresaId" });
            DropIndex("sist.Clientes", new[] { "GiroEmpresaId" });
            DropIndex("sist.Clientes", new[] { "Id" });
            DropIndex("sist.Candidatos", new[] { "TipoLicenciaId" });
            DropIndex("sist.Candidatos", new[] { "TipoDiscapacidadId" });
            DropIndex("sist.Candidatos", new[] { "EstadoCivilId" });
            DropIndex("sist.Candidatos", new[] { "GeneroId" });
            DropIndex("sist.Candidatos", new[] { "MunicipioNacimientoId" });
            DropIndex("sist.Candidatos", new[] { "EstadoNacimientoId" });
            DropIndex("sist.Candidatos", new[] { "PaisNacimientoId" });
            DropIndex("sist.Candidatos", new[] { "Id" });
            DropIndex("sist.RedesSociales", new[] { "PersonaId" });
            DropIndex("sist.RedesSociales", new[] { "TipoRedSocialId" });
            DropIndex("sist.PerfilesProfesionales", new[] { "AreaId" });
            DropIndex("sist.PerfilesProfesionales", new[] { "CargoId" });
            DropIndex("sist.FormulariosIniciales", new[] { "CandidatoId" });
            DropIndex("sist.FormasContacto", new[] { "CandidatoId" });
            DropIndex("sist.CandidatoConocimientoInformatico", new[] { "PorcentageId" });
            DropIndex("sist.CandidatoConocimientoInformatico", new[] { "ConocimientoInformaticoId" });
            DropIndex("sist.Agencias", new[] { "PersonaId" });
            DropIndex("sist.TelefonoPerfil", new[] { "DAMFO290Id" });
            DropIndex("sist.TelefonoPerfil", new[] { "telefonoId" });
            DropIndex("sist.RutasPerfil", new[] { "DAMFO290Id" });
            DropIndex("sist.RutasPerfil", new[] { "DireccionId" });
            DropIndex("sist.PsicometriasDamsas", new[] { "DAMFO290Id" });
            DropIndex("sist.PsicometriasClientes", new[] { "DAMFO290Id" });
            DropIndex("sist.ProcesoPerfils", new[] { "DAMFO290Id" });
            DropIndex("sist.PrestacionesClientePerfil", new[] { "DAMFO290Id" });
            DropIndex("sist.AptitudesPerfil", new[] { "DAMFO290Id" });
            DropIndex("sist.ObservacionesPerfil", new[] { "DAMFO290Id" });
            DropIndex("sist.HorariosPerfiles", new[] { "DAMFO290Id" });
            DropIndex("sist.EscolaridadesPerfil", new[] { "DAMFO290Id" });
            DropIndex("sist.DocumentosClientes", new[] { "DAMFO290Id" });
            DropIndex("sist.ContactoPerfil", new[] { "DAMFO290Id" });
            DropIndex("sist.ContactoPerfil", new[] { "ContactoId" });
            DropIndex("sist.CompetenciaGerencialPerfil", new[] { "DAMFO290Id" });
            DropIndex("sist.CompetenciaGerencialPerfil", new[] { "CompetenciaId" });
            DropIndex("sist.CompetenciaAreaPerfil", new[] { "DAMFO290Id" });
            DropIndex("sist.CompetenciaAreaPerfil", new[] { "CompetenciaId" });
            DropIndex("sist.CompetenciaCardinalPerfil", new[] { "DAMFO290Id" });
            DropIndex("sist.CompetenciaCardinalPerfil", new[] { "CompetenciaId" });
            DropIndex("sist.BeneficiosPerfils", new[] { "DAMFO290Id" });
            DropIndex("sist.BeneficiosPerfils", new[] { "TipoBeneficioId" });
            DropIndex("sist.DAMFO_290", new[] { "ContratoFinalId" });
            DropIndex("sist.DAMFO_290", new[] { "ContratoInicialId" });
            DropIndex("sist.DAMFO_290", new[] { "PeriodoPagoId" });
            DropIndex("sist.DAMFO_290", new[] { "DiaPagoId" });
            DropIndex("sist.DAMFO_290", new[] { "TipoNominaId" });
            DropIndex("sist.DAMFO_290", new[] { "DiaCorteId" });
            DropIndex("sist.DAMFO_290", new[] { "AreaId" });
            DropIndex("sist.DAMFO_290", new[] { "EstadoCivilId" });
            DropIndex("sist.DAMFO_290", new[] { "ClaseReclutamientoId" });
            DropIndex("sist.DAMFO_290", new[] { "TipoReclutamientoId" });
            DropIndex("sist.DAMFO_290", new[] { "DireccionId" });
            DropIndex("sist.DAMFO_290", new[] { "ClienteId" });
            DropIndex("sist.ActividadesPerfil", new[] { "DAMFO290Id" });
            DropIndex("sist.PerfilIdiomas", new[] { "PerfilCandidatoId" });
            DropIndex("sist.PerfilIdiomas", new[] { "NivelId" });
            DropIndex("sist.PerfilIdiomas", new[] { "IdiomaId" });
            DropIndex("sist.Formaciones", new[] { "PerfilCandidatoId" });
            DropIndex("sist.Formaciones", new[] { "MonthTerminoId" });
            DropIndex("sist.Formaciones", new[] { "YearTerminoId" });
            DropIndex("sist.Formaciones", new[] { "MonthInicioId" });
            DropIndex("sist.Formaciones", new[] { "YearInicioId" });
            DropIndex("sist.Formaciones", new[] { "CarreraId" });
            DropIndex("sist.Formaciones", new[] { "DocumentoValidadorId" });
            DropIndex("sist.Formaciones", new[] { "EstadoEstudioId" });
            DropIndex("sist.Formaciones", new[] { "GradoEstudioId" });
            DropIndex("sist.Formaciones", new[] { "InstitucionEducativaId" });
            DropIndex("sist.ExperienciasProfesionales", new[] { "PerfilCandidatoId" });
            DropIndex("sist.ExperienciasProfesionales", new[] { "MonthTerminoId" });
            DropIndex("sist.ExperienciasProfesionales", new[] { "YearTerminoId" });
            DropIndex("sist.ExperienciasProfesionales", new[] { "MonthInicioId" });
            DropIndex("sist.ExperienciasProfesionales", new[] { "YearInicioId" });
            DropIndex("sist.ExperienciasProfesionales", new[] { "AreaId" });
            DropIndex("sist.ExperienciasProfesionales", new[] { "GiroEmpresaId" });
            DropIndex("sist.Cursos", new[] { "PerfilCandidatoId" });
            DropIndex("sist.Cursos", new[] { "MonthTerminoId" });
            DropIndex("sist.Cursos", new[] { "YearTerminoId" });
            DropIndex("sist.Cursos", new[] { "MonthInicioId" });
            DropIndex("sist.Cursos", new[] { "YearInicioId" });
            DropIndex("sist.Cursos", new[] { "InstitucionEducativaId" });
            DropIndex("sist.ConocimientosHabilidades", new[] { "PerfilCandidatoId" });
            DropIndex("sist.ConocimientosHabilidades", new[] { "NivelId" });
            DropIndex("sist.ConocimientosHabilidades", new[] { "InstitucionEducativaId" });
            DropIndex("sist.Certificaciones", new[] { "PerfilCandidatoId" });
            DropIndex("sist.Certificaciones", new[] { "MonthTerminoId" });
            DropIndex("sist.Certificaciones", new[] { "YearTerminoId" });
            DropIndex("sist.Certificaciones", new[] { "MonthInicioId" });
            DropIndex("sist.Certificaciones", new[] { "YearInicioId" });
            DropIndex("sist.ActividadEmpresas", new[] { "GiroEmpresaId" });
            DropIndex("sist.Telefonos", new[] { "PersonaId" });
            DropIndex("sist.Telefonos", new[] { "TipoTelefonoId" });
            DropIndex("sist.Emails", new[] { "PersonaId" });
            DropIndex("sist.Municipios", new[] { "EstadoId" });
            DropIndex("sist.Estados", new[] { "PaisId" });
            DropIndex("sist.Colonias", new[] { "PaisId" });
            DropIndex("sist.Colonias", new[] { "EstadoId" });
            DropIndex("sist.Colonias", new[] { "MunicipioId" });
            DropIndex("sist.Direcciones", new[] { "PersonaId" });
            DropIndex("sist.Direcciones", new[] { "ColoniaId" });
            DropIndex("sist.Direcciones", new[] { "MunicipioId" });
            DropIndex("sist.Direcciones", new[] { "EstadoId" });
            DropIndex("sist.Direcciones", new[] { "PaisId" });
            DropIndex("sist.Direcciones", new[] { "TipoDireccionId" });
            DropIndex("sist.PerfilCandidato", new[] { "CandidatoId" });
            DropIndex("sist.AcercaDeMi", new[] { "PerfilCandidatoId" });
            DropIndex("sist.AcercaDeMi", new[] { "PerfilExperienciaId" });
            DropIndex("sist.AcercaDeMi", new[] { "AreaInteresId" });
            DropIndex("sist.AcercaDeMi", new[] { "AreaExperienciaId" });
            DropTable("sist.Referenciados");
            DropTable("sist.Contactos");
            DropTable("sist.Clientes");
            DropTable("sist.Candidatos");
            DropTable("sist.TiposPsicometrias");
            DropTable("sist.TiposRedesSociales");
            DropTable("sist.RedesSociales");
            DropTable("sist.PrestacionesLey");
            DropTable("sist.PerfilesProfesionales");
            DropTable("sist.FormulariosIniciales");
            DropTable("sist.FormasContacto");
            DropTable("sist.DocumentosDamsa");
            DropTable("sist.DiasObligatorios");
            DropTable("sist.Cargos");
            DropTable("sist.Porcentages");
            DropTable("sist.ConocimientosInformaticos");
            DropTable("sist.CandidatoConocimientoInformatico");
            DropTable("sist.Aptitudes");
            DropTable("sist.Agencias");
            DropTable("sist.TiposReclutamientos");
            DropTable("sist.TiposNominas");
            DropTable("sist.TelefonoPerfil");
            DropTable("sist.RutasPerfil");
            DropTable("sist.PsicometriasDamsas");
            DropTable("sist.PsicometriasClientes");
            DropTable("sist.ProcesoPerfils");
            DropTable("sist.PrestacionesClientePerfil");
            DropTable("sist.PeriodosPagos");
            DropTable("sist.AptitudesPerfil");
            DropTable("sist.ObservacionesPerfil");
            DropTable("sist.HorariosPerfiles");
            DropTable("sist.EscolaridadesPerfil");
            DropTable("sist.DocumentosClientes");
            DropTable("sist.DiasSemana");
            DropTable("sist.TiposContratos");
            DropTable("sist.ContactoPerfil");
            DropTable("sist.CompetenciasGerenciales");
            DropTable("sist.CompetenciaGerencialPerfil");
            DropTable("sist.CompetenciasAreas");
            DropTable("sist.CompetenciaAreaPerfil");
            DropTable("sist.CompetenciasCardinales");
            DropTable("sist.CompetenciaCardinalPerfil");
            DropTable("sist.ClasesReclutamientos");
            DropTable("sist.TiposBeneficios");
            DropTable("sist.BeneficiosPerfils");
            DropTable("sist.DAMFO_290");
            DropTable("sist.ActividadesPerfil");
            DropTable("sist.PerfilExperiencia");
            DropTable("sist.Idiomas");
            DropTable("sist.PerfilIdiomas");
            DropTable("sist.GradosEstudios");
            DropTable("sist.EstadosEstudios");
            DropTable("sist.DocumentosValidadores");
            DropTable("sist.Carreras");
            DropTable("sist.Formaciones");
            DropTable("sist.Areas");
            DropTable("sist.ExperienciasProfesionales");
            DropTable("sist.Cursos");
            DropTable("sist.Niveles");
            DropTable("sist.InstitucionesEducativas");
            DropTable("sist.ConocimientosHabilidades");
            DropTable("sist.Years");
            DropTable("sist.Months");
            DropTable("sist.Certificaciones");
            DropTable("sist.TiposLicencias");
            DropTable("sist.TiposDiscapacidades");
            DropTable("sist.Generos");
            DropTable("sist.EstadosCiviles");
            DropTable("sist.TiposDirecciones");
            DropTable("sist.TiposEmpresas");
            DropTable("sist.TiposBases");
            DropTable("sist.TamanosEmpresas");
            DropTable("sist.GiroEmpresas");
            DropTable("sist.ActividadEmpresas");
            DropTable("sist.TiposTelefonos");
            DropTable("sist.Telefonos");
            DropTable("sist.Emails");
            DropTable("sist.Municipios");
            DropTable("sist.Paises");
            DropTable("sist.Estados");
            DropTable("sist.Colonias");
            DropTable("sist.Direcciones");
            DropTable("sist.Personas");
            DropTable("sist.PerfilCandidato");
            DropTable("sist.AreasInteres");
            DropTable("sist.AreasExperiencia");
            DropTable("sist.AcercaDeMi");
        }
    }
}
