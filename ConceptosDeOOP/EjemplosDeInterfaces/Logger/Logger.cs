namespace ConceptosDeOOP.EjemplosDeInterfaces.Logger
{
    /// <summary>
    /// Defina la interfaz que deben implementar todas las clases que permiten registrar logs de errores pero también info y warnings
    /// </summary>
    public interface ILogger
    {
        void LogInfo(string message);
        void LogError(string message);
        void LogWarning(string message);
    }

    /// <summary>
    /// Esta clase implementa ILogger registrando los mensajes en la consola
    /// </summary>
    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.WriteLine($"Console Logger - ERROR: {message} - {DateTime.Now}");
        }

        public void LogInfo(string message)
        {
            Console.WriteLine($"Console Logger - INFO: {message} - {DateTime.Now}");
        }

        public void LogWarning(string message)
        {
            Console.WriteLine($"Console Logger - WARNING: {message} - {DateTime.Now}");
        }
    }

    /// <summary>
    /// Esta clase implementa ILogger registrando los mensajes en una base de datos (pendiente de construir)
    /// </summary>
    public class DataBaseLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.WriteLine($"SAVING TO DATA BASE Logger - ERROR: {message} - {DateTime.Now}");
            // ACA DEBERÍAMOS ESTAR GRABANDO EN SQL, pero lo dejo pendiente
            // INSERT INTO LOG ()....
        }

        public void LogInfo(string message)
        {
            Console.WriteLine($"SAVING TO DATA BASE Logger - INFO: {message} - {DateTime.Now}");
            // ACA DEBERÍAMOS ESTAR GRABANDO EN SQL, pero lo dejo pendiente
            // INSERT INTO LOG ()....
        }

        public void LogWarning(string message)
        {
            Console.WriteLine($"SAVING TO DATA BASE Logger - WARNING: {message} - {DateTime.Now}");
            // ACA DEBERÍAMOS ESTAR GRABANDO EN SQL, pero lo dejo pendiente
            // INSERT INTO LOG ()....
        }
    }




}
