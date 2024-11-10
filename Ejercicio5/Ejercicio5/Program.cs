using System;

/*Leer la cantidad y precio de un artículo y 
calcular su importe, mostrar el resultado 
en pantalla*/


class Ejercicio5
{
    static void Main()
    {
        // Leer 
        Console.Write("Introduce la cantidad del artículo: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        // Leer
        Console.Write("Introduce el precio del artículo: ");
        double precio = Convert.ToDouble(Console.ReadLine());

        // Calcular
        double importe = cantidad * precio;

        // Mostrar el resultado
        Console.WriteLine("El importe total es: "+ importe);
    }
}