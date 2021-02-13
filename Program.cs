using System;

namespace Practica03
{
    class Program
    {
        static void Main(string[] args)
        {
            //ejercicio 1

            Console.WriteLine("-----EJERCICIO 1-----");
            int n1;
            int acumulador = 0;

            do
            {
                Console.WriteLine("Ingrese un número que no sea negativo o 0");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("El número ingresado fue: " + n1);
                acumulador = acumulador + n1;
            } while (n1 != 0);
            Console.WriteLine("El resultado de los numeros es: " + acumulador);

            //ejercicio 2
            Console.WriteLine("-----EJERCICIO 2-----");

            int contador = 1;
            do
            {
                Console.WriteLine(contador);
                contador += 1;
            } while (contador <= 10);

            //ejercicio 3, crear un programa que muestre los 10 primeros numeros pares a partir del producto de (10x10)
            Console.WriteLine("-----EJERCICIO 3-----");

            int pr = 10;
            for (int i = 10; i <= 20; i++)
            {
                int mp = pr * i;
                Console.WriteLine(pr + " X " + i + " = " + mp);
            }

            //ejercicio 4
            Console.WriteLine("-----EJERCICIO 4-----");
            char letra;

            for (letra = 'Z'; letra >= 'A'; letra--)
            {
                Console.WriteLine(letra);
            }
        }
    }
}
