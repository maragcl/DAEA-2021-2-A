using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raiz cuadrada de {0} es {1}", 1, Math.Sqrt(i));
            }
        }
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            Console.Clear();
            Console.WriteLine("[1]SUMA DE DOS NÚMEROS.");
            opcion = Console.ReadLine();
            switch (opcion){
                case  "1":
                Console.WriteLine("Ingrese el primer numero");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                int b = Convert.ToInt32(Console.ReadLine());
                int suma = a + b;
                Console.WriteLine("La suma de {0} y {1}  es 2", a,b,suma);
                    break;
                case "2":
                Console.WriteLine(".....Calculando.....");
                    Raiz();
                    break;
            }
            Console.ReadKey();
        }while (!opcion.Equals("0"));
    }
}
