
using System;

/* Partiendo del ejercicio 1, agregar un 
tercer número y modificar las 
operaciones para que cada una de ellas 
sea en base a esos 3 en vez de 2 y 
mostrar el resultado de cada operación*/



class Ejercicio3
{ 
    static void Main()
    {

        Console.Write("Introduce el primer número: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());


        Console.Write("Introduce el segundo número: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());


        Console.Write("Introduce el tercer número: ");
        int numero3 = Convert.ToInt32(Console.ReadLine());


        int suma = numero1 + numero2 + numero3;
        int resta = numero1 - numero2 - numero3;
        int multiplicacion = numero1 * numero2 * numero3;
        double division = (double)numero1 / numero2 / numero3;

        // Mostrar los resultados
        Console.WriteLine("Suma: " + suma);
        Console.WriteLine("Resta: " + resta);
        Console.WriteLine("Multiplicación: " + multiplicacion);
        Console.WriteLine("División: " + division);
    }
}