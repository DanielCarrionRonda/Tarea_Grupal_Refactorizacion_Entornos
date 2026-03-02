using System;

namespace CIFPCarlosIII.ED.UT04.Grupo3
{
    /// <summary>
    /// Esta es la clase del Mago, lo primero es un constructor que hereda de Personaje
    /// </summary>
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
        /// <summary>
        /// Esto es un metodo encargado del ataque del mago, en caso de tener mana lo podra realizar
        /// en caso de que no tenga mana, el ataque no se podria realizar.
        /// </summary>

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

        /// <summary>
        /// Método que hace que el mago para recuperar mana,en caso de tener 100 o mas no añadira nada.
        /// </summary>
        public void Meditar()
        {
            mana += 30;
            if (mana > 100) mana = 100;
            Console.WriteLine(nombre + " medita y recupera mana. Mana actual: " + mana);
        }
    }
}
