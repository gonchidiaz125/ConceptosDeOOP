namespace ConceptosDeOOP.EjemplosDeInterfaces.OperacionesMatematicas
{
    /// <summary>
    /// La interfaz IOperacionMatematica define los métodos comunes que debe implementar (tener) cualquier clase que represente una operacion matematica (con clase me refiero a clase de orientacion objetos) 
    /// </summary>
    public interface IOperacionMatematica
    {
        public double Calcular(double numero1, double numero2);

        public string ObtenerMensajeConResultado(double numero1, double numero2);

    }

    public class CalculadoraDeSuma : IOperacionMatematica
    {
        private readonly string _operacion = "Suma";

        public double Calcular(double numero1, double numero2)
        {
            return numero1 + numero2;
        }

        public string ObtenerMensajeConResultado(double numero1, double numero2)
        {
            var resultado = Calcular(numero1, numero2);
            return $"La {_operacion} de {numero1} + {numero2} es {resultado}";
        }
    }

    public class CalculadoraDeResta : IOperacionMatematica
    {
        private readonly string _operacion = "Resta";

        public double Calcular(double numero1, double numero2)
        {
            return numero1 - numero2;
        }

        public string ObtenerMensajeConResultado(double numero1, double numero2)
        {
            var resultado = Calcular(numero1, numero2);
            return $"La {_operacion} de {numero1} - {numero2} es {resultado}";
        }
    }

    public class CalculadoraDeMultiplicacion : IOperacionMatematica
    {
        private readonly string _operacion = "Multiplicación";

        public double Calcular(double numero1, double numero2)
        {
            return numero1 * numero2;
        }

        public string ObtenerMensajeConResultado(double numero1, double numero2)
        {
            var resultado = Calcular(numero1, numero2);
            return $"La {_operacion} de {numero1} * {numero2} es {resultado}";
        }
    }
}
