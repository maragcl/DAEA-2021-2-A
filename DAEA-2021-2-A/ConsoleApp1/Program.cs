﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int Suma(int a, int b)
        {
            return a + b;
        }
        static int Resta(int c, int d)
        {
            return c - d;
        }
        static int Multiplicacion(int e, int f)
        {
            return e * f;
        }
        static int Division(int g, int h)
        {
            return g / h;
        }
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
                Console.WriteLine("La raiz cuadrada de {0} es {1}", i, Math.Sqrt(i));
        }
        static void Primo()
        {
            int cont = 0;
            for (int l = 2; l <= 30; l++)
            {
                for (int k = 1; k <= l; k++)
                {
                    if (l % k == 0)
                    {
                        cont = cont + 1;
                    }
                }
                if (cont <= 2)
                {
                    Console.WriteLine(l);
                }
                cont = 0;
            }
            Console.ReadKey();
        }
        static double Celsius(double j)
        {
            return (5 * (j - 32)) / 9;
        }

        static double Fahrenheit(double i)
        {
            return ((9 * i) / 5) + 32;
        }
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y Funciones";
            string opcion;
            do
            {


                Console.Clear();
                Console.WriteLine("[1] Suma de dos numeros");
                Console.WriteLine("[2] Resta de dos numeros");
                Console.WriteLine("[3] Multiplicasion de dos numeros");
                Console.WriteLine("[4] Division de dos numeros");
                Console.WriteLine("[5] Conversion  de celsius");
                Console.WriteLine("[6] Conversion de Fahrenheit ");
                Console.WriteLine("[0] Salir ");
                Console.WriteLine("Ingrese una opcion y de enter");
                opcion = Console.ReadLine();
                double i;
                double j;
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer numero");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        int b = Convert.ToInt32(Console.ReadLine());
                        int Suma = a + b;
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma);
                        break;
                    case "2":
                        Console.WriteLine("calculando .....");
                        Raiz();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el primer numero");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        int d = Convert.ToInt32(Console.ReadLine());
                        int Resta = c - d;
                        Console.WriteLine("La resta de {0} y {1} es {2}", c, d, Resta);
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el primer numero");
                        int e = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        int f = Convert.ToInt32(Console.ReadLine());
                        int Multiplicacion = e * f;
                        Console.WriteLine("La resta de {0} y {1} es {2}", e, f, Multiplicacion);
                        break;
                    case "5":
                        Console.WriteLine("Ingrese el primer numero");
                        int g = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        int h = Convert.ToInt32(Console.ReadLine());
                        int Division = g / h;
                        Console.WriteLine("La resta de {0} y {1} es {2}", g, h, Division);
                        break;
                    case "6":
                        Console.WriteLine("calculando");
                        Primo();
                        break;
                    case "7":
                        Console.WriteLine("Ingrese el valor de Fahrenheit");
                        j = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("El valor de Fahren es {0} por lo cual el valor de Celsius es {1}", j, Celsius(j));
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine("Ingrese el valor de Celsius");
                        i = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("El valor de Celsius es {0} por lo cual el valor de Fahrenheit es {1}", i, Fahrenheit(i));
                        Console.ReadKey();
                        break;
                }
                Console.ReadKey();

            } while (!opcion.Equals("0"));
        }
    }
}