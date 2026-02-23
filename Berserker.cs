using System;

namespace ProyectoRPG
{
    public class Berserker : Guerrero
    {
        public int furia;

        public Berserker()
        {
            this.furia = 0;
            this.arma = "Hacha de batalla";
            this.fuerza = 20;
        }

        public void EntrarEnFuria()
        {
            furia += 30;
            Console.WriteLine(nombre + " entra en estado de furia! Furia actual: " + furia);
        }

        public void AtaqueFurioso()
        {
            if (furia >= 50)
            {
                Console.WriteLine(nombre + " desata un ataque furioso devastador!");
                Console.WriteLine("Daño masivo: " + (fuerza * 3 + furia));
                furia = 0;
            }
            else
            {
                Console.WriteLine("Furia insuficiente para realizar ataque furioso.");
            }
        }

        public string MostrarInfo()
        {
            return "=== INFORMACIÓN DEL PERSONAJE ===" +
                   "\nNombre: " + nombre +
                   "\nClase: " + this.GetType().Name +
                   "\nNivel: " + nivel +
                   "\nVida: " + vida +
                   "\nFuerza: " + fuerza +
                   "\nArma: " + arma +
                   "\nFuria: " + furia;
        }
    }
}
