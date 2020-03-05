using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadosTriangulos
{
    //Desarrollar un programa que cargue los lados de un triángulo e implemente los siguientes métodos: 
    //inicializar los atributos, imprimir el valor del lado mayor y otro método que muestre si es equilátero o no.
    public class Triangulo
    {
        //Se declaran los atributos de la clase
        int ladoa;
        int ladob;
        int ladoc;

        public void CargaLados()
        {
            Console.Write("Ingrese Medida del lado A del triangulo: ");
            string linea;
            linea = Console.ReadLine();
            ladoa = int.Parse(linea);
            Console.Write("Ingrese Medida del lado B del triangulo: ");
            linea = Console.ReadLine();
            ladob = int.Parse(linea);
            Console.Write("Ingrese Medida del lado C del triangulo: ");
            linea = Console.ReadLine();
            ladoc = int.Parse(linea);
        }

        public void ImprimirLados()
        {
            Console.Write("El lado A = ");
            Console.WriteLine(ladoa);
            Console.Write("El lado B = ");
            Console.WriteLine(ladob);
            Console.Write("El lado C = ");
            Console.WriteLine(ladoc);

        }

        public void ImprimirLadoMayor()
        { 
            if((ladoa > ladob) & (ladob > ladoc))
            {
                Console.WriteLine("El lado mayor es A");
            }

            else if((ladoa>ladob) && (ladoc > ladob))
            {
                Console.WriteLine("El lado mayor es C");
              
            }

            else if ((ladoa < ladob) && (ladoc > ladob))
            {
                Console.WriteLine("El lado mayor es C");
            }
                       
            else
            {
                Console.WriteLine("El lado mayor es B");
            }
            
        }

        public void Equilatero()
        {
            if((ladoa==ladob) && (ladob == ladoc))
                {
                Console.WriteLine("El triángulo es Equilatero");
            }
            else
            {
                Console.WriteLine("El triángulo No es Equilatero");
            }
            Console.ReadKey();
        }
        public static void Main(string[] args)
        {
            Triangulo tri = new Triangulo();
            tri.CargaLados();
            tri.ImprimirLados();
            tri.ImprimirLadoMayor();
            tri.Equilatero();
        }
    }
}
