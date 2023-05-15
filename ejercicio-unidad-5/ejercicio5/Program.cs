using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, n, maxpar = 0, minimpar = 0;

            for (x = 0; x < 6; x++) {
                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());
                if (n % 2 == 0 && x == 0) 
                    maxpar = n;                
                else if (n % 2 == 0 && n > maxpar)
                    maxpar = n;
                if (n % 2 != 0 && x == 0) 
                    minimpar = n;                
                else if (n % 2 != 0 && n < minimpar)
                    minimpar = n;
            }
            
            Console.WriteLine("El máximo par es: " + maxpar);
            Console.WriteLine("El mínimo impar es: " + minimpar);
        }
    }
}
