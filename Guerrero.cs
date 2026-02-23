using System;

namespace ProyectoRPG
{
    public class Guerrero : Personaje
    {
        public int fuerza;
        public string arma;

        public Guerrero()
        {
            this.fuerza = 15;
            this.arma = "Espada";
        }

        public void AtaquePoderoso()
        {
            Console.WriteLine(nombre + " usa su " + arma + " para realizar un ataque poderoso!");
            Console.WriteLine("Daño infligido: " + (fuerza * 2));
        }

        public void DefenderseConEscudo()
        {
            Console.WriteLine(nombre + " se defiende con su escudo, reduciendo el daño recibido.");
        }
    }
}
