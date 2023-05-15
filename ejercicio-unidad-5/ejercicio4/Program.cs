using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con = 0;

            Console.WriteLine("Ingrese un número: ");
            n = int.Parse(Console.ReadLine());

            for (int x = 1; x <= n; x++) {
                if (n % x == 0)
                    con++;    
            }
            
            if (con == 2)
                Console.WriteLine("El número ingresado es primo"); 
            else 
                Console.WriteLine("El número ingresado no es primo"); 
                   
            
        }
    }
}
