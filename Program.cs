using System;

namespace ProyectoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BIENVENIDO AL REINO DE LOS HÉROES ===\n");

            Personaje pers = new Personaje();
            pers.nombre = "Héroe Genérico";
            Console.WriteLine("Se ha creado un personaje: " + pers.nombre);
            pers.Atacar();
            pers.SubirNivel();

            Console.WriteLine("\n--- Guerrero ---");
            Guerrero guer = new Guerrero();
            guer.nombre = "Guerrero Valiente";
            guer.Atacar();
            guer.AtaquePoderoso();
            guer.DefenderseConEscudo();

            Console.WriteLine("\n--- Berserker ---");
            Berserker bers = new Berserker();
            bers.nombre = "Destructor";
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
            Nigromante nigro = new Nigromante();
            nigro.nombre = "Señor Oscuro";
            nigro.CapturarAlma();
            nigro.CapturarAlma();
            nigro.InvocarNoMuerto();
            nigro.DrenarVida();

            Console.WriteLine("\n=== FIN DE LA DEMOSTRACIÓN ===");
            Console.ReadLine();
        }
    }
}
