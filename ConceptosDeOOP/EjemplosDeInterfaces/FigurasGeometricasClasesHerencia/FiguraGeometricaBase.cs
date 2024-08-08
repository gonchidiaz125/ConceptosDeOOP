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

        public Triangulo( string nombreFigura, int alturaTriangulo, int baseTriangulo) : base(nombreFigura) 
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
}
