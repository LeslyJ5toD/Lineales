using System;

/*Este programa en C# calcula el nuevo sueldo de
un empleado aplicando un aumento del 15% al sueldo
ingresado por el usuario, y luego muestra el sueldo 
anterior y el nuevo sueldo.*/

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el sueldo del empleado: ");
        double sueldoAnterior = Convert.ToDouble(Console.ReadLine());

        double aumento = sueldoAnterior * 0.15;
        double nuevoSueldo = sueldoAnterior + aumento;

        Console.WriteLine("\nSueldo anterior: " + sueldoAnterior);
        Console.WriteLine("Nuevo sueldo: " + nuevoSueldo);
    }
}
