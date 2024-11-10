
using System;

/* Leer 5 números por teclado y calcular el 
promedio, luego imprimir el resultado.  
Para obtener el promedio, se realiza 
sumando las cantidades y luego se 
divide entre ellas*/

class Ejercicio4
{
    static void Main()
    {
        Console.Write("Introduce el primer número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce el segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce el tercer número: ");
        double numero3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce el cuarto número: ");
        double numero4 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce el quinto número: ");
        double numero5 = Convert.ToDouble(Console.ReadLine());

        // Calcular la suma y el promedio
        double suma = numero1 + numero2 + numero3 + numero4 + numero5;
        double promedio = suma / 5;

        // Imprimir el resultado
        Console.WriteLine("El promedio de los números es: "+ promedio);
    }
}