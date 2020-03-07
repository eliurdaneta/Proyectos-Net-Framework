using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plano
{
    //Desarrollar un programa de consola que represente un punto en el plano y tenga los siguientes métodos:
    //cargar los valores de x e y, imprimir en que cuadrante se encuentra dicho punto (concepto matemático) 
    //primer cuadrante: si x e y son positivas, 
    //Segundo Cuadrante si x<0 e y>0 ,
    //Tercer Cuadrante si x<0 e y<0,
    //Cuarto Cuadrante si x>0 e y<0,
    public class Plano
    {
        private int x;
        private int y;

        public void cargarPuntos()
        {
            Console.Write("Ingrese la ubicación del Punto x: ");
            string linea;
            linea = Console.ReadLine();
            x = int.Parse(linea);
            Console.Write("Ingrese la ubicación del punto y: ");
            linea = Console.ReadLine();
            y = int.Parse(linea);
        }

        public void ImprimirPuntos()
        {
            Console.Write("El valor de x es: ");
            Console.WriteLine(x);
            Console.Write("El valor de y es: ");
            Console.WriteLine(y);
        }

        public void ImprimirCuadrante()
        {
            if(x>0 && y > 0)
            {
                Console.Write("Primer Cuadrante");
            }
            
            if(x < 0 && y> 0)
            {
                Console.Write("Segundo Cuadrante"); 
            }

            if(x < 0 && y<0)
            {
                Console.Write("Tercer Cuadrante");
            }
            
            if(x> 0 && y<0)
            {
                Console.Write("Cuarto Cuadrante");
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Plano pl = new Plano();
            pl.cargarPuntos();
            pl.ImprimirPuntos();
            pl.ImprimirCuadrante();
        }
    }
}
