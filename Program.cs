using System;

namespace CIFPCarlosIII.ED.UT04.Grupo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BIENVENIDO AL REINO DE LOS HÉROES ===\n");

            Personaje personaje = new Personaje();
            personaje.nombre = "Héroe Genérico";
            Console.WriteLine("Se ha creado un personaje: " + personaje.nombre);
            personaje.Atacar();
            personaje.SubirNivel();

            Console.WriteLine("\n--- Guerrero ---");
            Guerrero guerrero = new Guerrero();
            guerrero.nombre = "Guerrero Valiente";
            guerrero.Atacar();
            guerrero.AtaquePoderoso();
            guerrero.DefenderseConEscudo();
            Console.WriteLine("\n" + personaje.MostrarInfo(guerrero));
            
            Console.WriteLine("\n--- Berserker ---");
            Berserker bers = new Berserker();
            bers.nombre = "Destructor";
            bers.EntrarEnFuria();
            bers.EntrarEnFuria();
            bers.AtaqueFurioso();
            Console.WriteLine("\n" + personaje.MostrarInfo(bers));

            Console.WriteLine("\n--- Mago ---");
            Mago magi = new Mago();
            magi.nombre = "Merlín";
            magi.LanzarHechizo();
            magi.LanzarHechizo();
            magi.Meditar();
            magi.LanzarHechizo();
            Console.WriteLine("\n" + personaje.MostrarInfo(magi));

            Console.WriteLine("\n--- Nigromante ---");
            Nigromante nigro = new Nigromante();
            nigro.nombre = "Señor Oscuro";
            nigro.CapturarAlma();
            nigro.CapturarAlma();
            nigro.InvocarNoMuerto();
            nigro.DrenarVida();
            Console.WriteLine("\n" + personaje.MostrarInfo(nigro));

            Console.WriteLine("\n=== FIN DE LA DEMOSTRACIÓN ===");
            Console.ReadLine();
        }
    }
}
