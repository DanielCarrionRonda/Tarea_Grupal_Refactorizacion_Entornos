using System;

namespace CIFPCarlosIII.ED.UT04.Grupo3

{
    /// <summary>
    /// Esta clase llamada Guerrero hereda de Personaje.
    /// Tiene los atributos públicos "fuerza" y "arma"
    /// Esta clase está diseñada para crear los ataques y las defensas del Guerrero.
    /// </summary>
    public class Guerrero : Personaje
    {
        private string nombre;
        public int fuerza;
        public string arma;

        /// <summary>
        /// Constructor sin parámetros de Guerrero.
        /// </summary>
        public Guerrero()
        {
            this.fuerza = 15;
            this.arma = "Espada";
        }
        
        /// <summary>
        /// Constructor con un parámetro (nombre) de Guerrero.
        /// </summary>
        /// <param name="nombre"></param>
        public Guerrero(string nombre) : base(nombre)
        {
            this.nombre = nombre;
            this.fuerza = 15;
            this.arma = "Espada";
        }

        /// <summary>
        /// Devuelve el daño inflijido por un ataque poderoso calculando la fuerza multiplicado por 2.
        /// </summary>
        public void AtaquePoderoso()
        {
            Console.WriteLine(nombre + " usa su " + arma + " para realizar un ataque poderoso!");
            Console.WriteLine("Daño infligido: " + (fuerza * 2));
        }

        /// <summary>
        /// Devuelve una cadena del nombre del guerrero + explicando que se defiende y reduce el daño recibido.
        /// </summary>
        public void DefenderseConEscudo()
        {
            Console.WriteLine(nombre + " se defiende con su escudo, reduciendo el daño recibido.");
        }
    }
}
