using System;

using System;

namespace ProyectoRPG
{
    /// <summary>
    /// Clase principal que actúa como punto de entrada para la simulación del RPG.
    /// Coordina la creación de instancias y la demostración de las capacidades de cada clase de personaje.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método de entrada principal (Entry Point) que ejecuta la lógica de demostración del sistema de clases.
        /// </summary>
        /// <param name="args">Colección de argumentos de línea de comandos pasados al ejecutar la aplicación.</param>
        /// <remarks>
        /// El flujo del programa realiza las siguientes acciones:
        /// </remarks>
        static void Main(string[] args)
        {
            Console.WriteLine("=== BIENVENIDO AL REINO DE LOS HÉROES ===\n");

            // Demostración de Personaje base
            Personaje pers = new Personaje();
            pers.nombre = "Kasuga";
            Console.WriteLine("Se ha creado un personaje: " + pers.nombre);
            pers.Atacar();
            pers.SubirNivel();

            Console.WriteLine("\n--- Guerrero ---");
            Guerrero guer = new Guerrero();
            guer.nombre = "Gael";
            guer.Atacar();
            guer.AtaquePoderoso();
            guer.DefenderseConEscudo();

            Console.WriteLine("\n--- Berserker ---");
            Berserker bers = new Berserker(3);
            bers.nombre = "Ragval";
            bers.SubirNivel();
            bers.EntrarEnFuria();
            bers.EntrarEnFuria();
            bers.AtaqueFurioso();
            Console.WriteLine("\n" + bers.MostrarInfo());

            Console.WriteLine("\n--- Mago ---");
            Mago magi = new Mago();
            magi.nombre = "Merlín";
            magi.LanzarHechizo();
            magi.LanzarHechizo();
            magi.Meditar();
            magi.LanzarHechizo();

            Console.WriteLine("\n--- Nigromante ---");
            Nigromante nigro = new Nigromante(2);
            nigro.nombre = "Sauron't";
            nigro.SubirNivel();
            nigro.CapturarAlma();
            nigro.CapturarAlma();
            nigro.InvocarNoMuerto();
            nigro.DrenarVida();

            Console.WriteLine("\n=== FIN DE LA DEMOSTRACIÓN ===");
            Console.ReadLine();
        }
    }
}
