using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosDeOOP.EjemplosDeInterfaces.FigurasGeometricasClasesHerencia
{
    public class FiguraGeometricaBase
    {
        public string nombreFigura { get; set; }


        public FiguraGeometricaBase(string nombreFigura)
        {
            this.nombreFigura = nombreFigura;
        }

        

        public virtual void MostrarDescripcion()
        {
            Console.WriteLine($"Soy un {nombreFigura}"); 

        }

        public virtual double CalcularPerimetro() 
        {
            return 0.0;
        }

        public virtual double CalcularSuperficie() 
        {
            return 0.0;

        }
    }

    public class Triangulo : FiguraGeometricaBase 
    {   
        public double Altura { get; set; }
        public double Base { get; set; }

        public Triangulo( string nombreFigura, double alturaTriangulo, double baseTriangulo) : base(nombreFigura) 
        {
            Altura = alturaTriangulo; 
            Base = baseTriangulo;
        }

        public override void MostrarDescripcion()
        {
            base.MostrarDescripcion();
            Console.WriteLine($"La base es de: {Base}, y la altura es de: {Altura}");
        }
        public override double CalcularPerimetro()
        {
            return 3 * Base;
        }

        public override double CalcularSuperficie()
        {
            return (Base * Altura) / 2;
        }
    }

    public class Cuadrado : FiguraGeometricaBase
    {
        public double Lado { get; set; }

        public Cuadrado (string nombreFigura, double ladoDeCuadrado) : base(nombreFigura)
        {
            Lado = ladoDeCuadrado;
        }

        public override void MostrarDescripcion()
        {
            base.MostrarDescripcion();
            Console.WriteLine($"El lado del cuadrado mide: {Lado}");
        }

        public override double CalcularPerimetro()
        {
            return 4 * Lado; 
        }

        public override double CalcularSuperficie()
        {
            return Lado * Lado;
        }
    }

    public class Rectangulo : FiguraGeometricaBase 
    { 
        public double Ancho { get; set; }
        public double Alto { get; set; }

        public Rectangulo (string nombreFigura, double anchoRectangulo, double altoRectangulo) : base(nombreFigura) 
        {
            Ancho = anchoRectangulo;
            Alto = altoRectangulo;
        }

        public override void MostrarDescripcion()
        {
            base.MostrarDescripcion();
            Console.WriteLine($"El ancho del rectangulo es de: {Ancho} y el alto del rectangulo es de: {Alto}");
        }

        public override double CalcularPerimetro()
        {
            return 2 * (Ancho + Alto);
        }

        public override double CalcularSuperficie()
        {
            return Ancho * Alto;
        }

    }

    public class Circulo : FiguraGeometricaBase 
    {
        public double Radio { get; set; }

        public Circulo (string nombreFigura, double radioDeCirculo) : base(nombreFigura) 
        {
            Radio = radioDeCirculo;
        }

        public override void MostrarDescripcion()
        {
            base.MostrarDescripcion();
            Console.WriteLine($"El radio del circulo es de {Radio}");
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }

        public override double CalcularSuperficie()
        {
            return Math.PI * Radio * Radio;
        }

    }
}
