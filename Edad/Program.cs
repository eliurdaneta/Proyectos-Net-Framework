using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edad
{
    class Program
    {
        //Declarar Atributos
        private int edad;
        private string nombre;

        //Método de Inicialización de valores
        public void Inicializar()
        {
            Console.Write("Ingrese Nombre: ");
            nombre = Console.ReadLine();
            string linea;
            Console.Write("Ingrese edad: ");
            linea = Console.ReadLine();
            edad = int.Parse(linea);
        }

        public void Imprimir()
        {
            Console.Write("Nombre: ");
            Console.WriteLine(nombre);
            Console.Write("Edad: ");
            Console.WriteLine(edad);
        }

        public void MayorEdad()
        {
            if (edad >= 18)
            {
                Console.Write(nombre +" es Mayor de Edad");
            }
            else
            {
                Console.Write(nombre + " es Mayor de Edad");
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Program PObject = new Program();
            PObject.Inicializar();
            PObject.Imprimir();
            PObject.MayorEdad();
        }
    }
}
