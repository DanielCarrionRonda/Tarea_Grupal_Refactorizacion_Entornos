using System;

namespace CIFPCarlosIII.ED.UT04.Grupo3
{
    public class Mago : Personaje
    {
        private string nombre;
        private int _mana;
        public string hechizo;
        
        public int mana { get; set; }

        public Mago()
        {
            this.mana = 100;
            this.hechizo = "Bola de fuego";
        }

        public Mago(string nombre) : base(nombre)
        {
            this.nombre = nombre;
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
