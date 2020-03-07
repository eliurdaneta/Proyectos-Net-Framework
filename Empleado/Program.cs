using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado
{
    //Confeccionar una clase que represente un empleado. 
    //Definir como atributos su nombre y su sueldo. 
    //Confeccionar los métodos para la carga, 
    //otro para imprimir sus datos
    //por último uno que imprima un mensaje si debe pagar impuestos (si el sueldo supera a 3000)
    public class Program
    {
        public string nombre;
        public int sueldo;

        public void Inicializar()
        {
            Console.Write("Ingrese nombre del empleado: ");
            nombre = Console.ReadLine();
            string linea;
            Console.Write("Ingrese sueldo del empleado: ");
            linea = Console.ReadLine();
            sueldo = int.Parse(linea);
        }

        public void Imprimir()
        {
            Console.Write("El nombre del Empleado es: ");
            Console.WriteLine(nombre);
            Console.Write("El Sueldo del Empleado es: ");
            Console.WriteLine(sueldo);
        }

        public void Impuesto()
        {
            if(sueldo > 3000)
            {
                Console.Write("Debe Pagar Impuesto");
            }
            else
            {
                Console.Write("No Debe Pagar Impuesto");
            }
            Console.ReadKey();
        }
        public static void Main(string[] args)
        {
            Program em = new Program();
            em.Inicializar();
            em.Imprimir();
            em.Impuesto();
        }
    }
}
