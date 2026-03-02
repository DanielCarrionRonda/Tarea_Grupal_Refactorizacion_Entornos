using System;

namespace CIFPCarlosIII.ED.UT04.Grupo3
{
    
    /// <summary>
    /// Clase personaje que indica los atributos básicos de un personaje como el nombre, vida o el nivel.
    /// </summary>
    public class Personaje
    {
        
        public string nombre;
        public int vida;
        public int nivel;

        /// <summary>
        /// Constructor sin parámetros de Personaje
        /// </summary>
        public Personaje()
        {
            this.vida = 100;
            this.nivel = 1;
        }

        /// <summary>
        /// Constructor con un parámetro (nombre) de Personaje
        /// </summary>
        /// <param name="nombre">Parámetro que indica el nombre del personaje</param>
        public Personaje(string nombre) 
        {
            this.nombre = nombre;
            this.vida = 100;
            this.nivel = 1;
        } 
        /// <summary>
        /// Método que devuelve la informacion principal de cada personaje dependiendo de su clase.
        /// </summary>
        public string MostrarInfo(Guerrero guerrero)
       {
           return "=== INFORMACIÓN DEL PERSONAJE ===" +
                  "\nNombre: " + nombre +
                  "\nClase: " + this.GetType().Name +
                  "\nNivel: " + nivel +
                  "\nVida: " + vida +
                  "\nFuerza: " + guerrero.fuerza +
                  "\nArma: " + guerrero.arma;


       }
       public string MostrarInfo(Mago mago)
       {
           return "=== INFORMACIÓN DEL PERSONAJE ===" +
                  "\nNombre: " + nombre +
                  "\nClase: " + this.GetType().Name +
                  "\nNivel: " + nivel +
                  "\nVida: " + vida +
                  "\nMana: " + mago.mana +
                  "\nHechizo: " + mago.hechizo;
       }
       public string MostrarInfo(Nigromante nigromante)
       {
           return "=== INFORMACIÓN DEL PERSONAJE ===" +
                  "\nNombre: " + nombre +
                  "\nClase: " + this.GetType().Name +
                  "\nNivel: " + nivel +
                  "\nVida: " + vida +
                  "\nMana: " + nigromante.mana +
                  "\nHechizo: " + nigromante.hechizo +
                  "\nAlmas Capturadas: " + nigromante.almasCapturadas;
       }
       public string MostrarInfo(Berserker berserker)
       {
           return "=== INFORMACIÓN DEL PERSONAJE ===" +
                  "\nNombre: " + nombre +
                  "\nClase: " + this.GetType().Name +
                  "\nNivel: " + nivel +
                  "\nVida: " + vida +
                  "\nFuerza: " + berserker.fuerza +
                  "\nArma: " + berserker.arma +
                  "\nFuria: " + berserker.furia;
       }


        /// <summary>
        /// Método que indica quién ha realizado un ataque básico.
        /// </summary>
        public void Atacar()
        {
            Console.WriteLine(nombre + " realiza un ataque básico!");
        }

        /// <summary>
        /// Método que indica cuánto daño recibe el personaje
        /// </summary>
        /// <param name="danio">indica la cantidad de daño en tipo de dato número entero</param>
        public void RecibirDanio(int danio)
        {
            vida -= danio;
            Console.WriteLine(nombre + " recibe " + danio + " de daño. Vida restante: " + vida);
        }

        /// <summary>
        /// Método que te sube 1 nivel y te aumenta la vida en +20.
        /// </summary>
        public void SubirNivel()
        {
            nivel++;
            vida += 20;
            Console.WriteLine(nombre + " ha subido al nivel " + nivel + "!");
        }
    }
}
