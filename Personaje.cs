using System;

namespace CIFPCarlosIII.ED.UT04.Grupo3
{
    public class Personaje
    {

        private string _nombre;
        public int vida;
        public int nivel;

        public string nombre { get; set; }
        
        public Personaje()
        {
            this.vida = 100;
            this.nivel = 1;
        }

        public Personaje(string nombre)
        {
            this.nombre = nombre;
            this.vida = 100;
            this.nivel = 1;
        } 
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
        public void Atacar()
        {
            Console.WriteLine(nombre + " realiza un ataque básico!");
        }

        public void RecibirDanio(int danio)
        {
            vida -= danio;
            Console.WriteLine(nombre + " recibe " + danio + " de daño. Vida restante: " + vida);
        }

        public void SubirNivel()
        {
            nivel++;
            vida += 20;
            Console.WriteLine(nombre + " ha subido al nivel " + nivel + "!");
        }
    }
}
