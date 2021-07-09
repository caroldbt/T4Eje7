using System;

namespace T4Eje7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*************
             * Ejercicio 7
             * ***********/

            Console.WriteLine("Numeros del 1 al 100, bucle for");
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            /************
             * Ejercicio 8
             * **********/

            Console.WriteLine("Numeros del 1 al 100, bucle while");
            int j = 1;
            while (j <= 100)
            {
                Console.WriteLine(j);
                j++;
            }

            /************
             * Ejercicio 9
             * **********/

            Console.WriteLine("Numeros pares:");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }
            /************
            * Ejercicio 10
            * **********/
            Console.WriteLine("Numeros pares o divisibles entre 3");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
