using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrado
{
    public class Program
    {
        //Desarrollar una clase que represente un Cuadrado y tenga los siguientes métodos: 
        //cargar el valor de su lado, imprimir su perímetro y su superficie
        public int lado;
        
            public void Inicializar()
            {
                Console.Write("Ingrese Lado del Cuadrado: ");
                string linea ;
                linea=Console.ReadLine();
                lado = int.Parse(linea);
            }

            public void MostrarDatos()
            {
                Console.Write("El lado del cuadrado es: ");
                Console.WriteLine(lado);
            }

            public void PerimetroSuperficie()
            {
                int superficie = lado * lado;
                int perimetro = lado * lado * lado * lado;
                Console.Write("La Superficie del Cuadrado es: ");
                Console.WriteLine(superficie);
                Console.Write("El Perimetro del Cuadrado es: ");
                Console.WriteLine(perimetro);
                Console.ReadKey();
            }

            public static void Main(string[] args)
            {
                Program cu = new Program();
                cu.Inicializar();
                cu.MostrarDatos();
                cu.PerimetroSuperficie();
            }
    }
}
