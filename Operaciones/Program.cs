using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    //Implementar la clase operaciones. Se deben cargar dos valores enteros,
    //calcular su suma, resta, multiplicación y división, cada una en un método, imprimir dichos resultados.
    class Operaciones
    {
        private int valora;
        private int valorb;
        private string operador;
 

        public void Inicializar()
        {
            Console.Write("Ingresar valor a: ");
            string linea;
            linea = Console.ReadLine();
            valora = int.Parse(linea);
            Console.Write("Ingrese valor b: ");
            linea = Console.ReadLine();
            valorb = int.Parse(linea);
            Console.Write("Ingrese Operador (+, -, *, /): ");
            operador = Console.ReadLine();
        }
        public void Imprimir()
        {
            Console.Write("El valor de a es: ");
            Console.WriteLine(valora);
            Console.Write("El valor de b es: ");
            Console.WriteLine(valorb);
            Console.Write("La operación a realizar es: ");
            Console.WriteLine(operador);
        }
        public void Operacion()
        {
            int resultado;
            switch (operador)
                {
                    case "+":
                        resultado = valora + valorb;
                    break;

                    case "-":
                        resultado = valora - valorb;
                        break;

                    case "*":
                        resultado = valora * valorb;
                    break;

                    default:
                        resultado = valora / valorb;
                    break;
                }

            Console.Write("El resultado es: ");
            Console.WriteLine(resultado);

            Console.ReadKey();

        }
        public static void Main(string[] args)
        {
            Operaciones op = new Operaciones();
            op.Inicializar();
            op.Imprimir();
            op.Operacion();
        }
    }
}
