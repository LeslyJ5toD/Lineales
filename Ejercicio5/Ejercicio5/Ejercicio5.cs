using System;

/*Leer la cantidad y precio de un artículo y 
calcular su importe, mostrar el resultado 
en pantalla*/


class Ejercicio5
{
    static void Main()
    {
        Console.Write("Introduce la cantidad del artículo: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el precio del artículo: ");
        double precio = Convert.ToDouble(Console.ReadLine());

        
        double importe = cantidad * precio;

        Console.WriteLine("El importe total es: "+ importe);
    }
}