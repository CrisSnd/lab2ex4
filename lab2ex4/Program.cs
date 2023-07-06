using System;


namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /* Scrieti un program care va determina daca un numar este sau nu palindrom.*/

            int numar = 0;
            int r = 0;
            int suma = 0;
            int z = 0;
            Console.WriteLine("Introduceti valoarea:");
            while (int.TryParse(Console.ReadLine(), out numar))
            {
                z = numar;

                while (numar > 0)
                 {
                    r = numar % 10;
                    suma = (suma * 10) + r;
                    numar = numar / 10;
                 }



                if (z == suma)
                {
                    Console.WriteLine($"Numarul {z} este palindrome.");
                }

                else

                {
                    Console.WriteLine($"Numarul {z} nu este palindrome.");
  
                }

            }
            
         }
    }
}