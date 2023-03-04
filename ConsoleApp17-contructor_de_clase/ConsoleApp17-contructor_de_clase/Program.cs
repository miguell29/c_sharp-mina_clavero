using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17_contructor_de_clase
{
    /*
        Confeccionar una clase que represente un empleado. 
        Definir como atributos su nombre y su sueldo. 
        En el constructor cargar los atributos 
        y luego en otro método imprimir sus datos 
        y por último uno que imprima un mensaje si debe pagar impuestos (si el sueldo supera a 3000)
     */
    internal class Empleado
    {
        private string nombre;
        private decimal sueldo;

        Empleado()
        {
            Console.WriteLine("Ingrese el nombre del empleado");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el sueldo");
            sueldo = decimal.Parse(Console.ReadLine());
        }

        public void Imprimir()
        {
            Console.WriteLine($"{nombre} tiene un sueldo de {sueldo}.");
        }

        public void Impuestos()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("Debe pagar impuestos");
            }
            else
            {
                Console.WriteLine("No debe pagar impuestos");
            }
        }
        static void Main(string[] args)
        {
            Empleado juan = new Empleado();

            juan.Imprimir();
            juan.Impuestos();

            Console.ReadKey();
        }
    }
}
