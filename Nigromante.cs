using System;

namespace CIFPCarlosIII.ED.UT04.Grupo3
{
    /// <summary>
    /// Representa una clase de personaje especializada en la magia oscura y la manipulación de almas.
    /// Hereda de la clase base <see cref="Mago"/>.
    /// </summary>
    public class Nigromante : Mago
    {   
        /// <summary>
        /// Cantidad de almas que el nigromante ha recolectado para realizar invocaciones.
        /// </summary>
        public int almasCapturadas;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Nigromante"/> con valores por defecto.
        /// </summary>
        public Nigromante()
        {
            this.almasCapturadas = 0;
            this.hechizo = "Drenar vida";
            this.mana = 120;
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Nigromante"/> asignando un nivel específico.
        /// </summary>
        /// <param name="nivel">El nivel inicial del personaje.</param>
        public Nigromante(int nivel)
        {
            this.nivel = nivel;
        }

        /// <summary>
        /// Consume maná y almas capturadas para invocar a un aliado no-muerto.
        /// </summary>
        /// <remarks>
        /// Requiere un mínimo de 40 puntos de maná y al menos 1 alma capturada.
        /// </remarks>
        public void InvocarNoMuerto()
        {
            if (mana >= 40 && almasCapturadas >= 1)
            {
                Console.WriteLine(nombre + " invoca un no-muerto usando un alma capturada!");
                mana -= 40;
                almasCapturadas--;
                Console.WriteLine("Almas restantes: " + almasCapturadas);
            }
            else
            {
                Console.WriteLine("No hay suficiente mana o almas para invocar.");
            }
        }

        /// <summary>
        /// Incrementa el contador de almas capturadas del nigromante.
        /// </summary>
        public void CapturarAlma()
        {
            almasCapturadas++;
            Console.WriteLine(nombre + " ha capturado un alma. Total: " + almasCapturadas);
        }

        /// <summary>
        /// Ejecuta el hechizo característico para absorber vitalidad del enemigo.
        /// </summary>
        /// <remarks>
        /// Reduce el maná en 25 unidades e incrementa la vida en 15 unidades.
        /// </remarks>
        public void DrenarVida()
        {
            if (mana >= 25)
            {
                Console.WriteLine(nombre + " drena la vida de su enemigo!");
                mana -= 25;
                vida += 15;
                Console.WriteLine("Vida recuperada. Vida actual: " + vida);
            }
        }
    }
}