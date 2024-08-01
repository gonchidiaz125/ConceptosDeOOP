using ConceptosDeOOP.EjemplosDeInterfaces.Logger;
using ConceptosDeOOP.EjemplosDeInterfaces.OperacionesMatematicas;
using ConceptosDeOOP.EjemplosDeInterfaces.Vehiculos;

Console.WriteLine("Hola. Este son ejemplo de OOP (Object Oriented Programing). Se incluye el uso de Interfaces, clases y herencia");
Console.WriteLine("");


// Ejemplos 1 y 2 con Operaciones matematicas (Interfaces y clases)
// EjemploDeOperacionesMatematicas();


// Ejemplo 3 de los Logger (Interfaces y clases)
// EjemploDeUsoDeLogger();


// Ejemplo 4: Clases y Herencia
EjemploDeClaseVehiculo();


void EjemploDeOperacionesMatematicas()
{
    var num1 = 20.5d;
    var num2 = 10.2d;

    /* Primer ejemplo: Voy a crear un objeto de cada tipo de operación y lo utilizo para hacer el cálculo
       Como se puede ver el código es muy similar en cada caso, el principal cambio es que se utiliza una calculadora diferente en cada caso
     */

    Console.WriteLine("Ejemplo 1");
    Console.WriteLine("");

    var sumador = new CalculadoraDeSuma();
    var resultado = sumador.Calcular(num1, num2);
    Console.WriteLine($"Resultado ({num1} + {num2}): {resultado}");
    Console.WriteLine(sumador.ObtenerMensajeConResultado(num1, num2));
    Console.WriteLine("");

    var restador = new CalculadoraDeResta();
    resultado = restador.Calcular(num1, num2);
    Console.WriteLine($"Resultado ({num1} - {num2}): {resultado}");
    Console.WriteLine(restador.ObtenerMensajeConResultado(num1, num2));
    Console.WriteLine("");

    var multiplicador = new CalculadoraDeMultiplicacion();
    resultado = multiplicador.Calcular(num1, num2);
    Console.WriteLine($"Resultado ({num1} * {num2}): {resultado}");
    Console.WriteLine(multiplicador.ObtenerMensajeConResultado(num1, num2));
    Console.WriteLine("");

    var divisor = new CalculadoraDeDivision();
    resultado = divisor.Calcular(num1, num2);
    Console.WriteLine($"Resultado({num1} / {num2}): {resultado}");
    Console.WriteLine(divisor.ObtenerMensajeConResultado(num1, num2));
    Console.WriteLine("");
    Console.WriteLine("");


    /*
       Segundo ejemplo: Voy a crear un objeto de cada tipo de calculadora, pero voy a usar un función permita ejecutar cualquier tipo de calculadora
     */

    Console.WriteLine("Ejemplo 2");
    Console.WriteLine("");

    var sumadorEjemplo2 = new CalculadoraDeSuma();
    var restaEjemplo2 = new CalculadoraDeResta();
    var multiplicadorEjemplo2 = new CalculadoraDeMultiplicacion();
    
    EjecutarOperacion(num1, num2, sumadorEjemplo2);
    EjecutarOperacion(num1, num2, restaEjemplo2);
    EjecutarOperacion(num1, num2, multiplicadorEjemplo2);
}


double EjecutarOperacion(double num1, double num2, IOperacionMatematica operacion)
{
    var resultado = operacion.Calcular(num1, num2);
    Console.WriteLine(operacion.ObtenerMensajeConResultado(num1, num2));
    Console.WriteLine("");
    return resultado;
}

void EjemploDeUsoDeLogger()
{    
    Console.WriteLine("Ejemplo 3");
    Console.WriteLine("Usar una interfaz ILogger para dar soporte a diferentes tipos de loggers (a consola, a base de datos, a un servidor en la nube que guarde los logs) ");
    Console.WriteLine("");

    var logearEnConsola = new ConsoleLogger();
    var gestorCuentaBancaria = new GestorDeCuentaBanciaria(logearEnConsola);

    // Caso 1: Depósito exitoso (ConsoleLogger)
    Console.WriteLine("");
    Console.WriteLine("Caso 1: Deposito exitoso (usando ConsoleLogger)");
    Console.WriteLine("");
    var idCliente = 20;
    var numeroDeCuenta = 111222;
    var monto = 1500000d;
    gestorCuentaBancaria.ProcesarDepositoBancario(idCliente, numeroDeCuenta, monto);

    // Caso 2: Depósito fallido debido a monto = 0 (ConsoleLogger)
    Console.WriteLine("");
    Console.WriteLine("Caso 2: Deposito FALLIDO (usando ConsoleLogger)");
    Console.WriteLine("");
    monto = 0d;
    gestorCuentaBancaria.ProcesarDepositoBancario(idCliente, numeroDeCuenta, monto);


    // Ahora hago lo mismo pero usando DataBaseLogger
    var logearEnBaseDeDatos = new DataBaseLogger();
    gestorCuentaBancaria = new GestorDeCuentaBanciaria(logearEnBaseDeDatos);

    // Caso 3: Depósito exitoso (ConsoleLogger)
    Console.WriteLine("");
    Console.WriteLine("Caso 3: Deposito exitoso (usando DataBaseLogger)");
    Console.WriteLine("");
    monto = 1500000d;
    gestorCuentaBancaria.ProcesarDepositoBancario(idCliente, numeroDeCuenta, monto);

    // Caso 4: Depósito fallido debido a monto = 0 (ConsoleLogger)
    Console.WriteLine("");
    Console.WriteLine("Caso 4: Deposito FALLIDO (usando DataBaseLogger)");
    Console.WriteLine("");
    monto = 0d;
    gestorCuentaBancaria.ProcesarDepositoBancario(idCliente, numeroDeCuenta, monto);

}


void EjemploDeClaseVehiculo()
{
    Console.WriteLine("");
    Console.WriteLine("Ejemplo 4 de Vehiculos: Clases y Herencia");
    Console.WriteLine("");

    // Creo una lista de vehiculos, voy a cargar un automovil, un camion y un camión con acoplado
    var listaDeVehiculos = new List<Vehiculo>();

    var automovil = new Automovil(Fabricante.Ford, "Focus", 4);
    var camion = new Camion(Fabricante.MercedesBenz, "Unimog", 10000);
    var camionConAcoplado = new CamionConAcoplado(Fabricante.MercedesBenz, "1114", 12000, 12000);

    listaDeVehiculos.Add(automovil);
    listaDeVehiculos.Add(camion);
    listaDeVehiculos.Add(camionConAcoplado);

    // Aca voy a mostrar la descripción de cada vehiculo, que va a ser diferente según la clase de vehículo de la que se trate
    foreach (var vehiculo in listaDeVehiculos)
    {
        vehiculo.MostrarDescripcion();
        Console.WriteLine("");
    }

    Console.WriteLine("");
}


