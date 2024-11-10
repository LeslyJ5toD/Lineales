using System;

/*Crear un programa que permita 
introducir por teclado dos números 
enteros y mostrar el resultado de la 
suma, resta, multiplicación y división*/

class Ejercicio1
{
    static void Main()
    {
       
        Console.Write("Introduce el primer número: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());

       
        Console.Write("Introduce el segundo número: ");
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