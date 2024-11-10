using System;

class Program
{
    static void Main()
    {
        // Solicitar el primer número
        Console.Write("Introduce el primer número entero: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        // Solicitar el segundo número
        Console.Write("Introduce el segundo número entero: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());


        int suma = numero1 + numero2;
        int resta = numero1 - numero2;
        int multiplicacion = numero1 * numero2;
        double division = (double)numero1 / numero2; // Permite residuo

        // Mostrar los resultados
        Console.WriteLine("Suma: " + suma);
        Console.WriteLine("Resta: " + resta);
        Console.WriteLine("Multiplicación: " + multiplicacion);
        Console.WriteLine("División: " + division);
    }
}