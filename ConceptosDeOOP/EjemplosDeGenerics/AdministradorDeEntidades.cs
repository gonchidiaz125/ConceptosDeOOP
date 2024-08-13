using ConceptosDeOOP.EjemplosDeGenerics.Entidades;


namespace ConceptosDeOOP.EjemplosDeGenerics
{
    public class AdministradorDeEntidades
    {
        public void DarDeBaja<T>(T entidad, string usuarioBaja) where T : EntidadBase
        {
            if (entidad.Activo)
            {
                entidad.Activo = false;
                entidad.FechaBaja = DateTime.Now;
                entidad.UsuarioBaja = usuarioBaja;
            }
        }
    }

}
