using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosDeOOP.EjemplosDeInterfaces.Logger
{
    /// <summary>
    /// Esta clase solo es para poner un ejemplo simple de como utilizar las dos clases que implementan ILogger (ConsoleLogger y DataBaseLogger)
    /// </summary>
    public class GestorDeCuentaBanciaria
    {
        private readonly ILogger _logger;

        /// <summary>
        /// Cuando cree un objeto debo pasarle como parametro el logger que quiero utilizar (Esto es INJECCION DE DEPENDENCIAS básica)
        /// </summary>
        /// <param name="logger"></param>
        public GestorDeCuentaBanciaria(ILogger logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Aca voy a simular que hago un deposito bancario para un cliente,
        /// pero lo que me interesa es que veas como utilizo el logger
        /// </summary>
        /// <param name="idCliente"></param>
        /// <param name="numeroDeCuenta"></param>
        /// <param name="monto"></param>
        public bool ProcesarDepositoBancario(int idCliente, int numeroDeCuenta, double monto)
        {
            try
            {
                // Muchas veces se crean logs (registros) que sirven tanto de auditoria como para resolver problemas en casos de reclamos o quejas                
                _logger.LogInfo($"Procesando Deposito Bancario - INICIO - Cliente: {idCliente}, Cuenta: {numeroDeCuenta}, Monto: {monto}");

                // Verificar que el cliente existe en la BD
                // _logger.LogError($"No se pudo encontrar el cliente - Id: {idCliente}");
                _logger.LogInfo($"Cliente encontrado - Id: {idCliente}");

                // Verificar que la cuenta existe y está activa
                // _logger.LogError($"No se pudo encontrar la cuenta: {numeroDeCuenta}");
                _logger.LogInfo($"Cuenta encontrada y activa - Id: {numeroDeCuenta}");

                // Verificar el monto
                if (monto <= 0)
                {
                    throw new ApplicationException("El monto a depositar es menor o igual a 0. Depósito rechazado.");
                }

                // Realizar el deposito
                // Acá grabaría una transacción en la base de datos

                // Es una buena Práctica registrar que todo terminó bien
                _logger.LogInfo($"Procesando Deposito Bancario - FIN - Cliente: {idCliente}, Cuenta: {numeroDeCuenta}, Monto: {monto}");

                return true;
            }
            catch (Exception ex)
            {
                // Acá entra si ocurre algún error en cualquier parte del bloque TRY
                // Si ocurre un error ES IMPORTANTISIMO que registremos cuanto a los parametros cosas de que sea fácil revisarlo
                _logger.LogError($"{ex.Message} StackTrace: {ex.StackTrace} - Parametros Cliente: {idCliente}, Cuenta: {numeroDeCuenta}, Monto: {monto}");
                return false;
            }
        }

    }
}
