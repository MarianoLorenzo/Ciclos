using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, max = 0;

            for (int x = 0; x < 5; x++) {
                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());
                if (x == 0)
                    max = n;
                else if (n > max)
                    max = n;     
            }
            
            Console.WriteLine("El máximo es : " + max);

        }
    }
}
