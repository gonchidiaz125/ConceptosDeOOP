using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosDeOOP.EjemplosDeInterfaces.Hospitales
{
    public class EntidadBaseSinAuditoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }


    }

    public class Usuario: EntidadBaseSinAuditoria
    {
        public string email { get; set; }  
        public string password { get; set; }
        public bool Activo { get; set; }
    }

    public class EntidadBase : EntidadBaseSinAuditoria
    {
        public bool Activa { get; set; }

        public DateTime FechaAlta { get; set; }

        public Usuario UsuarioAlta { get; set; }

        public DateTime FechaModificacion { get; set; }

        public Usuario UsuarioModificacion { get; set; }

        public DateTime FechaBaja { get; set; }

        public Usuario UsuarioBaja { get; set; }
    }


    public class Persona : EntidadBase
    {
        public string Apellido { get; set; }
        public int NumeroDocumento { get; set;  }
        public string Email { get; set;  }
        public DateTime FechaNacimiento { get; set; }
    }

    public class Medico : Persona
    {
        public string Matricula { get; set; }
    }

    public class Especialidad : EntidadBase
    {

    }

    public class Sucursal : EntidadBase
    {
        public string Direccion { get; set; }

        public bool DisponeConsultorios { get; set; }
        public bool DisponeInternacion { get; set; }
        public bool DisponeGuardiaExterna { get; set; }
        public bool DisponeQuirofano { get; set; }
    }

    public class GestorDeEntidades
    {
        public void DarDeBaja<T>(T entidad, Usuario usuario) where T : EntidadBase
        {
            entidad.Activa = false;
            entidad.FechaBaja = DateTime.Now;
            entidad.UsuarioBaja = usuario;
        }
    }
    
}
