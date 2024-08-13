
using System.Reflection.Metadata.Ecma335;

namespace ConceptosDeOOP.EjemplosDeInterfaces.FigurasGeometricas
{
    public interface IFigurasGeometricas
    {
        public string Dibujar();

    }

    public class DibujandoCuadrado : IFigurasGeometricas
    {
        private readonly string _dibujar = "cuadrado";

        public string Dibujar()
        {

            var columnas = 6;
            var filas = 3;
            var linea1 = new string('X', columnas);
            var linea2 = "X" + new string(' ', columnas - 2) + "X";

            for (int i = 1; i <= filas; i++)
            {
                if (i == 1 || i == filas)
                {
                    Console.WriteLine(linea1);
                }
                else
                {
                    Console.WriteLine(linea2);
                }


            }

            return _dibujar;
        }
    }

    public class DibujandoUnTriangulo : IFigurasGeometricas
    {
        private readonly string _dibujar = "triangulo";

        public string Dibujar() 
        {
            int letrasPorFila = 8;
            int filas = letrasPorFila;

            // filas
            for (int fila = 1; fila <= filas; fila++)
            {

                // columnas
                for (int columna = 1; columna <= letrasPorFila; columna++)
                {
                    Console.Write("A");
                }
                Console.WriteLine();

                letrasPorFila--;
            }
            return _dibujar;
        }
        
    }
}
