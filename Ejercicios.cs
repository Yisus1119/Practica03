using System;

namespace Practica03
{
    class Ejercicios
    {
        static void Main(string[] args)
        {
            #region ejercicio 1 
            /*ejercicio 1 •	Crear un programa que pida números positivos al usuario, y vaya calculando
            la suma de todos ellos(terminará cuando se teclea un número negativo o cero). */


            Console.WriteLine("-----EJERCICIO 1-----");
            int n1;
            int acumulador = 0;

            do
            {
                Console.WriteLine("Ingrese un número que no sea negativo o 0");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("El número ingresado fue: " + n1);
                acumulador = acumulador + n1;
            } while (n1 != 0 && n1 >=1);
            Console.WriteLine("El resultado de los numeros es: " + acumulador);
            #endregion

            #region ejercicio 2
            //ejercicio 2 •	Crea un programa que escriba en pantalla los números del 1 al 10, usando "do..while".
            Console.WriteLine("-----EJERCICIO 2-----");

            int contador = 1;
            do
            {
                Console.WriteLine(contador);
                contador += 1;
            } while (contador <= 10);
            #endregion

            #region ejercicio 3
            //ejercicio 3, crear un programa que muestre los 10 primeros numeros pares a partir del producto de (10x10)
            Console.WriteLine("-----EJERCICIO 3-----");

            int pr = 10;
            for (int i = 10; i <= 20; i++)
            {
                int mp = pr * i;
                Console.WriteLine(pr + " X " + i + " = " + mp);
            }
            #endregion

            #region ejercicio 4
            //ejercicio 4 •	Crear un programa que muestre las letras de la Z (mayúscula) a la A (mayúscula, descendiendo).
            Console.WriteLine("-----EJERCICIO 4-----");
            char letra;

            for (letra = 'Z'; letra >= 'A'; letra--)
            {
                Console.WriteLine(letra);
            }
            #endregion
        }
    }

}