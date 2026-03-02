using System;

namespace CIFPCarlosIII.ED.UT04.Grupo3
{
    public class Berserker : Guerrero
    {   
        //Atributo furia
        public int furia;
        //Constructor del Berserker
        public Berserker()
        {
            this.furia = 0;
            this.arma = "Hacha de batalla";
            this.fuerza = 20;
        }
                //Metodo público de Berserker, aumenta la furia en 30
        public Berserker(int nivel)
        {
            this.nivel = nivel;
        }

        public void EntrarEnFuria()
        {
            furia += 30;
            Console.WriteLine(nombre + " entra en estado de furia! Furia actual: " + furia);
        }
        //Metodo público de Berserker ataque que alutilizarse baja furia a 0
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

        
    }
}
