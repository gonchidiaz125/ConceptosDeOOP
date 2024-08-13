using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosDeOOP.EjemplosDeInterfaces.Vehiculos
{

    // En este ejemplo voy a crear una clase base VEHICULO
    // VEHICULO tendrá dos propiedades (Fabricante y Nombre) y un método (MostrarDescripcion)

    // Luego voy a crear dos clases que heredan de VEHICULO (también podemos decir basadas en VEHICULO)
    // AUTOMOVIL: agrega una propiedad extra Cantidad de Puertas (se agrega a Fabricante y Nombre que se heredan de VEHICULO)
    // CAMINON: agrega propiedades extra
    // CAMINON CON ACOPLADO: Hereda de CAMION, agrega más propiedades extra
    public class Vehiculo
    {
        public Fabricante Fabricante { get; set; }
        public string Nombre { get; set; }

        // Constructor de la clase (es necesario definir el Fabricante y el nombre)
        // el constructor es el metodo que se ejecuta cuando se crea un objeto de esta clase
        public Vehiculo(Fabricante fabricante, string nombre)
        {
            Fabricante = fabricante;
            Nombre = nombre;
        }

        public virtual void MostrarDescripcion()
        {
            Console.WriteLine($"Nombre del vehículo: {Nombre} Fabricante: {Fabricante}");
        }
    }

    // Defino una ENUM, que me permite definir las marcas de Fabricantes válidas
    public enum Fabricante
    {        
        Chevrolet,        
        Fiat,
        Ford,
        Honda,
        MercedesBenz,
        Nissan,
        Peugeot,        
        Renault,
        Scania,        
        Volkswagen,
    }

    public class Automovil : Vehiculo
    {
        // Agrego una propiedad propia de los automoviles
        public int NumeroDePuertas { get; set; }

        // Constructor propio de la clase Automovil
        // lo primero que hace es llamar al constructor de la clase base mediante >> : base(fabricante, nombre) {
        // de esta forma aprovecha la funcionalidad de la clase base, y luego completa la propiedad NumeroDePuertas
        public Automovil(Fabricante fabricante, string nombre, int numeroDePuertas) : base(fabricante, nombre) 
        {
            NumeroDePuertas = numeroDePuertas;
        }

        // Override: Sobreescribe o pisa el método MostrarDescripcion original
        // Igualmente, en la primer linea se llama al método MostrarDescripcion de la clase base, ya que todavía nos interesa mostrar la información básica
        public override void MostrarDescripcion()
        {
            base.MostrarDescripcion();
            Console.WriteLine($"Cantidad de puertas: {NumeroDePuertas}");
        }
    }

    public class Camion : Vehiculo
    {
        // Agrego una propiedad propia de los camiones
        public int CapacidadCarga { get; set; }

        // Constructor propio de la clase Camion
        // lo primero que hace es llamar al constructor de la clase base mediante >> : base(fabricante, nombre) {
        // de esta forma aprovecha la funcionalidad de la clase base, y luego completa la propiedad capacidad de carga
        public Camion(Fabricante fabricante, string nombre, int capacidadCarga) : base(fabricante, nombre)
        {
            CapacidadCarga = capacidadCarga;
        }

        // Override: Sobreescribe o pisa el método MostrarDescripcion original
        // Igualmente, en la primer linea se llama al método MostrarDescripcion de la clase base, ya que todavía nos interesa mostrar la información básica
        public override void MostrarDescripcion()
        {
            base.MostrarDescripcion();
            Console.WriteLine($"Capacidad de Carga: {CapacidadCarga}");
        }
    }

    public class CamionConAcoplado: Camion
    {
        public int CargaExtraConAcoplado { get; set; }

        // Acá se muestra por primera vez una propiedad que tiene GET pero no SET
        // GET se ejecuta cuando se quiere leer la propiedad, y permite ejecutar código, en este caso devolver la capacidad de carga total
        // SET: como no tiene, no se puede definir un valor para esta propiedad (queda para "solo lectura / read only")
        public int CargaMaximaTotal { 
            get { return CapacidadCarga + CargaExtraConAcoplado; } 
        }


        // Constructor propio de la clase "Camión con Acoplado"
        // lo primero que hace es llamar al constructor de la clase base (Camión) mediante >> : base(fabricante, nombre) {
        // el constructor de "Camión" a su vez llama al constructor de la clase base
        public CamionConAcoplado(Fabricante fabricante, string nombre, int capacidadCarga, int cargaExtraConAcoplado) : base(fabricante, nombre, capacidadCarga)
        {
            CargaExtraConAcoplado = cargaExtraConAcoplado;
        }

        // Override: Sobreescribe o pisa el método MostrarDescripcion de la clase "Padre" Camion
        // Igualmente, en la primer linea se llama al método MostrarDescripcion de la clase base, ya que todavía nos interesa mostrar la información básica
        public override void MostrarDescripcion()
        {
            base.MostrarDescripcion();
            Console.WriteLine($"Este camión permite acoplado. Carga extra con Acoplado: {CargaExtraConAcoplado}");
            Console.WriteLine($"Carga máxima total: {CargaMaximaTotal}");
        }

    }

}
