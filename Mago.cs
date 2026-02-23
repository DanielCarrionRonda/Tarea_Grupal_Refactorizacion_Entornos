using System;

namespace ProyectoRPG
{
    public class Mago : Personaje
    {
        public int mana;
        public string hechizo;

        public Mago()
        {
            this.mana = 100;
            this.hechizo = "Bola de fuego";
        }

        public void LanzarHechizo()
        {
            if (mana >= 20)
            {
                Console.WriteLine(nombre + " lanza " + hechizo + "!");
                mana -= 20;
                Console.WriteLine("Mana restante: " + mana);
            }
            else
            {
                Console.WriteLine("Mana insuficiente para lanzar el hechizo.");
            }
        }

        public void Meditar()
        {
            mana += 30;
            if (mana > 100) mana = 100;
            Console.WriteLine(nombre + " medita y recupera mana. Mana actual: " + mana);
        }
    }
}
