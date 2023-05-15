using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, suma = 0, contador = 0, prom;

            for (int x = 0; x < 5; x++) {
                Console.WriteLine("Ingrese la edad: ");
                edad = int.Parse(Console.ReadLine());
                if (edad > 18) {
                    suma += edad;
                    contador++;
                }                   
            }
            prom = suma / contador;

            Console.WriteLine("El promedio de edad es: " + prom);
        }
    }
}
