using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SAGA.BOL
{
    public class Direccion
    {       
        public Guid Id { get; set; }


        public int TipoDireccionId { get; set; }
        public virtual TipoDireccion TipoDireccion { get; set; }

        [DefaultValue("False")]
        public bool esMoral { get; set; } 
        public string Calle { get; set; } 
        public string NumeroInterior { get; set; } 
        public string NumeroExterior { get; set; } 
        public int PaisId { get; set; }
        public Pais Pais { get; set; } 
        public int? EstadoId { get; set; }         
        public Estado Estado { get; set; } 
        public int? MunicipioId { get; set; }        
        public Municipio Municipio { get; set; }        
        public int?  ColoniaId { get; set; }
        public Colonia Colonia { get; set; }
        public string CodigoPostal { get; set; }
        public bool esPrincipal { get; set; } 
        [DefaultValue("True")]
        public bool Activo { get; set; }
        public string Referencia { get; set; }
        public Guid PersonaId { get; set; }
        public virtual Persona PersonaFisicaMoral { get; set; }

        public Direccion()
        {
            this.Id = Guid.NewGuid();
        }
    }
}